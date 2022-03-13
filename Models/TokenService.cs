
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace OktaClients {

public interface ITokenService
{
  Task<string> GetToken(string id = "");
}

public class TokenService : ITokenService
{
  private OktaToken _token = new OktaToken();
  private readonly IOptions<OktaConfigs> _oktaConfigs;
  private OktaConfig _oktaSettings;

  public TokenService(IOptions<OktaConfigs> oktaConfigs) {
    _oktaConfigs = oktaConfigs;
  }
  public async Task<string> GetToken(string id)
      {
        if (_token.IsValidAndNotExpiring)
        {
          return _token.AccessToken;
        }
        OktaConfigs oc = _oktaConfigs.Value;
        
        if (!String.IsNullOrEmpty(id)) {
        _oktaSettings = oc.items.SingleOrDefault(item => item.Id == id);
        } else {
        _oktaSettings = oc.items[0];
        }

         _token = await GetNewAccessToken();
        return _token.AccessToken;
      }
  private async Task<OktaToken> GetNewAccessToken()
    {
      var client = new HttpClient();
      var clientId = _oktaSettings.ClientId;
      var clientSecret = _oktaSettings.ClientSecret;
      var clientCreds = System.Text.Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}");

      // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(clientCreds));

      var postMessage = new Dictionary<string, string>
      {
        {"client_id", $"{clientId}"},
        {"client_secret", $"{clientSecret}"},
        {"grant_type", "client_credentials"},
        {"scope", "access_token"}
      };
// //
      var request = new HttpRequestMessage(HttpMethod.Post, _oktaSettings.TokenUrl)
      {
        Content = new FormUrlEncodedContent(postMessage)
      };

      var response = await client.SendAsync(request);
      if (response.IsSuccessStatusCode)
      {
        var json = await response.Content.ReadAsStringAsync();
        var newToken = JsonConvert.DeserializeObject<OktaToken>(json);
        newToken.ExpiresAt = DateTime.UtcNow.AddSeconds(_token.ExpiresIn);
        return newToken;
      }

      throw new ApplicationException("Unable to retrieve access token from Okta");
    }
  private class OktaToken
        {
          [JsonProperty(PropertyName = "access_token")]
          public string AccessToken { get; set; }

          [JsonProperty(PropertyName = "expires_in")]
          public int ExpiresIn { get; set; }

          public DateTime ExpiresAt { get; set; }

          public string Scope { get; set; }

          [JsonProperty(PropertyName = "token_type")]
          public string TokenType { get; set; }

          public bool IsValidAndNotExpiring
          {
            get
            {
                return !String.IsNullOrEmpty(this.AccessToken) && this.ExpiresAt > DateTime.UtcNow.AddSeconds(30);
            }
          }
        }
}
}

namespace OktaClients

{
  public class OktaConfig
  {
    public string Id {get;set;}
    public string TokenUrl { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
  }
  public class OktaSignIn 
  {
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string Domain {get; set;}
  }

  public class OktaConfigs {

    public OktaConfig [] items {get;set;} 
  }

}
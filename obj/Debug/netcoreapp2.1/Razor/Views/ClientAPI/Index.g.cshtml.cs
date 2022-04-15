#pragma checksum "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\ClientAPI\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66117bc42b85288e28821972bbfbb4f8058c0a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientAPI_Index), @"mvc.1.0.view", @"/Views/ClientAPI/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ClientAPI/Index.cshtml", typeof(AspNetCore.Views_ClientAPI_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\_ViewImports.cshtml"
using ge_app;

#line default
#line hidden
#line 2 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\_ViewImports.cshtml"
using ge_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66117bc42b85288e28821972bbfbb4f8058c0a6", @"/Views/ClientAPI/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_ClientAPI_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\ClientAPI\Index.cshtml"
  
    ViewData["Title"] = "API Authentications";

#line default
#line hidden
            BeginContext(55, 684, true);
            WriteLiteral(@"<div class=""container"">
   
   <h3 class=""display-4"">Authentication and Authorisation</h3>
   <p>This Application has user authentication sign in provided by the Okta dev account <a href=""https://dev-312326.okta.com/"">https://dev-312326.okta.com/</a></p>
   <p>The API authentication is via OAuth 2.0 with a client_id and client_secret, this is known as machine to machine authentication as it is independent of the user of the application. This is provided by the Okata dev account <a href=""https://dev-312326-admin.okta.com/admin/dashboard"">https://dev-312326-admin.okta.com/admin/dashboard</a>
  to protect the internal API endpoint of the Bentley gINT database connection.<p>");
            EndContext();
            BeginContext(740, 117, false);
#line 9 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\ClientAPI\Index.cshtml"
                                                                             Write(Html.ActionLink("Records in gINT Database Point Table (gINTProjectID=4)", "gINTLocations", new { gINTProjectID = 4 }));

#line default
#line hidden
            EndContext();
            BeginContext(857, 401, true);
            WriteLiteral(@"</p>  
  <p>Machine to Machine API authentication has not been applied to the Node.js Express API and the Python Django API as these are more passive services, that have short term project data retention</p>
 <p>No separate authorization groups have been established, if the machine or user is authenticated then they are authorised to carry out any tasks provided by the application or services</p>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

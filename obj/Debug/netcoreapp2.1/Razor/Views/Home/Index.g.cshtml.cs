#pragma checksum "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ff9a70928f7c30e723ef6631b45147e1177b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ff9a70928f7c30e723ef6631b45147e1177b3a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1329, true);
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Welcome</h3>
    <p>As part of Ground Engineering's digital transformation, we are investigating the use of application programme interfaces (API's) to provide a distributed software architecture that would allow enterprise automation of common geotechnical tasks and processes</p>
    <p>This portal is a proof of concept that uses API's to carry out common geotechnical data, analysis and design tasks.</p> 
    <p>All the web pages on this portal act as clients to backend servers. The client submits the data, the backend server processes it, returns the results and the client presents the result.</p> 
    <p>On our digital transformation to enterprise automation, these are some of the work tasks and procedures that would be needed. The selected tasks presented in this portal are stand alone, to demontrate the viablilty of this approach, further tasks are required to string together to complete the full work flows</p>
    <p>The decoupling of the procedu");
            WriteLiteral(@"res allows different interfaces to submit and process the results and to build automated end to end business work-flows.</p> 
    <p>Applications that could interface to these services include MS Office, Power Apps, Power BI. </p>   
    <p>For further details of the private API's developed please see ");
            EndContext();
            BeginContext(1375, 85, false);
#line 13 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Home\Index.cshtml"
                                                                Write(Html.ActionLink("Details of GE Application Programme Interfaces (API)", "APIDetails"));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 17, true);
            WriteLiteral(" </p>\r\n</div>  \r\n");
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

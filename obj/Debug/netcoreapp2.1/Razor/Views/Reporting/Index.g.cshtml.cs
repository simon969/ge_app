#pragma checksum "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Reporting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7566b3a422a3973c87749c2226e23e1098cb5766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reporting_Index), @"mvc.1.0.view", @"/Views/Reporting/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reporting/Index.cshtml", typeof(AspNetCore.Views_Reporting_Index))]
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
#line 1 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Reporting\Index.cshtml"
using ge_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7566b3a422a3973c87749c2226e23e1098cb5766", @"/Views/Reporting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Reporting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ge_app.Models.ProcessModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Reporting\Index.cshtml"
  
    ViewData["Title"] = "Reporting Tools";

#line default
#line hidden
            BeginContext(125, 202, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    \r\n    <h3 class=\"display-4\">Reporting Tools</h3>\r\n\r\n    <p>The following reporting tools are available to assist in outputing results in useful formats</p>\r\n    \r\n    <h3>");
            EndContext();
            BeginContext(328, 57, false);
#line 15 "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\Reporting\Index.cshtml"
   Write(Html.ActionLink("Latex to PDF Server", "Latex2PDFOutput"));

#line default
#line hidden
            EndContext();
            BeginContext(385, 144, true);
            WriteLiteral("</h3>\r\n    <p>If calculation results are returned in latex formated text they can be convert to Portable Document Format (PDF)</p> \r\n \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ge_app.Models.ProcessModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

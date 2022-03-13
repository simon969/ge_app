#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\DataProcessing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728f250f41b5037845c54f4c712c5ce906c43fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataProcessing_Index), @"mvc.1.0.view", @"/Views/DataProcessing/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataProcessing/Index.cshtml", typeof(AspNetCore.Views_DataProcessing_Index))]
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
#line 1 "C:\Users\thomsonsj\apps\ge_app\Views\_ViewImports.cshtml"
using ge_app;

#line default
#line hidden
#line 1 "C:\Users\thomsonsj\apps\ge_app\Views\DataProcessing\Index.cshtml"
using ge_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728f250f41b5037845c54f4c712c5ce906c43fda", @"/Views/DataProcessing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_DataProcessing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ge_app.Models.ProcessModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 4 "C:\Users\thomsonsj\apps\ge_app\Views\DataProcessing\Index.cshtml"
  
    ViewData["Title"] = "Data Processing Procedures";

#line default
#line hidden
            BeginContext(138, 212, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3 class=\"display-4\">Data Processing</h3>\r\n  <p>The following are examples of data processing where files are uploaded to the remote server, processed and then downloaded</p>\r\n<h3>");
            EndContext();
            BeginContext(351, 60, false);
#line 11 "C:\Users\thomsonsj\apps\ge_app\Views\DataProcessing\Index.cshtml"
Write(Html.ActionLink("Export Plaxis Results", "GetPlaxisResults"));

#line default
#line hidden
            EndContext();
            BeginContext(411, 245, true);
            WriteLiteral("</h3>\r\n<p>Extract results from Plaxis 2d and 3d Analysis</p><p>The remote server connects to Plaxis 2d or Plaxis 3d Output Module on a desktop or laptop, extract selected results and saves them as csv files for download by the client</p>\r\n\r\n<h3>");
            EndContext();
            BeginContext(657, 56, false);
#line 14 "C:\Users\thomsonsj\apps\ge_app\Views\DataProcessing\Index.cshtml"
Write(Html.ActionLink("Summary of AGS Files", "GetAGSSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(713, 238, true);
            WriteLiteral("</h3>\r\n<p>Create a summary of the quantity of records in AGS groups in multiple AGS files.</p> <p>Multiple AGS files are uploaded to the remote server, it reads the files and creates summary csv files for download by the client</p> \r\n\r\n\r\n");
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
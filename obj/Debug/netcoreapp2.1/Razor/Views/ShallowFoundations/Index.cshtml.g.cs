#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4577daead366d443a6d84ed90322948c67296e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShallowFoundations_Index), @"mvc.1.0.view", @"/Views/ShallowFoundations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShallowFoundations/Index.cshtml", typeof(AspNetCore.Views_ShallowFoundations_Index))]
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
#line 1 "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\Index.cshtml"
using ge_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4577daead366d443a6d84ed90322948c67296e", @"/Views/ShallowFoundations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_ShallowFoundations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ge_app.Models.ProcessModel>>
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
#line 5 "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\Index.cshtml"
  
    ViewData["Title"] = "Shallow Foundation Tools";

#line default
#line hidden
            BeginContext(134, 228, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    \r\n    <h3 class=\"display-4\">Shallow Foundation Tools</h3>\r\n\r\n    <p>The following geotechnical tools are available to assist in determining shallow foundation sizes</p>\r\n    <h3>Bearing Resistance ");
            EndContext();
            BeginContext(363, 51, false);
#line 14 "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\Index.cshtml"
                      Write(Html.ActionLink("Undrained", "UndrainedBearingEC7"));

#line default
#line hidden
            EndContext();
            BeginContext(414, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(420, 47, false);
#line 14 "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\Index.cshtml"
                                                                               Write(Html.ActionLink("Drained", "DrainedBearingEC7"));

#line default
#line hidden
            EndContext();
            BeginContext(467, 229, true);
            WriteLiteral(" </h3>\r\n    <p>Calculate undrained and drained bearing resistance of rectancular footing using EC7 formulae. The input values are submitted to the remote server and the results are presented in a results table</p> \r\n   \r\n    <h3>");
            EndContext();
            BeginContext(697, 53, false);
#line 17 "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\Index.cshtml"
   Write(Html.ActionLink("Load Inclination Factor", "EC7D1ic"));

#line default
#line hidden
            EndContext();
            BeginContext(750, 234, true);
            WriteLiteral("</h3>\r\n    <p>Investigate the influence of the Load Inclination Factor Ic on the bearing resistance. The input values are submitted to the remote server and the results are presented in a results table and a chart</p> \r\n    \r\n</div>\r\n");
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

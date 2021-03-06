#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\EC7D1ic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1ddf4826037b32faf1a46bf1a7d5b9f9d46c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShallowFoundations_EC7D1ic), @"mvc.1.0.view", @"/Views/ShallowFoundations/EC7D1ic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShallowFoundations/EC7D1ic.cshtml", typeof(AspNetCore.Views_ShallowFoundations_EC7D1ic))]
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
#line 2 "C:\Users\thomsonsj\apps\ge_app\Views\_ViewImports.cshtml"
using ge_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1ddf4826037b32faf1a46bf1a7d5b9f9d46c74", @"/Views/ShallowFoundations/EC7D1ic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_ShallowFoundations_EC7D1ic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ge_app.Models.ProcessModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ic_vs_cu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ic_vs_hload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ic_vs_area", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 3 "C:\Users\thomsonsj\apps\ge_app\Views\ShallowFoundations\EC7D1ic.cshtml"
  
    ViewData["Title"] = "Load Inclination Factor";

#line default
#line hidden
            BeginContext(100, 1134, true);
            WriteLiteral(@"  <div class=""container"">

    <h2>Bearing Resistance Calculation</h2>
    <p>(BS EN 1997-1:2004+A1:2013 Annex D (informative))</p>
    <h3>Load Inclination Factor ic</h3>
   <!-- Content here -->
    <div class=""form-group"" id=""fg_Breadth"">
    <div class=""form-group"" id=""fg_Area"">
      <label for=""Area"">Area</label>
      <input type=""text"" class=""form-control"" id=""Area"" value=""12"" aria-describedby=""AreaHelp"" placeholder=""...foundation area (m2)"" >
      <small id=""AreaHelp"" class=""form-text text-muted"">Enter the area of the footing</small>
    </div>
    <div class=""form-group"" id=""fg_H"">
      <label for=""HLoad"">Horizontal Load</label>
      <input type=""text"" class=""form-control"" id=""HLoad"" placeholder=""...horizontal load"">
    </div>
    <div class=""form-group"" id=""fg_cu"">
      <label for=""c"">Undrained shear strength</label>
      <input type=""text"" class=""form-control"" id=""Cu"" placeholder=""...undrained shear strength"">
    </div>
    <div class=""form-group"" id=""fg_chart"">
      <");
            WriteLiteral("label for=\"chart_select\">Select chart</label>\r\n      <select class=\"form-control\" id=\"chart_select\">\r\n        ");
            EndContext();
            BeginContext(1234, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df095fbe764a4a89b12b67dec2d5f679", async() => {
                BeginContext(1259, 34, true);
                WriteLiteral("Load Inclination Factor (ic) vs Cu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1302, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1312, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b27b87ee1105496d8b33f44010e978de", async() => {
                BeginContext(1340, 47, true);
                WriteLiteral("Load Inclination Factor (ic) vs Horizontal Load");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1396, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1406, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c398bd1f43a442baaf3a09a2e2fdd8ac", async() => {
                BeginContext(1433, 36, true);
                WriteLiteral("Load Inclination Factor (ic) vs Area");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1478, 3476, true);
            WriteLiteral(@"
      </select>
      <canvas id=""mychart""></canvas>
    </div>

    <div class=""form-group"" id =""fg_response"" >
      <label for=""response"">D.3 Undrained Conditions (intermediate results eq D1_ic)</label>
      <textarea id=""response"" class = ""form-control"" name=""response"" placeholder=""...intermediate results undrained inclination factor due to horizontal load"" rows=""4"" cols=""50""> </textarea>
    </div>
    <button  onclick=""calc()"" class=""btn btn-primary"">Calculate</button>
    <button  onclick=""populate('18,18,18,18,18,18,18,18,18','100,200,300,400,500,600,700,800,900','75,75,75,75,75,75,75,75,75')"" class=""btn btn-primary"">Test</button>
   </div>
   <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
   <script type=""text/javascript"" >
      const data = {
        datasets: [{
          label: 'My First dataset',
          backgroundColor: 'rgb(255, 99, 132)',
          borderColor: 'rgb(255, 99, 132)',
          data: [{x: 0, y: 0}]
        }]
      };

      const option");
            WriteLiteral(@"s = {
        scales: {
          x: {
            title: {
            display: true,
            text: 'Load inclination factor (ic)'
            }
          },
          y: {
            title: {
            display: true,
            text: 'Select Y axis data... (Cu or Hload)'
            }
          }
        }
      }

    
      const config = {
        type: 'scatter',
        data: data,
        options: options
      };
    
      var ctx = document.getElementById('mychart').getContext(""2d"");
      
      const mychart = new Chart(
              ctx,
              config
      );

 
    function calc() { 
          
          var Area =  get_value(""Area"");
          var HLoad =  get_value(""HLoad"");
          var Cu =  get_value(""Cu"");
          var url = host + `/EC7_Bearing/calc_EC7_D1/param/ic?area=${Area}&hload=${HLoad}&cu=${Cu}`
          
          httpGetAsync(url, display_result)
          
        }
        
    function display_result(response) {
");
            WriteLiteral(@"          set_innerHTML (""response"",response)
          var res = JSON.parse(response)
          
          renderChart (res.data)
    }
    
    function renderChart (data) {

      var chart_select = get_value(""chart_select"");
      var new_data = []
      
      for (let i = 0; i < data.length; i++) {
            var pt = new Object
            pt.x = parseFloat(data[i].ic);
            if (chart_select == 'ic_vs_cu') pt.y = parseFloat(data[i].cu);
            if (chart_select == 'ic_vs_hload') pt.y = parseFloat(data[i].hload);
            if (chart_select == 'ic_vs_area') pt.y = parseFloat(data[i].area);
            new_data.push(pt)
      }
      
      if (chart_select == 'ic_vs_cu') options.scales.y.title.text= ""Cu"";
      if (chart_select == 'ic_vs_hload') options.scales.y.title.text = ""Hload"";
      if (chart_select == 'ic_vs_area') options.scales.y.title.text = ""Area"";
      
      addData(mychart,new_data,chart_select,0);

    }

    function addData(chart, data, label, ");
            WriteLiteral(@"datasetIndex) {
      chart.data.datasets[datasetIndex].label = label;
      chart.data.datasets[datasetIndex].data = data;
      chart.update();
    }
    
    function populate(Area, HLoad, Cu) {
        
        $(""#Area"").val(Area);
        $(""#HLoad"").val(HLoad);
        $(""#Cu"").val(Cu);
    
        //reset results
        
        $(""#response"").html("""");
    }
   
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ge_app.Models.ProcessModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\GroundWater\MONDResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53461b07bf169da0934bd22c7ef517b8e56e01a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroundWater_MONDResults), @"mvc.1.0.view", @"/Views/GroundWater/MONDResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroundWater/MONDResults.cshtml", typeof(AspNetCore.Views_GroundWater_MONDResults))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53461b07bf169da0934bd22c7ef517b8e56e01a4", @"/Views/GroundWater/MONDResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_GroundWater_MONDResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ge_app.Models.ProcessModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("get_list_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(37, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 4 "C:\Users\thomsonsj\apps\ge_app\Views\GroundWater\MONDResults.cshtml"
  
    ViewData["Title"] = "Get MOND Results";

#line default
#line hidden
            BeginContext(95, 74, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h4>Get MOND Results</h4>\r\n        ");
            EndContext();
            BeginContext(169, 1511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ea7df7094743cabf2b11ebf4be881f", async() => {
                BeginContext(233, 1440, true);
                WriteLiteral(@"
            <div class=""row"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""ProjectId"">ProjectId
                        <button class=""button"" type=""button"" onclick=""get_projects()"">Load Projects</button>
                        </label>
                        <select class=""form-control"" type=""text"" id=""qryProjectId"" name=""qryProjectId""> 
                        
                        </select>

                     </div>
                    <div class=""form-group"">
                        <label for=""PointId"">Location (PointId) </label>
                        <button class=""button"" type=""button"" onclick=""get_points()"">Load Points</button>
                    </label>
                    <select class=""form-control"" type=""text"" id=""qryPointId"" name=""qryPointId""> 
                    
                    </select>
                    </div>
                    <div class=""form-group"">
                     ");
                WriteLiteral(@"   <label for=""MOND_TYPE"">Reading Type (MOND_TYPE)</label>
                        <input class=""form-control"" type=""text"" id=""qryMOND_TYPE"" name=""qryMOND_TYPE"" placeholder=""...enter mond_type"">
                    </div>
                </div>
                <div class=""col-sm-6""> 
                    <input class=""button"" type=""submit"" value=""Find"">
                </div>
            </div>   
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1680, 376, true);
            WriteLiteral(@"
            <div class=""table-wrapper-scroll-y mond_list-scrollbar"">
                <table class=""table table-striped"" id=""mond_table"">
                    <thead id=""mond_head"">
                    </thead>
                <tbody id=""mond_body""></tbody>
                </table>
            </div>
           <canvas id=""mychart""></canvas>
    </div>  
    
    ");
            EndContext();
            BeginContext(2056, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e50bf2ae10bd4e16ab77255bb1552a38", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2108, 1494, true);
            WriteLiteral(@"  
    <script src=""https://cdn.jsdelivr.net/npm/chartjs-adapter-date-fns/dist/chartjs-adapter-date-fns.bundle.min.js""></script>
   
    <script type=""text/javascript"">
    const data = {
        datasets: [{
          label: 'My First dataset',
          backgroundColor: 'rgb(255, 99, 132)',
          borderColor: 'rgb(255, 99, 132)',
          data: [{x: 0, y: 0}]
        }]
      };

      const options = {
        scales: {
          x: {
                title: {
                display: true,
                text: 'Reading DateTime'
                },
                type:'time', 
                time: {
                    unit: 'day',
                    unitStepSize: 7,
                    displayFormats:{
                        'day':'yyyy MMM dd'
                    }
                }
            },
          y: {
            title: {
            display: true,
            text: 'Select MOND_TYPE'
            }
          }
        }
      }

    
      const ");
            WriteLiteral(@"config = {
        type: 'scatter',
        data: data,
        options: options
      };
    
      var ctx = document.getElementById('mychart').getContext(""2d"");
      
      const mychart = new Chart(
              ctx,
              config
      );

    function renderChart (data) {

      var chart_select = get_value(""chart_select"");
      var new_data = []
      
      for (let i = 0; i < data.length; i++) {
            var pt = new Object
");
            EndContext();
            BeginContext(3658, 3850, true);
            WriteLiteral(@"            pt.x = data[i].DateTime;
            pt.y = parseFloat(data[i].MOND_RDNG);
            new_data.push(pt)
      }
      
      options.scales.y.title.text= data[0].MOND_TYPE + ' ' + data[0].MOND_UNIT;
      
      addData(mychart,new_data,chart_select,0);

    }

    function addData(chart, data, label, datasetIndex) {
      chart.data.datasets[datasetIndex].label = label;
      chart.data.datasets[datasetIndex].data = data;
      chart.update();
    }

    function init_form () {
       
        $(""#get_list_form"").submit(function(e) {
            e.preventDefault()
            get_mond_results()
        });
    }

    function get_projects() {
        init_form()
        var url = gint_host + '/project';
        httpGetAsync(url,display_projects)
    }
    
    function display_projects(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryProjectId"");
        sel.innerHTML = """"
        for (var i = 0; i < json_d");
            WriteLiteral(@"ata.length; i++) {
            var project = json_data[i];
            op = document.createElement('option');
            op.setAttribute(""value"",project.gINTProjectID)
            op.innerHTML = project.PROJ_NAME 
            sel.appendChild(op)
        }

    }

    function get_points() {
        var projectid = get_value(""qryProjectId"");
        var url = gint_host + '/point/project/' + projectid;

        // test_OktaCORS()

        // if (!OAuth2Client_gINT.token) {
        //    get_token (OAuth2Client_gINT)
        // }
        // httpGetAsync(url,display_points, OAuth2Client_gINT.token)
        
        httpGetAsync(url,display_points)
        
    }
    
    function display_points(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryPointId"");
        sel.innerHTML = """"
        for (var i = 0; i < json_data.length; i++) {
            var point = json_data[i];
            op = document.createElement('option');
       ");
            WriteLiteral(@"     op.setAttribute(""value"",point.PointID)
            op.innerHTML = point.PointID 
            sel.appendChild(op)
        }

    }
    function get_mond_results() {
        var projectid = get_value(""qryProjectId"")
        var pointid = get_value(""qryPointId"")
        var mond_type = get_value(""qryMOND_TYPE"")
        var url = gint_host + '/mond/project/' + projectid + '/point/' + pointid + '/type/' + mond_type;
        httpGetAsync(url,display_list)
    }

    function display_list (response) {
        var show_fields = ['PointID','MOND_TYPE','ItemKey','MONG_DIS','DateTime','MOND_RDNG']
        var json_data = JSON.parse(response);
        var thead = document.getElementById(""mond_head"");
        thead.innerHTML = """";
        tr = document.createElement('tr');
        th = document.createElement('th')
            th.setAttribute(""class"",""d-none"")
            th.innerHTML = ""GintRecID""
            tr.appendChild(th)
        for (var j = 0; j < show_fields.length; j++) {
          ");
            WriteLiteral(@"  th = document.createElement('th')
            th.innerHTML = show_fields[j]
            tr.appendChild(th)
        }
        thead.appendChild(tr)
        
        var tbody = document.getElementById(""mond_body"");
        tbody.innerHTML = """";
        for (var i = 0; i < json_data.length; i++) {
        var mond = json_data[i];
        tr = document.createElement('tr');
             td = document.createElement('td')
                td.setAttribute(""class"",""d-none"")
                td.innerHTML = mond['GintRecID']
            tr.appendChild(td)
            for (var j = 0; j < show_fields.length; j++) {
                td = document.createElement('td')
                td.innerHTML = mond[show_fields[j]]
            tr.appendChild(td)
            }
");
            EndContext();
            BeginContext(8143, 99, true);
            WriteLiteral("        tbody.appendChild(tr);\r\n        renderChart (json_data)\r\n        } \r\n    }\r\n    </script>\r\n");
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

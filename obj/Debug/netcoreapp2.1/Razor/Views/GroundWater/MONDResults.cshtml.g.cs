#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\GroundWater\MONDResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734b96c9096496ad0b89fd51648d69fadfeba48a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734b96c9096496ad0b89fd51648d69fadfeba48a", @"/Views/GroundWater/MONDResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_GroundWater_MONDResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ge_app.Models.ProcessModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ALL_PROJECTS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "individual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "daily_max", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "daily_min", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "hourly_max", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "hourly_min", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("get_list_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
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
            BeginContext(169, 4210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "600ff04f5f0f4e6ba2972ad12e90f340", async() => {
                BeginContext(233, 471, true);
                WriteLiteral(@"
            <div class=""row col-sm-12"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""qryProjectId"">ProjectId
                        <button class=""button"" type=""button"" onclick=""get_projects()"">Load Projects</button>
                        </label>
                        <select class=""form-control"" type=""text"" id=""qryProjectId"" name=""qryProjectId""> 
                            ");
                EndContext();
                BeginContext(704, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ce16ba963748f49c566b942e3abbe6", async() => {
                    BeginContext(733, 12, true);
                    WriteLiteral("All Projects");
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
                BeginContext(754, 467, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""qryMondType"">Reading Type (MOND_TYPE)</label>
                        <button class=""button"" type=""button"" onclick=""get_mondtypes()"">Load Types</button>
                        <select class=""form-control"" type=""text"" id=""qryMondType"" name=""qryMondType""> 
                        
                        </select>
");
                EndContext();
                BeginContext(1364, 751, true);
                WriteLiteral(@"                    </div>
                    <div class=""form-group"">
                        <label for=""qryPointID_DIS"">Location (PointId) </label>
                        <button class=""button"" type=""button"" onclick=""get_pointsbymond()"">Load Points</button>
                        </label>
                        <select class=""form-control"" type=""text"" id=""qryPointID_DIS"" name=""qryPointID_DIS""> 
                        
                        </select>
                    </div>
                   <div class=""form-group"">
                        <label for=""qryInterval"">Reading Interval</label>
                        <select class=""form-control"" type=""text"" id=""qryInterval"" name=""qryInterval"">
                            ");
                EndContext();
                BeginContext(2115, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2d6d325533d4582af4ec3aaad918eb6", async() => {
                    BeginContext(2142, 19, true);
                    WriteLiteral("Individual Readings");
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
                BeginContext(2170, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2200, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9241ad5632d042619d5a478d385b981b", async() => {
                    BeginContext(2226, 9, true);
                    WriteLiteral("Daily Max");
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
                BeginContext(2244, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2274, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "221d48a8339645d4ae8dec10bfd354a3", async() => {
                    BeginContext(2300, 9, true);
                    WriteLiteral("Daily Min");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2318, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2348, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6700c65e63e24a6aab0e2ee6217c746f", async() => {
                    BeginContext(2375, 10, true);
                    WriteLiteral("Hourly Max");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2394, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2424, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140e09eb383546ac9e250282bf706ba4", async() => {
                    BeginContext(2451, 10, true);
                    WriteLiteral("Hourly Min");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2470, 1902, true);
                WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""col-sm-6"">      
                    <div class=""form-group"">
                        <label for=""qryFromDT"">Readings from DateTime</label>
                        <input class=""form-control"" type=""datetime-local"" id=""qryFromDT"" name=""qryFromDT"" placeholder=""...enter mond_type"">
                    </div>
                    <div class=""form-group"">
                        <label for=""qryToDT"">Readings to DateTime</label>
                        <input class=""form-control"" type=""datetime-local"" id=""qryToDT"" name=""qryToDT"" placeholder=""...enter mond_type"">
                    </div>
                    <div class=""form-group"">
                                <label for=""qryPage"">Page No</label>
                                <input class=""form-control"" type=""text"" id=""qryPage"" name=""qryPage"" value=""0"">
                    </div>  
                    <div class=""form-group"">
     ");
                WriteLiteral(@"                           <label for=""qryPage"">Page Size</label>
                                <input class=""form-control"" type=""text"" id=""qrySize"" name=""qrySize"" value=""1000"">
                    </div>
                    <div class=""form-group"">  
                                <input class=""button"" type=""button"" value=""Previous Page"" onclick=""previous_page()"">  
                                <input class=""button"" type=""button"" value=""Get MOND Results"" onclick=""get_mond_results()"">  
                                <input class=""button"" type=""button"" value=""Next Page"" onclick=""next_page()"">  
                                <a id=""url_json"" target=""_blank"" rel=""noopener"" >JSON</a>
                                <a id=""url_csv"" target=""_blank"" rel=""noopener"">CSV</a>
                    </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4379, 429, true);
            WriteLiteral(@"
            <div class=""table-wrapper-scroll-y mond_list-scrollbar"">
                <table class=""table table-striped"" id=""mond_table"">
                    <thead id=""mond_head"">
                    </thead>
                <tbody id=""mond_body""></tbody>
                </table>
            </div>

            <p id=""response""> </p>
           

           <canvas id=""mychart""></canvas>
    </div>  
    
    ");
            EndContext();
            BeginContext(4808, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9222183cb16d4211a62a3065caf3d959", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4860, 1574, true);
            WriteLiteral(@"  
    <script src=""https://cdn.jsdelivr.net/npm/chartjs-adapter-date-fns/dist/chartjs-adapter-date-fns.bundle.min.js""></script>
   
    <script type=""text/javascript"">
    const data = {
        datasets: [{
          label: 'MOND_TYPE',
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

    
      const config ");
            WriteLiteral(@"= {
        type: 'scatter',
        data: data,
        options: options
      };
    
      var ctx = document.getElementById('mychart').getContext(""2d"");
      
      const mychart = new Chart(
              ctx,
              config
      );

    function resetChart () {

        mychart.data = data        

    }
    function renderChart (data, index) {

     // var chart_select = get_value(""chart_select"");
      var new_data = []
      
      for (let i = 0; i < data.length; i++) {
            var pt = new Object
");
            EndContext();
            BeginContext(6490, 7775, true);
            WriteLiteral(@"            pt.x = data[i].DateTime;
            pt.y = parseFloat(data[i].MOND_RDNG);
            new_data.push(pt)
      }
      
      options.scales.y.title.text= data[0].MOND_TYPE + ' ' + data[0].MOND_UNIT;
            
      addData(mychart,new_data,data[0].MOND_TYPE, index);
      
    }

    function removeData(ds1) {
    let removalIndex = data.datasets.indexOf(ds1); //Locate index of ds1
        if(removalIndex >= 0) { //make sure this element exists in the array
            data.datasets.splice(removalIndex, 1);
        }
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
        var url = gint_host + '/proj");
            WriteLiteral(@"ect';
        httpGetAsync(url,display_projects)
    }
    function display_projects(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryProjectId"");
        sel.innerHTML = """"
        for (var i = 0; i < json_data.length; i++) {
            var project = json_data[i];
            op = document.createElement('option');
            op.setAttribute(""value"",project.gINTProjectID);
            op.innerHTML = project.PROJ_NAME ;
            sel.appendChild(op);
        }

        // Add all project option
        op = document.createElement('option');
        op.setAttribute(""value"",""ALL_PROJECTS"");
        op.innerHTML = ""All Projects"" ;
        sel.appendChild(op);
    }

    function get_mondtypes() {
        var projectid = $(""#qryProjectId"").val();  
        var url = """";
        if (projectid == ""ALL_PROJECTS"") { 
            url  = gint_host + '/mond/uniquetypes';
        } else {
            url = gint_host + '/mond/uniquetypes");
            WriteLiteral(@"/project/'+ projectid;
        }
        httpGetAsync(url,display_mondtypes);
    }
    function display_mondtypes(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryMondType"");
        sel.innerHTML = """";
        for (var i = 0; i < json_data.length; i++) {
            var type = json_data[i];
            op = document.createElement('option');
            op.setAttribute(""value"",type.MOND_TYPE);
            op.innerHTML = type.MOND_TYPE + ' (' + type.count + ')'; 
            sel.appendChild(op);
        }

    }
    function get_pointsbymond() {
        var projectid = $(""#qryProjectId"").val();
        var mondtype = $(""#qryMondType"").val();
        var url = """"

        if (projectid == ""ALL_PROJECTS"") {
            url = gint_host + '/mond/uniquetypes/type/' + mondtype;
        } else {
            url = gint_host + '/mond/uniquetypes/project/'+ projectid + '/type/' + mondtype;
        }

        httpGetAsync(url,display_poin");
            WriteLiteral(@"ts)
        
    }

    function get_points() {
        var projectid = $(""#qryProjectId"").val();
        if (projectid) {
        var url = gint_host + '/point/project/' + projectid;
        }
        
        // test_OktaCORS()
        // if (!OAuth2Client_gINT.token) {
        //    get_token (OAuth2Client_gINT)
        // }
        // httpGetAsync(url,display_points, OAuth2Client_gINT.token)
        
        httpGetAsync(url,display_points)
        
    }
    
    function display_points(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryPointID_DIS"");
        sel.innerHTML = """"
        for (var i = 0; i < json_data.length; i++) {
            var point = json_data[i];
            op = document.createElement('option');
            op.setAttribute(""value"",point.gINTProjectID + ',' + point.PointID + ',' + point.MONG_DIS)
            if (point.count) { 
                op.innerHTML = point.PointID + '_' + point.MONG_DIS + 'm (' ");
            WriteLiteral(@"+ point.count + ': ' + point.FromDT + '-' + point.ToDT + ')'
            } else {
                op.innerHTML = point.PointID  
            }
            sel.appendChild(op)
        }

    }

    function previous_page() {
        var page = get_value(""qryPage"");
        if (page > 0) {
        set_value(""qryPage"", parseInt(page) - 1);
        }
        get_mond_results();
    }
    
    function next_page() {
        var page = $(""#qryPage"").val();
        $(""#qryPage"").val(parseInt(page) + 1);
        get_mond_results();
    }

    function get_mond_results() {
        var location = $(""#qryPointID_DIS"").val();
        var loca = location.split(',');
        var projectid = loca[0];
        var pointid = loca[1];
        var dist = loca[2];    
        var mond_type = $(""#qryMondType"").val();
        var from_dt = $(""#qryFromDT"").val();
        var to_dt = $(""#qryToDT"").val();
        var page = $(""#qryPage"").val();
        var size = $(""#qrySize"").val();
        var inter");
            WriteLiteral(@"val  =$(""#qryInterval"").val();

        dateformat = 'YYYY-MM-DDTHH:m:s';

        var url_download = gint_host + '/mond/project/' + projectid + '/point/' + pointid + '/dist/' + dist +'/type/' + mond_type + '/download';
        var add = '/?';
        
        if (from_dt) {
            var d = new Date(from_dt)
            url_download += add + 'from=' + d.toISOString();
            add = ""&"";
        } 

        if (to_dt) {
            var d = new Date(to_dt)
            url_download += add + 'to=' + d.toISOString();
            add = ""&"";
        } 
        
        if (page && size) {   
            url_download += add + 'size=' + size + '&page=' + page
            add = ""&""
        } 

        if (interval) {   
            url_download += add + 'interval=' + interval
            add = ""&""
        }  

        url = url_download.replace('/download','');
        
        var e = document.getElementById(""url_csv"");
            url_csv = url_download + add + 'format=csv'
  ");
            WriteLiteral(@"          e.setAttribute ('href',url_csv);
        
        var e = document.getElementById(""url_json"");
            url_json = url_download + add + 'format=json'
            e.setAttribute ('href',url_json);
            
        httpGetAsync(url,display_list);
    }
   
    function display_list (response) {
        var show_fields = ['PointID','MOND_TYPE','ItemKey','MOND_REF','MONG_DIS','DateTime','MOND_RDNG','MOND_REM']
        var json_data = JSON.parse(response);
        var thead = document.getElementById(""mond_head"");
        thead.innerHTML = """";
        tr = document.createElement('tr');
        th = document.createElement('th');
            th.setAttribute(""class"",""d-none"");
            th.innerHTML = ""GintRecID"";
            tr.appendChild(th);
        for (var j = 0; j < show_fields.length; j++) {
            th = document.createElement('th')
            th.innerHTML = show_fields[j];
            tr.appendChild(th);
        }
        thead.appendChild(tr)
        
       ");
            WriteLiteral(@" var tbody = document.getElementById(""mond_body"");
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
            BeginContext(14902, 452, true);
            WriteLiteral(@"        tbody.appendChild(tr);
        } 

        resetChart ();

        var currentDT = new Date().toISOString();
        
        if (json_data.length>0){ 
            set_innerHTML (""response"",  'Records returned: Count = ' + json_data.length  + '; Type = ' + json_data[0].MOND_TYPE)
            renderChart (json_data, 0);
        } else {
            set_innerHTML (""response"",'No records returned')
        }
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

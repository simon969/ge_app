#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\GroundWater\MONDResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0e278eb94d456b7c6f0a0eed0c6c62e5911e80"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e0e278eb94d456b7c6f0a0eed0c6c62e5911e80", @"/Views/GroundWater/MONDResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_GroundWater_MONDResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ge_app.Models.ProcessModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "individual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "day_max", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "day_min", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("get_list_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(169, 3974, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c9ce8b1eda4872b65953e66f818adc", async() => {
                BeginContext(233, 908, true);
                WriteLiteral(@"
            <div class=""row col-sm-12"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""qryProjectId"">ProjectId
                        <button class=""button"" type=""button"" onclick=""get_projects()"">Load Projects</button>
                        </label>
                        <select class=""form-control"" type=""text"" id=""qryProjectId"" name=""qryProjectId""> 
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""qryMondType"">Reading Type (MOND_TYPE)</label>
                        <button class=""button"" type=""button"" onclick=""get_mondtypes()"">Load Types</button>
                        <select class=""form-control"" type=""text"" id=""qryMondType"" name=""qryMondType""> 
                        
                        </select>
");
                EndContext();
                BeginContext(1284, 751, true);
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
                BeginContext(2035, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "155b5b42ca4b4fbdbb007a75ab4d7104", async() => {
                    BeginContext(2062, 19, true);
                    WriteLiteral("Individual Readings");
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
                BeginContext(2090, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2120, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52799b6d18cd488d98941785e2af5c44", async() => {
                    BeginContext(2144, 9, true);
                    WriteLiteral("Daily Max");
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
                BeginContext(2162, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2192, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e79b36105b64c14a39c68c96aa78399", async() => {
                    BeginContext(2216, 9, true);
                    WriteLiteral("Daily Min");
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
                BeginContext(2234, 1902, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4143, 429, true);
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
            BeginContext(4572, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3523c81287b24dd08c27cff7ea42db96", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4624, 1572, true);
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

      var chart_select = get_value(""chart_select"");
      var new_data = []
      
      for (let i = 0; i < data.length; i++) {
            var pt = new Object
");
            EndContext();
            BeginContext(6252, 7213, true);
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
            op.setAttribute(""value"",project.gINTProjectID)
            op.innerHTML = project.PROJ_NAME 
            sel.appendChild(op)
        }
    }
    function get_mondtypes() {
        var projectid = get_value(""qryProjectId"");
        var url = gint_host + '/mond/uniquetypes/project/'+ projectid;
        httpGetAsync(url,display_mondtypes)
    }
    function display_mondtypes(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryMondType"");
        sel.innerHTML = """"
        for (var i = 0; i < json_data.length; i++) {
            var type = json_data[i];
     ");
            WriteLiteral(@"       op = document.createElement('option');
            op.setAttribute(""value"",type.MOND_TYPE)
            op.innerHTML = type.MOND_TYPE + ' (' + type.count + ')' 
            sel.appendChild(op)
        }

    }
    function get_pointsbymond() {
        var projectid = get_value(""qryProjectId"");
        var mondtype = get_value(""qryMondType"");
        var url = gint_host + '/mond/uniquetypes/project/'+ projectid + '/type/' + mondtype;

        // test_OktaCORS()
        // if (!OAuth2Client_gINT.token) {
        //    get_token (OAuth2Client_gINT)
        // }
        // httpGetAsync(url,display_points, OAuth2Client_gINT.token)
        
        httpGetAsync(url,display_points)
        
    }

    function get_points() {
        var projectid = get_value(""qryProjectId"");
        var url = gint_host + '/point/project/' + projectid;

        // test_OktaCORS()
        // if (!OAuth2Client_gINT.token) {
        //    get_token (OAuth2Client_gINT)
        // }
        // httpGetAs");
            WriteLiteral(@"ync(url,display_points, OAuth2Client_gINT.token)
        
        httpGetAsync(url,display_points)
        
    }
    
    function display_points(response) {
        var json_data = JSON.parse(response);
        var sel = document.getElementById(""qryPointID_DIS"");
        sel.innerHTML = """"
        for (var i = 0; i < json_data.length; i++) {
            var point = json_data[i];
            op = document.createElement('option');
            op.setAttribute(""value"",point.PointID + ',' + point.MONG_DIS)
            if (point.count) { 
                op.innerHTML = point.PointID + '_' + point.MONG_DIS + 'm (' + point.count + ': ' + point.FromDT + '-' + point.ToDT + ')'
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
");
            WriteLiteral(@"    }
    
    function next_page() {
        var page = $(""#qryPage"").val();
        $(""#qryPage"").val(parseInt(page) + 1);
        get_mond_results();
    }

    function get_mond_results() {
        var projectid = $(""#qryProjectId"").val();
        var location = $(""#qryPointID_DIS"").val();
        var loca = location.split(',');
        var pointid = loca[0];
        var dist = loca[1];    
        var mond_type = $(""#qryMondType"").val();
        var from_dt = $(""#qryFromDT"").val();
        var to_dt = $(""#qryToDT"").val();
        var page = $(""#qryPage"").val();
        var size = $(""#qrySize"").val();
        dateformat = 'YYYY-MM-DDTHH:m:s';

        var url_download = gint_host + '/mond/project/' + projectid + '/point/' + pointid + '/dist/' + dist +'/type/' + mond_type + '/download';
        var add = '/?';
        
        if (from_dt) {
            var d = new Date(from_dt)
            url_download += add + 'from=' + d.toISOString();
            add = ""&"";
        } 

   ");
            WriteLiteral(@"     if (to_dt) {
            var d = new Date(to_dt)
            url_download += add + 'to=' + d.toISOString();
            add = ""&"";
        } 
        
        if (page && size) {   
            url_download += add + 'size=' + size + '&page=' + page
            add = ""&""
        }  
        url = url_download.replace('/download','');
        
        var e = document.getElementById(""url_csv"");
            url_csv = url_download + add + 'format=csv'
            e.setAttribute ('href',url_csv);
        
        var e = document.getElementById(""url_json"");
            url_json = url_download + add + 'format=json'
            e.setAttribute ('href',url_json);
            
        httpGetAsync(url,display_list);
    }
   
    function display_list (response) {
        var show_fields = ['PointID','MOND_TYPE','ItemKey','MONG_DIS','DateTime','MOND_RDNG','MOND_REM']
        var json_data = JSON.parse(response);
        var thead = document.getElementById(""mond_head"");
        thead.inne");
            WriteLiteral(@"rHTML = """";
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
  ");
            WriteLiteral("          tr.appendChild(td)\r\n            }\r\n");
            EndContext();
            BeginContext(14102, 452, true);
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

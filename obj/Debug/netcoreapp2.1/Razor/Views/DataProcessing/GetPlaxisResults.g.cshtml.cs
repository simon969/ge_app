#pragma checksum "C:\Users\thomsonsj\apps\ge_app\Views\DataProcessing\GetPlaxisResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6431b0593b6462eac4d8927592dd3810a6a4489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataProcessing_GetPlaxisResults), @"mvc.1.0.view", @"/Views/DataProcessing/GetPlaxisResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataProcessing/GetPlaxisResults.cshtml", typeof(AspNetCore.Views_DataProcessing_GetPlaxisResults))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6431b0593b6462eac4d8927592dd3810a6a4489", @"/Views/DataProcessing/GetPlaxisResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_DataProcessing_GetPlaxisResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://localhost:8000/PlaxisTask/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("plaxis_list_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Plaxis2dConnectV2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Plaxis2dConnect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Plaxis3dConnect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("plaxis_post_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("plaxis_get_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 200, true);
            WriteLiteral("    <div class=\"container\">\r\n        <h3 class=\"class=\"display-4\">Get Plaxis Results</h3>\r\n        <p>Create a query to connect to the Plaxis 2d or 3d Output Server and return a csv file</p>\r\n        ");
            EndContext();
            BeginContext(200, 581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f2aa3ad64d24687b24be1864efeae14", async() => {
                BeginContext(284, 490, true);
                WriteLiteral(@"
            <div class=""row"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <input class=""form-control"" type=""text"" id=""owner"" name=""owner"" placeholder=""...enter owner email"">
                    </div>
                </div>
                <div class=""col-sm-6""> 
                    <input class=""button"" type=""button"" value=""Find"" onclick=""get_results()"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 1019, true);
            WriteLiteral(@"
            <div class=""table-wrapper-scroll-y plaxis_list-scrollbar"">
                <table class=""table table-striped"" id=""task_table"">
                    <thead>
                    <tr>
                        <th class=""d-none"" scope=""col"">Id</th>
                        <th class=""col-3"" scope=""col"">Connection</th>
                        <th class=""col-4"" scope=""col"">Query</th>
                        <th class=""col-1"" scope=""col"">Created</th>
                        <th class=""col-1"" scope=""col"">Completed</th>
                        <th class=""col-1""  scope=""col"">Status</th>
                        <th class=""col-1""  scope=""col"">Action</th>
                    </tr>
                    </thead>
                <tbody id=""task_body""></tbody>
                </table>
            </div>
        <button class=""button"" onclick=""show_form('task_detail')""> Task Details</button>    
        <button class=""button"" onclick=""show_form('create_task')""> Create New Task</button>
        ");
            EndContext();
            BeginContext(1800, 2862, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a822a2bc556d43ef9c6339764ed0b624", async() => {
                BeginContext(1894, 1099, true);
                WriteLiteral(@"
            <div class=""row"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""host"">Host</label>
                        <input type=""text"" class=""form-control"" id=""host"" name=""host"" placeholder=""...host"" >
                    </div>
                    <div class=""form-group"">
                        <label for=""port"">Port</label>
                        <input type=""text"" class=""form-control"" id=""port"" name=""port"" placeholder=""...port"">
                    </div>
                    <div class=""form-group"">
                        <label for=""password"">Password</label>
                        <input type=""text"" class=""form-control"" id=""password"" name=""password"" placeholder=""...password"">
                    </div>
                </div>
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""version"">version</label>
                        <select ty");
                WriteLiteral("pe=\"text\" class=\"form-control\" id=\"version\"> \r\n                            ");
                EndContext();
                BeginContext(2993, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5735339a354b46b3f74204ee7c7ac9", async() => {
                    BeginContext(3027, 17, true);
                    WriteLiteral("Plaxis2dConnectV2");
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
                BeginContext(3053, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3083, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0d8b1ae8f2d4057a942966698b2a39e", async() => {
                    BeginContext(3115, 15, true);
                    WriteLiteral("Plaxis2dConnect");
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
                BeginContext(3139, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3169, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "763a4d17b43f44e4abbb0260f142109a", async() => {
                    BeginContext(3201, 15, true);
                    WriteLiteral("Plaxis3dConnect");
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
                BeginContext(3225, 1430, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""results"">results</label>
                        <input type=""text"" class=""form-control"" id=""results"" placeholder=""...version"">
                    </div>
                    <div class=""form-group"">
                        <label for=""phases"">phases</label>
                        <input type=""text"" class=""form-control"" id=""phases"" placeholder=""...phases"">
                    </div>
                    </div>
            </div>
            <input type=""hidden"" class=""form-control"" id=""query"" name=""query"" placeholder=""...query"">
            <input type=""hidden"" class=""form-control"" id=""conn"" name=""conn"" placeholder=""...conn"">
            <input type=""submit"" value=""Create New"">
        <button type=""button"" onclick=""populate_post('UKCRD1PC40002',10000,'vPQ?G?Ua3~5whK+W','Plaxis2dConnectV2','Plates EmbeddedBeams','All')"">UKCRD1PC40002</button>
        <");
                WriteLiteral(@"button type=""button"" onclick=""populate_post('UKCRDLFP0B8Y2',10000,'5g^zi8kaH5sS2fW4','Plaxis3dConnect','Plates EmbeddedBeams','Phase_51')"">UKCRDLFP0B8Y2 Plaxis3d</button>
        <button type=""button"" onclick=""populate_post('UKCRDLFP0B8Y2',10001,'LFgQ=CC1ZAVCuRmx','Plaxis2dConnect','Plates,EmbeddedBeams,Interfaces,FixedEndAnchors,NodeToNodeAnchors','Phase_19')"">UKCRDLFP0B8Y2 Plaxis2d</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4662, 14, true);
            WriteLiteral(" \r\n           ");
            EndContext();
            BeginContext(4676, 2769, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33aca76f6724651b9cfee8fa413ef7d", async() => {
                BeginContext(4705, 2733, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""response"">Task Response</label>
                <textarea class=""form-control"" readonly id=""response"" rows=""4""></textarea>
            </div>
            <div class=""row"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""id"">Task Id</label>
                        <input class=""form-control"" readonly type=""text"" id=""id"">
                    </div>
                    <div class=""form-group"">
                        <label for=""get_conn"">Connection</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_conn"">
                    </div>
                    <div class=""form-group"">
                        <label for=""get_query"">Query</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_query"">
                    </div>
                    <div class=""form-group"">
                      ");
                WriteLiteral(@"  <label for=""get_files"">Files</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_files"">
                    </div>
                </div>
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""createdDT"">Created Datetime</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_createdDT"">
                    </div>
                    <div class=""form-group"">
                        <label for=""completedDT"">Completed Datetime</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_completedDT"">
                    </div> 
                    <div class=""form-group"">
                        <label for=""owner"">Owner</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_owner"">
                    </div> 
                    <div class=""form-group"">
                        <label for=""get_res");
                WriteLiteral(@"ult"">Results</label>
                        <input class=""form-control"" readonly type=""text"" id=""get_result"">
                    </div> 
                </div>
            </div>
            <div class=""form-group"">
                <label for=""get_progress"">Progress</label>
                <textarea class = ""form-control"" readonly id=""get_progress""></textarea>
            </div>   
            <div class=""form-group"">
                <label for=""download_list"">Download Files</label>
                <ul class=""list-group"" id=""download_list""></ul>  
            <button class=""button"" type=""button"" onclick=""get_results()"">Refresh Status</button>       
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7445, 7504, true);
            WriteLiteral(@"
    </div>
   
    <script type=""text/javascript"">
    
    function update_JSONfields() {
        var qry = ""{'version':'"" + get_value(""version"") + ""','phases':'"" + get_value(""phases"") + ""','results':'"" + get_value(""results"") + ""'}""
        set_value(""query"", qry);
        var con = ""{'host':'""+ get_value(""host"") + ""','port':"" + get_value(""port"") + "",'password':'"" + get_value(""password"") + ""'}""
        set_value(""conn"", con);
    }
    function show_form(s) {
        var create = document.getElementById(""plaxis_post_form"");
        var detail = document.getElementById(""plaxis_get_form"");
        if (s=='create_task') {
            detail.setAttribute(""hidden"", ""True"")
            create.removeAttribute(""hidden"")
        }

        if (s=='task_detail') {
            detail.removeAttribute(""hidden"")
            create.setAttribute(""hidden"", ""True"")
        }

    }
    function populate_post(host, port, password, version, results, phases) {
        set_value(""host"",host);
        s");
            WriteLiteral(@"et_value(""port"",port);
        set_value(""password"",password);
        set_value(""version"",version);
        set_value (""phases"",phases);
        set_value(""results"",results);
     }
    
    function init_form() {
        $(""#plaxis_post_form"").submit(function(e) {
            e.preventDefault()
            post_results()
        });
        $(""#plaxis_get_form"").submit(function(e) {
            e.preventDefault()
            get_result()
        });
        $(""#plaxis_list_form"").submit(function(e) {
            e.preventDefault()
            get_results()
        });
    }

    function get_results() {
        init_form();
        var owner = get_value(""owner"")
        if (owner !=null) {
        var url = py_host + '/PlaxisTask/?owner=' + owner;
        httpGetAsync(url,display_list)
        }
    }
    function delete_task(id) {
        var url = py_host + '/PlaxisTask/' + id;
        httpDelete(url,display_detail)
        get_results()
    }
    function get_result(id ");
            WriteLiteral(@"= null) {
        if (id==null) {
            id = get_value(""id"")
        }
        if (id !=null) {
        var url = py_host + '/PlaxisTask/' + id;
        show_form('task_detail')
        httpGetAsync(url,display_detail)
        }
    }
    function post_results() {
        update_JSONfields();
        var conn =  get_value(""conn"");
        var query =  get_value(""query"");
        var owner =  get_value(""owner"");
        var content = `{""conn"":""${conn}"",""query"":""${query}"",""owner"":""${owner}""}`;
        var url = py_host + '/PlaxisTask/';
        console.log(content);
        show_form('plaxis_get_form')
        httpPostAsync(url, content, display_detail)
    }

    function display_list (response) {
        var json_data = JSON.parse(response);
        var tbd = document.getElementById(""task_body"");
        tbd.innerText='';
        tbd.innerHTML='';
        tbd.childNodes = null;
        $(""#task_body"").empty();
        clear_detail();
        for (var i = 0; i < json_data.le");
            WriteLiteral(@"ngth; i++) {
        var task = json_data[i];
        tr = document.createElement('tr');
            if (task.completedDT!=null) {
                tr.setAttribute(""class"","".table-success"")
            }
            td = document.createElement('td')
                td.setAttribute(""class"",""d-none"")
                td.innerHTML = task.id
            tr.appendChild(td)
            
            td = document.createElement('td')
            td.setAttribute(""style"",""word-wrap: break-word;min-width: 160px;max-width: 160px;"")
            td.innerHTML = task.conn
            tr.appendChild(td)
            
            td = document.createElement('td')
            td.setAttribute(""style"",""word-wrap: break-word;min-width: 160px;max-width: 160px;"")
                td.innerHTML = task.query
            tr.appendChild(td)
            td = document.createElement('td')
                td.innerHTML = task.createdDT
            tr.appendChild(td)
            td = document.createElement('td')
           ");
            WriteLiteral(@"     td.innerHTML = task.completedDT
            tr.appendChild(td)
            td = document.createElement('td')
            td.setAttribute(""style"",""word-wrap: break-word;min-width: 160px;max-width: 160px;"")
                td.innerHTML = task.files
            tr.appendChild(td)
            td = document.createElement('td')
                td.innerHTML = task.results
            tr.appendChild(td)
            td = document.createElement('td')
                del_btn = document.createElement ('button')
                del_btn.setAttribute(""class"", ""button"")
                del_btn.setAttribute(""onclick"", ""get_result('"" + task.id + ""')"")
                del_btn.innerHTML = ""Details""
                td.appendChild(del_btn)
                
                del_btn = document.createElement ('button')
                del_btn.setAttribute(""class"", ""button"")
                del_btn.setAttribute(""onclick"", ""delete_task('"" + task.id + ""')"")
                del_btn.innerHTML = ""Delete""
           ");
            WriteLiteral(@"     td.appendChild(del_btn)
                
            tr.appendChild(td)
        tbd.appendChild(tr);
        } 
    }
    
    function clear_detail() {
            set_innerHTML(""response"",'')  
            set_value(""id"",'') 
            set_value(""get_conn"",'')
            set_value(""get_query"",'')
            set_value(""get_createdDT"",'')
            set_value(""get_completedDT"",'')
            set_value(""get_result"",'')
            set_value(""get_files"",'')
            set_value(""get_progress"",'')
            var lst =  document.getElementById(""download_list"");
            lst.innerHTML = """";

    }
    function display_detail(response) { 
        set_innerHTML (""response"",response)
        var resp = JSON.parse(response);
        var id = resp.id
        if (id!=null) { 
            set_value(""id"",id) 
            set_value(""get_conn"",resp.conn)
            set_value(""get_query"",resp.query)
            set_value(""get_createdDT"",resp.createdDT)
            set_value(""get");
            WriteLiteral(@"_completedDT"",resp.completedDT)
            set_value(""get_progress"",resp.progress)
            set_value(""get_files"",resp.files)
            set_value(""get_result"",resp.result)
            var lst =  document.getElementById(""download_list""); 
                //clear existing list
                lst.innerHTML = """";
            var i = 0;
            
            if (resp.files != null) {
                files = resp.files.split("","")
               
            while(i < files.length) { 
                var download_url = py_host + ""/PlaxisTask/"" + id + ""/download/"" + files[i]
                li = document.createElement('li');
                li.setAttribute(""class"", ""list-group-item"");
                // Create anchor element.
                var a = document.createElement('a'); 
                // Create the text node for anchor element.
                var link = document.createTextNode(files[i]);
                // Append the text node to anchor element.
                a.appendChild(");
            WriteLiteral(@"link); 
                // Set the title.
                a.title = files[i]; 
                // Set the href property.
                a.href = download_url 
                li.appendChild(a)
                lst.appendChild(li);
                i++
            }
            
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

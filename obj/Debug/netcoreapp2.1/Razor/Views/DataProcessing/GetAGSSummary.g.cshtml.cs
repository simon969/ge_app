#pragma checksum "C:\Users\thomsonsj\AECOM\ge_dev - Documents\apps\ge_app\Views\DataProcessing\GetAGSSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d816007138d7b93d5e8570d48076cb7e8f6b7c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataProcessing_GetAGSSummary), @"mvc.1.0.view", @"/Views/DataProcessing/GetAGSSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataProcessing/GetAGSSummary.cshtml", typeof(AspNetCore.Views_DataProcessing_GetAGSSummary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d816007138d7b93d5e8570d48076cb7e8f6b7c21", @"/Views/DataProcessing/GetAGSSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2085f25f2ee1003de86d2144c6e47df98778b6d", @"/Views/_ViewImports.cshtml")]
    public class Views_DataProcessing_GetAGSSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://localhost:8000/AGSTask/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ags_list_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "AGS4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "AGS3.1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ags_post_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ags_get_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(17, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57bbea45ea044a791fe6b05a854ce43", async() => {
                BeginContext(23, 260, true);
                WriteLiteral(@"
    <title>Get AGS Summary</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
   
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(292, 14303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8592408e57144845bf62c1de6a9ada17", async() => {
                BeginContext(298, 98, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h3 class=\"class=\"display-4\">Get AGS Summary</h3>\r\n        ");
                EndContext();
                BeginContext(396, 575, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66cf6e043fbd4e62b2cc8337a77d1d32", async() => {
                    BeginContext(474, 490, true);
                    WriteLiteral(@"
            <div class=""row"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <input class=""form-control"" type=""text"" id=""owner"" name=""owner"" placeholder=""...enter owner email"">
                    </div>
                </div>
                <div class=""col-sm-6""> 
                    <input class=""button"" type=""button"" onclick=""get_results()"" value=""Find"">
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
                BeginContext(971, 1038, true);
                WriteLiteral(@"
            <div class=""table-wrapper-scroll-y ags_list-scrollbar"">
                <table class=""table table-striped"" id=""task_table"">
                    <thead>
                    <tr>
                        <th class=""d-none"" scope=""col"">Id</th>
                        <th class=""col-3"" scope=""col"">Task</th>
                        <th class=""col-1"" scope=""col"">Created</th>
                        <th class=""col-1"" scope=""col"">Completed</th>
                        <th class=""col-2""  scope=""col"">Status</th>
                        <th class=""col-1""  scope=""col"">Action</th>
                    </tr>
                    </thead>
                <tbody id=""task_body""></tbody>
                </table>
            </div>
        
            <div class = ""form-group"">    
                <button class=""button"" onclick=""show_form('task_detail')""> Task Details </button>    
                <button class=""button"" onclick=""show_form('create_task')""> Create New Task </button>
            </di");
                WriteLiteral("v>\r\n\r\n        ");
                EndContext();
                BeginContext(2009, 1967, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c482e601dfc44e08f998a2b01ad140e", async() => {
                    BeginContext(2144, 794, true);
                    WriteLiteral(@"
            <div class=""row"">  
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""host"">AGS Files</label>
                        <input type=""file"" id=""files"" name=""files"" multiple=""multiple"" onchange=""update_file_list3('files','filelist')"" >
                    </div>
                    <div class=""form-group"">
                       <ul class=""list-group"" id=""filelist"" > </ul>
                    </div>
                </div>
                <div class=""col-sm-6""> 
                    <div class=""form-group"">
                        <label for=""version"">AGS version</label>
                        <select type=""text"" class=""form-control"" id=""version"" name=""version""> 
                            ");
                    EndContext();
                    BeginContext(2938, 37, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8b7a0be2f4d14b3ec3bd16ee34551", async() => {
                        BeginContext(2959, 7, true);
                        WriteLiteral("AGS 4.0");
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
                    BeginContext(2975, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(3005, 39, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59d48182b0934524818f23f82daa394e", async() => {
                        BeginContext(3028, 7, true);
                        WriteLiteral("AGS 3.1");
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
                    BeginContext(3044, 925, true);
                    WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""actions"">Task Actions</label>
                        <input type=""text"" class=""form-control"" id=""actions"" placeholder=""...actions"">
                    </div>
                    <div class=""form-group"">
                        <label for=""results"">Task Results</label>
                        <input type=""text"" class=""form-control"" id=""results"" placeholder=""...results"">
                    </div>
                    <div class=""form-group"" hidden>
                    <label for=""task"">task</label>
                    <input type=""text"" class=""form-control"" id=""task"" name=""task"" placeholder=""...task"">
                    </div>
                    <input type=""submit"" value=""Submit"">
                  
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
                BeginContext(3976, 205, true);
                WriteLiteral("  \r\n\r\n        <button onclick=\"post_results()\">Post</button>\r\n      \r\n        <button onclick=\"populate(\'simon.thomson@aecom.com\',\'AGS4\', \'processAGS\',\'ags_summary,ags_lines\')\">Test101</button>\r\n\r\n        ");
                EndContext();
                BeginContext(4181, 2588, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a18a74d10d75466ab18ead82d72d7f4f", async() => {
                    BeginContext(4207, 2555, true);
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
                    <label for=""get_task"">Task Details</label>
                    <input class=""form-control"" readonly type=""text"" id=""get_task"">
                </div>
                <div class=""form-group"">
                    <label for=""get_createdDT"">Task Created Datetime</label>
                    <input class=""form-control"" readonly type=""text"" id=""get_createdDT"">
                </div>
                <div class=""form-group"">
                    <label for=""completedDT"">Completed Datetime</label");
                    WriteLiteral(@">
                    <input class=""form-control"" readonly type=""text"" id=""get_completedDT"">
                </div>   
            </div>
            <div class=""col-sm-6"">  
                <div class=""form-group"">
                    <label for=""get_files"">Files</label>
                    <input class=""form-control"" readonly type=""text"" id=""get_files"">
                </div>
                <div class=""form-group"">
                    <label for=""owner"">Owner</label>
                    <input class=""form-control"" readonly type=""text"" id=""get_owner"">
                </div> 
                <div class=""form-group"">
                    <label for=""get_result"">Result</label>
                    <input class=""form-control"" readonly type=""text"" id=""get_result"">
                </div>  
                <div class=""form-group"">
                    <label for=""get_status"">Status</label>
                <input class=""form-control"" readonly type=""text"" id=""get_status"">
                </div> 
  ");
                    WriteLiteral(@"          </div>
        </div>
        <div class=""form-group"">
        <label for=""get_progress"">Progress</label>
        <textarea class = ""form-control"" readonly id=""get_progress""></textarea>
        </div> 
        
        <div class=""form-group"">
            <label for=""download_list"">Download Files</label>
            <ul class=""list-group"" id=""download_list""></ul>  
        <button class=""button"" onclick=""get_results()"">Refresh Status</button>       
        </div>         
       ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6769, 7819, true);
                WriteLiteral(@"
    </div> 
    
    <script type=""text/javascript"">
    
    function update_JSONfields() {
        var task = ""{'version':'"" + get_value(""version"") + ""','actions':'"" + get_value(""actions"") +""','results':'"" + get_value(""results"") + ""'}""
        set_value(""task"", task);
    }
    function populate(owner, version, actions, results) {
        set_value(""owner"",owner);
        set_value(""version"",version);
        set_value(""actions"",actions);
        set_value(""results"",results);
        update_JSONfields()
    }
    function show_form(s) {
        var create = document.getElementById(""ags_post_form"");
        var detail = document.getElementById(""ags_get_form"");
        if (s=='create_task') {
            detail.setAttribute(""hidden"", ""True"")
            create.removeAttribute(""hidden"")
        }

        if (s=='task_detail') {
            detail.removeAttribute(""hidden"")
            create.setAttribute(""hidden"", ""True"")
        }
    }
    function init_form()  {
            $(");
                WriteLiteral(@"""#ags_post_form"").submit(function(e) {
                e.preventDefault()
                post_results()
            });
            $(""#ags_get_form"").submit(function(e) {
                e.preventDefault()
                get_result()
            });
            $(""#ags_list_form"").submit(function(e) {
                e.preventDefault()
                get_results()
            });
    }

    // $(""#ags_form"").submit(function() { alert(""hi"");
    //     var url = ""http://localhost:8000/AGSTask/"";
    //     $.ajax({
    //         type: ""POST"",
    //         url: url,
    //         data: $(""#ags_form"").serialize(),
    //         success: function(data) {
    //             alert(data);
    //         }
    //         });

    //     return false;
    // });
   
    
    function get_results() {
        init_form();
        var owner = get_value(""owner"");
        if (owner !=null) {
        var url = py_host + '/AGSTask/?owner=' + owner;
        httpGetAsync(url,display_l");
                WriteLiteral(@"ist)
        }
    }
    function get_result(id = null) {
        if (id==null) {
            id = get_value(""id"")
        }
        if (id !=null) {
        var url = py_host + '/AGSTask/' + id;
        show_form('task_detail')
        httpGetAsync(url,display_detail)
        }
    }
    function delete_task(id) {
        var url = py_host + '/AGSTask/' + id;
        httpDelete(url,display_detail)
        get_results()
    }
    function post_results() {

        // https://developer.mozilla.org/en-US/docs/Web/API/FormData/Using_FormData_Objects

        var form = document.getElementById(""ags_post_form"");
        var data = new FormData(form);
        update_JSONfields()
        var task = get_value(""task"");
        var owner = get_value(""owner"");
        var content = `{""task"":""${task}"",""owner"":""${owner}""}`;
        data.append(""owner"", owner)
        var url = py_host + '/AGSTask/';
        console.log(data);
        // httpPostAsync(url,data,display_result,'multi-part/form-");
                WriteLiteral(@"data')
        clear_detail();
        show_form('task_detail');
        httpPostAsync(url,data,display_detail,'')
        // httpPostAsync(url,content,display_result)
        }
    function display_detail(response) { 
        console.log(response);
        set_innerHTML(""response"",response)
        var resp = JSON.parse(response);
        var id = resp.id
        if (id!=null) { 
            set_value(""id"",id) 
            set_value(""get_task"",resp.task)
            set_value(""get_files"",resp.files)
            set_value(""get_result"",resp.result)
            set_value(""get_createdDT"",resp.createdDT)
            set_value(""get_completedDT"",resp.completedDT)
            set_value(""get_progress"",resp.progress)
            set_value(""get_status"",resp.status)
            set_value(""get_owner"",resp.owner)
            
            var lst =  document.getElementById(""download_list"");
              //clear existing list
                lst.innerHTML = """";
            var i = 0;
            ");
                WriteLiteral(@"
            if (resp.files.length>0) {
                files = resp.files.split("","")
              
            while(i < files.length) { 
                var download_url = py_host + ""/AGSTask/"" + id + ""/download/"" + files[i]
                li = document.createElement('li');
                li.setAttribute(""class"", ""list-group-item"");
                // Create anchor element.
                var a = document.createElement('a'); 
                // Create the text node for anchor element.
                var link = document.createTextNode(files[i]);
                // Append the text node to anchor element.
                a.appendChild(link); 
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

    function clear_detail() {
           ");
                WriteLiteral(@" set_innerHTML(""response"",'') 
            set_value(""id"",'') 
            set_value(""get_task"",'')
            set_value(""get_createdDT"",'')
            set_value(""get_completedDT"",'')
            set_value(""get_result"",'')
            set_value(""get_files"",'')
            set_value(""get_progress"",'')
            set_value(""get_status"",'')
            var lst =  document.getElementById(""download_list"");
            lst.innerHTML = """";

    }
    function display_list (response) {
        var json_data = JSON.parse(response);
        var tbd = document.getElementById(""task_body"");
        tbd.innerText='';
        tbd.innerHTML='';
        tbd.childNodes = null;
        $(""#task_body"").empty();
        clear_detail();
        for (var i = 0; i < json_data.length; i++) {
        var task = json_data[i];
        tr = document.createElement('tr');
            if (task.completedDT!=null) {
                tr.setAttribute(""class"","".table-success"")
            }
            td = document.");
                WriteLiteral(@"createElement('td')
                td.setAttribute(""class"",""d-none"")
                td.innerHTML = task.id
            tr.appendChild(td)
            
            td = document.createElement('td')
            td.setAttribute(""style"",""word-wrap: break-word;min-width: 160px;max-width: 160px;"")
            td.innerHTML = task.task
            tr.appendChild(td)
            
            td = document.createElement('td')
                td.innerHTML = task.createdDT
            tr.appendChild(td)
 
            td = document.createElement('td')
                td.innerHTML = task.completedDT
            tr.appendChild(td)
 
            td = document.createElement('td')
                if (task.status == status.SUCCESS) {
                    td.setAttribute(""class"","".table-success"")
                }
                td.innerHTML = get_status(task.status)
            tr.appendChild(td)
 
            td = document.createElement('td')
                del_btn = document.createElement ('button");
                WriteLiteral(@"')
                del_btn.setAttribute(""class"", ""button"")
                del_btn.setAttribute(""onclick"", ""get_result('"" + task.id + ""')"")
                del_btn.innerHTML = ""Details""
                td.appendChild(del_btn)
                
                del_btn = document.createElement ('button')
                del_btn.setAttribute(""class"", ""button"")
                del_btn.setAttribute(""onclick"", ""delete_task('"" + task.id + ""')"")
                del_btn.innerHTML = ""Delete""
                td.appendChild(del_btn)
                
            tr.appendChild(td)
        tbd.appendChild(tr);
        } 
    }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14595, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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

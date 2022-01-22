#pragma checksum "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6458709acfcc0e0d9ca40258baca6189566d4b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HabitApp.Pages.Pages_AdminAllocatePoints), @"mvc.1.0.razor-page", @"/Pages/AdminAllocatePoints.cshtml")]
namespace HabitApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\_ViewImports.cshtml"
using HabitApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
using HabitApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/adminallocatepoints")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6458709acfcc0e0d9ca40258baca6189566d4b5d", @"/Pages/AdminAllocatePoints.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d8de3ee89885d71118c8112e0d377848ef63c3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminAllocatePoints : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <h2 style=""align-content: center"">My Habits</h2>
    <table class=""table table-primary table-striped table-borderless"" style=""margin-top: 3rem; border-radius:0.5rem"">
        <thead>
            <tr>
                <th scope=""col"">Habit Status</th>
                <th scope=""col"">Habit Image</th>
                <th scope=""col"">ID</th>
                <th scope=""col"">Habit</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Allocate Points</th>
                <th style=""text-align:center; align-items:center"" scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 23 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
             foreach (var item in Model.HabitDataModels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td id=\"hstatus\">");
#nullable restore
#line 26 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                Write(item.habitStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img style=\"width:100px; height:100px\"");
            BeginWriteAttribute("src", " src=\"", 999, "\"", 1021, 1);
#nullable restore
#line 27 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
WriteAttributeValue("", 1005, item.habitImage, 1005, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td id=\"hid\">");
#nullable restore
#line 28 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                            Write(item.habitId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"htitle\">");
#nullable restore
#line 29 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                               Write(item.habitTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"hdescription\">");
#nullable restore
#line 30 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                     Write(item.habitDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"haudio\" hidden>");
#nullable restore
#line 31 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                      Write(item.habitAudio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"himage\" hidden>");
#nullable restore
#line 32 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                      Write(item.habitImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td id=\"hpoints\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6458709acfcc0e0d9ca40258baca6189566d4b5d6945", async() => {
                WriteLiteral(@"
                            <input type=""number""
                                   id=""addpoints""
                                   value=""0""
                                   style=""width:65px"" />

                            <button type=""button""
                                    class=""btn btn-success""
                                    onclick=""addpoint()""
                                    style=""margin-left: 10px"">
                                Save
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td id=\"hvideo\" hidden>");
#nullable restore
#line 50 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
                                      Write(item.habitVideoUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">\r\n                        <button type=\"button\" class=\"btn btn-primary\" onclick=\"viewpage(this)\">View</button>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Vikumsri\source\repos\NotifyMyHabit\Pages\AdminAllocatePoints.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        </tbody>
    </table>

    <script>
        function viewpage() {
            var idtext = document.getElementById(""hid"").innerText
            var titleText = document.getElementById(""htitle"").innerText
            var descriptiontext = document.getElementById(""hdescription"").innerText
            var audiotext = document.getElementById(""haudio"").innerText
            var imagetext = document.getElementById(""himage"").innerText
            var statustext = document.getElementById(""hstatus"").innerText
            var pointtext = document.getElementById(""hpoints"").innerText
            var videourltext = document.getElementById(""hvideo"").innerText

            window.localStorage.setItem(""imagetext"", imagetext)
            window.localStorage.setItem(""audio"", audiotext)

            window.location.replace(""/viewsinglehabit?hid="" + idtext + ""&htitle="" + titleText + ""&hdescription="" + descriptiontext + ""&hstatus="" + statustext + ""&hpoints="" + pointtext + ""&hvideo="" + videourltext);

            WriteLiteral("\n        }\r\n\r\n        function addpoint() {\r\n            var points = document.getElementById(\"hpoints\").value\r\n\r\n            //Alert message for successful point allocation\r\n            alert(\"Successfully Saved!\");\r\n        }\r\n    </script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HabitApp.Pages.AdminAllocatePointsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HabitApp.Pages.AdminAllocatePointsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HabitApp.Pages.AdminAllocatePointsModel>)PageContext?.ViewData;
        public HabitApp.Pages.AdminAllocatePointsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
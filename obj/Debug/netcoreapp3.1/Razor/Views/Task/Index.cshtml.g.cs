#pragma checksum "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d51c46e6f75f3cd8d679f5d5b0b3953e3c8521dad27c1c4dc8d3908144c0f378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lee\Desktop\TaskManager\Views\_ViewImports.cshtml"
using TaskManager

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Lee\Desktop\TaskManager\Views\_ViewImports.cshtml"
using TaskManager.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d51c46e6f75f3cd8d679f5d5b0b3953e3c8521dad27c1c4dc8d3908144c0f378", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"484d791b7cb614702aab74c2e1fb3a7badea9f87f545c772f871790f6da63b75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskManager.Models.TaskModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Priority", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1 class=\"display-4\">Lista zadań</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51c46e6f75f3cd8d679f5d5b0b3953e3c8521dad27c1c4dc8d3908144c0f3785087", async() => {
                WriteLiteral("Dodaj zadanie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51c46e6f75f3cd8d679f5d5b0b3953e3c8521dad27c1c4dc8d3908144c0f3786360", async() => {
                WriteLiteral("Priorytet - legenda");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 18 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                 Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Priorytet\r\n            </th>\r\n            <th>\r\n                Status\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td style=\"width:50%\">\r\n                    ");
            Write(
#nullable restore
#line 34 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td style=\"width:15%;\">\r\n");
#nullable restore
#line 37 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                     if (item.PriorityId != null)
                    {
                        if (item.PriorityId == 1)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <span>wysoki</span>\r\n");
#nullable restore
#line 42 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                        }
                        else if (item.PriorityId == 1004)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <span>średni</span>\r\n");
#nullable restore
#line 46 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                        }
                        else if (item.PriorityId == 1005)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <span>niski</span>\r\n");
#nullable restore
#line 50 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                <td style=\"width:15%\">\r\n                    ");
            Write(
#nullable restore
#line 53 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                     Html.ActionLink("Gotowe", "Done", new { id = item.TaskId }, new { @class = "btn btn-success" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    ");
            Write(
#nullable restore
#line 54 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                     Html.ActionLink("Szczegóły", "Details", new { id = item.TaskId }, new { @class = "btn btn-info" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    ");
            Write(
#nullable restore
#line 55 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                     Html.ActionLink("Edytuj", "Edit", new { id = item.TaskId }, new { @class = "btn btn-warning" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    ");
            Write(
#nullable restore
#line 56 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
                     Html.ActionLink("Usuń", "Delete", new { id = item.TaskId }, new { @class = "btn btn-danger" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Lee\Desktop\TaskManager\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function changeStatus(status, taskId) {
            // Implement logic to update task status using AJAX or form submission
            // For example:
            // $.post('/Task/ChangeStatus', { id: taskId, status: status }, function(data) {
            //     // handle response
            // });
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskManager.Models.TaskModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "df06e91c08797a73f0ae79871188caa2d61264bff37fbd8094330cd74856f70f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Details), @"mvc.1.0.view", @"/Views/Task/Details.cshtml")]
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
#line 1 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\_ViewImports.cshtml"
using TaskManager

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\_ViewImports.cshtml"
using TaskManager.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"df06e91c08797a73f0ae79871188caa2d61264bff37fbd8094330cd74856f70f", @"/Views/Task/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"071bb9376a5038c07cb24b7436cfa78fbd748436fa89b6ff170c5d03e374b74d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManager.Models.TaskModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1 class=\"display-4\">Szczegóły zadania</h1>\n\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 13 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml"
             Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 16 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml"
             Html.DisplayFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 19 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml"
             Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 22 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml"
             Html.DisplayFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            Write(
#nullable restore
#line 27 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Task\Details.cshtml"
     Html.ActionLink("Edytuj", "Edit", new { id = Model.TaskId }, new { @class = "btn btn-warning" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df06e91c08797a73f0ae79871188caa2d61264bff37fbd8094330cd74856f70f6023", async() => {
                WriteLiteral("Wróć do listy zadań");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManager.Models.TaskModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

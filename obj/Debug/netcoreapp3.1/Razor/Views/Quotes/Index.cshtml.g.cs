#pragma checksum "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Quotes\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87f62cee157c0527e07d19b5f44afa4b86a7e47f7327eca5e6fe0795556e5653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotes_Index), @"mvc.1.0.view", @"/Views/Quotes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"87f62cee157c0527e07d19b5f44afa4b86a7e47f7327eca5e6fe0795556e5653", @"/Views/Quotes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"071bb9376a5038c07cb24b7436cfa78fbd748436fa89b6ff170c5d03e374b74d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Quotes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskManager.Models.Quotes>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Quotes\Index.cshtml"
  
    ViewData["Title"] = "Quotes";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1 class=\"display-4\">Cytaty</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f62cee157c0527e07d19b5f44afa4b86a7e47f7327eca5e6fe0795556e56534224", async() => {
                WriteLiteral("Dodaj cytat");
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
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Quotes\Index.cshtml"
 if (ViewBag.RandomQuote != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <strong>Motywujący cytat na dziś!</strong>\r\n        <br />\r\n        <p>");
            Write(
#nullable restore
#line 18 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Quotes\Index.cshtml"
            ViewBag.RandomQuote.Quote

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n        <footer class=\"blockquote-footer\">");
            Write(
#nullable restore
#line 19 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Quotes\Index.cshtml"
                                           ViewBag.RandomQuote.Author

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</footer>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Quotes\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskManager.Models.Quotes>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

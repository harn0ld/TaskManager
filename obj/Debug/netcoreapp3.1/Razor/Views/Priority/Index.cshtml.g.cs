#pragma checksum "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Priority\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8f13e96713c571912a2f81e08737fa66848735e9106a0a0eb20b4d43836dc827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Priority_Index), @"mvc.1.0.view", @"/Views/Priority/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f13e96713c571912a2f81e08737fa66848735e9106a0a0eb20b4d43836dc827", @"/Views/Priority/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"071bb9376a5038c07cb24b7436cfa78fbd748436fa89b6ff170c5d03e374b74d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Priority_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskManager.Models.Priorities>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Priority\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Określenie</th>\n            <th>Szczegóły</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 16 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Priority\Index.cshtml"
         foreach (var priority in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\n                <td>");
            Write(
#nullable restore
#line 19 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Priority\Index.cshtml"
                     priority.PriorityType

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                <td>");
            Write(
#nullable restore
#line 20 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Priority\Index.cshtml"
                     priority.Reason

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 22 "C:\Users\Lidia\Desktop\TaskManager-task-manager-3-tabele\Views\Priority\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\n</table>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <!-- reszta kodu -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskManager.Models.Priorities>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d476fc04d4c9cdd1a3830741c482179a3ddf04d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRoleManagementSupervisor_DetailsSupervisor), @"mvc.1.0.view", @"/Views/UserRoleManagementSupervisor/DetailsSupervisor.cshtml")]
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
#nullable restore
#line 1 "D:\backup API\brandnew\testcsharp\Views\_ViewImports.cshtml"
using testcsharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\backup API\brandnew\testcsharp\Views\_ViewImports.cshtml"
using testcsharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d476fc04d4c9cdd1a3830741c482179a3ddf04d", @"/Views/UserRoleManagementSupervisor/DetailsSupervisor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c212b555005bf2ac7a90e02a43036eead3c0fd", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRoleManagementSupervisor_DetailsSupervisor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveUserRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to remove this role from user?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container-fluid\" style=\"padding-bottom: 200px; background-color: #F4F8FB; min-height: 600px;\">\n    <div class=\"row\">\n        <h2 style=\"padding-top: 20px; padding-bottom: 20px;\">");
#nullable restore
#line 8 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                                                        Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\n        <div class=\"col-12\">\n");
#nullable restore
#line 10 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Keine Rolle gefunden!</p> ");
#nullable restore
#line 12 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                                 }
else
{
    


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table"">
                        <thead class=""bg-dark text-white"">
                            <tr>
                                <th>Rolle</th>
                                <th>Aktionen</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 25 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                             foreach (var r in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 28 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
               Write(r);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d476fc04d4c9cdd1a3830741c482179a3ddf04d6521", async() => {
                WriteLiteral("Rolle entfernen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-role", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                           WriteLiteral(r);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["role"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-role", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["role"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                               WriteLiteral(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>");
#nullable restore
#line 36 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>");
#nullable restore
#line 38 "D:\backup API\brandnew\testcsharp\Views\UserRoleManagementSupervisor\DetailsSupervisor.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591

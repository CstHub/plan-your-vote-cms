#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4788ddd4174e294232ac918294d7f125be7dee90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagement_Index), @"mvc.1.0.view", @"/Views/UserManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagement/Index.cshtml", typeof(AspNetCore.Views_UserManagement_Index))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\_ViewImports.cshtml"
using Web.CmsControllers;

#line default
#line hidden
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4788ddd4174e294232ac918294d7f125be7dee90", @"/Views/UserManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.ViewModels.UserRoleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(201, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
  
    ViewData["Title"] = @Localizer["userManagement_edit_title"];

#line default
#line hidden
            BeginContext(272, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(278, 17, false);
#line 11 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(295, 45, true);
            WriteLiteral("</h1>\n\n<div style=\"margin-bottom:10px;\">\n    ");
            EndContext();
            BeginContext(340, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4788ddd4174e294232ac918294d7f125be7dee906569", async() => {
                BeginContext(417, 48, false);
#line 14 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
                                                                           Write(Localizer["userManagement_index_registerButton"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(469, 195, true);
            WriteLiteral("\n</div>\n\n<table class=\"table panel panel-default user-management\">\n    <thead>\n    <tr>\n        <th scope=\"col\">Username</th>\n        <th scope=\"col\">Email</th>\n        <th scope=\"col\">Role</th>\n");
            EndContext();
            BeginContext(712, 35, true);
            WriteLiteral("    </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 28 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
     foreach (var userRoleViewModel in Model)
    {

#line default
#line hidden
            BeginContext(799, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(846, 61, false);
#line 32 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(_ => userRoleViewModel.IdentityUser.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(907, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(960, 58, false);
#line 35 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(_ => userRoleViewModel.IdentityUser.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1071, 57, false);
#line 38 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
           Write(Html.DisplayFor(_ => userRoleViewModel.IdentityRole.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 19, true);
            WriteLiteral("\n            </td>\n");
            EndContext();
            BeginContext(2488, 14, true);
            WriteLiteral("        </tr>\n");
            EndContext();
#line 58 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
         if (userRoleViewModel.IdentityUser.UserName != Constants.Account.ADMIN_USERNAME)
        {

#line default
#line hidden
            BeginContext(2602, 129, true);
            WriteLiteral("            <tr>\n                <td colspan=\"3\" class=\"user-management-btns\">\n                    <div>\n                        ");
            EndContext();
            BeginContext(2731, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4788ddd4174e294232ac918294d7f125be7dee9010920", async() => {
                BeginContext(2840, 23, false);
#line 63 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
                                                                                                                               Write(Localizer["editButton"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
                                                                              WriteLiteral(userRoleViewModel.IdentityUser.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2867, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2892, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4788ddd4174e294232ac918294d7f125be7dee9013665", async() => {
                BeginContext(2968, 79, true);
                WriteLiteral("\n                            <input type=\"submit\" class=\"btn btn-danger btn-sm\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3047, "", 3080, 1);
#line 65 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
WriteAttributeValue("", 3054, Localizer["deleteButton"], 3054, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3080, 28, true);
                WriteLiteral(" />\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
                                                    WriteLiteral(userRoleViewModel.IdentityUser.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3115, 69, true);
            WriteLiteral("\n                    </div>\n\n                </td>\n            </tr>\n");
            EndContext();
#line 71 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
        }

#line default
#line hidden
#line 71 "C:\projects\plan-your-vote-cms-develop\Web\Views\UserManagement\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(3200, 21, true);
            WriteLiteral("    </tbody>\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.ViewModels.UserRoleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d32a05e4103dea2056afc92e9d1968885f30ed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Details), @"mvc.1.0.view", @"/Views/Candidates/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidates/Details.cshtml", typeof(AspNetCore.Views_Candidates_Details))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d32a05e4103dea2056afc92e9d1968885f30ed7", @"/Views/Candidates/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Candidate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(177, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
  
    ViewData["Title"] = @Localizer["candidates_details_title"];

#line default
#line hidden
            BeginContext(247, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(253, 17, false);
#line 11 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(270, 104, true);
            WriteLiteral("</h1>\n\n<div class=\"panel panel-default\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(375, 40, false);
#line 16 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(415, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(474, 36, false);
#line 19 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(510, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(568, 43, false);
#line 22 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(611, 46, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n");
            EndContext();
#line 25 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
              
                var url = "../../" + Model.Picture;

#line default
#line hidden
            BeginContext(724, 45, true);
            WriteLiteral("                <img width=\"150\" height=\"150\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 769, "\"", 779, 1);
#line 27 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
WriteAttributeValue("", 775, url, 775, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(780, 2, true);
            WriteLiteral(">\n");
            EndContext();
            BeginContext(796, 56, true);
            WriteLiteral("        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(853, 53, false);
#line 31 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Organization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(906, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(965, 49, false);
#line 34 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
       Write(Html.DisplayFor(model => model.Organization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1072, 50, false);
#line 37 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CandidateRaces));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 63, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            <ul>\n");
            EndContext();
#line 41 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                 foreach (var candidateRace in Model.CandidateRaces)
                {
                    var races = (List<Race>)ViewBag.Races;
                    var race = races.Find(r => r.RaceId == candidateRace.RaceId);


#line default
#line hidden
            BeginContext(1414, 49, true);
            WriteLiteral("                    <li>\n                        ");
            EndContext();
            BeginContext(1464, 43, false);
#line 47 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                   Write(Html.DisplayFor(model => race.PositionName));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 27, true);
            WriteLiteral("\n                    </li>\n");
            EndContext();
#line 49 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1552, 51, true);
            WriteLiteral("            </ul>\n        </dd>\n    </dl>\n\n    <h4>");
            EndContext();
            BeginContext(1604, 43, false);
#line 54 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 17, true);
            WriteLiteral("</h4>\n    <hr />\n");
            EndContext();
#line 56 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
     foreach (var detail in Model.Details)
    {

#line default
#line hidden
            BeginContext(1713, 75, true);
            WriteLiteral("        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1789, 42, false);
#line 60 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayNameFor(model => detail.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1902, 38, false);
#line 63 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayFor(model => detail.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(2010, 41, false);
#line 66 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayNameFor(model => detail.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 54, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n");
            EndContext();
#line 69 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                 if (detail.Format == CandidateDetailFormat.List)
                {

#line default
#line hidden
            BeginContext(2189, 53, true);
            WriteLiteral("                    <ul>\n                        <li>");
            EndContext();
            BeginContext(2243, 21, false);
#line 72 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                       Write(Html.Raw(detail.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 32, true);
            WriteLiteral("</li>\n                    </ul>\n");
            EndContext();
#line 74 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                }
                else if (detail.Format == CandidateDetailFormat.OrderedList)
                {

#line default
#line hidden
            BeginContext(2409, 53, true);
            WriteLiteral("                    <ol>\n                        <li>");
            EndContext();
            BeginContext(2463, 21, false);
#line 78 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                       Write(Html.Raw(detail.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2484, 32, true);
            WriteLiteral("</li>\n                    </ol>\n");
            EndContext();
#line 80 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(2594, 21, false);
#line 83 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
               Write(Html.Raw(detail.Text));

#line default
#line hidden
            EndContext();
#line 83 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                                          
                }

#line default
#line hidden
            BeginContext(2634, 47, true);
            WriteLiteral("            </dd>\n        </dl>\n        <hr />\n");
            EndContext();
#line 88 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2687, 9, true);
            WriteLiteral("\n    <h4>");
            EndContext();
            BeginContext(2697, 44, false);
#line 90 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Contacts));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 17, true);
            WriteLiteral("</h4>\n    <hr />\n");
            EndContext();
#line 92 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
     foreach (var contact in Model.Contacts)
    {

#line default
#line hidden
            BeginContext(2809, 75, true);
            WriteLiteral("        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(2885, 51, false);
#line 96 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayNameFor(model => contact.ContactMethod));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(3007, 47, false);
#line 99 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayFor(model => contact.ContactMethod));

#line default
#line hidden
            EndContext();
            BeginContext(3054, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(3124, 50, false);
#line 102 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayNameFor(model => contact.ContactValue));

#line default
#line hidden
            EndContext();
            BeginContext(3174, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(3245, 46, false);
#line 105 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
           Write(Html.DisplayFor(Model => contact.ContactValue));

#line default
#line hidden
            EndContext();
            BeginContext(3291, 48, true);
            WriteLiteral("\n            </dd>\n        </dl>\n        <hr />\n");
            EndContext();
#line 109 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(3345, 17, true);
            WriteLiteral("</div>\n<div>\n    ");
            EndContext();
            BeginContext(3362, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d32a05e4103dea2056afc92e9d1968885f30ed717356", async() => {
                BeginContext(3442, 23, false);
#line 112 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                                                                              Write(Localizer["editButton"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                                                   WriteLiteral(Model.CandidateId);

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
            BeginContext(3469, 6, true);
            WriteLiteral(" \n    ");
            EndContext();
            BeginContext(3475, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d32a05e4103dea2056afc92e9d1968885f30ed719980", async() => {
                BeginContext(3519, 23, false);
#line 113 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Details.cshtml"
                                          Write(Localizer["backButton"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3546, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Candidate> Html { get; private set; }
    }
}
#pragma warning restore 1591

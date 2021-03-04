#pragma checksum "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a02268bc400f1adcdfa49bc740400280f994ec5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\_ViewImports.cshtml"
using DataTransfer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a02268bc400f1adcdfa49bc740400280f994ec5d", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70a27f691fdcb941c3cf4362f6f98edd9074b39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OlympicViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
   
    ViewData["Title"] = "Country Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Country Details</h3>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6 col-sm-offset-3\">\r\n        <ul class=\"list-group text-center\">\r\n            <li class=\"list-group-item bg-dark text-white\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 296, "\"", 340, 1);
#nullable restore
#line 12 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
WriteAttributeValue("", 302, Url.Content(@Model.Country.FlagImage), 302, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 341, "\"", 347, 0);
            EndWriteAttribute();
            WriteLiteral(" width=200 height=100/>\r\n                <h3>");
#nullable restore
#line 13 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
               Write(Model.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </li>\r\n            <li class=\"list-group-item bg-dark text-white\">\r\n                <h4>Game: ");
#nullable restore
#line 16 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
                     Write(Model.Country.Game.GameName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </li>\r\n            <li class=\"list-group-item bg-dark text-white\">\r\n                <h4>Sport: ");
#nullable restore
#line 19 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
                      Write(Model.Country.Sport.SportName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </li>\r\n            <li class=\"list-group-item bg-dark\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a02268bc400f1adcdfa49bc740400280f994ec5d5286", async() => {
                WriteLiteral("\r\n                    Return to Home Page\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-game", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
                       WriteLiteral(Model.ActiveGame);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["game"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-game", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["game"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Eric\source\repos\OlympicFlagList\DataTransfer\Views\Home\Details.cshtml"
                        WriteLiteral(Model.ActiveSport);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sport"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sport", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sport"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OlympicViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
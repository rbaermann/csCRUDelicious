#pragma checksum "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f476661f838ee6230c4fb0e16f0948ba0219b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayDish), @"mvc.1.0.view", @"/Views/Home/DisplayDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayDish.cshtml", typeof(AspNetCore.Views_Home_DisplayDish))]
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
#line 1 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 1 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f476661f838ee6230c4fb0e16f0948ba0219b7d", @"/Views/Home/DisplayDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/displayDish.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "homeRoutePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 42, true);
            WriteLiteral("\n<!DOCTYPE html>\n    <html lang=\"en\">\n    ");
            EndContext();
            BeginContext(81, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f476661f838ee6230c4fb0e16f0948ba0219b7d4686", async() => {
                BeginContext(87, 188, true);
                WriteLiteral("\n        <meta charset=\"UTF-8\">\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n        <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n        <title>");
                EndContext();
                BeginContext(276, 10, false);
#line 10 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
          Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(286, 17, true);
                WriteLiteral("</title>\n        ");
                EndContext();
                BeginContext(303, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f476661f838ee6230c4fb0e16f0948ba0219b7d5628", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(355, 5, true);
                WriteLiteral("\n    ");
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
            BeginContext(367, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(372, 381, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f476661f838ee6230c4fb0e16f0948ba0219b7d7727", async() => {
                BeginContext(378, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(387, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f476661f838ee6230c4fb0e16f0948ba0219b7d8109", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(421, 13, true);
                WriteLiteral("\n        <h1>");
                EndContext();
                BeginContext(435, 10, false);
#line 15 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
       Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(445, 18, true);
                WriteLiteral("</h1>\n        <h4>");
                EndContext();
                BeginContext(464, 10, false);
#line 16 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
       Write(Model.Chef);

#line default
#line hidden
                EndContext();
                BeginContext(474, 39, true);
                WriteLiteral("</h4>\n        <span></span>\n        <p>");
                EndContext();
                BeginContext(514, 17, false);
#line 18 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
      Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(531, 32, true);
                WriteLiteral("</p>\n        <p>Calories: <span>");
                EndContext();
                BeginContext(564, 14, false);
#line 19 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
                      Write(Model.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(578, 40, true);
                WriteLiteral("</span></p>\n        <p>Tastiness: <span>");
                EndContext();
                BeginContext(619, 15, false);
#line 20 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
                       Write(Model.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(634, 22, true);
                WriteLiteral("</span></p>\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 656, "\"", 681, 2);
                WriteAttributeValue("", 663, "edit/", 663, 5, true);
#line 21 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
WriteAttributeValue("", 668, Model.DishId, 668, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(682, 20, true);
                WriteLiteral(">Edit</a>\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 702, "\"", 729, 2);
                WriteAttributeValue("", 709, "delete/", 709, 7, true);
#line 22 "/media/thethup/KINGSTON/coding/coding-dojo/c#/entity/CRUDelicious/Views/Home/DisplayDish.cshtml"
WriteAttributeValue("", 716, Model.DishId, 716, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(730, 16, true);
                WriteLiteral(">Delete</a>\n    ");
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
            BeginContext(753, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591

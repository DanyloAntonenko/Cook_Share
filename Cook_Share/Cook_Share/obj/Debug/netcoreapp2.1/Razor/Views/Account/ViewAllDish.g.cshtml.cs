#pragma checksum "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4a456f67abb45dbe72a6ae7685bb9490ced1ed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewAllDish), @"mvc.1.0.view", @"/Views/Account/ViewAllDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ViewAllDish.cshtml", typeof(AspNetCore.Views_Account_ViewAllDish))]
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
#line 1 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
#line 2 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a456f67abb45dbe72a6ae7685bb9490ced1ed7", @"/Views/Account/ViewAllDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a947732fe9c17793ed08c30568b9f3ac6c7817", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ViewAllDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cook_Share.Models.Publication>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dish-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.fancybox.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.fancybox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carousel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
  
    ViewData["Title"] = "ViewAllDish";

#line default
#line hidden
            BeginContext(100, 103, true);
            WriteLiteral("\r\n\r\n<div class=\"title__all\">Все рецепты</div>\r\n\r\n<br /><br />\r\n<div class=\"container container__all\">\r\n");
            EndContext();
#line 12 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
       foreach (var publication in Model)
        {




#line default
#line hidden
            BeginContext(263, 134, true);
            WriteLiteral("            <div class=\"dish-item-all\">\r\n                <div class=\"dish-left\">\r\n                        <div class=\"owl-carousel\">\r\n");
            EndContext();
#line 20 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                              
                                if (publication.Photos.Count != 0)
                                {
                                    foreach (var photo in publication.Photos)
                                    {


#line default
#line hidden
            BeginContext(652, 113, true);
            WriteLiteral("                                        <div class=\"photo__slider\">\r\n                                            ");
            EndContext();
            BeginContext(765, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23b3b63cf7ed4ff1ac2a3489360a4bee", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 775, "~/dish_img/", 775, 11, true);
#line 27 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
AddHtmlAttributeValue("", 786, photo.Name, 786, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(825, 50, true);
            WriteLiteral("\r\n                                        </div>\r\n");
            EndContext();
#line 29 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                    }
                                }
                                else
                                {
                                    string dish = "default-dish.jpg";

#line default
#line hidden
            BeginContext(1093, 105, true);
            WriteLiteral("                                    <div class=\"photo__slider\">\r\n                                        ");
            EndContext();
            BeginContext(1198, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2e24386dfec4307b9f827b863d62ff3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1208, "~/dish_img/", 1208, 11, true);
#line 35 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
AddHtmlAttributeValue("", 1219, dish, 1219, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1252, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 37 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1364, 208, true);
            WriteLiteral("                        </div>\r\n                </div>\r\n\r\n                <div class=\"dish-right\">\r\n                    <div class=\"title__dish__creator\">\r\n                        <div class=\"name__dish-all\">");
            EndContext();
            BeginContext(1573, 20, false);
#line 44 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                               Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(1593, 136, true);
            WriteLiteral("</div>\r\n                        <div class=\"subtitle__dish\">\r\n                            <div class=\"name__creator name__creator__all\">");
            EndContext();
            BeginContext(1730, 21, false);
#line 46 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                     Write(publication.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1751, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1753, 24, false);
#line 46 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                            Write(publication.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1777, 116, true);
            WriteLiteral("</div>\r\n                            <div class=\"cuisine__dish cuisine__dish__all\">\r\n                                ");
            EndContext();
            BeginContext(1894, 19, false);
#line 48 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                           Write(publication.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(1913, 197, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"category__dish dish__span__all\"><span class=\"dish__span dish__span__all\">Категория: </span>");
            EndContext();
            BeginContext(2111, 25, false);
#line 51 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                                                          Write(publication.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2136, 197, true);
            WriteLiteral("</div>\r\n                        <div class=\"description__dish dish__span__all\">\r\n                            <span class=\"dish__span dish__span__all\">Описание: </span>\r\n                            ");
            EndContext();
            BeginContext(2334, 23, false);
#line 54 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                       Write(publication.Discription);

#line default
#line hidden
            EndContext();
            BeginContext(2357, 287, true);
            WriteLiteral(@"
                        </div>
                        <div class=""recipe__dish dish__span__all"">
                            <span class=""dish__span dish__span__all"">Рецепт: </span>
                            <textarea class=""txtArea__recipe input__item dish__span__all"" disabled>");
            EndContext();
            BeginContext(2645, 18, false);
#line 58 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                              Write(publication.Recipe);

#line default
#line hidden
            EndContext();
            BeginContext(2663, 178, true);
            WriteLiteral("</textarea>\r\n                        </div>\r\n                        <div class=\"date__creator dish__span__all\"> <span class=\"dish__span dish__span__all\">Дата добавления: </span>");
            EndContext();
            BeginContext(2842, 16, false);
#line 60 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                                                                Write(publication.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2858, 125, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 65 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"

        }
    

#line default
#line hidden
            BeginContext(3003, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(3011, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6d8d9292c534d26a8d3aad8bc433a26", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3053, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3055, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0b58b84f1594305a893f2cdb098f606", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3126, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a5aff94fd7e45f2bed6c77a170d75b0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3177, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3181, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "416da2d699e64310985f7571e49f334e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3231, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "864c83333027448791c714c70fa71684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3271, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cook_Share.Models.Publication>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f424127fcb65f6c7dff4ad8a29ec428603857bc"
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
#line 1 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
#line 2 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f424127fcb65f6c7dff4ad8a29ec428603857bc", @"/Views/Account/ViewAllDish.cshtml")]
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
#line 3 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
  
    ViewData["Title"] = "ViewAllDish";

#line default
#line hidden
            BeginContext(100, 67, true);
            WriteLiteral("\r\n<h2>ViewAllDish</h2>\r\n\r\n\r\n<br /><br />\r\n<div class=\"container\">\r\n");
            EndContext();
#line 12 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
       foreach (var publication in Model)
        {




#line default
#line hidden
            BeginContext(227, 130, true);
            WriteLiteral("            <div class=\"dish-item\">\r\n                <div class=\"dish-left\">\r\n                        <div class=\"owl-carousel\">\r\n");
            EndContext();
#line 20 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                              
                                if (publication.Photos.Count != 0)
                                {
                                    foreach (var photo in publication.Photos)
                                    {


#line default
#line hidden
            BeginContext(612, 113, true);
            WriteLiteral("                                        <div class=\"photo__slider\">\r\n                                            ");
            EndContext();
            BeginContext(725, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a465bcb9c0c44d69ae68b99d8741e9b5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 735, "~/dish_img/", 735, 11, true);
#line 27 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
AddHtmlAttributeValue("", 746, photo.Name, 746, 11, false);

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
            BeginContext(785, 50, true);
            WriteLiteral("\r\n                                        </div>\r\n");
            EndContext();
#line 29 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                    }
                                }
                                else
                                {
                                    string dish = "default-dish.jpg";

#line default
#line hidden
            BeginContext(1053, 105, true);
            WriteLiteral("                                    <div class=\"photo__slider\">\r\n                                        ");
            EndContext();
            BeginContext(1158, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e441cac9518b4dab9306e2f0343db984", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1168, "~/dish_img/", 1168, 11, true);
#line 35 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
AddHtmlAttributeValue("", 1179, dish, 1179, 5, false);

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
            BeginContext(1212, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 37 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1324, 204, true);
            WriteLiteral("                        </div>\r\n                </div>\r\n\r\n                <div class=\"dish-right\">\r\n                    <div class=\"title__dish__creator\">\r\n                        <div class=\"name__dish\">");
            EndContext();
            BeginContext(1529, 20, false);
#line 44 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                           Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 117, true);
            WriteLiteral("</div>\r\n                        <div class=\"subtitle__dish\">\r\n                            <div class=\"name__creator\">");
            EndContext();
            BeginContext(1667, 21, false);
#line 46 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                  Write(publication.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1690, 24, false);
#line 46 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                         Write(publication.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 97, true);
            WriteLiteral("</div>\r\n                            <div class=\"cuisine__dish\">\r\n                                ");
            EndContext();
            BeginContext(1812, 19, false);
#line 48 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                           Write(publication.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 165, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"category__dish\"><span class=\"dish__span\">Категория: </span>");
            EndContext();
            BeginContext(1997, 25, false);
#line 51 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                          Write(publication.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2022, 165, true);
            WriteLiteral("</div>\r\n                        <div class=\"description__dish\">\r\n                            <span class=\"dish__span\">Описание: </span>\r\n                            ");
            EndContext();
            BeginContext(2188, 23, false);
#line 54 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                       Write(publication.Discription);

#line default
#line hidden
            EndContext();
            BeginContext(2211, 239, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"recipe__dish\">\r\n                            <span class=\"dish__span\">Рецепт: </span>\r\n                            <textarea class=\"txtArea__recipe input__item\" disabled>");
            EndContext();
            BeginContext(2451, 18, false);
#line 58 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                              Write(publication.Recipe);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 146, true);
            WriteLiteral("</textarea>\r\n                        </div>\r\n                        <div class=\"date__creator\"> <span class=\"dish__span\">Дата добавления: </span>");
            EndContext();
            BeginContext(2616, 16, false);
#line 60 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                                Write(publication.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2632, 125, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 65 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"

        }
    

#line default
#line hidden
            BeginContext(2777, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(2785, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c0b69cea5544f5b468b421a4704968", async() => {
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
            BeginContext(2827, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2829, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ab842d623404c1b83a27fad49ec8c56", async() => {
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
            BeginContext(2898, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2900, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d63cecccd24e9ba2a8a1fb9246be4b", async() => {
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
            BeginContext(2951, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2955, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d31b6f3aa654635baa334cbc24f5147", async() => {
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
            BeginContext(3003, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3005, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4f40a79fd049299d76dd28a32733fc", async() => {
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
            BeginContext(3045, 2, true);
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

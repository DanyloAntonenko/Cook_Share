#pragma checksum "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dfeef2944a2a24e0d7be1f3c60baf6eed78303b"
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
#line 1 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
#line 2 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfeef2944a2a24e0d7be1f3c60baf6eed78303b", @"/Views/Account/ViewAllDish.cshtml")]
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
#line 3 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
  
    ViewData["Title"] = "ViewAllDish";

#line default
#line hidden
            BeginContext(100, 67, true);
            WriteLiteral("\r\n<h2>ViewAllDish</h2>\r\n\r\n\r\n<br /><br />\r\n<div class=\"container\">\r\n");
            EndContext();
#line 12 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
       foreach (var publication in Model)
        {




#line default
#line hidden
            BeginContext(227, 126, true);
            WriteLiteral("            <div class=\"dish-item\">\r\n                <div class=\"dish-left\">\r\n                    <div class=\"owl-carousel\">\r\n");
            EndContext();
#line 20 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                          
                            foreach (var photo in publication.Photos)
                            {

#line default
#line hidden
            BeginContext(483, 97, true);
            WriteLiteral("                                <div class=\"photo__slider\">\r\n                                    ");
            EndContext();
            BeginContext(580, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a2c915f056b742e2b01c8fdd515818d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 590, "~/dish_img/", 590, 11, true);
#line 24 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
AddHtmlAttributeValue("", 601, photo.Name, 601, 11, false);

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
            BeginContext(640, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 26 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(740, 200, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n                <div class=\"dish-right\">\r\n                    <div class=\"title__dish__creator\">\r\n                        <div class=\"name__dish\">");
            EndContext();
            BeginContext(941, 20, false);
#line 33 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                           Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(961, 117, true);
            WriteLiteral("</div>\r\n                        <div class=\"subtitle__dish\">\r\n                            <div class=\"name__creator\">");
            EndContext();
            BeginContext(1079, 21, false);
#line 35 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                  Write(publication.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1100, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1102, 24, false);
#line 35 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                         Write(publication.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 97, true);
            WriteLiteral("</div>\r\n                            <div class=\"cuisine__dish\">\r\n                                ");
            EndContext();
            BeginContext(1224, 19, false);
#line 37 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                           Write(publication.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 165, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"category__dish\"><span class=\"dish__span\">Категория: </span>");
            EndContext();
            BeginContext(1409, 25, false);
#line 40 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                          Write(publication.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1434, 165, true);
            WriteLiteral("</div>\r\n                        <div class=\"description__dish\">\r\n                            <span class=\"dish__span\">Описание: </span>\r\n                            ");
            EndContext();
            BeginContext(1600, 23, false);
#line 43 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                       Write(publication.Discription);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 239, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"recipe__dish\">\r\n                            <span class=\"dish__span\">Рецепт: </span>\r\n                            <textarea class=\"txtArea__recipe input__item\" disabled>");
            EndContext();
            BeginContext(1863, 18, false);
#line 47 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                              Write(publication.Recipe);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 146, true);
            WriteLiteral("</textarea>\r\n                        </div>\r\n                        <div class=\"date__creator\"> <span class=\"dish__span\">Дата добавления: </span>");
            EndContext();
            BeginContext(2028, 16, false);
#line 49 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"
                                                                                                Write(publication.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2044, 125, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 54 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllDish.cshtml"

        }
    

#line default
#line hidden
            BeginContext(2189, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(2197, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db1ee5a41ba42c18031d9c431ea1416", async() => {
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
            BeginContext(2239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2241, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6acbbe81c82a48d2a0c5184ba6c43cf0", async() => {
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
            BeginContext(2310, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2312, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa13ba0db25c4c54883686a549d91f9b", async() => {
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
            BeginContext(2363, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2367, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2f184809c6b414ea64c72af2cba1579", async() => {
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
            BeginContext(2415, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2417, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5080a6eef0464294124bb98e776a4a", async() => {
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
            BeginContext(2457, 2, true);
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

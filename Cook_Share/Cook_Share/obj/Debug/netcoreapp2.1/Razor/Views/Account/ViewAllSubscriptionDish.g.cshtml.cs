#pragma checksum "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b7f6e31219eee0c2d44bf948f6b72f1ceaf3cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewAllSubscriptionDish), @"mvc.1.0.view", @"/Views/Account/ViewAllSubscriptionDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ViewAllSubscriptionDish.cshtml", typeof(AspNetCore.Views_Account_ViewAllSubscriptionDish))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b7f6e31219eee0c2d44bf948f6b72f1ceaf3cd", @"/Views/Account/ViewAllSubscriptionDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a947732fe9c17793ed08c30568b9f3ac6c7817", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ViewAllSubscriptionDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cook_Share.Models.Publication>>
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
#line 2 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
  
    ViewData["Title"] = "ViewAllSubscriptionDish";

#line default
#line hidden
            BeginContext(103, 91, true);
            WriteLiteral("\r\n<h2>ViewAllSubscriptionDish</h2>\r\n\r\n<br /><br />\r\n<div class=\"container container-all\">\r\n");
            EndContext();
#line 10 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
       foreach (var publication in Model)
        {




#line default
#line hidden
            BeginContext(254, 130, true);
            WriteLiteral("            <div class=\"dish-item-all\">\r\n                <div class=\"dish-left\">\r\n                    <div class=\"owl-carousel\">\r\n");
            EndContext();
#line 18 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                          
                            if (publication.Photos.Count != 0)
                            {
                                foreach (var photo in publication.Photos)
                                {


#line default
#line hidden
            BeginContext(619, 105, true);
            WriteLiteral("                                    <div class=\"photo__slider\">\r\n                                        ");
            EndContext();
            BeginContext(724, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6dfdfcbf78d14ee9803172f999510ddb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 734, "~/dish_img/", 734, 11, true);
#line 25 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
AddHtmlAttributeValue("", 745, photo.Name, 745, 11, false);

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
            BeginContext(784, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 27 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                }
                            }
                            else
                            {
                                string dish = "default-dish.jpg";

#line default
#line hidden
            BeginContext(1028, 97, true);
            WriteLiteral("                                <div class=\"photo__slider\">\r\n                                    ");
            EndContext();
            BeginContext(1125, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f67d915c1cce4546abf1fb4d5c9eed8e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1135, "~/dish_img/", 1135, 11, true);
#line 33 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
AddHtmlAttributeValue("", 1146, dish, 1146, 5, false);

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
            BeginContext(1179, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 35 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1279, 204, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n                <div class=\"dish-right\">\r\n                    <div class=\"title__dish__creator\">\r\n                        <div class=\"name__dish-all\">");
            EndContext();
            BeginContext(1484, 20, false);
#line 42 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                               Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 92, true);
            WriteLiteral("</div>\r\n                        <div class=\"subtitle__dish\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1596, "\'", 1667, 1);
#line 44 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
WriteAttributeValue("", 1603, Url.Action("UserPage","Account", new{id = @publication.UserId}), 1603, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1668, 100, true);
            WriteLiteral(" class=\"link__dish\">\r\n                                <div class=\"name__creator name__creator__all\">");
            EndContext();
            BeginContext(1769, 21, false);
#line 45 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                         Write(publication.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1792, 24, false);
#line 45 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                                Write(publication.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 150, true);
            WriteLiteral("</div>\r\n                            </a>\r\n                            <div class=\"cuisine__dish cuisine__dish__all\">\r\n                                ");
            EndContext();
            BeginContext(1967, 19, false);
#line 48 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                           Write(publication.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 197, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"category__dish dish__span__all\"><span class=\"dish__span dish__span__all\">Категория: </span>");
            EndContext();
            BeginContext(2184, 25, false);
#line 51 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                                                          Write(publication.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 197, true);
            WriteLiteral("</div>\r\n                        <div class=\"description__dish dish__span__all\">\r\n                            <span class=\"dish__span dish__span__all\">Описание: </span>\r\n                            ");
            EndContext();
            BeginContext(2407, 23, false);
#line 54 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                       Write(publication.Discription);

#line default
#line hidden
            EndContext();
            BeginContext(2430, 287, true);
            WriteLiteral(@"
                        </div>
                        <div class=""recipe__dish dish__span__all"">
                            <span class=""dish__span dish__span__all"">Рецепт: </span>
                            <textarea class=""txtArea__recipe input__item dish__span__all"" disabled>");
            EndContext();
            BeginContext(2718, 18, false);
#line 58 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                              Write(publication.Recipe);

#line default
#line hidden
            EndContext();
            BeginContext(2736, 178, true);
            WriteLiteral("</textarea>\r\n                        </div>\r\n                        <div class=\"date__creator dish__span__all\"> <span class=\"dish__span dish__span__all\">Дата добавления: </span>");
            EndContext();
            BeginContext(2915, 16, false);
#line 60 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                                                                Write(publication.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2931, 125, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 65 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"

        }
    

#line default
#line hidden
            BeginContext(3076, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(3084, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62d2a8caf7c14b52b1e55edd16595b6b", async() => {
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
            BeginContext(3126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3128, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce3079abd78a4de89b86ed091f6477b4", async() => {
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
            BeginContext(3197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3199, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b75396a561d4360bee638437957174e", async() => {
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
            BeginContext(3250, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3254, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bfd6992620346adba47e283f8f954fe", async() => {
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
            BeginContext(3302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3304, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb8d7589a2b34b41a867b73d1bba1e9f", async() => {
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
            BeginContext(3344, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cook_Share.Models.Publication>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b2e16451cd9eaaa6f9982606a395078be94f54"
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
#line 1 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
#line 2 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b2e16451cd9eaaa6f9982606a395078be94f54", @"/Views/Account/ViewAllSubscriptionDish.cshtml")]
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
#line 2 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
  
    ViewData["Title"] = "ViewAllSubscriptionDish";

#line default
#line hidden
            BeginContext(103, 97, true);
            WriteLiteral("\r\n<h2 class=\"title__all\">Подписчики</h2>\r\n\r\n<br /><br />\r\n<div class=\"container container-all\">\r\n");
            EndContext();
#line 10 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
       foreach (var publication in Model)
        {




#line default
#line hidden
            BeginContext(260, 130, true);
            WriteLiteral("            <div class=\"dish-item-all\">\r\n                <div class=\"dish-left\">\r\n                    <div class=\"owl-carousel\">\r\n");
            EndContext();
#line 18 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                          
                            if (publication.Photos.Count != 0)
                            {
                                foreach (var photo in publication.Photos)
                                {


#line default
#line hidden
            BeginContext(625, 105, true);
            WriteLiteral("                                    <div class=\"photo__slider\">\r\n                                        ");
            EndContext();
            BeginContext(730, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "912fc88cafde4d8c810f6e64d7400438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 740, "~/dish_img/", 740, 11, true);
#line 25 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
AddHtmlAttributeValue("", 751, photo.Name, 751, 11, false);

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
            BeginContext(790, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 27 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                }
                            }
                            else
                            {
                                string dish = "default-dish.jpg";

#line default
#line hidden
            BeginContext(1034, 97, true);
            WriteLiteral("                                <div class=\"photo__slider\">\r\n                                    ");
            EndContext();
            BeginContext(1131, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b630ae1772d4627843a2bcbfdc4a5b9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1141, "~/dish_img/", 1141, 11, true);
#line 33 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
AddHtmlAttributeValue("", 1152, dish, 1152, 5, false);

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
            BeginContext(1185, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 35 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1285, 178, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n                <div class=\"dish-right\">\r\n                    <div class=\"title__dish__creator\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1463, "\'", 1516, 1);
#line 42 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
WriteAttributeValue("", 1470, Url.Action("DishPage","Account", publication), 1470, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1517, 74, true);
            WriteLiteral(" class=\"link__dish\">\r\n                        <div class=\"name__dish-all\">");
            EndContext();
            BeginContext(1592, 20, false);
#line 43 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                               Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 122, true);
            WriteLiteral("</div>\r\n                        </a>\r\n                        <div class=\"subtitle__dish\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1734, "\'", 1805, 1);
#line 46 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
WriteAttributeValue("", 1741, Url.Action("UserPage","Account", new{id = @publication.UserId}), 1741, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1806, 100, true);
            WriteLiteral(" class=\"link__dish\">\r\n                                <div class=\"name__creator name__creator__all\">");
            EndContext();
            BeginContext(1907, 21, false);
#line 47 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                         Write(publication.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1928, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1930, 24, false);
#line 47 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                                Write(publication.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 150, true);
            WriteLiteral("</div>\r\n                            </a>\r\n                            <div class=\"cuisine__dish cuisine__dish__all\">\r\n                                ");
            EndContext();
            BeginContext(2105, 19, false);
#line 50 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                           Write(publication.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(2124, 197, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"category__dish dish__span__all\"><span class=\"dish__span dish__span__all\">Категория: </span>");
            EndContext();
            BeginContext(2322, 25, false);
#line 53 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                                                          Write(publication.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2347, 197, true);
            WriteLiteral("</div>\r\n                        <div class=\"description__dish dish__span__all\">\r\n                            <span class=\"dish__span dish__span__all\">Описание: </span>\r\n                            ");
            EndContext();
            BeginContext(2545, 23, false);
#line 56 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                       Write(publication.Discription);

#line default
#line hidden
            EndContext();
            BeginContext(2568, 287, true);
            WriteLiteral(@"
                        </div>
                        <div class=""recipe__dish dish__span__all"">
                            <span class=""dish__span dish__span__all"">Рецепт: </span>
                            <textarea class=""txtArea__recipe input__item dish__span__all"" disabled>");
            EndContext();
            BeginContext(2856, 18, false);
#line 60 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                              Write(publication.Recipe);

#line default
#line hidden
            EndContext();
            BeginContext(2874, 178, true);
            WriteLiteral("</textarea>\r\n                        </div>\r\n                        <div class=\"date__creator dish__span__all\"> <span class=\"dish__span dish__span__all\">Дата добавления: </span>");
            EndContext();
            BeginContext(3053, 16, false);
#line 62 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"
                                                                                                                                Write(publication.Time);

#line default
#line hidden
            EndContext();
            BeginContext(3069, 125, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 67 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\ViewAllSubscriptionDish.cshtml"

        }
    

#line default
#line hidden
            BeginContext(3214, 1944, true);
            WriteLiteral(@"</div>


<footer class=""wrap__bottom"">
    <div class=""bottom"">
        <div class=""row""></div>
        <div class=""footer__top"">
            <div class=""footer__top-item"">
                <span class=""title__footer__top""><a href=""#"" class=""footer__link"">Главная</a></span>
                <ul class=""footer__list"">
                    <li class=""footer__list-item""><a href=""#"" class=""footer__link"">Link</a></li>
                    <li class=""footer__list-item"">Text</li>
                    <li class=""footer__list-item"">Text</li>
                </ul>
            </div>

            <div class=""footer__top-item"">
                <span class=""title__footer__top""><a href=""#"" class=""footer__link"">Аккаунт</a></span>
                <ul class=""footer__list"">
                    <li class=""footer__list-item""><a href=""#"" class=""footer__link"">Link</a></li>
                    <li class=""footer__list-item""><a href=""#"" class=""footer__link"">Link</a></li>
                    <li class=""footer__list-item");
            WriteLiteral(@"""><a href=""#"" class=""footer__link"">Link</a></li>
                </ul>
            </div>

            <div class=""footer__top-item"">
                <span class=""title__footer__top"">Навигация</span>
                <ul class=""footer__list"">
                    <li class=""footer__list-item"">Адрес: Ukraine Kharkiv </li>
                    <br>
                    <li class=""footer__list-item"">Номер:<a href=""#"" class=""link__list-item"">+380958695956</a></li>
                    <br>
                    <li class=""footer__list-item"">E-mail.:<a href=""#"" class=""link__list-item"">info@gmail.com</a></li>
                </ul>
            </div>
        </div>
        <div class=""row""></div>
        <div class=""footer__bottom"">
            <div class=""footer__container"">
                <div class=""footer__create"">MyWork s.r.o 2019.</div>
            </div>
        </div>
    </div>
</footer>
");
            EndContext();
            BeginContext(5158, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6532997cbaf4c469f380ad2516ecb3a", async() => {
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
            BeginContext(5200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5202, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07a3d2eb9c4648ae801bf695a9d4eb2b", async() => {
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
            BeginContext(5271, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5273, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba806646475c4c3da9a9a2b4133f8a2f", async() => {
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
            BeginContext(5324, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(5328, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ea608911cb4cf0807802879605799d", async() => {
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
            BeginContext(5376, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5378, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "742d2ebe444b4a5f82264bed390ed564", async() => {
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
            BeginContext(5418, 2, true);
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

#pragma checksum "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2136bc861f8ff925090b4208af9637868245f104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserPage), @"mvc.1.0.view", @"/Views/Account/UserPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/UserPage.cshtml", typeof(AspNetCore.Views_Account_UserPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2136bc861f8ff925090b4208af9637868245f104", @"/Views/Account/UserPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a947732fe9c17793ed08c30568b9f3ac6c7817", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("MyPhoto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile__photo "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addPhotoArea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("photo__dish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
  
    ViewData["Title"] = "UserPage";
    string defUser = Model.User.Photo ?? "default-user.png";

#line default
#line hidden
            BeginContext(108, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(133, 131, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <header class=\"header\"></header>\r\n    <main>\r\n        <div class=\"title__profile\">\r\n            ");
            EndContext();
            BeginContext(264, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f452c4482535441eacc0c544318c23bf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 274, "~/img/", 274, 6, true);
#line 16 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
AddHtmlAttributeValue("", 280, defUser, 280, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(348, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(446, 38, true);
            WriteLiteral("            <span class=\"title__name\">");
            EndContext();
            BeginContext(485, 15, false);
#line 19 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                                 Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(500, 100, true);
            WriteLiteral("</span>\r\n            <span class=\"title__name\">&ensp;</span>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(601, 18, false);
#line 21 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                                 Write(Model.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(619, 282, true);
            WriteLiteral(@"</span>

        </div>
        <div class=""row""></div>

        <div class=""profile__navigation"">
            <div class=""nav__left"">
                <a href=""#""
                   class=""nav__link active""
                   id=""first__tag"">Блюда</a>
            </div>
");
            EndContext();
#line 32 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
              
                if (User.Identity.IsAuthenticated)
                {
                    if (Model.IsSub)
                    {

#line default
#line hidden
            BeginContext(1049, 87, true);
            WriteLiteral("                        <div class=\"nav__right\">\r\n\r\n                            <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1136, "\"", 1198, 3);
            WriteAttributeValue("", 1146, "location.href=\'/Account/Subscribe?id=", 1146, 37, true);
#line 39 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
WriteAttributeValue("", 1183, Model.User.Id, 1183, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1197, "\'", 1197, 1, true);
            EndWriteAttribute();
            BeginContext(1199, 139, true);
            WriteLiteral(" class=\"nav__button\">\r\n                                Подписаться\r\n                            </button>\r\n                        </div>\r\n");
            EndContext();
#line 43 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1410, 87, true);
            WriteLiteral("                        <div class=\"nav__right\">\r\n\r\n                            <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1497, "\"", 1561, 3);
            WriteAttributeValue("", 1507, "location.href=\'/Account/UnSubscribe?id=", 1507, 39, true);
#line 48 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
WriteAttributeValue("", 1546, Model.User.Id, 1546, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1560, "\'", 1560, 1, true);
            EndWriteAttribute();
            BeginContext(1562, 152, true);
            WriteLiteral(" class=\"nav__button nav__btn-nope\">\r\n                                Отписаться\r\n                            </button>\r\n                        </div>\r\n");
            EndContext();
#line 52 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(1771, 208, true);
            WriteLiteral("        </div>\r\n        <div class=\"row\"></div>\r\n        <div class=\"content\">\r\n            <div class=\"left__content\" id=\"left__content\">\r\n                <div class=\"content__mydishes\" id=\"cnt__mydishes\">\r\n");
            EndContext();
#line 60 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                      

                        foreach (var publication in Model.Publications)
                        {
                            string dish = "default-dish.jpg";
                            var photo = Model.Photos.FirstOrDefault(p => p.PublicationId == publication.Id);
                            if (photo != null)
                            {
                                dish = photo.Name;
                            }

#line default
#line hidden
            BeginContext(2440, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2470, "\'", 2523, 1);
#line 70 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
WriteAttributeValue("", 2477, Url.Action("DishPage","Account", publication), 2477, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2524, 125, true);
            WriteLiteral(" class=\"link__dish\">\r\n\r\n                                <div class=\"content__mydish\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(2649, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c43b99872ccb4c02b712ac6ea59f476d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2659, "~/dish_img/", 2659, 11, true);
#line 74 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
AddHtmlAttributeValue("", 2670, dish, 2670, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(2706, 135, true);
            WriteLiteral("\r\n                                    <div class=\"wrap__photo\">\r\n                                        <h1 class=\"title-name__photo\">");
            EndContext();
            BeginContext(2842, 20, false);
#line 76 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                                                                 Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(2862, 129, true);
            WriteLiteral("</h1>\r\n                                    </div>\r\n                                </div>\r\n\r\n\r\n                            </a>\r\n");
            EndContext();
#line 82 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\UserPage.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3041, 48, true);
            WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(3523, 2167, true);
            WriteLiteral(@"        </div>
    </main>

    <footer class=""wrap__bottom"">
        <div class=""bottom"">
            <div class=""row""></div>
            <div class=""footer__top"">
                <div class=""footer__top-item"">
                    <span class=""title__footer__top""><a href=""#"" class=""footer__link"">News</a></span>
                    <ul class=""footer__list"">
                        <li class=""footer__list-item""><a href=""#"" class=""footer__link"">Link</a></li>
                        <li class=""footer__list-item"">Text</li>
                        <li class=""footer__list-item"">Text</li>
                    </ul>
                </div>

                <div class=""footer__top-item"">
                    <span class=""title__footer__top""><a href=""#"" class=""footer__link"">Support</a></span>
                    <ul class=""footer__list"">
                        <li class=""footer__list-item""><a href=""#"" class=""footer__link"">Link</a></li>
                        <li class=""footer__list-item""><a href=""#"" ");
            WriteLiteral(@"class=""footer__link"">Link</a></li>
                        <li class=""footer__list-item""><a href=""#"" class=""footer__link"">Link</a></li>
                    </ul>
                </div>

                <div class=""footer__top-item"">
                    <span class=""title__footer__top"">Navigation</span>
                    <ul class=""footer__list"">
                        <li class=""footer__list-item"">Address: Ukraine Kharkiv </li>
                        <br>
                        <li class=""footer__list-item"">Tel.:<a href=""#"" class=""link__list-item"">+380958695956</a></li>
                        <br>
                        <li class=""footer__list-item"">E-mail.:<a href=""#"" class=""link__list-item"">info@gmail.com</a></li>
                    </ul>
                </div>
            </div>
            <div class=""row""></div>
            <div class=""footer__bottom"">
                <div class=""footer__container"">
                    <div class=""footer__create"">MyWork s.r.o 2019.</div>
     ");
            WriteLiteral("           </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n</div>\r\n<script src=\"../js/script.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

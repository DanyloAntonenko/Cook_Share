#pragma checksum "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53833d27a25607b56cdd17d1e0c591a996d00f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Account), @"mvc.1.0.view", @"/Views/Account/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Account.cshtml", typeof(AspNetCore.Views_Account_Account))]
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
using Cook_Share;

#line default
#line hidden
#line 2 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53833d27a25607b56cdd17d1e0c591a996d00f9f", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0530d5c97a2da7007dcbebf6549388f39eae983", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cook_Share.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";
    string str = Model?.Photo ?? "default-user.png";

#line default
#line hidden
            BeginContext(130, 182, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"../css/style.css\" />\r\n\r\n<div class=\"container\">\r\n    <header class=\"header\"></header>\r\n    <main>\r\n        <div class=\"title__profile\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 312, "\"", 329, 2);
            WriteAttributeValue("", 318, "../img/", 318, 7, true);
#line 13 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 325, str, 325, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(330, 181, true);
            WriteLiteral(" alt=\"MyPhoto\" class=\"profile__photo \" id=\"addPhotoArea\"/>\r\n            <button class=\"profile__add \" id=\"addPhotoBtn\">Добавить фото</button>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(512, 10, false);
#line 15 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(522, 100, true);
            WriteLiteral("</span>\r\n            <span class=\"title__name\">&ensp;</span>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(623, 13, false);
#line 17 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(636, 655, true);
            WriteLiteral(@"</span>

        </div>
        <div class=""row""></div>

        <div class=""profile__navigation"">
            <div class=""nav__left"">
                <a href=""#""
                   class=""nav__link active""
                   onclick=""addContentMyDish()"">Мои блюда</a>

                    <a href=""#"" class=""nav__link"" onclick=""addContentMyFavorite()"">Избранное</a>
                </div>
            <div class=""nav__right"">
                
                <button onclick=""location.href='/Account/ChangeInfo';"" class=""nav__button"">
                    Редактирование
                </button>

                </a>
                ");
            EndContext();
            BeginContext(1291, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fb856c5ed84dea91de4874b3a8f6e9", async() => {
                BeginContext(1365, 45, true);
                WriteLiteral("\r\n                    Выход\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 266, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row""></div>
        <div class=""content"">
            <div class=""left__content"" id=""left__content"">
                <div class=""content__mydishes"">
                    <div class=""add-content__mydish"">
");
            EndContext();
            BeginContext(1853, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1879, "\'", 1931, 1);
#line 49 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 1886, Url.Action("AddDish","Account", Model, null), 1886, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1932, 2397, true);
            WriteLiteral(@">Добавить Блюдо</a>
                        <button onclick=""location.href='/Account/AddDish';"">
                            Добавить Блюдо
                        </button>
                    </div>

                    <div class=""content__mydish"">
                        <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                        <h1></h1>
                    </div>

                    <div class=""content__mydish"">
                        <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                        <h1></h1>
                    </div>

                    <div class=""content__mydish"">
                        <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                        <h1></h1>
                    </div>

                    <div class=""content__mydish"">
                        <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                        <h1></h1>
                    </");
            WriteLiteral(@"div>

                    <div class=""content__mydish"">
                        <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                        <h1></h1>
                    </div>
                </div>
            </div>
            <div class=""right__content"">
                <div class=""subscribers li__profile"">
                    Подписчики:<span class=""num__content"">4</span>
                </div>
                <div class=""subscriptions li__profile"">
                    Подписки:<span class=""num__content"">23</span>
                </div>
                <div class=""row""></div>
            </div>
        </div>
    </main>
</div>
<script src=""../js/script.js""></script>


<!--
<div class=""friend__list"">
  <div class=""friend-profile__mini"">
    <div class=""title__friend-profile__mini"">
      <img src=""./img/test2.jpg"" alt="""" class=""mini-photo_friend"" />
      <span class=""friend__name"">Никитченко Богдан</span>
    </div>
    <button class=""button-fr");
            WriteLiteral(@"iend__mini"">Просмотреть</button>
  </div>
  <div class=""friend-profile__mini"">
    <div class=""title__friend-profile__mini"">
      <img src=""./img/test1.jpg"" alt="""" class=""mini-photo_friend"" />
      <span class=""friend__name"">Шишло Ольга</span>
    </div>
    <button class=""button-friend__mini"">Просмотреть</button>
  </div>
</div>
-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cook_Share.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591

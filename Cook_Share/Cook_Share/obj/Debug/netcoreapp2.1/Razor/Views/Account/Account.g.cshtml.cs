#pragma checksum "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e00d0624749297872b121260ffac1fed62b97640"
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
#line 1 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share;

#line default
#line hidden
#line 2 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00d0624749297872b121260ffac1fed62b97640", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0530d5c97a2da7007dcbebf6549388f39eae983", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cook_Share.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav__button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";
    string str = ViewBag.Info?.Photo ?? "test.jpg";

#line default
#line hidden
            BeginContext(129, 182, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"../css/style.css\" />\r\n\r\n<div class=\"container\">\r\n    <header class=\"header\"></header>\r\n    <main>\r\n        <div class=\"title__profile\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 311, "\"", 328, 2);
            WriteAttributeValue("", 317, "../img/", 317, 7, true);
#line 13 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 324, str, 324, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(329, 181, true);
            WriteLiteral(" alt=\"MyPhoto\" class=\"profile__photo \" id=\"addPhotoArea\"/>\r\n            <button class=\"profile__add \" id=\"addPhotoBtn\">Добавить фото</button>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(511, 17, false);
#line 15 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(ViewBag.info.Name);

#line default
#line hidden
            EndContext();
            BeginContext(528, 100, true);
            WriteLiteral("</span>\r\n            <span class=\"title__name\">&ensp;</span>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(629, 20, false);
#line 17 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(ViewBag.info.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(649, 655, true);
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
            BeginContext(1304, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0e210e9823845849c8993918daf592c", async() => {
                BeginContext(1377, 45, true);
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
            BeginContext(1431, 2649, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row""></div>
        <div class=""content"">
            <div class=""left__content"" id=""left__content"">
                <div class=""content__mydishes"">
                    <div class=""add-content__mydish"">
                        <img src=""../img/plus.png"" alt="""" class=""photo__add"" />
                        <button class=""button__add-dish"" hidden>Добавить</button>
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
           ");
            WriteLiteral(@"             <h1></h1>
                    </div>

                    <div class=""content__mydish"">
                        <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                        <h1></h1>
                    </div>

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
  ");
            WriteLiteral(@"<div class=""friend-profile__mini"">
    <div class=""title__friend-profile__mini"">
      <img src=""./img/test2.jpg"" alt="""" class=""mini-photo_friend"" />
      <span class=""friend__name"">Никитченко Богдан</span>
    </div>
    <button class=""button-friend__mini"">Просмотреть</button>
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

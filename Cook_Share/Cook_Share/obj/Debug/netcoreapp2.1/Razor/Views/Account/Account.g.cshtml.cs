#pragma checksum "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292d2d0a9a67ac3fc3a582663a751647f8681a0b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292d2d0a9a67ac3fc3a582663a751647f8681a0b", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0530d5c97a2da7007dcbebf6549388f39eae983", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cook_Share.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav__button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddDish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link__dish__add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link__dish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";
    string str = Model?.Photo ?? "default-user.png";

#line default
#line hidden
            BeginContext(130, 133, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <header class=\"header\"></header>\r\n    <main>\r\n        <div class=\"title__profile\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 263, "\"", 280, 2);
            WriteAttributeValue("", 269, "../img/", 269, 7, true);
#line 13 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 276, str, 276, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(281, 188, true);
            WriteLiteral(" alt=\"MyPhoto\" class=\"profile__photo \" id=\"addPhotoArea\"/>\r\n            <button class=\"profile__add \" id=\"addPhotoBtn\" hidden>Добавить фото</button>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(470, 10, false);
#line 15 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(480, 100, true);
            WriteLiteral("</span>\r\n            <span class=\"title__name\">&ensp;</span>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(581, 13, false);
#line 17 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(594, 674, true);
            WriteLiteral(@"</span>

        </div>
        <div class=""row""></div>

        <div class=""profile__navigation"">
            <div class=""nav__left"">
                <a href=""#""
                   class=""nav__link active""
                   id=""first__tag""
                  >Мои блюда</a>

                    <a href=""#"" class=""nav__link"" 
                          id=""second__tag"">Избранное</a>
                </div>
            <div class=""nav__right"">
                
                <button onclick=""location.href='/Account/ChangeInfo';"" class=""nav__button"">
                    Редактирование
                </button>

                </a>
                ");
            EndContext();
            BeginContext(1268, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d09b18f14ff84a748d833d3a86f2b3a5", async() => {
                BeginContext(1342, 45, true);
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
            BeginContext(1396, 238, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\"></div>\r\n        <div class=\"content\">\r\n            <div class=\"left__content\" id=\"left__content\">\r\n                <div class=\"content__mydishes\" hidden>\r\n                    ");
            EndContext();
            BeginContext(1634, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2739fb9409b34edfa0e435920f4abe4e", async() => {
                BeginContext(1719, 200, true);
                WriteLiteral("\r\n                        <div class=\"add-content__mydish\">\r\n                            <img src=\"../img/plus.png\" alt=\"\" class=\"photo__add\" />\r\n\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1923, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1945, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef1d1afb971459e9d1694b8840079b2", async() => {
                BeginContext(2022, 244, true);
                WriteLiteral("\r\n                        <div class=\"content__mydish\">\r\n\r\n                            <img src=\"../img/photo-food-1.png\" alt=\"\" class=\"photo__dish\" />\r\n                            <h1></h1>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2270, 26, true);
            WriteLiteral("\r\n\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2296, "\'", 2345, 1);
#line 62 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2303, Url.Action("Dish","Account", Model, null), 2303, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2346, 292, true);
            WriteLiteral(@" class=""link__dish"">
                        <div class=""content__mydish"">
                            <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                            <h1></h1>
                        </div>
                    </a>

                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2638, "\'", 2687, 1);
#line 69 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2645, Url.Action("Dish","Account", Model, null), 2645, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2688, 292, true);
            WriteLiteral(@" class=""link__dish"">
                        <div class=""content__mydish"">
                            <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                            <h1></h1>
                        </div>
                    </a>

                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2980, "\'", 3029, 1);
#line 76 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2987, Url.Action("Dish","Account", Model, null), 2987, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3030, 292, true);
            WriteLiteral(@" class=""link__dish"">
                        <div class=""content__mydish"">
                            <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                            <h1></h1>
                        </div>
                    </a>

                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3322, "\'", 3371, 1);
#line 83 "G:\GitHub\projectAVPZ\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 3329, Url.Action("Dish","Account", Model, null), 3329, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3372, 1439, true);
            WriteLiteral(@" class=""link__dish"">
                        <div class=""content__mydish"">
                            <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                            <h1></h1>
                        </div>
                    </a>
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
      <span class=""friend__name"">");
            WriteLiteral(@"Никитченко Богдан</span>
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

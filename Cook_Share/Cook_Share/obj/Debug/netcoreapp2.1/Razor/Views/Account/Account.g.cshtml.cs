#pragma checksum "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785ebea995c90be7978af3c903251f281872954a"
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
using Cook_Share.Models;

#line default
#line hidden
#line 2 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785ebea995c90be7978af3c903251f281872954a", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a947732fe9c17793ed08c30568b9f3ac6c7817", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav__button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link__dish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";
    string str = Model.User.Photo ?? "default-user.png";

#line default
#line hidden
            BeginContext(101, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(126, 135, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <header class=\"header\"></header>\r\n    <main>\r\n        <div class=\"title__profile\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 261, "\"", 278, 2);
            WriteAttributeValue("", 267, "../img/", 267, 7, true);
#line 15 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 274, str, 274, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(279, 190, true);
            WriteLiteral(" alt=\"MyPhoto\" class=\"profile__photo \" id=\"addPhotoArea\"/>\r\n\r\n            <button class=\"profile__add \" id=\"addPhotoBtn\" hidden>Добавить фото</button>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(470, 15, false);
#line 18 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(485, 100, true);
            WriteLiteral("</span>\r\n            <span class=\"title__name\">&ensp;</span>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(586, 18, false);
#line 20 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(604, 652, true);
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

                ");
            EndContext();
            BeginContext(1256, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e80abbcf01d4f32b7d56fbc532c6bc5", async() => {
                BeginContext(1330, 45, true);
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
            BeginContext(1384, 551, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""row""></div>
        <div class=""content"">
            <div class=""left__content"" id=""left__content"">
                <div class=""content__mydishes"" id=""cnt__mydishes"">
                   
                    <a href=""/Account/AddDish"" class=""link__dish__add"">

                        <div class=""add-content__mydish"">
                            <img src=""../img/plus.png"" alt="""" class=""photo__add"" />

                        </div>
                    </a>
                   
");
            EndContext();
#line 59 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                      

                        foreach (var publication in Model.Publications)
                        {

                            var photo = Model.Photos.FirstOrDefault(p => p.PublicationId == publication.Id);

#line default
#line hidden
            BeginContext(2173, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2203, "\'", 2252, 1);
#line 65 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2210, Url.Action("Dish","Account", publication), 2210, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2253, 173, true);
            WriteLiteral("  class=\"link__dish\">\r\n                                            \r\n                                <div class=\"content__mydish\">\r\n\r\n                                   <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2426, "\"", 2455, 2);
            WriteAttributeValue("", 2432, "../dish_img/", 2432, 12, true);
#line 69 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2444, photo.Name, 2444, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2456, 163, true);
            WriteLiteral(" alt=\"\" class=\"photo__dish\" />\r\n                                   <div class=\"wrap__photo\">\r\n                                       <h1 class=\"title-name__photo\">");
            EndContext();
            BeginContext(2620, 20, false);
#line 71 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                                                Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(2640, 171, true);
            WriteLiteral("</h1>\r\n                                   </div>\r\n                                </div>\r\n                        \r\n                    \r\n                           </a>\r\n");
            EndContext();
#line 77 "E:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(2861, 151, true);
            WriteLiteral("                </div>\r\n\r\n\r\n                <div class=\"content__myfavorite dispnone\"  id=\"cnt__myfavorite\">\r\n                   \r\n                    ");
            EndContext();
            BeginContext(3012, 454, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57da11f075504bc2abd1719e7d23e60f", async() => {
                BeginContext(3089, 373, true);
                WriteLiteral(@"
                        <div class=""content__mydish"">

                            <img src=""../img/photo-food-1.png"" alt="""" class=""photo__dish"" />
                            <div class=""wrap__photo"">
                                <h1 class=""title-name__photo"">Макароны</h1>
                            </div>
                        </div>
                    ");
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
            BeginContext(3466, 1189, true);
            WriteLiteral(@"

                  
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
    <button class=""button-friend__mini"">Просмотреть</button>
  </div>
  <div class=""friend-profile__mini"">
    <div class=""title__friend-profile__mini"">
      <img src=""./img/test1.jpg"" alt="""" class=""mini-pho");
            WriteLiteral("to_friend\" />\r\n      <span class=\"friend__name\">Шишло Ольга</span>\r\n    </div>\r\n    <button class=\"button-friend__mini\">Просмотреть</button>\r\n  </div>\r\n</div>\r\n-->\r\n");
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

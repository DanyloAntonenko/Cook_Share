#pragma checksum "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58620804e97543f207c700370dd1ee202d99dcfc"
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
#line 1 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.Models;

#line default
#line hidden
#line 2 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\_ViewImports.cshtml"
using Cook_Share.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58620804e97543f207c700370dd1ee202d99dcfc", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a947732fe9c17793ed08c30568b9f3ac6c7817", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link__dish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";
    string defUser = Model.User.Photo ?? "default-user.png";
    //string defDish = Model.Photos ?? "default-dish.jpg";

#line default
#line hidden
            BeginContext(165, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(190, 135, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <header class=\"header\"></header>\r\n    <main>\r\n        <div class=\"title__profile\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 325, "\"", 346, 2);
            WriteAttributeValue("", 331, "../img/", 331, 7, true);
#line 16 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 338, defUser, 338, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(347, 62, true);
            WriteLiteral(" alt=\"MyPhoto\" class=\"profile__photo \" id=\"addPhotoArea\"/>\r\n\r\n");
            EndContext();
            BeginContext(503, 38, true);
            WriteLiteral("            <span class=\"title__name\">");
            EndContext();
            BeginContext(542, 15, false);
#line 19 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(557, 100, true);
            WriteLiteral("</span>\r\n            <span class=\"title__name\">&ensp;</span>\r\n            <span class=\"title__name\">");
            EndContext();
            BeginContext(658, 18, false);
#line 21 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                 Write(Model.User.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(676, 1183, true);
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
            </div>
        </div>
        <div class=""row""></div>
        <div class=""content"">
            <div class=""left__content"" id=""left__content"">
                <div class=""content__mydishes"" id=""cnt__mydishes"">
                   
                    <a href=""/Account/AddDish"" class=""link__dish__add"">

                        <div class=""add-content__mydish"">
       ");
            WriteLiteral("                     <img src=\"../img/plus.png\" alt=\"\" class=\"photo__add\" />\r\n\r\n                        </div>\r\n                    </a>\r\n                   \r\n");
            EndContext();
#line 56 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                      

                        foreach (var publication in Model.Publications)
                        {
                            string dish = "default-dish.jpg";
                            var photo = Model.Photos.FirstOrDefault(p => p.PublicationId == publication.Id);
                            if(photo != null)
                            {
                                dish = photo.Name;
                            }

#line default
#line hidden
            BeginContext(2319, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2349, "\'", 2398, 1);
#line 66 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2356, Url.Action("Dish","Account", publication), 2356, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2399, 209, true);
            WriteLiteral("  class=\"link__dish\">\r\n                                            \r\n                                <div class=\"content__mydish\">\r\n                                    \r\n                                   <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2608, "\"", 2631, 2);
            WriteAttributeValue("", 2614, "../dish_img/", 2614, 12, true);
#line 70 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
WriteAttributeValue("", 2626, dish, 2626, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2632, 163, true);
            WriteLiteral(" alt=\"\" class=\"photo__dish\" />\r\n                                   <div class=\"wrap__photo\">\r\n                                       <h1 class=\"title-name__photo\">");
            EndContext();
            BeginContext(2796, 20, false);
#line 72 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                                                                Write(publication.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(2816, 171, true);
            WriteLiteral("</h1>\r\n                                   </div>\r\n                                </div>\r\n                        \r\n                    \r\n                           </a>\r\n");
            EndContext();
#line 78 "D:\Github\Cook_Share\Cook_Share\Cook_Share\Views\Account\Account.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3037, 151, true);
            WriteLiteral("                </div>\r\n\r\n\r\n                <div class=\"content__myfavorite dispnone\"  id=\"cnt__myfavorite\">\r\n                   \r\n                    ");
            EndContext();
            BeginContext(3188, 454, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20f36dfc8d9642ab943f3fd5d0607192", async() => {
                BeginContext(3265, 373, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3642, 550, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42e79c8e5b5518b50a0ef9e2518b616f4235e086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodSemWork.Pages.Home.Views_Home_Profile), @"mvc.1.0.razor-page", @"/Views/Home/Profile.cshtml")]
namespace FoodSemWork.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\_ViewImports.cshtml"
using FoodSemWork;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e79c8e5b5518b50a0ef9e2518b616f4235e086", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95aea09efcbe511a0d11e9d6303fe4d91c7cd04f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42e79c8e5b5518b50a0ef9e2518b616f4235e0863055", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <title>Еда</title>
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

        <link rel=""stylesheet"" href=""css/style.css"">


    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42e79c8e5b5518b50a0ef9e2518b616f4235e0864566", async() => {
                WriteLiteral(@"
        <header>
            <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
                <a class=""navbar-brand"" href=""#"">Главная</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarText"" aria-controls=""navbarText"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarText"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Блог </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Контакты</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Галерея</a>
                        </li>
                     ");
                WriteLiteral(@"   <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Наша команда</a>
                        </li>
                    </ul>
                    <span class=""navbar-text"">
                        <img src=""https://lh3.googleusercontent.com/proxy/Rkg8z1crcj5MSA6atr-jK-qjIDzF8QX0sFVU62xEBNWt_NpYEno_oSw29MvBKjucDhh5pcqaZMRKVTYaTjoaXQuXJymoMBgMuT2wCyZASVk5ZCmgxMxk7hhb_RA0_VcMVMJNsQFPdHCOcWe-nculrXjb72RnkgaFCrQNhz1ZBzFs3txMgCu_1DdqX0nv7w"" height=""32"" width=""32"">
                    </span>
                </div>
            </nav>
        </header>


        <div class=""container"" style=""display: flex; flex-direction: row;"">

            <!-- 1 column -->
            <div style=""display: flex; flex-direction: column; justify-content: start; align-items: center; height: 80%; width: 40%"">
                <div style="" height: 100px; width: 100px;"">
                    <img src=""pic/pic-image.png"" height=""50px"" width=""50px"">
                    <p>olesy2002</p>
        ");
                WriteLiteral(@"            <p>админ</p>
                </div>
            </div>

            <!-- 2 col -->
            <div class=""container"" style=""display: flex; flex-direction: column; justify-content: start; align-items: flex-start; height: 80%; width: 60%"">
                <div style=""width: 100%"">
                    <p style=""font-size: 30px;"">Мой аккаунт</p>
                    <p>Посмотрите и отредактируйте сведения о себе</p>
                    <button>Сбросить</button>
                    <button>Обновить</button>
                </div>

                <div style=""width: 100%; margin-top: 20px;"">
                    <p style=""font-size: 30px;"">Открытая информация</p>
                    <p>Карточка профиля видна всем пользователям этого сайта</p>
                    <p>Имя</p>
                    <input type=""text"" name=""name"" value=""olesya2002"" style=""color: black;"">
                </div>

                <div style=""width: 100%;  margin-top: 20px;"">
                    <p style=""font-");
                WriteLiteral("size: 30px;\">Аккаунт</p>\r\n                    <p");
                BeginWriteAttribute("style", " style=\"", 3721, "\"", 3729, 0);
                EndWriteAttribute();
                WriteLiteral(@">Обновите и редактируйте информацию, которой вы делитесь с сообществом</p>
                    <p>Эл. почта для входа</p>
                    <input type=""text"" name=""name"" value=""olesya2002@mail.ru"" style=""color: black;"">
                    <p>Эл. почту изменить нельзя</p>

");
                WriteLiteral(@"
                    <div style=""margin-top: 20px;"">
                        <button>Сбросить</button>
                        <button>Обновить</button>
                    </div>


                </div>

            </div>

        </div>

        <nav class=""navbar fixed-bottom navbar-light bg-dark"">
            <a class=""navbar-brand"" href=""#"">Fixed bottom</a>
        </nav>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodSemWork.Models.UserViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodSemWork.Models.UserViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodSemWork.Models.UserViewModel>)PageContext?.ViewData;
        public FoodSemWork.Models.UserViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe3158d3b5e82ed4c1f9aa6fb5a7a4e982ef2626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodSemWork.Pages.Account.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
namespace FoodSemWork.Pages.Account
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3158d3b5e82ed4c1f9aa6fb5a7a4e982ef2626", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95aea09efcbe511a0d11e9d6303fe4d91c7cd04f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodSemWork.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ButtonsStyle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
  
    ViewBag.Title = "Profile";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3158d3b5e82ed4c1f9aa6fb5a7a4e982ef26264426", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3158d3b5e82ed4c1f9aa6fb5a7a4e982ef26265905", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"

    <div class=""container"" style=""display: flex; flex-direction: row;"">

        <!-- 1 column -->
        <div style=""display: flex; flex-direction: column; justify-content: start; align-items: center; height: 80%; width: 40%"">
            <div style="" height: 100px; width: 100px;"">
");
#nullable restore
#line 57 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
                 if (Model.Avatar != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <img style=\'width:200px; height:200px;margin-top:10px\'");
                BeginWriteAttribute("src", " src=\"", 2642, "\"", 2710, 2);
                WriteAttributeValue("", 2648, "data:image/jpeg;base64,", 2648, 23, true);
#nullable restore
#line 59 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
WriteAttributeValue("", 2671, Convert.ToBase64String(Model.Avatar), 2671, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 60 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 61 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
              Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                <p>Пользователь</p>
            </div>
        </div>

        <!-- 2 col -->
        <div class=""container"" style=""display: flex; flex-direction: column; justify-content: start; align-items: flex-start; height: 80%; width: 60%"">
            <div style=""width: 100%"">
                <p style=""font-size: 30px;"">Мой аккаунт</p>
                <p>Посмотрите и отредактируйте сведения о себе</p>
            </div>

            <div style=""width: 100%; margin-top: 20px;"">
                <p style=""font-size: 30px;"">Открытая информация</p>
                <p>Карточка профиля видна всем пользователям этого сайта</p>
                <p>Имя</p>
                <input type=""text"" name=""name""");
                BeginWriteAttribute("value", " value=\"", 3496, "\"", 3519, 1);
#nullable restore
#line 77 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3504, Model.Username, 3504, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: black;\">\r\n            </div>\r\n\r\n            <div style=\"width: 100%;  margin-top: 20px;\">\r\n                <p style=\"font-size: 30px;\">Аккаунт</p>\r\n                <p");
                BeginWriteAttribute("style", " style=\"", 3701, "\"", 3709, 0);
                EndWriteAttribute();
                WriteLiteral(">Обновите и редактируйте информацию, которой вы делитесь с сообществом</p>\r\n                <p>Эл. почта для входа</p>\r\n                <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 3876, "\"", 3896, 1);
#nullable restore
#line 84 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3884, Model.Email, 3884, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color: black;\">\r\n                <p>Эл. почту изменить нельзя</p>\r\n\r\n");
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"Settings_button\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3158d3b5e82ed4c1f9aa6fb5a7a4e982ef262610065", async() => {
                    WriteLiteral("\r\n            Настроить пользователя\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

    <div style=""height:100px margin-top:25px ""><br><br /></div>
    <div style=""height:100px margin-top:10px ""><br><br /></div>

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
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodSemWork.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
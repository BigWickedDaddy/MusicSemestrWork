#pragma checksum "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b3e072258d95112fcfd0fc1af83564802753c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodSemWork.Pages.MainPage.Views_MainPage_Post), @"mvc.1.0.view", @"/Views/MainPage/Post.cshtml")]
namespace FoodSemWork.Pages.MainPage
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b3e072258d95112fcfd0fc1af83564802753c7", @"/Views/MainPage/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95aea09efcbe511a0d11e9d6303fe4d91c7cd04f", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FoodSemWork.Models.Posts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b3e072258d95112fcfd0fc1af83564802753c74177", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Еда</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8b3e072258d95112fcfd0fc1af83564802753c74890", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b3e072258d95112fcfd0fc1af83564802753c76785", async() => {
                WriteLiteral("\r\n    <!-- ГЛАВНАЯ ЧАСТЬ -->\r\n    <div class=\"container\">\r\n        <nav class=\"navbar navbar-light bg-white\" style=\"width: 100%;\">\r\n            <a class=\"navbar-brand\">Все посты</a>\r\n            ");
#nullable restore
#line 25 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
       Write(await Html.PartialAsync("_GetMessage"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </nav>\r\n\r\n\r\n\r\n");
#nullable restore
#line 30 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
         foreach (FoodSemWork.Models.Posts posts in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"border post\" style=\"margin-top:15px\">\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 999, "\"", 1019, 1);
#nullable restore
#line 33 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
WriteAttributeValue("", 1005, posts.Picture, 1005, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"700\">\r\n            <div class=\"post-info\">\r\n                <div class=\"post-info-header\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
               Write(posts.AuthorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n\r\n                <div>\r\n                    <h5>");
#nullable restore
#line 40 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
                   Write(posts.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n                    <p>");
#nullable restore
#line 41 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
                  Write(posts.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                </div>\r\n\r\n                <div class=\"d-flex justify-content-start mt-auto\">\r\n                    <div class=\"ml-auto\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\olegs\source\repos\FoodSemWork\FoodSemWork\Views\MainPage\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("    </div>\r\n\r\n    <div style=\"height:100px margin-top:25px \"><br><br /></div>\r\n    <div style=\"height:100px margin-top:10px \"><br><br /></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FoodSemWork.Models.Posts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
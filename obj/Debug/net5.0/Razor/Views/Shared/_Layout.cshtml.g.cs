#pragma checksum "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "801da8f8189eefb974c08d607015eee2749c3f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "F:\ZeroXTeamWebsite\Views\_ViewImports.cshtml"
using ZeroXTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ZeroXTeamWebsite\Views\_ViewImports.cshtml"
using ZeroXTeam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
using ZeroXTeam.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801da8f8189eefb974c08d607015eee2749c3f2f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/minification/js_client_before.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/minification/client.bundle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-vertical-dark.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ZeroX Team"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("ZeroX Team"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/minification/js_client_after.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
  
  var activeMenu = ViewData["ActiveMenu"] as string;

  var activeHome = activeMenu == ActiveMenu.Home ? "active" : "";
  var activeProject = activeMenu == ActiveMenu.Project ? "active" : "";
  var activeAbout = activeMenu == ActiveMenu.About ? "active" : "";
  var activeContact = activeMenu == ActiveMenu.Contact ? "active" : "";
  var activeRecruit = activeMenu == ActiveMenu.Recruitment ? "active" : "";
  var activeBlog = activeMenu == ActiveMenu.Blog ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "801da8f8189eefb974c08d607015eee2749c3f2f7052", async() => {
                WriteLiteral(@"
  <!-- Required meta tags -->
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""robots"" content=""learning, zerox, zeroxteam, community, Đà Nẵng, Cộng đồng Đà nẵng, Zerox Đà nẵng, IT, công nghệ thông tin"">
  <meta name=""googlebot"" content=""learning, zerox, zeroxteam, community, Đà Nẵng, Cộng đồng Đà nẵng, Zerox Đà nẵng, IT, công nghệ thông tin"">
  <meta name=""description"" content=""ZeroX Team là một cộng đồng nơi mà mọi người cùng nhau học và giúp đỡ nhau trong lập trình, team có các sản phẩm nền tảng khác như SchoolX và HiCode."" />

  <title> ZeroX - ");
#nullable restore
#line 25 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
             Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </title>

  <!-- web fonts -->
  <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
  <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
  <link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,700;1,100;1,400&display=swap"" rel=""stylesheet"">

  <!-- jQuery JS -->
  <!-- <script src=""~/js/jquery-3.4.1.slim.min.js""></script> -->
  <!-- jQuery JS -->
  <link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">
  <script src=""https://cdn.quilljs.com/1.3.6/quill.min.js""></script>
  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "801da8f8189eefb974c08d607015eee2749c3f2f8767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "801da8f8189eefb974c08d607015eee2749c3f2f9864", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "801da8f8189eefb974c08d607015eee2749c3f2f11755", async() => {
                WriteLiteral("\r\n  <!--header-->\r\n  <header id=\"site-header\" class=\"fixed-top\">\r\n    <div class=\"container\">\r\n      <nav class=\"navbar navbar-expand-lg stroke\">\r\n        <a class=\"navbar-brand\" href=\"/\">\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "801da8f8189eefb974c08d607015eee2749c3f2f12234", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </a>
        <button class=""navbar-toggler  collapsed bg-gradient"" type=""button"" data-toggle=""collapse""
          data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false""
          aria-label=""Toggle navigation"">
          <span class=""navbar-toggler-icon fa icon-expand fa-bars""></span>
          <span class=""navbar-toggler-icon fa icon-close fa-times""></span>
          </span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
          <ul class=""navbar-nav ml-auto"">
            <li");
                BeginWriteAttribute("class", " class=\"", 2817, "\"", 2845, 2);
                WriteAttributeValue("", 2825, "nav-item", 2825, 8, true);
#nullable restore
#line 60 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2833, activeHome, 2834, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\" href=\"/\">Trang chủ <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n            <li");
                BeginWriteAttribute("class", " class=\"", 2980, "\"", 3009, 2);
                WriteAttributeValue("", 2988, "nav-item", 2988, 8, true);
#nullable restore
#line 63 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2996, activeAbout, 2997, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\" href=\"/about\">Về Chúng Tôi</a>\r\n            </li>\r\n            <li");
                BeginWriteAttribute("class", " class=\"", 3113, "\"", 3144, 2);
                WriteAttributeValue("", 3121, "nav-item", 3121, 8, true);
#nullable restore
#line 66 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 3129, activeProject, 3130, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\" href=\"/projects\">Dự án</a>\r\n            </li>\r\n            <li");
                BeginWriteAttribute("class", " class=\"", 3244, "\"", 3275, 2);
                WriteAttributeValue("", 3252, "nav-item", 3252, 8, true);
#nullable restore
#line 69 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 3260, activeRecruit, 3261, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\" href=\"/recruitments\">Tuyển dụng</a>\r\n            </li>\r\n            <li");
                BeginWriteAttribute("class", " class=\"", 3384, "\"", 3412, 2);
                WriteAttributeValue("", 3392, "nav-item", 3392, 8, true);
#nullable restore
#line 72 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 3400, activeBlog, 3401, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\" href=\"/blogs\">Bài viết</a>\r\n            </li>\r\n            <li");
                BeginWriteAttribute("class", " class=\"", 3512, "\"", 3543, 2);
                WriteAttributeValue("", 3520, "nav-item", 3520, 8, true);
#nullable restore
#line 75 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 3528, activeContact, 3529, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\" href=\"/contact\">Liên hệ</a>\r\n            </li>\r\n          </ul>\r\n        </div>\r\n      </nav>\r\n    </div>\r\n  </header>\r\n\r\n    ");
#nullable restore
#line 84 "F:\ZeroXTeamWebsite\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
  
  <footer>
    <!-- footer -->
    <section class=""w3l-footer"">
      <div class=""w3l-footer-16-main py-5"">
        <div class=""container"">
          <div class=""row"">
            <div class=""col-md-4 column"">
              <h3>ZeroX Team</h3>
              <ul class=""footer-gd-16"">
                <li><a href=""index.html"">Trang chủ</a></li>
                <li><a href=""about.html"">Về chúng tôi</a></li>
                <li><a href=""services.html"">Dự án </a></li>
                <li><a href=""#blog.html"">Bài viết</a></li>
                <li><a href=""contact.html"">Liên hệ chúng tôi</a></li>
              </ul>
            </div>
            <div class=""col-md-4 column mt-md-0 mt-4"">
              <h3>Các dự án nổi bật</h3>
              <ul class=""footer-gd-16"">
                <li><a href=""#url"">Case Studies</a></li>
                <li><a href=""#url"">Our Branches</a></li>
                <li><a href=""#url"">Latest Media</a></li>
                <li><a href=""about.html"">About Company");
                WriteLiteral(@"</a></li>
                <li><a href=""#url"">Our People</a></li>
              </ul>
            </div>
            <div class=""col-md-4 column mt-md-0 mt-4"">
              <h3>Các bài viết nổi bật</h3>
              <ul class=""footer-gd-16"">
                <li><a href=""#url"">Privacy Policy</a></li>
                <li><a href=""#url"">Our Terms</a></li>
                <li><a href=""services.html"">Services</a></li>
                <li><a href=""#landing-single.html"">Landing Page</a></li>
                <li><a href=""#url"">Our People</a></li>
              </ul>
            </div>
          </div>
          <div class=""d-flex below-section justify-content-between align-items-center pt-4 mt-5"">
            <div class=""columns text-lg-left text-center"">
              <p>&copy; 2020 Masterwork. All rights reserved | Designed by <a
                  href=""https://w3layouts.com/"">W3Layouts</a> | re-design by zerox-team
              </p>
            </div>
");
                WriteLiteral(@"          </div>
        </div>
      </div>

      <!-- move top -->
      <button onclick=""topFunction()"" id=""movetop"" title=""Go to top"">
        <span class=""fa fa-angle-up""></span>
      </button>
    </section>
    <!-- //footer -->
  </footer>

  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "801da8f8189eefb974c08d607015eee2749c3f2f20008", async() => {
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
                WriteLiteral("\r\n  <!--  Bootstrap JS -->\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "801da8f8189eefb974c08d607015eee2749c3f2f21134", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6efe6217788fbbb2b2c13c5156b8297a6b0097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\_ViewImports.cshtml"
using ZeroXTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\_ViewImports.cshtml"
using ZeroXTeam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6efe6217788fbbb2b2c13c5156b8297a6b0097", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/contact.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-curve img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostContact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- contact breadcrumbs -->
<nav id=""breadcrumbs"" class=""breadcrumbs"">
  <div class=""container page-wrapper"">
    <a href=""/"">Trang chủ</a> » <span class=""breadcrumb_last"" aria-current=""page"">Liên hệ</span>
  </div>
</nav>
<!-- /contact breadcrumbs -->

<!-- contact form -->
<section class=""w3l-contact"" id=""contact"">
  <div class=""container py-5"">
    <div class=""contacts12-main py-md-3"">
      <div class=""header-section mb-5 text-center"">
");
#nullable restore
#line 14 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Home\Contact.cshtml"
         if (TempData["SuccessMessage"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"alert alert-success mt-4\" style=\"width: 30rem; margin: 0 auto\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Home\Contact.cshtml"
       Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>            \r\n");
#nullable restore
#line 19 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Home\Contact.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n      <div class=\"row align-items-center\">\r\n        <div class=\"col-lg-6 text-center\">\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fd6efe6217788fbbb2b2c13c5156b8297a6b00976701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral(@"
        </div>
        <div class=""col-lg-6 position-relative"">
          <div class=""contact-form"">
            <div class=""header-section mb-4 text-left"">
              <h3>Liên hệ chúng tôi</h3>
              <p class=""mt-2 mb-3""> Vestibulum ante ipsum primis in faucibus orci luctus et ultrices
                turpis sodales quis. Integer sit amet mattis quam.</p>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd6efe6217788fbbb2b2c13c5156b8297a6b00978314", async() => {
                WriteLiteral(@"
              <div class=""main-input"">
                <input type=""text"" name=""Name"" placeholder=""Tên của bạn"" class=""contact-input"" required />
                <input type=""email"" name=""Mail"" placeholder=""Email của bạn"" class=""contact-input"" required />
                <input type=""text"" name=""Subject"" placeholder=""Tiêu đề"" class=""contact-input"" />
                <textarea class=""contact-textarea contact-input"" name=""Message"" placeholder=""Bạn muốn nhắn gửi gì đến chúng tôi""");
                BeginWriteAttribute("required", " required=\"", 1832, "\"", 1843, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n              </div>\r\n              <div class=\"text-right\">\r\n                <button class=\"btn-primary btn theme-button\">Gửi</button>\r\n              </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class=""contant11-top-bg py-5"">
    <div class=""container py-lg-3"">
      <div class=""header-section text-center mb-5 mx-auto"">
        <h6 class=""sub-title mb-3"">Liên Lạc</h6>
        <h3>Chúng Tôi Ở Đây Để Giúp Đỡ</h3>
        <p class=""my-3""> Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;
          Nulla mollis dapibus nunc, ut rhoncus
          turpis sodales quis. Integer sit amet mattis quam.</p>
      </div>
      <div class=""d-grid contact section-gap"">
        <div class=""contact-info-left d-grid"">
          <div class=""contact-info"">
            <div class=""icon"">
              <span class=""fa fa-location-arrow"" aria-hidden=""true""></span>
            </div>
            <div class=""contact-details"">
              <h4>Địa Chỉ Liên Lạc</h4>
              <p>54 Nguyễn Lương Bằng, Hòa Khánh Bắc, Liên Chiểu, Đà Nẵng, Việt Nam</p>
            </div>
          </div>
   ");
            WriteLiteral(@"       <div class=""contact-info"">
            <div class=""icon"">
              <span class=""fa fa-phone"" aria-hidden=""true""></span>
            </div>
            <div class=""contact-details"">
              <h4>Điện Thoại</h4>
              <p><a href=""tel:+84932502578"">+84932502578</a></p>
            </div>
          </div>
          <div class=""contact-info"">
            <div class=""icon"">
              <span class=""fa fa-envelope-open-o"" aria-hidden=""true""></span>
            </div>
            <div class=""contact-details"">
              <h4>Email</h4>
              <!-- <p><a href=""mailto:info@masterwork.com"" class=""email"">info@masterwork.com</a></p> -->
              <p><a href=""mailto:support@zeroxteam.com"" class=""email"">support@zeroxteam.com</a></p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class=""map"">
    <iframe
      src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3833.8396925331817!2d108.14772551466335!3d16.07380");
            WriteLiteral(@"6443585205!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x314218d68e8ccb03%3A0x64dc2cb3e38bbdaf!2zNTQgTmd1eeG7hW4gTMawxqFuZyBC4bqxbmcsIEhvw6AgS2jDoW5oIELhuq9jLCBMacOqbiBDaGnhu4N1LCDEkMOgIE7hurVuZyA1NTAwMDAsIFZp4buHdCBOYW0!5e0!3m2!1svi!2s!4v1631776350158!5m2!1svi!2s""
      frameborder=""0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4378, "\"", 4396, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n  </div>\r\n</section>\r\n<!-- //contact form -->");
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

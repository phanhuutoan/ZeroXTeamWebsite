#pragma checksum "/home/app/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b52110deea86b82ab548881aecab170f4b44270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/app/Views/_ViewImports.cshtml"
using ZeroXTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/app/Views/_ViewImports.cshtml"
using ZeroXTeam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/app/Views/Home/Index.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/app/Views/Home/Index.cshtml"
using ZeroXTeam.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/app/Views/Home/Index.cshtml"
using ZeroXTeam.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b52110deea86b82ab548881aecab170f4b44270", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid shadow img-curve"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block zoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/home/app/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Trang chủ, nơi mọi người học cùng nhau :D";
    ViewData["ActiveMenu"] = ActiveMenu.Home;
    
    var information = ViewData["Information"] as HomePageInformation;
    var heroUrl = Html.Raw(information?.HeroUrl);
    var showedProjects = ViewData["ShowedProjects"] as List<Project>;
    var listOfActivites = new List<TeamActivity>()
    {
      new TeamActivity("/images/sprite.svg#icon-graduation-cap", "Teaching", "Học tập và thực hành dự án thực tế, cung cấp kiến thức nền tảng."),
      new TeamActivity("/images/sprite.svg#icon-quill", "Learning", "Nghiêm túc học tập và tiếp thu kiến thức một cách chủ động."),
      new TeamActivity("/images/sprite.svg#icon-redeem", "Sharing", "Sẵn sàng chia sẻ những kiến thức bạn có."),
      new TeamActivity("/images/sprite.svg#icon-cogs", "Training", "Liên tục đào tạo và bổ sung kỹ năng cần thiết về mọi lĩnh vực trong CNTT."),
      new TeamActivity("/images/sprite.svg#icon-user-tie", "Working", "Áp dụng những kỹ năng đã học để làm việc, thực hành những dự án thực tế."),
      new TeamActivity("/images/sprite.svg#icon-stats", "Doing Project", "Biến ý tưởng thành một dự án thực tế hoặc tham gia những dự án thực tế với đầy đủ độ phức tạp cũng như đa dạng về công nghệ."),
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("  <!--/header-->\r\n  <!-- index-block1 -->\r\n  <section class=\"w3l-hero-area\">\r\n    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1466, "\"", 1482, 1);
#nullable restore
#line 25 "/home/app/Views/Home/Index.cshtml"
WriteAttributeValue("", 1474, heroUrl, 1474, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"heroImgInput\">\r\n    <div class=\"content\" \r\n        id=\"heroImg\">\r\n      <div class=\"container\">\r\n        <div class=\"row align-items-center\">\r\n          <div class=\"col-md-6 col-sm-8 content-left\">\r\n            <h1 class=\"mb-3\">\r\n              ");
#nullable restore
#line 32 "/home/app/Views/Home/Index.cshtml"
         Write(information?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n            <p class=\"mb-lg-5 mb-4\"> ");
#nullable restore
#line 34 "/home/app/Views/Home/Index.cshtml"
                                Write(information?.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
            <a href=""/contact"" class=""btn btn-white"">Get Started</a>
          </div>
        </div>
        <div class=""clear""></div>
      </div>
    </div>
  </section>
  <!-- //index-block1 -->
  <!-- index-block2 -->
  <section class=""w3l-passion py-5"">
    <div class=""container py-md-3"">
      <div class=""header-section text-center mx-auto"">
        <h6 class=""sub-title mb-3"">Our main activities</h6>
        <h1>Hoạt động</h1>
        <p class=""my-3""> 
          <strong>
              ZeroX Team mang lại những kiến thức nền tảng về lĩnh vực Công nghệ thông tin,cùng với sự phát triển và đào tạo
              nguồn nhân lực,tạo ra những sản phẩm phục vụ cộng đồng, doanh nghiệp và xã hội theo phương châm: Đơn giản - Dễ 
              dàng - Sáng tạo - Hiệu quả.
          </strong> 
        </p>
      </div>
      <div class=""row bottom_grids text-center"">
");
#nullable restore
#line 58 "/home/app/Views/Home/Index.cshtml"
         foreach (var activity in listOfActivites)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-4 col-md-6 mt-5\">\r\n            <div class=\"s-block\">\r\n              <a href=\"/about\" class=\"d-block\">\r\n                <svg style=\"fill: #eb5d6a; height: 7.5rem; width: 7.5rem;\">\r\n                  <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 3040, "\"", 3070, 1);
#nullable restore
#line 64 "/home/app/Views/Home/Index.cshtml"
WriteAttributeValue("", 3053, activity.SvgLink, 3053, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </svg>\r\n                <h2 class=\"my-3\">");
#nullable restore
#line 66 "/home/app/Views/Home/Index.cshtml"
                            Write(activity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p");
            BeginWriteAttribute("class", " class=\"", 3171, "\"", 3179, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "/home/app/Views/Home/Index.cshtml"
                       Write(activity.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              </a>\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 71 "/home/app/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      </div>
    </div>
  </section>

  <section class=""w3l-values py-5"">
    <div class=""container py-lg-3 mt-3"">
      <div class=""row align-items-center"">
        <div class=""col-lg-6 book-info pr-lg-5"">
          <h6 class=""sub-title mb-3"">Our main values</h6>
          <h1 class=""mb-md-4 mb-3"">Giá trị chúng tôi đem lại</h1>
          <p class=""mb-md-5 mb-4"">ZeroX team thành lập với giá trị cốt lõi là mong muốn đem đến một cộng đồng học tập và chia sẻ kiến thức hữu ích, giá trị dành cho tất cả những người có đam mê tìm hiểu về lập trình, quan tâm đến ngôn ngữ máy và trí tuệ nhân tạo. Đến với ZeroX, bạn sẽ được trải nghiệm và học hỏi ở môi trường năng động, đầy nhiệt huyết, sáng tạo, nơi mọi người cùng chia sẻ, cùng  giúp đỡ nhau phát triển và xây dựng những dự án ý nghĩa dành cho cộng đồng - nơi mọi người sống tốt hơn, tiện lợi hơn, an toàn hơn nhờ vào công nghệ. </p>
          <a href=""/projects"" class=""btn btn-primary theme-button"">Tìm hiểu thêm</a>
        </div>
        <div class=""col-lg");
            WriteLiteral("-6 pl-lg-5 mt-lg-0 mt-5\">\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b52110deea86b82ab548881aecab170f4b4427011646", async() => {
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
      </div>
    </div>
  </section>
  
  <section class=""w3l-stats pb-5 pt-4"" id=""stats"">
    <div class=""gallery-inner container pb-lg-3"">
      <div class=""row stats-con text-white"">
        <div class=""col-lg-4 col-sm-6"">
          <div class=""stats_info counter_grid"">
            <h4>Thành Viên</h4>
            <p class=""counter""> ");
#nullable restore
#line 98 "/home/app/Views/Home/Index.cshtml"
                           Write(ViewData["NumberOfMembers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
            <p>Số lượng đối với chúng tôi không quan trọng mà chủ yếu là chất lượng thành viên, bạn có muốn trở thành một trong chúng tôi?</p>
          </div>
        </div>
        <div class=""col-lg-4 col-sm-6 mt-sm-0 mt-4"">
          <div class=""stats_info counter_grid1"">
            <h4>Giải Thưởng</h4>
            <p class=""counter"">7</p>
            <p>ZeroX cùng đồng đội đã tham gia và đạt nhiều giải thưởng danh giá trong các cuộc thi cho sinh viên, hackathon, và nhiều sự kiện khác</p>
          </div>
        </div>
        <div class=""col-lg-4 col-sm-6 mt-lg-0 mt-sm-5 mt-4"">
          <div class=""stats_info counter_grid"">
            <h4>Dự Án</h4>
            <p class=""counter""> ");
#nullable restore
#line 112 "/home/app/Views/Home/Index.cshtml"
                           Write(ViewData["NumberOfProjects"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>Dự án của chúng tôi trải dài từ quy mô trường học, đồ án cho tới tầm doanh nghiệp vừa và nhỏ cùng với nhiều loại công nghệ khác nhau.</p>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>\r\n  \r\n");
            WriteLiteral(@"
  <!-- Projects Section -->
  <section class=""w3l-projects py-5"">
      <div class=""container py-lg-3"">
        <div class=""header-section text-center mx-auto"">
          <h6 class=""sub-title mb-3"">Our projects</h6>
          <h1>Dự Án Đã Hoàn Thành</h1>
          <p class=""my-3 mb-5""> Dưới đây là một số dự án tiêu biểu của đội ngũ chúng tôi </p>
        </div>
        <div class=""grid-view"">
");
#nullable restore
#line 147 "/home/app/Views/Home/Index.cshtml"
           foreach (var project in showedProjects)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"grid-item\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b52110deea86b82ab548881aecab170f4b4427015307", async() => {
                WriteLiteral("\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 7287, "\"", 7310, 1);
#nullable restore
#line 153 "/home/app/Views/Home/Index.cshtml"
WriteAttributeValue("", 7293, project.PhotoUrl, 7293, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"photo\" class=\"img-fluid news-image\" />\r\n                <div class=\"project-info\">\r\n                  <h4 class=\"mb-3\">");
#nullable restore
#line 155 "/home/app/Views/Home/Index.cshtml"
                              Write(project.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                  <p class=\"line-clamp-2 mb-3\">");
#nullable restore
#line 156 "/home/app/Views/Home/Index.cshtml"
                                          Write(project.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "/home/app/Views/Home/Index.cshtml"
                  WriteLiteral(project.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>              \r\n");
#nullable restore
#line 160 "/home/app/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n      </div>\r\n  </section>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
  <section class=""w3l-mission py-5"">
    <div class=""container py-md-3 text-center"">
      <div class=""header-section text-center mx-auto"">
        <h6 class=""sub-title mb-3"">Our mission</h6>
        <h1>ZeroX và sứ mệnh</h1>
        <p class=""my-3"">ZeroX Team luôn làm việc với sứ mệnh: tập trung vào việc phát triển con người, đào tạo nguồn nhân lực chất lượng cao, luôn đổi mới và sáng tạo, luôn quan tâm đến sự cống hiến cho cộng đồng và cả sự phát triển của đội ngũ nhân sự, trở thành bệ phóng startup thành công cho sinh viên nói riêng và bất cứ ai mong muốn phát triển bản thân trong ngành CNTT.</p>
      </div>
    </div>
  </section>

  <script>
      const input = document.querySelector(""#heroImgInput"");
      const div = document.querySelector(""#heroImg"");

      div.style.backgroundImage = `url(${input.value})`
  </script>");
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

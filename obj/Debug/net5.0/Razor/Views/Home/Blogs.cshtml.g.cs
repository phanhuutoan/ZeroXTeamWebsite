#pragma checksum "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67713ede76f3b3f828148d48502c3c1989523aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blogs), @"mvc.1.0.view", @"/Views/Home/Blogs.cshtml")]
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
#line 1 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
using ZeroXTeam.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
using ZeroXTeam.Models.Partials;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
using ZeroXTeam.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67713ede76f3b3f828148d48502c3c1989523aae", @"/Views/Home/Blogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "components/_ClientSorting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "components/_ClientPagination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
  
  var newestBlogs = ViewData["NewestBlogs"] as List<Blog>;
  var remainingBlogs = ViewData["RemainingBlogs"] as PaginationList<Blog>;
  var random = new Random();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav id=""breadcrumbs"" class=""breadcrumbs"">
  <div class=""container page-wrapper"">
    <a href=""/"">Trang chủ</a> » <span class=""breadcrumb_last"" aria-current=""page"">Bài viết</span>
  </div>
</nav>
<!-- /about breadcrumbs -->

<style>
  .remaining__blog {
    display: flex;
    margin-bottom: 2rem;
    
    box-shadow: -2px 9px 15px 0px rgba(0,0,0,0.1);
    transition: all .2s;
    border-radius: .5rem;
    position: relative;
  }

  .remaining__blog:hover {
    box-shadow: -2px 9px 22px 0px rgba(0,0,0,0.25);
  }

  .remaining__views {
    position: absolute;
    top: 1.5rem;
    right: 1.5rem;
  }

  .remaining__view i {
    color: #dc4f72;
    font-size: 2rem;
  }

  .remaining__blog img {
    height: 13rem;
    border-top-left-radius: .5rem;
    border-bottom-left-radius: .5rem;
  }

  .remaining__content{
    padding: 2rem 1.7rem;
    width: 100%;
  }

  .remaining__content h4 {
    color: #dc4f72;
  }

  .remaining__content h6 {
    color: #777
  }

  #");
            WriteLiteral(@"blog .theme-button {
    width: 10rem;
  }

  #blog select {
    height: 3.1rem;
    width: 100%;
  }

</style>
<!-- projects section -->
<section class=""w3l-projects py-5"">
    <div class=""container principles-grids principles-grids1 py-lg-3"">
      <div class=""header-section mb-5 text-center mx-auto"">
        <h6 class=""sub-title mb-3 p-3"">Chia sẻ kiến thức, kinh nghiệm</h6>
        <h1>Bài viết</h1>
        <p class=""my-3""> Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;
          Nulla mollis dapibus nunc, ut rhoncus
          turpis sodales quis. Integer sit amet mattis quam.</p>
      </div>
      <div class=""blog-container mb-5"">

");
#nullable restore
#line 85 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
         foreach (var blog in newestBlogs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"blog-item\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2098, "\"", 2120, 2);
            WriteAttributeValue("", 2105, "/blogs/", 2105, 7, true);
#nullable restore
#line 88 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
WriteAttributeValue("", 2112, blog.Id, 2112, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"zoom\">\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 2155, "\"", 2175, 1);
#nullable restore
#line 89 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
WriteAttributeValue("", 2161, blog.PhotoUrl, 2161, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2176, "\"", 2182, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n              <div class=\"card-info p-3\">\r\n                <h4 class=\"mb-3\">");
#nullable restore
#line 91 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                            Write(blog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"line-clamp-2 mb-3\">");
#nullable restore
#line 92 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                                        Write(blog.Brief);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h5>");
#nullable restore
#line 93 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
               Write(blog.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Ngày xuất bản: ");
#nullable restore
#line 93 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                                            Write(blog.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n              </div>\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 97 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      </div>
    </div>
    <!-- /projects section -->
    
    <div class=""container principles-grids principles-grids1 py-lg-3"" id=""blog"">
      <hr>
      <div class=""header-section mb-5 text-center mx-auto"">
        <h1 class=""mt-4"">Các bài viết khác</h1>
        <p class=""my-3""> Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;
          Nulla mollis dapibus nunc, ut rhoncus
          turpis sodales quis. Integer sit amet mattis quam.</p>
      </div>

");
#nullable restore
#line 111 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
          
          var sortingModel = new ClientSorting()
          {
            AspAction = "GetBlogs",
            AspController = "Home",
            CurrentPage = remainingBlogs.CurrentPage,
            SortBy = remainingBlogs.SortBy,
            SortingOptions = new List<SortingOption>()
              {
                new SortingOption("Name", "Tên của dự án"),
                new SortingOption("CreatedAt", "Ngày xuất bản"),
                new SortingOption("UpdatedAt", "Ngày cập nhật"),
                new SortingOption("Author", "Tác giả"),
              }
          };
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67713ede76f3b3f828148d48502c3c1989523aae9900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 128 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = sortingModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n         \r\n      <div class=\"remaining\">\r\n");
#nullable restore
#line 131 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
         foreach (var blog in remainingBlogs)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("          <a");
            BeginWriteAttribute("href", " href=\"", 3859, "\"", 3881, 2);
            WriteAttributeValue("", 3866, "/blogs/", 3866, 7, true);
#nullable restore
#line 134 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
WriteAttributeValue("", 3873, blog.Id, 3873, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"remaining__blog\">\r\n              <div class=\"remaining__views\">\r\n                <span class=\"mr-2\"> ");
#nullable restore
#line 137 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                               Write(blog.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                <i class=\"fa fa-eye\"></i>\r\n              </div>\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 4114, "\"", 4134, 1);
#nullable restore
#line 140 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
WriteAttributeValue("", 4120, blog.PhotoUrl, 4120, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"photo url\">\r\n              <div class=\"remaining__content\">\r\n                <h4 class=\"mb-3\">");
#nullable restore
#line 142 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                            Write(blog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"line-clamp-2 mb-3\">");
#nullable restore
#line 143 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                                        Write(blog.Brief);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h6>Tác giả: <strong>");
#nullable restore
#line 144 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                                Write(blog.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <br> (Ngày xuất bản: ");
#nullable restore
#line 144 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
                                                                           Write(blog.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h6>\r\n              </div>\r\n            </div>  \r\n          </a>\r\n");
#nullable restore
#line 148 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n        </div>\r\n        \r\n");
#nullable restore
#line 152 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
        
      var paginationModel = new ClientPagination() 
        {
          AspAction = "GetBlogs",
          AspController = "Home",
          CurrentPage = remainingBlogs.CurrentPage,
          TotalPages = remainingBlogs.TotalPages,
          SortBy = remainingBlogs.SortBy,
        };
      

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67713ede76f3b3f828148d48502c3c1989523aae14817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 164 "F:\ZeroXTeamWebsite\Views\Home\Blogs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = paginationModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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

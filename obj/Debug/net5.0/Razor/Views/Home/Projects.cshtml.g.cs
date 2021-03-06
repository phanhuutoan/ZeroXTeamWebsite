#pragma checksum "/home/app/Views/Home/Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a188680fe3a77e3e44f127a26847fa1f8651f77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Projects), @"mvc.1.0.view", @"/Views/Home/Projects.cshtml")]
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
#line 1 "/home/app/Views/Home/Projects.cshtml"
using ZeroXTeam.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/app/Views/Home/Projects.cshtml"
using ZeroXTeam.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/app/Views/Home/Projects.cshtml"
using ZeroXTeam.Models.Partials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a188680fe3a77e3e44f127a26847fa1f8651f77", @"/Views/Home/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 5 "/home/app/Views/Home/Projects.cshtml"
  
  var projects = ViewData["Projects"] as PaginationList<Project>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
  .theme-button {
    padding-right: 14px;
    padding-left: 14px;
    height: 38px;
    transform: translateY(-2px);
    line-height: 1px;
  }
</style>
<nav id=""breadcrumbs"" class=""breadcrumbs"">
  <div class=""container page-wrapper"">
    <a href=""/"">Trang ch???</a> ?? <span class=""breadcrumb_last"" aria-current=""page"">D??? ??n</span>
  </div>
</nav>
<!-- projects section -->
<section class=""w3l-projects py-5"" style=""margin-top: 1rem"">
    <div class=""container principles-grids principles-grids1 py-lg-3"">
      <div class=""header-section mb-5 text-center mx-auto"">
        <h6 class=""sub-title mb-3"">Our projects</h6>
        <h3>D??? ??n ??ang ph??t tri???n</h3>
        <p class=""my-3""> D?????i ????y l?? c??c d??? ??n m?? team ZeroX ???? c??ng nhau ph??t tri???n</p>
      </div>

");
#nullable restore
#line 32 "/home/app/Views/Home/Projects.cshtml"
        
        var sortingModel = new ClientSorting()
        {
          AspAction = "Projects",
          AspController = "Home",
          CurrentPage = projects.CurrentPage,
          SortBy = projects.SortBy,
          SortingOptions = new List<SortingOption>()
            {
              new SortingOption("Name", "T??n c???a d??? ??n"),
              new SortingOption("StartDate", "Ng??y kh???i ?????ng d??? ??n"),
            }
        };
      

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a188680fe3a77e3e44f127a26847fa1f8651f775570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "/home/app/Views/Home/Projects.cshtml"
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
            WriteLiteral("</partial>\r\n      \r\n      <div class=\"grid-view mb-5\">\r\n");
#nullable restore
#line 51 "/home/app/Views/Home/Projects.cshtml"
         foreach (var project in projects)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"grid-item\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1657, "\"", 1685, 2);
            WriteAttributeValue("", 1664, "/projects/", 1664, 10, true);
#nullable restore
#line 54 "/home/app/Views/Home/Projects.cshtml"
WriteAttributeValue("", 1674, project.Id, 1674, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block zoom\">\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 1728, "\"", 1751, 1);
#nullable restore
#line 55 "/home/app/Views/Home/Projects.cshtml"
WriteAttributeValue("", 1734, project.PhotoUrl, 1734, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1752, "\"", 1758, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid news-image\" />\r\n              <div class=\"project-info\">\r\n                <h4 class=\"mb-3\">");
#nullable restore
#line 57 "/home/app/Views/Home/Projects.cshtml"
                            Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"line-clamp-2 mb-3\">");
#nullable restore
#line 58 "/home/app/Views/Home/Projects.cshtml"
                                        Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              </div>\r\n            </a>\r\n          </div>\r\n");
#nullable restore
#line 62 "/home/app/Views/Home/Projects.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n\r\n");
#nullable restore
#line 65 "/home/app/Views/Home/Projects.cshtml"
      
      var paginationModel = new ClientPagination() 
      {
        AspAction = "Projects",
        AspController = "Home",
        CurrentPage = projects.CurrentPage,
        TotalPages = projects.TotalPages,
        SortBy = projects.SortBy,
      };
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a188680fe3a77e3e44f127a26847fa1f8651f779480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 77 "/home/app/Views/Home/Projects.cshtml"
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
            WriteLiteral("</partial>\r\n\r\n    </div>\r\n</section>\r\n<!-- /projects section -->");
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

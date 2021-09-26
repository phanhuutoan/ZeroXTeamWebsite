#pragma checksum "/home/app/Views/AdminBlog/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ee8c65b0678e344b6e5757df60bf239c374a4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminBlog_Index), @"mvc.1.0.view", @"/Views/AdminBlog/Index.cshtml")]
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
#line 1 "/home/app/Views/AdminBlog/Index.cshtml"
using ZeroXTeam.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/app/Views/AdminBlog/Index.cshtml"
using ZeroXTeam.Models.Partials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ee8c65b0678e344b6e5757df60bf239c374a4e", @"/Views/AdminBlog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "components/_EditDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "components/_PaginationAndSorting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/home/app/Views/AdminBlog/Index.cshtml"
  
  var listOfBlogs = ViewData["Blogs"] as PaginationList<ZeroXTeam.Entities.Blog>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n  .table td {\r\n    vertical-align: middle !important;\r\n  }\r\n\r\n  .table th {\r\n    vertical-align: middle !important;\r\n  }\r\n</style>\r\n\r\n<div class=\"container mt-4\">\r\n  <h2>\r\n    Blog lists\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11ee8c65b0678e344b6e5757df60bf239c374a4e5374", async() => {
                WriteLiteral("\r\n      Create one\r\n    ");
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
  </h2>
  <div>
    <table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Photo</th>
      <th scope=""col"">Brief</th>
      <th scope=""col"">Created At</th>
      <th scope=""col"">Updated At</th>
      <th scope=""col"">Edit / Delete</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 39 "/home/app/Views/AdminBlog/Index.cshtml"
     foreach (var blog in listOfBlogs)
    {
      var editDeleteModel = new ZeroXTeam.Models.Partials.EditDelete()
      {
        AspAction = "GetEdit",
        AspController = "AdminBlog",
        RouteId = blog.Id,
        DeleteRoute ="/admin/blogs/delete/"
      };


#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <th scope=\"row\">");
#nullable restore
#line 50 "/home/app/Views/AdminBlog/Index.cshtml"
                   Write(blog?.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <td>");
#nullable restore
#line 51 "/home/app/Views/AdminBlog/Index.cshtml"
       Write(blog?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          <img");
            BeginWriteAttribute("src", " src=\"", 1230, "\"", 1251, 1);
#nullable restore
#line 53 "/home/app/Views/AdminBlog/Index.cshtml"
WriteAttributeValue("", 1236, blog?.PhotoUrl, 1236, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"photo\" height=\"100\" class=\"img-thumbnail\" style=\"height: 7rem;\">\r\n        </td>\r\n        <td style=\"max-width: 15rem;\">");
#nullable restore
#line 55 "/home/app/Views/AdminBlog/Index.cshtml"
                                 Write(blog?.Brief);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 56 "/home/app/Views/AdminBlog/Index.cshtml"
       Write(blog?.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 57 "/home/app/Views/AdminBlog/Index.cshtml"
       Write(blog?.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11ee8c65b0678e344b6e5757df60bf239c374a4e9165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 61 "/home/app/Views/AdminBlog/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = editDeleteModel;

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
            WriteLiteral("</partial>\r\n\r\n        </td>\r\n      </tr>\r\n");
#nullable restore
#line 65 "/home/app/Views/AdminBlog/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n  </div>\r\n</div>\r\n");
#nullable restore
#line 70 "/home/app/Views/AdminBlog/Index.cshtml"
  
  var paginationModel = new PaginationAndSort()
  {
    CurrentPage = listOfBlogs.CurrentPage,
    ItemPerPage = listOfBlogs.ItemPerPage,
    TotalPages = listOfBlogs.TotalPages,
    SortBy = listOfBlogs.SortBy,
    AspController= "AdminBlog",
    SortOptions = new List<SortOption>()
    {
      new SortOption("Id", "By Id"),
      new SortOption("Name", "By Name"),
      new SortOption("CreatedAt", "By Created Date"),
      new SortOption("Updated", "By Updated Date"),
      new SortOption("Author", "By Author"),
      new SortOption("View", "By View"),
    }
  };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11ee8c65b0678e344b6e5757df60bf239c374a4e11631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 90 "/home/app/Views/AdminBlog/Index.cshtml"
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
            WriteLiteral("</partial>");
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

#pragma checksum "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c08549788cd5498171e3f0e86ebff8419046254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMember_Index), @"mvc.1.0.view", @"/Views/AdminMember/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
using ZeroXTeam.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
using ZeroXTeam.Models.Partials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c08549788cd5498171e3f0e86ebff8419046254", @"/Views/AdminMember/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMember_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
  
  var listOfMember = ViewData["Members"] as PaginationList<ZeroXTeam.Entities.Member>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n  .table td {\r\n    vertical-align: middle !important;\r\n  }\r\n\r\n  .table th {\r\n    vertical-align: middle !important;\r\n  }\r\n</style>\r\n\r\n<div class=\"container mt-4\">\r\n  <h2>\r\n    Member lists\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c08549788cd5498171e3f0e86ebff84190462545677", async() => {
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
      <th scope=""col"">Image</th>
      <th scope=""col"">Date Of Birth</th>
      <th scope=""col"">Joined At</th>
      <th scope=""col"">Show for client</th>
      <th scope=""col"">Edit / Delete</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 38 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
     foreach (var member in listOfMember)
    {
      var editDeleteModel = new ZeroXTeam.Models.Partials.EditDelete()
      {
        AspAction = "GetEdit",
        AspController = "AdminMember",
        RouteId = member.Id,
        DeleteRoute ="/admin/members/delete/"
      };

      var alertClass = !member.ShowForClient ? "alert-danger" : "alert-success";


#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <th scope=\"row\">");
#nullable restore
#line 51 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
                   Write(member?.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <td>");
#nullable restore
#line 52 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
       Write(member?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          <img");
            BeginWriteAttribute("src", " src=\"", 1347, "\"", 1370, 1);
#nullable restore
#line 54 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
WriteAttributeValue("", 1353, member?.PhotoUrl, 1353, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"photo\" height=\"100\" class=\"img-thumbnail\" style=\"height: 7rem;\">\r\n        </td>\r\n        <td>");
#nullable restore
#line 56 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
       Write(member?.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 57 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
       Write(member?.JoinedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          <p");
            BeginWriteAttribute("class", " class=\"", 1559, "\"", 1584, 2);
            WriteAttributeValue("", 1567, "alert", 1567, 5, true);
#nullable restore
#line 59 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
WriteAttributeValue(" ", 1572, alertClass, 1573, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Show status </p>\r\n        </td>\r\n        <td>\r\n\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c08549788cd5498171e3f0e86ebff841904625410110", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 64 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
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
#line 68 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n  </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 74 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
  
  var paginationModel = new PaginationAndSort()
  {
    CurrentPage = listOfMember.CurrentPage,
    ItemPerPage = listOfMember.ItemPerPage,
    TotalPages = listOfMember.TotalPages,
    SortBy = listOfMember.SortBy,
    AspController = "AdminMember",
    SortOptions = new List<SortOption>()
    {
      new SortOption("Id", "By Id"),
      new SortOption("Name", "By Name"),
      new SortOption("TeamTitle", "Member 's Title"),
      new SortOption("DateOfBirth", "By Date of birth"),
      new SortOption("JoinedAt", "Day that member joined"),
    }
  };

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c08549788cd5498171e3f0e86ebff841904625412740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 93 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\AdminMember\Index.cshtml"
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
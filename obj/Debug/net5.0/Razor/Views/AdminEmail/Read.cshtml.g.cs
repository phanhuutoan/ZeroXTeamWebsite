#pragma checksum "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf6aced57eb13a384e57469f6494a9733772aca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminEmail_Read), @"mvc.1.0.view", @"/Views/AdminEmail/Read.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf6aced57eb13a384e57469f6494a9733772aca", @"/Views/AdminEmail/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminEmail_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml"
  
  var letter = ViewData["Letter"] as ZeroXTeam.Entities.Contact;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top: 5rem;\">\r\n  <h3>Letter from ");
#nullable restore
#line 6 "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml"
             Write(letter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n  <small>Send At: ");
#nullable restore
#line 7 "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml"
             Write(letter.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n  <div style=\"margin-top: 3rem;\">\r\n    <div class=\"mb-4\">\r\n      <h5>Email:</h5>\r\n      <p>");
#nullable restore
#line 11 "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml"
    Write(letter.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"mb-4\">\r\n      <h5>Subject:</h5>\r\n      <p>");
#nullable restore
#line 15 "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml"
    Write(letter.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"mb-4\">\r\n      <h5>Content:</h5>\r\n      <p>");
#nullable restore
#line 19 "F:\ZeroXTeamWebsite\Views\AdminEmail\Read.cshtml"
    Write(letter.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n  </div>\r\n</div>");
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

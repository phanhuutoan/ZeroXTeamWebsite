#pragma checksum "/home/app/Views/AdminEmail/Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e90193f3e9ce02b15e8f4b9237e63ebc13fc83c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e90193f3e9ce02b15e8f4b9237e63ebc13fc83c", @"/Views/AdminEmail/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ef9636db1140519afc6c199c75484633cb83ca", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminEmail_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/app/Views/AdminEmail/Read.cshtml"
  
  var letter = ViewData["Letter"] as ZeroXTeam.Entities.Contact;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\" style=\"margin-top: 5rem;\">\n  <h3>Letter from ");
#nullable restore
#line 6 "/home/app/Views/AdminEmail/Read.cshtml"
             Write(letter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n  <small>Send At: ");
#nullable restore
#line 7 "/home/app/Views/AdminEmail/Read.cshtml"
             Write(letter.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n  <div style=\"margin-top: 3rem;\">\n    <div class=\"mb-4\">\n      <h5>Email:</h5>\n      <p>");
#nullable restore
#line 11 "/home/app/Views/AdminEmail/Read.cshtml"
    Write(letter.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <div class=\"mb-4\">\n      <h5>Subject:</h5>\n      <p>");
#nullable restore
#line 15 "/home/app/Views/AdminEmail/Read.cshtml"
    Write(letter.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <div class=\"mb-4\">\n      <h5>Content:</h5>\n      <p>");
#nullable restore
#line 19 "/home/app/Views/AdminEmail/Read.cshtml"
    Write(letter.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n  </div>\n</div>");
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

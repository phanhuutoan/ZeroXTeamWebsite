#pragma checksum "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e51bd7183a81aac924e1f985f5ec932c3416b134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_components__EditableRichText), @"mvc.1.0.view", @"/Views/Shared/components/_EditableRichText.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51bd7183a81aac924e1f985f5ec932c3416b134", @"/Views/Shared/components/_EditableRichText.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c036fba8911336508770ec72b0606b66737239", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_components__EditableRichText : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZeroXTeam.Models.Partials.EditableRichTextEditor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 64, "\"", 84, 1);
#nullable restore
#line 3 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
WriteAttributeValue("", 69, Model.EditorId, 69, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n  <p>Hello World!</p>\r\n  <p>Some initial <strong>bold</strong> text</p>\r\n</div>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 189, "\"", 209, 1);
#nullable restore
#line 7 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
WriteAttributeValue("", 196, Model.AspFor, 196, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 210, "\"", 234, 1);
#nullable restore
#line 7 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
WriteAttributeValue("", 218, Model.FormValue, 218, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<!-- Initialize Quill editor -->\r\n<script>\r\n  dynamicVar[\"quill\" + \"");
#nullable restore
#line 10 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                   Write(Model.EditorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"] = new Quill(\'#");
#nullable restore
#line 10 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                                                   Write(Model.EditorId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', {
    theme: 'snow',
    modules: {
      toolbar: [
        ['bold', 'italic', 'underline', 'strike'],        // toggled buttons
        ['blockquote', 'code-block'],

        [{ 'header': 1 }, { 'header': 2 }],               // custom button values
        [{ 'list': 'ordered'}, { 'list': 'bullet' }],
        [{ 'script': 'sub'}, { 'script': 'super' }],      // superscript/subscript
        [{ 'indent': '-1'}, { 'indent': '+1' }],          // outdent/indent
        [{ 'direction': 'rtl' }],                         // text direction
        [{ 'header': [1, 2, 3, 4, 5, 6, false] }],

        [{ 'color': [] }, { 'background': [] }],          // dropdown with defaults from theme
        [{ 'font': [] }],
        [{ 'align': [] }],

        ['clean']                                         // remove formatting button
      ]
    },
  });

  if (document.querySelector(""[name=");
#nullable restore
#line 33 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                               Write(Model.AspFor);

#line default
#line hidden
#nullable disable
            WriteLiteral("]\").value) {\r\n    dynamicVar[\"quill\" + \"");
#nullable restore
#line 34 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                     Write(Model.EditorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"].setContents(\r\n      JSON.parse(document.querySelector(\"[name=");
#nullable restore
#line 35 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                                          Write(Model.AspFor);

#line default
#line hidden
#nullable disable
            WriteLiteral("]\").value)\r\n    );\r\n  }\r\n\r\n  dynamicVar[\"quill\" + \"");
#nullable restore
#line 39 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                   Write(Model.EditorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"].on(\'editor-change\', () => {\r\n    document.querySelector(\"[name=");
#nullable restore
#line 40 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                             Write(Model.AspFor);

#line default
#line hidden
#nullable disable
            WriteLiteral("]\").value = JSON.stringify(dynamicVar[\"quill\" + \"");
#nullable restore
#line 40 "C:\Users\Toan\OneDrive\Documents\ZeroXTeam\Views\Shared\components\_EditableRichText.cshtml"
                                                                                           Write(Model.EditorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"].getContents().ops)\r\n  })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZeroXTeam.Models.Partials.EditableRichTextEditor> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa440b34d51c9af72853051809dcaabffebf085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Header_header), @"mvc.1.0.view", @"/Views/List/Header/header.cshtml")]
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
#line 1 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\_ViewImports.cshtml"
using _7fotograf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\_ViewImports.cshtml"
using _7fotograf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa440b34d51c9af72853051809dcaabffebf085", @"/Views/List/Header/header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d4b1428f1b4d519d890477257d74f72bef979b", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Header_header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FacebookLogin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar is-mobile is-fixed-top\">\r\n  <div class=\"navbar-brand\">\r\n       <a");
            BeginWriteAttribute("href", " href=\"", 112, "\"", 146, 1);
#nullable restore
#line 4 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml"
WriteAttributeValue("", 119, Url.Action("login","List"), 119, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 152, "\"", 207, 1);
#nullable restore
#line 4 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml"
WriteAttributeValue("", 158, Url.Content("~/Contents/img/7fotograf-logo.png"), 158, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n  </div>\r\n  <div class=\"navbar-end is-mobile\">\r\n");
#nullable restore
#line 7 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml"
      foreach (var item in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <h1 class=\"login-info\">");
#nullable restore
#line 9 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml"
                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </div>\r\n     <a id=\"upload\" href=\"#\">Fotoğraf Yükle</a>\r\n  </div>\r\n</nav>\r\n");
#nullable restore
#line 15 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\List\Header\header.cshtml"
Write(await Component.InvokeAsync("listmodal"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FacebookLogin>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Category\Header\header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e72a9f6fb40f74cd8b72d8b526816211489ac6ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Header_header), @"mvc.1.0.view", @"/Views/Category/Header/header.cshtml")]
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
#nullable restore
#line 1 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Category\Header\header.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e72a9f6fb40f74cd8b72d8b526816211489ac6ec", @"/Views/Category/Header/header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d4b1428f1b4d519d890477257d74f72bef979b", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Header_header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar is-mobile is-fixed-top\">\r\n  <div class=\"navbar-brand\">\r\n       <a");
            BeginWriteAttribute("href", " href=\"", 118, "\"", 152, 1);
#nullable restore
#line 4 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Category\Header\header.cshtml"
WriteAttributeValue("", 125, Url.Action("login","List"), 125, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 158, "\"", 213, 1);
#nullable restore
#line 4 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Category\Header\header.cshtml"
WriteAttributeValue("", 164, Url.Content("~/Contents/img/7fotograf-logo.png"), 164, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"7fotograflogo\" /></a>\r\n  </div>\r\n  <div class=\"navbar-end\">\r\n        <a style=\"color: red;\">");
#nullable restore
#line 7 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Category\Header\header.cshtml"
                          Write(Context.Session.GetString("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n  </div>\r\n</nav>");
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

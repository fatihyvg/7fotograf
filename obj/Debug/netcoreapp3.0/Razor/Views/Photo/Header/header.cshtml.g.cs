#pragma checksum "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Photo\Header\header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd0d98f1008dcc7a66e8e2c875639ff4275af9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_Header_header), @"mvc.1.0.view", @"/Views/Photo/Header/header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd0d98f1008dcc7a66e8e2c875639ff4275af9c8", @"/Views/Photo/Header/header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d4b1428f1b4d519d890477257d74f72bef979b", @"/Views/_ViewImports.cshtml")]
    public class Views_Photo_Header_header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar is-mobile is-fixed-top\">\r\n  <div class=\"navbar-brand\">\r\n       <a");
            BeginWriteAttribute("href", " href=\"", 84, "\"", 118, 1);
#nullable restore
#line 3 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Photo\Header\header.cshtml"
WriteAttributeValue("", 91, Url.Action("login","List"), 91, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 124, "\"", 179, 1);
#nullable restore
#line 3 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Photo\Header\header.cshtml"
WriteAttributeValue("", 130, Url.Content("~/Contents/img/7fotograf-logo.png"), 130, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n  </div>\r\n  <div class=\"navbar-end is-mobile\">\r\n         <h1 class=\"login-info\"></h1>\r\n     </div>\r\n  </div>\r\n</nav>");
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

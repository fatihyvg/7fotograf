#pragma checksum "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Home\Container\container.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f00930fbc575cb915ef965f235e6c935f14b7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Container_container), @"mvc.1.0.view", @"/Views/Home/Container/container.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f00930fbc575cb915ef965f235e6c935f14b7e", @"/Views/Home/Container/container.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d4b1428f1b4d519d890477257d74f72bef979b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Container_container : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ImagePosition>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\" style=\"margin-top: 130px;\">\r\n   <div class=\"columns is-mobile\">\r\n        <div class=\"column\">\r\n            <div id=\"homegallery\" class=\"justified-gallery\">\r\n");
#nullable restore
#line 6 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Home\Container\container.cshtml"
               foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <a><img");
            BeginWriteAttribute("src", " src=\"", 294, "\"", 315, 1);
#nullable restore
#line 8 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Home\Container\container.cshtml"
WriteAttributeValue("", 300, item.ImagePath, 300, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 316, "\"", 333, 1);
#nullable restore
#line 8 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Home\Container\container.cshtml"
WriteAttributeValue("", 322, item.Story, 322, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n");
#nullable restore
#line 9 "c:\Users\FTHY\Documents\VsCode Projects\7fotograf\Views\Home\Container\container.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div> \r\n        </div>\r\n   </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ImagePosition>> Html { get; private set; }
    }
}
#pragma warning restore 1591

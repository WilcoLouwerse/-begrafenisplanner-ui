#pragma checksum "K:\HTA Software\Common Ground\begrafenisplanner-ui\begrafenisplanner\begrafenisplanner\Views\Home\ReadGrave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a87876c57678d48c8d99813cdf320aa8df5de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReadGrave), @"mvc.1.0.view", @"/Views/Home/ReadGrave.cshtml")]
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
#line 1 "K:\HTA Software\Common Ground\begrafenisplanner-ui\begrafenisplanner\begrafenisplanner\Views\_ViewImports.cshtml"
using begrafenisplanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\HTA Software\Common Ground\begrafenisplanner-ui\begrafenisplanner\begrafenisplanner\Views\Home\ReadGrave.cshtml"
using begrafenisplanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a87876c57678d48c8d99813cdf320aa8df5de4", @"/Views/Home/ReadGrave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3d8ef90936719d6b1271618fe7e1effc272568", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReadGrave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "K:\HTA Software\Common Ground\begrafenisplanner-ui\begrafenisplanner\begrafenisplanner\Views\Home\ReadGrave.cshtml"
  
    ViewData["Title"] = "Graves";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div align=\"right\"><a");
            BeginWriteAttribute("href", " href=\"", 103, "\"", 143, 1);
#nullable restore
#line 8 "K:\HTA Software\Common Ground\begrafenisplanner-ui\begrafenisplanner\begrafenisplanner\Views\Home\ReadGrave.cshtml"
WriteAttributeValue("", 110, Url.Action("WriteGrave", "Home"), 110, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Add Grave</a></div>

<h5>Graves :</h5>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Grave ID</th>
            <th scope=""col"">Grave Covers</th>
            <th scope=""col"">Grave Reference</th>
            <th scope=""col"">Cemetery</th>
            <th scope=""col"">Location</th>
            <th scope=""col"">Position</th>
            <th scope=""col"">Grave Type</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Acquisition</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Date Created</th>
            <th scope=""col"">Date Modified</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
            <td>x</td>
        </tr>
    </");
            WriteLiteral("tbody>\r\n</table>");
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

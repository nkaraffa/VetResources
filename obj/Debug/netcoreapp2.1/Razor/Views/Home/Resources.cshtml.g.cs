#pragma checksum "D:\Project\VetResource\Views\Home\Resources.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a7096535ceb06caa1190c8cd4ac934304112ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resources), @"mvc.1.0.view", @"/Views/Home/Resources.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Resources.cshtml", typeof(AspNetCore.Views_Home_Resources))]
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
#line 1 "D:\Project\VetResource\Views\_ViewImports.cshtml"
using VetResource;

#line default
#line hidden
#line 2 "D:\Project\VetResource\Views\_ViewImports.cshtml"
using VetResource.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a7096535ceb06caa1190c8cd4ac934304112ab", @"/Views/Home/Resources.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c9be3dc43b2ffaa56c5c59fcfdf3020b5866f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resources : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VetResource.Models.ResCont>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project\VetResource\Views\Home\Resources.cshtml"
  
    ViewData["Title"] = "Resources";

#line default
#line hidden
            BeginContext(93, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(100, 17, false);
#line 6 "D:\Project\VetResource\Views\Home\Resources.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(129, 19, false);
#line 7 "D:\Project\VetResource\Views\Home\Resources.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 385, true);
            WriteLiteral(@"</h3>

<p>Commonly used Veterans Resources</p>

<br />

<table class=""table"">
    <thead>
        <tr>
            <th>
                Resource Name
            </th>
            <th>
                Website URL
            </th>
            <th>
                Contact Info
            </th>
            <th>Address</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 29 "D:\Project\VetResource\Views\Home\Resources.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(582, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(643, 43, false);
#line 33 "D:\Project\VetResource\Views\Home\Resources.cshtml"
               Write(Html.DisplayFor(model => item.ResourceName));

#line default
#line hidden
            EndContext();
            BeginContext(686, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(754, 41, false);
#line 36 "D:\Project\VetResource\Views\Home\Resources.cshtml"
               Write(Html.DisplayFor(model => item.WebsiteUrl));

#line default
#line hidden
            EndContext();
            BeginContext(795, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(863, 42, false);
#line 39 "D:\Project\VetResource\Views\Home\Resources.cshtml"
               Write(Html.DisplayFor(model => item.ContactInfo));

#line default
#line hidden
            EndContext();
            BeginContext(905, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(973, 38, false);
#line 42 "D:\Project\VetResource\Views\Home\Resources.cshtml"
               Write(Html.DisplayFor(model => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 45 "D:\Project\VetResource\Views\Home\Resources.cshtml"
        }

#line default
#line hidden
            BeginContext(1066, 165, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br />\r\n<br />\r\n\r\n<h3>Resource Highlights</h3>\r\n<p>Excellent Resources </p>\r\n<div class=\"row\">\r\n    <div class=\"text-center\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 1231, "\'", 1272, 1);
#line 56 "D:\Project\VetResource\Views\Home\Resources.cshtml"
WriteAttributeValue("", 1237, Url.Content("~/images/Sitrep.png"), 1237, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1273, 395, true);
            WriteLiteral(@" width=""300"" height=""300"" />
        <br />
        <a href=""https://www.sitreps2steercos.com/"">sitreps2steercos.com</a>
        <br />
        <div>Self proclaimed ""BEST FREE MILITARY TRANSITION PERSPECTIVE AVAILABLE."" </div>
        <div>This site provides advice and perspective on popular post-military careers.</div>
    </div>
    <br />
    <div class=""text-center"">
        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 1668, "\'", 1711, 1);
#line 65 "D:\Project\VetResource\Views\Home\Resources.cshtml"
WriteAttributeValue("", 1674, Url.Content("~/images/Veterati.png"), 1674, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1712, 341, true);
            WriteLiteral(@" width=""250"" height=""250"" />
        <br />
        <a href=""https://www.veterati.com/"">Veterati.com</a>
        <br />
        <div>Veterati is a free networking and mentoring site for veterans.</div>
        <div>Veterati provides a forum for veterans to network and prepare for transtion or just talk.</div>
    </div>
</div>


");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VetResource.Models.ResCont>> Html { get; private set; }
    }
}
#pragma warning restore 1591
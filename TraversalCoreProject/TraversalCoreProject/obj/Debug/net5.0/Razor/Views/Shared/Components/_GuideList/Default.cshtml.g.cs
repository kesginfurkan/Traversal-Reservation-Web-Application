#pragma checksum "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f281949c538a2bce860851385c752a2bb6197477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GuideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GuideList/Default.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f281949c538a2bce860851385c752a2bb6197477", @"/Views/Shared/Components/_GuideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__GuideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-12 col-xl-4\">\r\n    <div class=\"card h-100\">\r\n        <div class=\"card-header pb-0 p-3\">\r\n            <h6 class=\"mb-0\">Tur Rehberlerimiz</h6>\r\n        </div>\r\n        <div class=\"card-body p-3\">\r\n            <ul class=\"list-group\">\r\n");
#nullable restore
#line 11 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item border-0 d-flex align-items-center px-0 mb-2\">\r\n                    <div class=\"avatar me-3\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 530, "\"", 547, 1);
#nullable restore
#line 15 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml"
WriteAttributeValue("", 536, item.Image, 536, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"kal\" class=\"border-radius-lg shadow\">\r\n                    </div>\r\n                    <div class=\"d-flex align-items-start flex-column justify-content-center\">\r\n                        <h6 class=\"mb-0 text-sm\">");
#nullable restore
#line 18 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p class=\"mb-0 text-xs\">");
#nullable restore
#line 19 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <a class=\"btn btn-link pe-3 ps-0 mb-0 ms-auto\" href=\"javascript:;\">Profil</a>\r\n                </li>\r\n");
#nullable restore
#line 23 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_GuideList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591

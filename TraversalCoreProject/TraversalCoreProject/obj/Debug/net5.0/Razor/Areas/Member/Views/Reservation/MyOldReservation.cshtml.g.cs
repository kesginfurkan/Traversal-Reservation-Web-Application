#pragma checksum "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44855a92335aac9306c209fe4dfe8fab8cb80968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyOldReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyOldReservation.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44855a92335aac9306c209fe4dfe8fab8cb80968", @"/Areas/Member/Views/Reservation/MyOldReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74919c66fc5d7abbf773422e6378c6ac2193c755", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Reservation_MyOldReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
  
    ViewData["Title"] = "MyOldReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ge??mi?? Rezervasyonlar??m</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>#</td>\r\n        <td>Lokasyon</td>\r\n        <td>Ki??i Say??s??</td>\r\n        <td>Rezervasyon Tarihi</td>\r\n        <td>Durum</td>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
           Write(item.ReservationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
           Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\admin\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f9590bef15594d06dee55f8298b1de25b23449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentDetails_Index), @"mvc.1.0.view", @"/Views/PaymentDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f9590bef15594d06dee55f8298b1de25b23449", @"/Views/PaymentDetails/Index.cshtml")]
    #nullable restore
    public class Views_PaymentDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreditPaymentAPI.Models.PaymentDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardOwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SecurityCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardOwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SecurityCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1221, "\"", 1244, 1);
#nullable restore
#line 46 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
WriteAttributeValue("", 1236, item.Id, 1236, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1297, "\"", 1320, 1);
#nullable restore
#line 47 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
WriteAttributeValue("", 1312, item.Id, 1312, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1375, "\"", 1398, 1);
#nullable restore
#line 48 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
WriteAttributeValue("", 1390, item.Id, 1390, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\stchu\source\repos\CreditPaymentAPI\CreditPaymentAPI\Views\PaymentDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreditPaymentAPI.Models.PaymentDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

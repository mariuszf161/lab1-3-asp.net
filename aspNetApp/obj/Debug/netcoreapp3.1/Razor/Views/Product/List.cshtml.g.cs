#pragma checksum "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa9e912e2fa1cba870d9909d88ddb7ab873e443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\_ViewImports.cshtml"
using aspNetApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa9e912e2fa1cba870d9909d88ddb7ab873e443", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41587a17c9e147a5c604184a56c00db3c3c7efe", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\Product\List.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 10 "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\Product\List.cshtml"
       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        ");
#nullable restore
#line 11 "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\Product\List.cshtml"
   Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h4>");
#nullable restore
#line 12 "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\Product\List.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\mariu\Desktop\aspNetApp\aspNetApp\Views\Product\List.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb7fa61c05513ee72f9c057597713adb0a1ba4da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetEmployee), @"mvc.1.0.view", @"/Views/Account/GetEmployee.cshtml")]
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
#line 1 "D:\.net core\CrudOperations\CrudOperations\Views\_ViewImports.cshtml"
using CrudOperations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net core\CrudOperations\CrudOperations\Views\_ViewImports.cshtml"
using CrudOperations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7fa61c05513ee72f9c057597713adb0a1ba4da", @"/Views/Account/GetEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b76af488cff69a1d645202704817a4179e9d2d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_GetEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DAL.DataModel.Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
  
    ViewData["Title"] = "GetEmployee";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetEmployee</h1>\r\n<div>\r\n    <table>\r\n\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Email</th>\r\n            <th>Mobile</th>\r\n            <th>Action</th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 18 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
               Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
               Write(Html.ActionLink("Edit", "EditEmployee", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
               Write(Html.ActionLink("Delete", "DeleteEmp", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n              \r\n\r\n            </tr>\r\n");
#nullable restore
#line 34 "D:\.net core\CrudOperations\CrudOperations\Views\Account\GetEmployee.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DAL.DataModel.Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

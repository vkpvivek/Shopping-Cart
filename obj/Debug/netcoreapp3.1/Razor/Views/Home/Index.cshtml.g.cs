#pragma checksum "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb1ca3a30e9d59e20e76f9244dad102961db694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\_ViewImports.cshtml"
using DatabaseFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\_ViewImports.cshtml"
using DatabaseFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb1ca3a30e9d59e20e76f9244dad102961db694", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d67b4382ca4f85b0080dbacecca31a13f5bda468", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DatabaseFirstApp.Models.EmployeeTable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>****Employee  Management System****</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
Write(Html.Raw(TempData["insert"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
Write(Html.Raw(TempData["update"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
Write(Html.Raw(TempData["delete"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
Write(Html.ActionLink("Add New Emplyee", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table bgcolor=""aquagreen"" class=""table-bordered"">
    <tr>
        <th>empId</th>
        <th>empName</th>
        <th>empAdd</th>
        <th>empAge</th>
        <th>empSalary</th>
        <th>edit</th>
        <th>delete</th>
        <th>details</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
     foreach (var ep in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(ep.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(ep.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(ep.EmpAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(ep.EmpAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(ep.EmpSal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = ep.EmpId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = ep.EmpId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = ep.EmpId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\vkpvi\source\repos\test\DatabaseFirstApp\DatabaseFirstApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DatabaseFirstApp.Models.EmployeeTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591

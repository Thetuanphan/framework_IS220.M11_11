#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b0fd91d795e7b06f950559ad33086b6f31cf26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_Index), @"mvc.1.0.view", @"/Views/KhachHang/Index.cshtml")]
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
#line 1 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\_ViewImports.cshtml"
using DoAn_CuaHangLaptop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\_ViewImports.cshtml"
using DoAn_CuaHangLaptop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b0fd91d795e7b06f950559ad33086b6f31cf26", @"/Views/KhachHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b8ba9fc583e43ab0ed1cccc6fe68ac4fc52165", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_CuaHangLaptop.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93b0fd91d795e7b06f950559ad33086b6f31cf263800", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 20 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenKH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SoDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 50 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenKH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenDN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 71 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { makh = item.MaKH }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 72 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", item));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 73 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 76 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\KhachHang\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_CuaHangLaptop.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c39e98b4820da36167771e658985bff31b77ed90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Index), @"mvc.1.0.view", @"/Views/Sanpham/Index.cshtml")]
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
#line 1 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39e98b4820da36167771e658985bff31b77ed90", @"/Views/Sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39e98b4820da36167771e658985bff31b77ed904531", async() => {
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
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tensp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mausac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ocung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cardmanhinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dacbiet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hdh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 37 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Thietke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 40 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KichthuocTrongluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 43 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Webcam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 46 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 49 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ramat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 52 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 55 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dongia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 58 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 61 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BoxulyNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 64 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CongketnoiNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 67 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DanhmucNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 70 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManhinhNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 73 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RamNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 79 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 82 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tensp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 85 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 88 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mausac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 91 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ocung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 94 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cardmanhinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 97 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dacbiet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 100 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hdh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 103 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Thietke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 106 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KichthuocTrongluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 109 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Webcam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 112 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 115 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ramat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 118 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 121 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dongia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 124 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hinhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 127 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BoxulyNavigation.Mabxl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 130 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CongketnoiNavigation.Mackn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 133 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DanhmucNavigation.Madm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 136 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManhinhNavigation.Mamh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 139 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RamNavigation.Maram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39e98b4820da36167771e658985bff31b77ed9018509", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
                                       WriteLiteral(item.Masp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39e98b4820da36167771e658985bff31b77ed9020673", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
                                          WriteLiteral(item.Masp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39e98b4820da36167771e658985bff31b77ed9022843", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
                                         WriteLiteral(item.Masp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 147 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591

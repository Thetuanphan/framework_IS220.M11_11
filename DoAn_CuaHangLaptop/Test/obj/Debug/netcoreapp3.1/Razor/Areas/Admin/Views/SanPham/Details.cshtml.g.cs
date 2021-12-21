#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c667d0a458405df3cda4f856d1736305dcbddf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPham_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPham/Details.cshtml")]
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
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c667d0a458405df3cda4f856d1736305dcbddf6", @"/Areas/Admin/Views/SanPham/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52b98b440d1e9433f31e366fabeda1975b4a3f2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SanPham_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.Models.Sanpham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
   ViewData["Title"] = "Details";
                Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
                var sanpham = ViewData["SanPham"] as Sanpham;
                var bxl = ViewData["BXL"] as Boxuly;
                var ram = ViewData["RAM"] as Bonhoram;
                var mh = ViewData["MH"] as Manhinh;
                var ckn = ViewData["CKN"] as Congketnoi; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Chi tiết</h1>

<div>
    <h4>Sản phẩm</h4>
    <hr />



    <div class=""p-4"">
        <div class=""container"">
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Thông tin sản phẩm</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">Tên sản phẩm</th>
                        <td>");
#nullable restore
#line 31 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Đơn giá</th>\n                        <td>");
#nullable restore
#line 35 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Dongia?.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Số lượng</th>\n                        <td>");
#nullable restore
#line 39 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Màu sắc</th>\n                        <td>");
#nullable restore
#line 43 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Mausac);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>


                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Bộ xử lý</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">Công nghệ CPU</th>
                        <td>");
#nullable restore
#line 59 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(bxl.Congnghecpu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Số nhân</th>\n                        <td>");
#nullable restore
#line 63 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(bxl.Sonhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Số luồng</th>\n                        <td>");
#nullable restore
#line 67 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(bxl.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Tốc độ CPU</th>\n                        <td>");
#nullable restore
#line 71 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(bxl.Tocdocpu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Tốc độ tối đa</th>\n                        <td>");
#nullable restore
#line 75 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(bxl.Tocdotoida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Bộ nhớ đệm</th>\n                        <td>");
#nullable restore
#line 79 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(bxl.Bonhodem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Bộ nhớ RAM, Ổ cứng</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">RAM</th>
                        <td>");
#nullable restore
#line 93 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ram.Dungluongram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Loại RAM</th>\n                        <td>");
#nullable restore
#line 97 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ram.Loairam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Tốc độ Bus RAM</th>\n                        <td>");
#nullable restore
#line 101 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ram.Busram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Hỗ trợ RAM tối đa</th>\n                        <td>");
#nullable restore
#line 105 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ram.Hotrotoida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Ổ cứng</th>\n                        <td>");
#nullable restore
#line 109 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Ocung);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Màn hình</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">Màn hình</th>
                        <td>");
#nullable restore
#line 123 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(mh.Kichthuoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Độ phân giải</th>\n                        <td>");
#nullable restore
#line 127 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(mh.Dophangiai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Tần số quét</th>\n                        <td>");
#nullable restore
#line 131 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(mh.Tansoquet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Cộng nghệ màn hình</th>\n                        <td>");
#nullable restore
#line 135 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(mh.Congnghemh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Cảm ứng</th>\n                        <td>");
#nullable restore
#line 139 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(mh.Camung);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Đồ họa và Âm thanh</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">Card màn hình</th>
                        <td>");
#nullable restore
#line 152 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Cardmanhinh);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Cổng kết nối & tính năng mở rộng</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">Cổng giao tiếp</th>
                        <td>");
#nullable restore
#line 166 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ckn.Conggiaotiep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Kết nối không dây</th>\n                        <td>");
#nullable restore
#line 170 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ckn.Ketnoikhongday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Webcam</th>\n                        <td>");
#nullable restore
#line 174 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ckn.Webcam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 176 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                     if (ckn.Tinhnangkhac != "")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th scope=\"row\">Tính năng khác</th>\n            <td>");
#nullable restore
#line 180 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
           Write(ckn.Tinhnangkhac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 182 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                     if (ckn.Khedocthenho != "")
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th scope=\"row\">Khe đọc thẻ nhớ</th>\n            <td>");
#nullable restore
#line 188 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
           Write(ckn.Khedocthenho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 190 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <th scope=\"row\">Đèn bàn phím</th>\n                        <td>");
#nullable restore
#line 193 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(ckn.Denbanphim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Kích thước & trọng lượng</th>
                    </tr>
                </thead>
                <tbody>

                    <tr>
                        <th scope=""row"">Kích thước,trọng lượng</th>
                        <td>");
#nullable restore
#line 207 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.KichthuocTrongluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Chất liệu</th>\n                        <td>");
#nullable restore
#line 211 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Thietke);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th colspan=""2"">Thông tin khác</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">Đặc biệt</th>
                        <td>");
#nullable restore
#line 224 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Dacbiet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Thông tin Pin</th>\n                        <td>");
#nullable restore
#line 228 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Pin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Hệ điều hành</th>\n                        <td>");
#nullable restore
#line 232 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Hdh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Thời điểm ra mắt</th>\n                        <td>");
#nullable restore
#line 236 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                       Write(sanpham.Ramat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th scope=\"row\">Hình ảnh</th>\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 8156, "\"", 8178, 1);
#nullable restore
#line 240 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
WriteAttributeValue("", 8162, sanpham.Hinhanh, 8162, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150px\" height=\"100px\" /></td>\n                    </tr>\n                </tbody>\n            </table>\n\n            <div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c667d0a458405df3cda4f856d1736305dcbddf621753", async() => {
                WriteLiteral("Cập nhật");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 246 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\SanPham\Details.cshtml"
                                       WriteLiteral(Model.Masp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c667d0a458405df3cda4f856d1736305dcbddf624059", async() => {
                WriteLiteral("Trở về trang danh sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<style>\n    .table tbody th {\n        width: 350px\n    }\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591

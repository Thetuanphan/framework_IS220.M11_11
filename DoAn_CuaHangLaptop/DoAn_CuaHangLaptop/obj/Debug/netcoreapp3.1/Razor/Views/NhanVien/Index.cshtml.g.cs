#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac90df0041b5250104d6292d38e39e04b8a68302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Index), @"mvc.1.0.view", @"/Views/NhanVien/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac90df0041b5250104d6292d38e39e04b8a68302", @"/Views/NhanVien/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b8ba9fc583e43ab0ed1cccc6fe68ac4fc52165", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_CuaHangLaptop.Models.NhanVien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NhanVien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    setTimeout(function () {
        $('#msgA').fadeOut('slow');
    }, 2000);
    $('table .delete').on('click', function () {
        var id = $(this).data(""id"");
            $.ajax({
                type: 'POST',
                url: '");
#nullable restore
#line 15 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                 Write(Url.Action("timNhanVien"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                data: { ""manv"": id },
                success: function (response) {
                    console.log(response)
                    $(""#DeleteRecord #manv"").val(response.maNV);
                    $(""#DeleteRecord #tendangnhap"").val(response.tenDangNhap);
                    $(""#DeleteRecord #tennhanvien"").val(response.tenNV);
                    $(""#DeleteRecord #chucvu"").val(response.chucVu);
                }
            })
    })
    $(document).ready(function () {
        var listdate = $(""[name='date']"")
        for (var i = 0; i < listdate.length; i++) {
            dateItem = listdate[i].innerHTML
            dateview = dateItem.trim().split("" "")[0]
            listdate[i].innerHTML = dateview
        }
    })
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""card m-5"">
    <div class=""card-header"">
        <div class=""row"">
            <div class=""col-md-6"">
                <strong>Danh sách nhân viên</strong>
            </div>
            <div class=""col-md-6 d-flex justify-content-end"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1459, "\"", 1498, 1);
#nullable restore
#line 43 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
WriteAttributeValue("", 1466, Url.Action("Create","NhanVien"), 1466, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Thêm</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 47 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
     if (TempData["AlertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"msgA\"");
            BeginWriteAttribute("class", " class=\"", 1655, "\"", 1685, 1);
#nullable restore
#line 49 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
WriteAttributeValue("", 1663, TempData["AlertType"], 1663, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n            ");
#nullable restore
#line 50 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
       Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 52 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body p-3\">\r\n        <table class=\"table table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 58 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TenDangNhap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 61 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TenNV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 64 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 67 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 70 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ChucVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 73 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 76 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.NgayVL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 79 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SoDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 85 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                 foreach (var item in ViewBag.dsNV)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.TenDangNhap);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.TenNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td name=\"date\">\r\n                            ");
#nullable restore
#line 95 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.NgaySinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 98 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.GioiTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 101 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.ChucVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 104 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td name=\"date\">\r\n                            ");
#nullable restore
#line 107 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.NgayVL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 110 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(item.SoDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 113 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(Html.ActionLink("Cập nhật", "Edit", new { manv = item.MaNV }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 114 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                       Write(Html.ActionLink("Xem chi tiết", "Details", new { manv = item.MaNV }, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                            <button type=""button""
                                    class=""btn btn-danger delete""
                                    data-toggle=""modal""
                                    data-target=""#DeleteRecord""
                                    data-id=""");
#nullable restore
#line 121 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"
                                        Write(item.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                Xóa\r\n                            </button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 126 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\NhanVien\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""modal fade"" id=""DeleteRecord"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Xác nhận xóa</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac90df0041b5250104d6292d38e39e04b8a6830216423", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <input type=""hidden"" readonly id=manv class=""form-control"" name=""manv"" />

                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Tên đăng nhập:</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" readonly id=tendangnhap class=""form-control"" name=""tendangnhap"" />
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Tên nhân viên </label>
                            <div class=""col-sm-8"">
                                <input type=""text"" readonly id=""tennhanvien"" class=""form-control"" name=""tennhanvien"" />
                            </div>
                     ");
                WriteLiteral(@"   </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Chức vụ: </label>
                            <div class=""col-sm-8"">
                                <input type=""text"" readonly id=""chucvu"" class=""form-control"" name=""chucvu"" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>

                    <button type=""submit"" class=""btn btn-primary"">Xóa</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<style>\r\n    table th {\r\n        font-weight: bold !important;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_CuaHangLaptop.Models.NhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
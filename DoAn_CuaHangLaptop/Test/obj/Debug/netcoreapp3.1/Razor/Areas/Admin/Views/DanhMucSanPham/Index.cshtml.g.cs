#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4fff54488f41535ba2c6a7a9d7c523f7938c93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DanhMucSanPham_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DanhMucSanPham/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4fff54488f41535ba2c6a7a9d7c523f7938c93", @"/Areas/Admin/Views/DanhMucSanPham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52b98b440d1e9433f31e366fabeda1975b4a3f2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DanhMucSanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Danhmucsanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DanhMucSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n    setTimeout(function () {\n        $(\'#msgA\').fadeOut(\'slow\');\n    }, 2000);\n    $(\'table .delete\').on(\'click\', function () {\n        var id = $(this).data(\"id\");\n            $.ajax({\n                type: \'POST\',\n                url: \'");
#nullable restore
#line 16 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                 Write(Url.Action("timDanhMuc"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                data: { ""id"": id },
                success: function (response) {
                    console.log(response)
                    $(""#DeleteRecord #madm"").val(response.madm);
                    $(""#DeleteRecord #tendanhmuc"").val(response.tendm);
                }
            })
    })
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">

    <!-- Page Heading -->
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">

        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh mục sản phẩm</h6>
        </div>

        <p></p>

        <div class=""container"">

            <div class=""row"">

                <div class=""col-md-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4fff54488f41535ba2c6a7a9d7c523f7938c937058", async() => {
                WriteLiteral(@"
                        <input type=""hidden"" class=""form-control"" id=""Madm"" name=""Madm"" value=""1"">
                        <div class=""form-row"">
                            <div class=""form-group col-md-2"">
                                <label for=""inputBrand"">Tên danh mục</label>
                                <input type=""text"" class=""form-control"" id=""Tendm"" name=""Tendm"">
                            </div>
                        </div>

                        <div class=""form-row"">
                            <div class=""form-group col-md-1 center"">
                                <button type=""submit"" class=""btn btn-primary"">Thêm</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n\n\n\n            </div>\n\n        </div>\n");
#nullable restore
#line 66 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
         if (TempData["AlertMessage"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"msgA\"");
            BeginWriteAttribute("class", " class=\"", 2096, "\"", 2126, 1);
#nullable restore
#line 68 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
WriteAttributeValue("", 2104, TempData["AlertType"], 2104, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n                ");
#nullable restore
#line 69 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
           Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 71 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th width=""20%"">Mã danh mục</th>
                            <th width=""50%"">Tên danh mục</th>
                            <th width=""30%"">Tác vụ</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 83 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 86 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                               Write(item.Madm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 87 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                               Write(item.Tendm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4fff54488f41535ba2c6a7a9d7c523f7938c9312251", async() => {
                WriteLiteral("Cập nhật");
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
#line 89 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                                                           WriteLiteral(item.Madm);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <button type=""button""
                                            class=""btn btn-danger delete""
                                            data-toggle=""modal""
                                            data-target=""#DeleteRecord""
                                            data-id=""");
#nullable restore
#line 94 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                                                Write(item.Madm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                        Xóa\n                                    </button>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 99 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Areas\Admin\Views\DanhMucSanPham\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4fff54488f41535ba2c6a7a9d7c523f7938c9316180", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <input type=""hidden"" readonly id=madm class=""form-control"" name=""Madm"" />

                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Tên danh mục</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" readonly id=tendanhmuc class=""form-control"" name=""Tendm"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Danhmucsanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Areas\Admin\Views\Home\RAM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aafb27b9a85608df6b2e10935e0c7facfcbd989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_RAM), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/RAM.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aafb27b9a85608df6b2e10935e0c7facfcbd989", @"/Areas/Admin/Views/Home/RAM.cshtml")]
    public class Areas_Admin_Views_Home_RAM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Areas\Admin\Views\Home\RAM.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">

    <!-- Page Heading -->
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">

        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">DataTables Example</h6>
        </div>

        <p></p>

        <div class=""container"">

            <div class=""row"">



                <div class=""col-md-12"">
                    <form>

                        <div class=""form-row"">
                            <div class=""form-group col-md-2"">
                                <label for=""inputRAM"">Mã RAM</label>
                                <input type=""text"" readonly class=""form-control-plaintext"" id=""staticRAMCode"" value=""DDR4L"">
                            </div>

                            <div class=""form-group col-md-2"">
                                <label for=""inputRAMCapacity"">Dung lượng</label>
                                <input type=""number"" class=""form-control"" id=""inputRAMCapacity"" place");
            WriteLiteral(@"holder=""16"">
                            </div>

                            <div class=""form-group col-md-1"">
                            </div>

                            <div class=""form-group col-md-1"">
                                <label for=""inputRAMType"">Loại ram</label>
                                <input type=""text"" class=""form-control"" id=""inputRAMType"" placeholder=""DDR4"">
                            </div>

                            <div class=""form-group col-md-1"">
                            </div>

                            <div class=""form-group col-md-1"">
                                <label for=""inputBus"">Bus ram</label>
                                <input type=""number"" class=""form-control"" id=""inputBus"" placeholder=""3200"">
                            </div>

                            <div class=""form-group col-md-1"">
                            </div>

                            <div class=""form-group col-md-2"">
                                <labe");
            WriteLiteral(@"l for=""inputMaxRAM"">Hỗ trợ tối đa</label>
                                <input type=""text"" class=""form-control"" id=""inputMaxRAM"" placeholder=""16gb"">
                            </div>

                        </div>

                        <div class=""form-row"">
                            <div class=""form-group col-md-6""></div>
                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-primary"">Thêm</button>
                            </div>

                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-secondary"">Cập nhật</button>
                            </div>

                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-danger"">Xóa</button>
                            </div>
                        </div>

                    </form>

            ");
            WriteLiteral(@"    </div>


            </div>

        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th width=""15%"">Mã RAM</th>
                            <th width=""10%"">Dung lượng</th>
                            <th width=""10%"">Loại RAM</th>
                            <th width=""10%"">Bus RAM</th>
                            <th width=""10%"">Hỗ trợ tối đa</th>

                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th width=""15%"">Mã RAM</th>
                            <th width=""10%"">Dung lượng</th>
                            <th width=""10%"">Loại RAM</th>
                            <th width=""10%"">Bus RAM</th>
                            <th width=""10%"">Hỗ trợ tối đa</th>

              ");
            WriteLiteral(@"          </tr>
                    </tfoot>
                    <tbody>
                        <tr>
                            <td>DDR4L</td>
                            <td>16gb</td>
                            <td>DDR4</td>
                            <td>3200mhz</td>
                            <td>16</td>

                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

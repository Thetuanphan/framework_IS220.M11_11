#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4a4e62affdb19243912096e33e6d009ade5560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Checkout), @"mvc.1.0.view", @"/Views/Sanpham/Checkout.cshtml")]
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
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4a4e62affdb19243912096e33e6d009ade5560", @"/Views/Sanpham/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Test.Models.GioHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("billing-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""hero-wrap hero-bread"" style=""background-image: url(/images/bg_6.jpg);"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Checkout</span></p>
                <h1 class=""mb-0 bread"">Checkout</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-xl-10 ftco-animate"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4a4e62affdb19243912096e33e6d009ade55605740", async() => {
                WriteLiteral(@"
                    <h3 class=""mb-4 billing-heading"">Chi tiết đơn hàng</h3>
                    <div class=""row align-items-end"">
                        <div class=""col-md-6"">
                           
                            <div class=""form-group"">
                                 <label for=""hoten"">Họ tên</label>
                                 <input type=""text"" name=""hoten"" id=""hoten"" class=""form-control"" placeholder=""Nhập họ tên người nhận"">
                            </div>
                            
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""diachi"">Địa chỉ giao hàng</label>
                                <input type=""text"" name=""diachi"" id=""diachi"" class=""form-control"" placeholder=""Địa chỉ nhận hàng"">
                            </div>
                        </div>
                        <div class=""w-100"">");
                WriteLiteral(@"</div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""sdt"">SĐT</label>
                                <input type=""text""  name=""sdt"" id=""sdt"" class=""form-control"" placeholder=""SĐT người nhận"">
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""email"">Email</label>
                                <input type=""text""  name=""email"" id=""email"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2579, "\"", 2606, 1);
#nullable restore
#line 55 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
WriteAttributeValue("", 2587, User.Identity.Name, 2587, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            </div>\n                        </div>\n\n\n                    </div>\n\n");
#nullable restore
#line 62 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                     if (Model.Count > 0)
                    {
                        decimal total = 0;
                        int stt = 1;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <section class=""ftco-section ftco-cart"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-md-12 ftco-animate"">
                                        <div class=""cart-list"">
                                            <table class=""table"">
                                                <thead class=""thead-primary"">
                                                    <tr class=""text-center"">
                                                        <th>&nbsp;</th>
                                                        <th>&nbsp;&nbsp;</th>
                                                        <th>Sản phẩm</th>
                                                        <th>Gía</th>
                                                        <th>Số lượng</th>
                                                        <th>Tổng tiền</th>
                                                    </tr>");
                WriteLiteral("\n                                                </thead>\n                                                <tbody>\n");
#nullable restore
#line 83 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                     foreach (var item in Model)
                                                    {
                                                        decimal thanhtien = item.SL * (decimal)item.Sanpham.Dongia;
                                                        total += thanhtien;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <tr class=\"text-center\">\n                                                            <td class=\"product-remove\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4a4e62affdb19243912096e33e6d009ade556010462", async() => {
                    WriteLiteral("<span class=\"ion-ios-close\"></span>");
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
#line 88 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                                                                                    WriteLiteral(item.Sanpham.Masp);

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
                WriteLiteral("</td>\n\n                                                            <td class=\"image-prod\"><div class=\"img\"");
                BeginWriteAttribute("style", " style=\"", 4688, "\"", 4740, 3);
                WriteAttributeValue("", 4696, "background-image:url(", 4696, 21, true);
#nullable restore
#line 90 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
WriteAttributeValue("", 4717, item.Sanpham.Hinhanh, 4717, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4738, ");", 4738, 2, true);
                EndWriteAttribute();
                WriteLiteral("></div></td>\n\n                                                            <td class=\"product-name\">\n                                                                <h3>");
#nullable restore
#line 93 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                               Write(item.Sanpham.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n\n                                                            </td>\n\n                                                            <td class=\"price\">");
#nullable restore
#line 97 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                                         Write(item.Sanpham.Dongia?.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>

                                                            <td class=""quantity"">
                                                                <div class=""input-group mb-3"">
                                                                    <input type=""text"" name=""quantity"" class=""quantity form-control input-number""");
                BeginWriteAttribute("value", " value=\"", 5452, "\"", 5468, 1);
#nullable restore
#line 101 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
WriteAttributeValue("", 5460, item.SL, 5460, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" max=\"100\">\n                                                                </div>\n                                                            </td>\n\n                                                            <td class=\"total\">");
#nullable restore
#line 105 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                                         Write(thanhtien.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                        </tr>\n");
#nullable restore
#line 107 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    <!-- END TR-->
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>

                                <div class=""row mt-5 pt-3 d-flex"">
                                    <div class=""col-md-6 d-flex"">
                                        <div class=""cart-detail cart-total bg-light p-3 p-md-4"">
                                            <h3 class=""billing-heading mb-4"">Cart Total</h3>
                                            <p class=""d-flex"">
                                                <span>Thành tiền</span>
                                                <span>");
#nullable restore
#line 122 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                 Write(total.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            </p>
                                            <p class=""d-flex"">
                                                <span>Vận chuyển</span>
                                                <span>0</span>
                                            </p>
                                            <p class=""d-flex"">
                                                <span>Giảm giá</span>
                                                <span>0</span>
                                            </p>
                                            <hr>
                                            <p class=""d-flex total-price"">
                                                <span>Tổng tiền</span>
                                                <span>");
#nullable restore
#line 135 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                                                 Write(total.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            </p>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""cart-detail bg-light p-3 p-md-4"">
                                            <h3 class=""billing-heading mb-4"">Phương thức thanh toán</h3>
                                            <div class=""form-group"">
                                                <div class=""col-md-12"">
                                                    <div class=""radio"">
                                                        <label><input type=""radio"" name=""optradio"" class=""mr-2""> Thẻ ngân hàng </label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                            ");
                WriteLiteral(@"    <div class=""col-md-12"">
                                                    <div class=""radio"">
                                                        <label><input type=""radio"" name=""optradio"" class=""mr-2"">  Ví điện tử</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <div class=""col-md-12"">
                                                    <div class=""radio"">
                                                        <label><input type=""radio"" name=""optradio"" class=""mr-2""> Thanh toán khi nhận hàng </label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                ");
                WriteLiteral("                <div class=\"col-md-12\">\n                                                    <div class=\"checkbox\">\n                                                        <label><input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 9781, "\"", 9789, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""mr-2"">  Tôi đã đọc và đồng ý với chính sách của cửa hàng.</label>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>

                        </section>
");
#nullable restore
#line 177 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Checkout.cshtml"
                    }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"btn btn-success\" type=\"submit\">Xác nhận đặt hàng</button>\n\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- END -->\n\n            </div> <!-- .col-md-8 -->\n        </div>\n\n    </div>\n</section> <!-- .section -->\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Test.Models.GioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf136975e695aa0acbd14f563253e1d9a203a66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Cart), @"mvc.1.0.view", @"/Views/Sanpham/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf136975e695aa0acbd14f563253e1d9a203a66", @"/Views/Sanpham/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Test.Models.GioHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary py-3 px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
 if (Model.Count > 0)
{
    decimal total = 0;
    int stt = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-wrap hero-bread"" style=""background-image: url(/images/bg_6.jpg);"">
        <div class=""container"">
            <div class=""row no-gutters slider-text align-items-center justify-content-center"">
                <div class=""col-md-9 ftco-animate text-center"">
                    <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Cart</span></p>
                    <h1 class=""mb-0 bread"">My Wishlist</h1>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral(@"    <section class=""ftco-section ftco-cart"">
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
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 39 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
                                 foreach (var item in Model)
                                {

                                    decimal thanhtien = item.SL * (decimal)item.Sanpham.Dongia;
                                    total += thanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"text-center\">\r\n                                        <td class=\"product-remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf136975e695aa0acbd14f563253e1d9a203a667639", async() => {
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
#line 45 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
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
            WriteLiteral("</td>\r\n\r\n                                        <td class=\"image-prod\"><div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 2071, "\"", 2123, 3);
            WriteAttributeValue("", 2079, "background-image:url(", 2079, 21, true);
#nullable restore
#line 47 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
WriteAttributeValue("", 2100, item.Sanpham.Hinhanh, 2100, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2121, ");", 2121, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div></td>\r\n\r\n                                        <td class=\"product-name\">\r\n                                            <h3>");
#nullable restore
#line 50 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
                                           Write(item.Sanpham.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                                        </td>\r\n\r\n                                        <td class=\"price\">");
#nullable restore
#line 54 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
                                                     Write(item.Sanpham.Dongia?.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf136975e695aa0acbd14f563253e1d9a203a6611360", async() => {
                WriteLiteral(@"
                                        <td class=""quantity"">
                                            <div class=""w-100""></div>
                                            <div class=""input-group mb-3"">

                                                <div style=""display:none"">
                                                    <input type=""text"" id=""id"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 2902, "\"", 2928, 1);
#nullable restore
#line 61 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
WriteAttributeValue("", 2910, item.Sanpham.Masp, 2910, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                </div>\r\n\r\n                                                <input type=\"text\" id=\"quantity\" name=\"quantity\" class=\"quantity form-control input-number\"");
                BeginWriteAttribute("value", " value=\"", 3131, "\"", 3147, 1);
#nullable restore
#line 64 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
WriteAttributeValue("", 3139, item.SL, 3139, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=""1"" max=""100"">
                                                <span class=""input-group-btn ml-2"">
                                                    <button class=""btn btn-primary py-3 px-4"" type=""submit"" data-type=""plus"" data-field="""">
                                                        cập nhật
                                                    </button>
                                                </span>
                                            </div>
                                            <div class=""w-100""></div>

                                        </td>
                                        ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        <td class=\"total\">");
#nullable restore
#line 76 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
                                                     Write(thanhtien.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 78 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
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
            <div class=""row justify-content-start"">
                <div class=""col col-lg-5 col-md-6 mt-5 cart-wrap ftco-animate"">
                    <div class=""cart-total mb-3"">
                        <h3>Tổng tiền</h3>
                        <p class=""d-flex"">
                            <span>Thành tiền</span>
                            <span>");
#nullable restore
#line 93 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
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
#line 106 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
                             Write(total.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </p>\r\n                    </div>\r\n                    <p class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf136975e695aa0acbd14f563253e1d9a203a6617379", async() => {
                WriteLiteral("Mua hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n");
#nullable restore
#line 115 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>

    function giam() {
        var i = document.getElementById('quantity').value;
        i=i-1;
        document.getElementById('quantity').value = i;
    }

    function tang() {
        var i = document.getElementById('quantity').value;
        i=i+1;
        document.getElementById('quantity').value = i;
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Test.Models.GioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591

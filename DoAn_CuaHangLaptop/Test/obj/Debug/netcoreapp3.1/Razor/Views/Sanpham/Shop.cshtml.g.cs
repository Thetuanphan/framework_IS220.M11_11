#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1973a04f813e6e034a18e272c771234e1348e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Shop), @"mvc.1.0.view", @"/Views/Sanpham/Shop.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1973a04f813e6e034a18e272c771234e1348e1", @"/Views/Sanpham/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductSingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-to-cart text-center py-2 mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var page = $(""#currentPage"").text()
            if (page == 0) {
                $(""#1"").addClass(""active"");
            }
            else {
                document.getElementById(page).classList.add(""active"");
            }

        })
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url(/images/bg_6.jpg);"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Shop</span></p>
                <h1 class=""mb-0 bread"">Shop</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-lg-10 order-md-last"">
                <div class=""row"">
");
#nullable restore
#line 35 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-12 col-md-12 col-lg-4 ftco-animate d-flex"">
                            <div class=""product d-flex flex-column"">
                                <a href=""#"" class=""img-prod"">
                                    <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 1431, "\"", 1450, 1);
#nullable restore
#line 40 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
WriteAttributeValue("", 1437, item.Hinhanh, 1437, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"">
                                    <div class=""overlay""></div>
                                </a>
                                <div class=""text py-3 pb-4 px-3"">
                                    <div class=""d-flex"">
                                        <div class=""cat"">
                                            <span>Lifestyle</span>
                                        </div>
                                        <div class=""rating"">
                                            <p class=""text-right mb-0"">
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                                <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                                         ");
            WriteLiteral("       <a href=\"#\"><span class=\"ion-ios-star-outline\"></span></a>\n                                            </p>\n                                        </div>\n                                    </div>\n                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f1973a04f813e6e034a18e272c771234e1348e17630", async() => {
#nullable restore
#line 58 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                                                                           Write(item.Tensp);

#line default
#line hidden
#nullable disable
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
#line 58 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
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
            WriteLiteral("</h3>\n                                    <div class=\"pricing\">\n                                        <p class=\"price\"><span>");
#nullable restore
#line 60 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                                          Write(item.Dongia?.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\n                                    </div>\n                                    <p class=\"bottom-area d-flex px-3\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f1973a04f813e6e034a18e272c771234e1348e110628", async() => {
                WriteLiteral("<span>Add to cart <i class=\"ion-ios-add ml-1\"></i></span>");
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
#line 63 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                                                    WriteLiteral(item.Masp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <a href=""#"" class=""buy-now text-center py-2"">Buy now<span><i class=""ion-ios-cart ml-1""></i></span></a>
                                    </p>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 69 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n                <div class=\"row mt-5\">\n                    <div class=\"col text-center\">\n                        <div class=\"block-27\">\n                            <span style=\"display:none\" id=\"currentPage\">");
#nullable restore
#line 75 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                                                   Write(ViewBag.pageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            <ul>\n");
#nullable restore
#line 77 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                 for (var i = 1; i <= ViewBag.totalPage; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li");
            BeginWriteAttribute("id", " id=\"", 4031, "\"", 4038, 1);
#nullable restore
#line 79 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
WriteAttributeValue("", 4036, i, 4036, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 4042, "\"", 4098, 1);
#nullable restore
#line 79 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
WriteAttributeValue("", 4049, Url.Action("Shop", "SanPham", new { page = @i }), 4049, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 80 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-4 col-lg-2"">
                <div class=""sidebar"">
                    <div class=""sidebar-box-2"">
                        <h2 class=""heading"">Categories</h2>
                        <div class=""fancy-collapse-panel"">
                            <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
                                <div class=""panel panel-default"">
                                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                                        <h4 class=""panel-title"">
");
#nullable restore
#line 96 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                             foreach (Danhmucsanpham dm in (List<Danhmucsanpham>)ViewBag.dmSP)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 5071, "\"", 5132, 1);
#nullable restore
#line 98 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
WriteAttributeValue("", 5078, Url.Action("Shop", "SanPham", new { madm = dm.Madm }), 5078, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                    ");
#nullable restore
#line 99 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                               Write(dm.Tendm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </a>\n");
#nullable restore
#line 101 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Shop.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </h4>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            WriteLiteral("<style>\n    .product .text h3\n    {\n        height: 100px\n    }\n    .price span{\n        font-size: 18px;\n        color: #e600a0;\n    }\n</style>");
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

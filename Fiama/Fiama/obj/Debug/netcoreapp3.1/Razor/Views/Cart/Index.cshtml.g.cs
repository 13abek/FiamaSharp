#pragma checksum "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c83722410b79739fb6ba4597d15a654c4ede0e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\_ViewImports.cshtml"
using Fiama;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\_ViewImports.cshtml"
using Fiama.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\_ViewImports.cshtml"
using Fiama.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\_ViewImports.cshtml"
using Fiama.Libs.AuthFilter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\_ViewImports.cshtml"
using Repository.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83722410b79739fb6ba4597d15a654c4ede0e0c", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc21f89d61f2ad103c1e782dd9c9e61d4da61ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private global::AspNetCore.Views_Cart_Index.__Generated__HeadersBasketViewComponentTagHelper __HeadersBasketViewComponentTagHelper;
        private global::AspNetCore.Views_Cart_Index.__Generated__BrandsViewComponentTagHelper __BrandsViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Modals/_MobilMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Utilize Cart Menu Start -->\r\n<div id=\"ltn__utilize-cart-menu\" class=\"ltn__utilize ltn__utilize-cart-menu\">\r\n    <div class=\"ltn__utilize-menu-inner ltn__scrollbar header-basket\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:headers-basket", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c83722410b79739fb6ba4597d15a654c4ede0e0c4578", async() => {
            }
            );
            __HeadersBasketViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Cart_Index.__Generated__HeadersBasketViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__HeadersBasketViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<!-- Utilize Cart Menu End -->
<!-- Utilize Mobile Menu Start -->
<!-- Utilize Mobile Menu End -->

<div class=""ltn__utilize-overlay""></div>

<!-- BREADCRUMB AREA START -->
<div class=""ltn__breadcrumb-area ltn__breadcrumb-area-4 ltn__breadcrumb-color-white---"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ltn__breadcrumb-inner text-center"">
                    <h1 class=""ltn__page-title"">Cart</h1>
                    <div class=""ltn__breadcrumb-list"">
                        <ul>
                            <li><a href=""index.html"">Home</a></li>
                            <li>Cart</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- BREADCRUMB AREA END -->
<!-- SHOPING CART AREA START -->
<div class=""liton__shoping-cart-area mb-100"">
    <div class=""container"">
        <div class=""row"">
            ");
            WriteLiteral(@"<div class=""col-lg-12"">
                <div class=""shoping-cart-inner"">
                    <div class=""shoping-cart-table table-responsive"">
                        <table class=""table"">
                            <!-- <thead>
                                <th class=""cart-product-remove"">Remove</th>
                                <th class=""cart-product-image"">Image</th>
                                <th class=""cart-product-info"">Product</th>
                                <th class=""cart-product-price"">Price</th>
                                <th class=""cart-product-quantity"">Quantity</th>
                                <th class=""cart-product-subtotal"">Subtotal</th>
                            </thead> -->
                            <tbody>
                                <tr>
                                    <td class=""cart-product-remove"">x</td>
                                    <td class=""cart-product-image"">
                                        <a href=""product-detai");
            WriteLiteral(@"ls.html""><img src=""img/product/1.png"" alt=""#""></a>
                                    </td>
                                    <td class=""cart-product-info"">
                                        <h4><a href=""product-details.html"">Brake Conversion Kit</a></h4>
                                    </td>
                                    <td class=""cart-product-price"">$149.00</td>
                                    <td class=""cart-product-quantity"">
                                        <div class=""cart-plus-minus"">
                                            <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                                        </div>
                                    </td>
                                    <td class=""cart-product-subtotal"">$298.00</td>
                                </tr>
                                <tr>
                                    <td class=""cart-product-remove"">x</td>
                                    <td");
            WriteLiteral(@" class=""cart-product-image"">
                                        <a href=""product-details.html""><img src=""img/product/2.png"" alt=""#""></a>
                                    </td>
                                    <td class=""cart-product-info"">
                                        <h4><a href=""product-details.html"">OE Replica Wheels</a></h4>
                                    </td>
                                    <td class=""cart-product-price"">$85.00</td>
                                    <td class=""cart-product-quantity"">
                                        <div class=""cart-plus-minus"">
                                            <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                                        </div>
                                    </td>
                                    <td class=""cart-product-subtotal"">$170.00</td>
                                </tr>
                                <tr>
                           ");
            WriteLiteral(@"         <td class=""cart-product-remove"">x</td>
                                    <td class=""cart-product-image"">
                                        <a href=""product-details.html""><img src=""img/product/3.png"" alt=""#""></a>
                                    </td>
                                    <td class=""cart-product-info"">
                                        <h4><a href=""product-details.html"">Wheel Bearing Retainer</a></h4>
                                    </td>
                                    <td class=""cart-product-price"">$75.00</td>
                                    <td class=""cart-product-quantity"">
                                        <div class=""cart-plus-minus"">
                                            <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                                        </div>
                                    </td>
                                    <td class=""cart-product-subtotal"">$150.00</td>
           ");
            WriteLiteral(@"                     </tr>
                                <tr class=""cart-coupon-row"">
                                    <td colspan=""6"">
                                        <div class=""cart-coupon"">
                                            <input type=""text"" name=""cart-coupon"" placeholder=""Coupon code"">
                                            <button type=""submit"" class=""btn theme-btn-2 btn-effect-2"">Apply Coupon</button>
                                        </div>
                                    </td>
                                    <td>
                                        <button type=""submit"" class=""btn theme-btn-2 btn-effect-2-- disabled"">Update Cart</button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""shoping-cart-total mt-50"">
                        <h4>Cart Totals</h4>
                        ");
            WriteLiteral(@"<table class=""table"">
                            <tbody>
                                <tr>
                                    <td>Cart Subtotal</td>
                                    <td>$618.00</td>
                                </tr>
                                <tr>
                                    <td>Shipping and Handing</td>
                                    <td>$15.00</td>
                                </tr>
                                <tr>
                                    <td>Vat</td>
                                    <td>$00.00</td>
                                </tr>
                                <tr>
                                    <td><strong>Order Total</strong></td>
                                    <td><strong>$633.00</strong></td>
                                </tr>
                            </tbody>
                        </table>
                        <div class=""btn-wrapper text-right"">
                            <a href=""ch");
            WriteLiteral(@"eckout.html"" class=""theme-btn-1 btn btn-effect-1"">Proceed to checkout</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- SHOPING CART AREA END -->
<!-- BRAND LOGO AREA START -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:brands", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c83722410b79739fb6ba4597d15a654c4ede0e0c13331", async() => {
            }
            );
            __BrandsViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Cart_Index.__Generated__BrandsViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__BrandsViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- BRAND LOGO AREA END -->\r\n");
            DefineSection("Modals", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c83722410b79739fb6ba4597d15a654c4ede0e0c14353", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:headers-basket")]
        public class __Generated__HeadersBasketViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__HeadersBasketViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("HeadersBasket", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:brands")]
        public class __Generated__BrandsViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__BrandsViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Brands", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591

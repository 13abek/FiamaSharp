#pragma checksum "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5adc0955853193cd8fdb72e18ff21e2de7b6b656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Modals__QuickView), @"mvc.1.0.view", @"/Views/Shared/Modals/_QuickView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5adc0955853193cd8fdb72e18ff21e2de7b6b656", @"/Views/Shared/Modals/_QuickView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc21f89d61f2ad103c1e782dd9c9e61d4da61ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Modals__QuickView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-btn-1 btn btn-effect-1 d-add-to-cart add-to-basket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add to Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#add_to_cart_modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-effect-1 d-add-to-wishlist add-to-basket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- MODAL AREA START (Quick View Modal) -->
<div class=""ltn__modal-area ltn__quick-view-modal-area"">
    <div class=""modal fade"" id=""quick_view_modal"" tabindex=""-1"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                        <!-- <i class=""fas fa-times""></i> -->
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""ltn__quick-view-modal-inner"">
                        <div class=""modal-product-item"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-12"">
                                    <div class=""modal-product-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5adc0955853193cd8fdb72e18ff21e2de7b6b6568530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1014, "~/uploads/", 1014, 10, true);
#nullable restore
#line 19 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
AddHtmlAttributeValue("", 1024, Model.Images.FirstOrDefault(), 1024, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                                <div class=""col-lg-6 col-12"">
                                    <div class=""modal-product-info shop-details-info pl-0"">
                                        <h3>");
#nullable restore
#line 24 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <div class=\"product-price-ratting mb-20\">\r\n                                            <ul>\r\n                                                <li>\r\n");
#nullable restore
#line 28 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                     if (Model.Discount == null)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"product-price\">\r\n\r\n                                                            <span>");
#nullable restore
#line 32 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                             Write(Model.Price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </div>\r\n");
#nullable restore
#line 34 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                    }
                                                    else
                                                    {
                                                        var price = Model.Price - (Model.Price * Model.Discount.Percentage / 100);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"product-price\">\r\n\r\n                                                            <span>");
#nullable restore
#line 41 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                             Write(price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</span>\r\n                                                            <del>");
#nullable restore
#line 42 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                            Write(Model.Price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</del>\r\n                                                        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </li>\r\n                                                <li>\r\n                                                    <div class=\"product-ratting\">\r\n                                                        <ul>\r\n");
#nullable restore
#line 49 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                             for (int i = 0; i < Model.StarCount; i++)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <li><a href=\"#\"><i class=\"icon-star\"></i></a></li>\r\n");
#nullable restore
#line 52 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"

                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li class=\"review-total\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5adc0955853193cd8fdb72e18ff21e2de7b6b65614483", async() => {
                WriteLiteral(" ( ");
#nullable restore
#line 54 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                                                                                            Write(Model.Reviews.Count().ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                                                                       WriteLiteral(Model.id);

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
            WriteLiteral(@"</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""modal-product-brief"">
                                            <p>");
#nullable restore
#line 61 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                          Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"modal-product-meta ltn__product-details-menu-1 mb-20\">\r\n                                            <ul>\r\n\r\n");
#nullable restore
#line 66 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                 foreach (var option in Model.Options)
                                                {
                                                    if (option.Type == OptionsType.Color)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <li>
                                                            <div class=""ltn__color-widget clearfix"">
                                                                <strong class=""d-meta-title"">");
#nullable restore
#line 72 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                        Write(option.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                                                <ul>\r\n");
#nullable restore
#line 74 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                     foreach (var OptionItem in option.OptionItems)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <li");
            BeginWriteAttribute("class", " class=\"", 4990, "\"", 5015, 1);
#nullable restore
#line 76 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
WriteAttributeValue("", 4998, OptionItem.Value, 4998, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\"></a></li>\r\n");
#nullable restore
#line 77 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"

                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                </ul>\r\n                                                            </div>\r\n                                                        </li>\r\n");
#nullable restore
#line 82 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"

                                                    }
                                                    else if (option.Type == OptionsType.Select)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <li>
                                                            <div class=""ltn__size-widget clearfix mt-25"">
                                                                <strong class=""d-meta-title"">");
#nullable restore
#line 88 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                        Write(option.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                                                <ul>\r\n");
#nullable restore
#line 90 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                     foreach (var optionItem in option.OptionItems)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <li><a href=\"#\">");
#nullable restore
#line 92 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                   Write(optionItem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 93 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"

                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                </ul>\r\n                                                            </div>\r\n                                                        </li>\r\n");
#nullable restore
#line 98 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"

                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                        <div class=""ltn__product-details-menu-2 product-cart-wishlist-btn mb-30"">
                                            <ul>
                                                <li>
                                                    <div class=""cart-plus-minus"">
                                                        <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                                                    </div>
                                                </li>
                                                <li>
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5adc0955853193cd8fdb72e18ff21e2de7b6b65624115", async() => {
                WriteLiteral("\r\n                                                        <span>ADD TO CART</span>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                                WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </li>\r\n                                                <li>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5adc0955853193cd8fdb72e18ff21e2de7b6b65627166", async() => {
                WriteLiteral("\r\n                                                        <i class=\"icon-heart\"></i>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                                WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""ltn__social-media mb-30"">
                                            <ul>
                                                <li class=""d-meta-title"">Share:</li>
                                                <li><a href=""#"" title=""Facebook""><i class=""icon-social-facebook""></i></a></li>
                                                <li><a href=""#"" title=""Twitter""><i class=""icon-social-twitter""></i></a></li>
                                                <li><a href=""#"" title=""Pinterest""><i class=""icon-social-pinterest""></i></a></li>
                                                <li><a href=""#"" title=""Instagram""><i class=""icon-social-instagram""></i></a></li>

                                            </ul>
                                        </div>
                                      ");
            WriteLiteral("  <div class=\"modal-product-meta ltn__product-details-menu-1 mb-30 d-none\">\r\n                                            <ul>\r\n                                                <li><strong>SKU:</strong> <span>");
#nullable restore
#line 134 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                           Write(Model.SKU);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                                                <li>
                                                    <strong>Categories:</strong>
                                                    <span>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5adc0955853193cd8fdb72e18ff21e2de7b6b65631908", async() => {
#nullable restore
#line 138 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                                                            Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_QuickView.cshtml"
                                                                                                          WriteLiteral(Model.id);

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
            WriteLiteral(@"
                                                    </span>
                                                </li>
                                                <li>
                                                    <strong>Tags:</strong>
                                                    <span>
                                                        <a href=""#"">Love</a>
                                                        <a href=""#"">Flower</a>
                                                        <a href=""#"">Heart</a>
                                                    </span>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""ltn__safe-checkout d-none"">
                                            <h5>Guaranteed Safe Checkout</h5>
                                            <img src=""img/icons/payment-2.png"" alt=""Payment Image"">
   ");
            WriteLiteral(@"                                     </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- MODAL AREA END -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

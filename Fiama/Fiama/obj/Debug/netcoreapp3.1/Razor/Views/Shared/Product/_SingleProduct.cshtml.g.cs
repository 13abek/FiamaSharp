#pragma checksum "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707efb765fa72334a3b4229c09b1cd43259a4ead"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Product__SingleProduct), @"mvc.1.0.view", @"/Views/Shared/Product/_SingleProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707efb765fa72334a3b4229c09b1cd43259a4ead", @"/Views/Shared/Product/_SingleProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc21f89d61f2ad103c1e782dd9c9e61d4da61ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Product__SingleProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-to-basket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add to Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#add_to_cart_modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-img\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707efb765fa72334a3b4229c09b1cd43259a4ead6497", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "707efb765fa72334a3b4229c09b1cd43259a4ead6713", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 141, "~/uploads/", 141, 10, true);
#nullable restore
#line 4 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
AddHtmlAttributeValue("", 151, Model.Images.FirstOrDefault(), 151, 30, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
AddHtmlAttributeValue("", 188, Model.Name, 188, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 4 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
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
            WriteLiteral("\r\n    <div class=\"product-badge\">\r\n        <ul>\r\n");
#nullable restore
#line 7 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
             if (Model.Discount != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"badge-2\">");
#nullable restore
#line 9 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
                               Write(Model.Discount.Percentage.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</li>\r\n");
#nullable restore
#line 10 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
             if (Model.Discount == null && Model.Label != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"badge-1\"");
            BeginWriteAttribute("style", " style=\"", 531, "\"", 574, 2);
            WriteAttributeValue("", 539, "background-color:", 539, 17, true);
#nullable restore
#line 14 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
WriteAttributeValue("", 556, Model.Label.Color, 556, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
                                                                           Write(Model.Label.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
    <div class=""product-hover-action product-hover-action-3"">
        <ul>
            <li>
                <a href=""#"" title=""Quick View"" data-toggle=""modal"" data-target=""#quick_view_modal"">
                    <i class=""icon-magnifier""></i>
                </a>
            </li>
            <li>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707efb765fa72334a3b4229c09b1cd43259a4ead13373", async() => {
                WriteLiteral("\r\n                    <i class=\"icon-handbag\"></i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
                                                            WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li>
                <a href=""#"" title=""Quick View"" data-toggle=""modal"" data-target=""#quick_view_modal"">
                    <i class=""icon-shuffle""></i>
                </a>
            </li>
        </ul>
    </div>
</div>
<div class=""product-info"">
    <div class=""product-ratting"">
        <ul>
");
#nullable restore
#line 41 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
             for (int i = 0; i < Model.StarCount; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a href=\"#\"><i class=\"icon-star\"></i></a></li>\r\n");
#nullable restore
#line 44 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <h2 class=\"product-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707efb765fa72334a3b4229c09b1cd43259a4ead17142", async() => {
#nullable restore
#line 47 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
                                                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
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
            WriteLiteral("</h2>\r\n    <div class=\"product-price\">\r\n");
#nullable restore
#line 49 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
         if (Model.Discount == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 51 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
             Write(Model.Price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</span>\r\n");
#nullable restore
#line 52 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
        }
        else
        {
            var price = Model.Price - (Model.Price * Model.Discount.Percentage / 100);

#line default
#line hidden
#nullable disable
            WriteLiteral("             <span>");
#nullable restore
#line 56 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
              Write(price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</span>\r\n            <del>");
#nullable restore
#line 57 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
            Write(Model.Price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</del>\r\n");
#nullable restore
#line 58 "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Product\_SingleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
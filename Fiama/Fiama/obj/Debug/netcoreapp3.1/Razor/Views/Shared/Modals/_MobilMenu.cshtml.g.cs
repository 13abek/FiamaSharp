#pragma checksum "C:\Users\Legion\Desktop\CoreLesson\Fiama\Fiama\Views\Shared\Modals\_MobilMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c695170aa0b524e7b3278d0144e1696c4fbdd2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Modals__MobilMenu), @"mvc.1.0.view", @"/Views/Shared/Modals/_MobilMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c695170aa0b524e7b3278d0144e1696c4fbdd2c", @"/Views/Shared/Modals/_MobilMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc21f89d61f2ad103c1e782dd9c9e61d4da61ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Modals__MobilMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Shoping Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Utilize Mobile Menu Start -->
<div id=""ltn__utilize-mobile-menu"" class=""ltn__utilize ltn__utilize-mobile-menu"">
    <div class=""ltn__utilize-menu-inner ltn__scrollbar"">
        <div class=""ltn__utilize-menu-head"">
            <div class=""site-logo"">
                <a href=""index.html""><img src=""img/logo.png"" alt=""Logo""></a>
            </div>
            <button class=""ltn__utilize-close"">×</button>
        </div>
        <div class=""ltn__utilize-menu-search-form"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c695170aa0b524e7b3278d0144e1696c4fbdd2c6040", async() => {
                WriteLiteral("\r\n                <input type=\"text\" placeholder=\"Search...\">\r\n                <button><i class=\"icon-magnifier\"></i></button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"ltn__utilize-menu\">\r\n            <ul>\r\n                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c695170aa0b524e7b3278d0144e1696c4fbdd2c7629", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
                <li><a href=""about.html"">About Us</a></li>
                <li>
                    <a href=""#"">Shop</a>
                    <ul class=""sub-menu"">
                        <li><a href=""cart.html"">Cart</a></li>
                        <li><a href=""wishlist.html"">Wishlist</a></li>
                        <li><a href=""checkout.html"">Checkout</a></li>
                        <li><a href=""account.html"">My Account</a></li>
                        <li><a href=""login.html"">Sign in</a></li>
                        <li><a href=""register.html"">Register</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""blog.html"">News</a>
                </li>
                <li>
                    <a href=""#"">About Us</a>
                </li>
                <li>
                    <a href=""contact.html"">Contact</a>
                </li>
            </ul>
        </div>
        <div class=""ltn__utilize-buttons ltn_");
            WriteLiteral(@"_utilize-buttons-2"">
            <ul>
                <li>
                    <a href=""account.html"" title=""My Account"">
                        <span class=""utilize-btn-icon"">
                            <i class=""icon-user""></i>
                        </span>
                        My Account
                    </a>
                </li>
                <li>
                    <a href=""wishlist.html"" title=""Wishlist"">
                        <span class=""utilize-btn-icon"">
                            <i class=""icon-heart""></i>
                            <sup>3</sup>
                        </span>
                        Wishlist
                    </a>
                </li>
                <li>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c695170aa0b524e7b3278d0144e1696c4fbdd2c10837", async() => {
                WriteLiteral("\r\n                        <span class=\"utilize-btn-icon\">\r\n                            <i class=\"icon-handbag\"></i>\r\n                            <sup>5</sup>\r\n                        </span>\r\n                        Shoping Cart\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        <div class=""ltn__social-media-2"">
            <ul>
                <li><a href=""#"" title=""Facebook""><i class=""icon-social-facebook""></i></a></li>
                <li><a href=""#"" title=""Twitter""><i class=""icon-social-twitter""></i></a></li>
                <li><a href=""#"" title=""Pinterest""><i class=""icon-social-pinterest""></i></a></li>
                <li><a href=""#"" title=""Instagram""><i class=""icon-social-instagram""></i></a></li>
            </ul>
        </div>
    </div>
</div>
<!-- Utilize Mobile Menu End -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
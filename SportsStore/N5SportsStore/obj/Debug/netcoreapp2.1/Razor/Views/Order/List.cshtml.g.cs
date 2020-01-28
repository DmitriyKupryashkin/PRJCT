#pragma checksum "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ec3334dea8f13a8a7bfe763958746b28ce8f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\_ViewImports.cshtml"
using N5SportsStore.Models;

#line default
#line hidden
#line 2 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\_ViewImports.cshtml"
using N5SportsStore.Models.ViewModels;

#line default
#line hidden
#line 3 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\_ViewImports.cshtml"
using N5SportsStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ec3334dea8f13a8a7bfe763958746b28ce8f24", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb76a3872a85b933ec247cf328155ae62f3bdc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
  
    ViewBag.Title = "Orders";
    Layout = "_AdminLayout";

#line default
#line hidden
#line 7 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(125, 137, true);
            WriteLiteral("    <table class=\"table table-bordered table-striped\">\r\n        <tr><th>Name</th><th>Zip</th><th colspan=\"2\">Details</th><th></th></tr>\r\n");
            EndContext();
#line 11 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
         foreach (Order o in Model)
        {

#line default
#line hidden
            BeginContext(310, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(349, 6, false);
#line 14 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
               Write(o.Name);

#line default
#line hidden
            EndContext();
            BeginContext(355, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(383, 5, false);
#line 15 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
               Write(o.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(388, 118, true);
            WriteLiteral("</td>\r\n                <th>Product</th>\r\n                <th>Quantity</th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(506, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3b3da05eef43cd8ca7c5c3eddfab08", async() => {
                BeginContext(551, 63, true);
                WriteLiteral("\r\n                          <input type=\"hidden\" name=\"orderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 614, "\"", 632, 1);
#line 20 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
WriteAttributeValue("", 622, o.OrderID, 622, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(633, 159, true);
                WriteLiteral("/>\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                        Ship\r\n                    </button>\r\n                    ");
                EndContext();
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
            EndContext();
            BeginContext(799, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
             foreach (CartLine line in o.Lines)
            {

#line default
#line hidden
            BeginContext(907, 89, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\"></td>\r\n                    <td>");
            EndContext();
            BeginContext(997, 17, false);
#line 31 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
                   Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1046, 13, false);
#line 32 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
            }

#line default
#line hidden
#line 34 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1115, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 37 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1141, 56, true);
            WriteLiteral("    <div class=\"text-center\">No Unshipped Orders</div>\r\n");
            EndContext();
#line 41 "F:\Программирование\Project\PortfolioRepo\SportsStore\N5SportsStore\Views\Order\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

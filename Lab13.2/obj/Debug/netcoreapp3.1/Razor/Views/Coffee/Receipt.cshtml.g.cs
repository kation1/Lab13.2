#pragma checksum "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689f572d4c4cb287a76449236586a153247d0fb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coffee_Receipt), @"mvc.1.0.view", @"/Views/Coffee/Receipt.cshtml")]
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
#line 1 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\_ViewImports.cshtml"
using Lab13._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\_ViewImports.cshtml"
using Lab13._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689f572d4c4cb287a76449236586a153247d0fb1", @"/Views/Coffee/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf24838dd218c2f8439262bc72fdcd3893e2248", @"/Views/_ViewImports.cshtml")]
    public class Views_Coffee_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab13._2.Models.CoffeeOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/myStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "689f572d4c4cb287a76449236586a153247d0fb14086", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml"
  
    ViewBag.Title = "Receipt";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Receipt</h2>\r\n\r\n\r\nOrder Number: #001\r\n<br />\r\n\r\nName: ");
#nullable restore
#line 16 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml"
 Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h4>Order Details: <br />  </h4>\r\n\r\n<p>");
#nullable restore
#line 20 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml"
Write(Model.CoffeeType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />  </p>\r\n<p>");
#nullable restore
#line 21 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml"
Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />  </p>\r\n<p>");
#nullable restore
#line 22 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml"
Write(Model.Pickup);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /></p>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<h4>Expected Order Time:</h4>\r\n");
#nullable restore
#line 29 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Coffee\Receipt.cshtml"
Write(ViewBag.TimeMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab13._2.Models.CoffeeOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
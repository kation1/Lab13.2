#pragma checksum "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5a86ec66d70b59bc2ebb3334d7b4025ee77302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateProduct), @"mvc.1.0.view", @"/Views/Admin/UpdateProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5a86ec66d70b59bc2ebb3334d7b4025ee77302", @"/Views/Admin/UpdateProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf24838dd218c2f8439262bc72fdcd3893e2248", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/AddProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml"
  
    ViewData["Title"] = "UpdateProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>UpdateProduct</h1>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5a86ec66d70b59bc2ebb3334d7b4025ee773024080", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td> Id Number:</td>\r\n            <td><input type=\"number\" readonly");
                BeginWriteAttribute("placeholder", " placeholder=", 252, "", 274, 1);
#nullable restore
#line 14 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 265, Model.id, 265, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td> Product Name:</td>\r\n            <td><input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=", 394, "", 418, 1);
#nullable restore
#line 18 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 407, Model.Name, 407, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Price:</td>\r\n            <td><input type=\"number\"");
                BeginWriteAttribute("placeholder", " placeholder=", 534, "", 559, 1);
#nullable restore
#line 22 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 547, Model.Price, 547, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Price\" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td> Desciption:</td>\r\n            <td><input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=", 680, "", 711, 1);
#nullable restore
#line 26 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 693, Model.Description, 693, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Description\" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td> Category:</td>\r\n            <td> <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=", 837, "", 865, 1);
#nullable restore
#line 30 "C:\devbuild\Week11\Lab13.2\Lab13.2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 850, Model.Category, 850, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Category\" /> </td>\r\n        </tr>\r\n\r\n        <tr> <td><input type=\"submit\" /></td>   </tr>\r\n\r\n\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

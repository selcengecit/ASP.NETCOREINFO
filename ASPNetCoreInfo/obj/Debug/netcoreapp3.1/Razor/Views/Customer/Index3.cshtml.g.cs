#pragma checksum "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83230575a69f89032a730d4421d7ee644902d5ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index3), @"mvc.1.0.view", @"/Views/Customer/Index3.cshtml")]
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
#line 1 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\_ViewImports.cshtml"
using ASPNetCoreInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\_ViewImports.cshtml"
using ASPNetCoreInfo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83230575a69f89032a730d4421d7ee644902d5ea", @"/Views/Customer/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b8b1db51041db98119091a5c7118a27024d992", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerListViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83230575a69f89032a730d4421d7ee644902d5ea3496", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index3</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83230575a69f89032a730d4421d7ee644902d5ea4556", async() => {
                WriteLiteral("\r\n    <table>\r\n");
#nullable restore
#line 15 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
         foreach (var customer in Model.Customers)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
               Write(customer.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
               Write(customer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
               Write(customer.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
               Write(customer.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
         foreach (var shops  in Model.Shops)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"
               Write(shops);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\selcuk\source\repos\ASPNetCoreInfo\ASPNetCoreInfo\Views\Customer\Index3.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52cc420b9c79889950bc6de508f3fb3cae2143c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Online_Views_QuestionAnswers_Index1), @"mvc.1.0.view", @"/Areas/Online/Views/QuestionAnswers/Index1.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\_ViewImports.cshtml"
using LMS.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cc420b9c79889950bc6de508f3fb3cae2143c6", @"/Areas/Online/Views/QuestionAnswers/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0240ba85f5adc2901295b7e665777794fa27d1ed", @"/Areas/Online/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Online_Views_QuestionAnswers_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LMS.Web.Models.QuestionAnswer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Online", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Results", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<h1 style=\"text-align:center;color:blue\"> HTML Exam</h1>\r\n<h4 style=\"color:red\">There is 10 Questions each question conatins(1 point)</h4>\r\n<p style=\"color:green\">You must get 8 points to pass the test!(Less than 8 points you will be fail)</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52cc420b9c79889950bc6de508f3fb3cae2143c64977", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
 foreach (var item in Model)
{
    var rdoName = "q" + item.QuestionAnswerId;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <table class=\"table\">\r\n   <tr>\r\n    <td>");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
   Write(item.QuestionAnswerId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ) ");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
                            Write(item.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ?</td>\r\n        </tr>\r\n           \r\n        <tr>\r\n            <td>\r\n                <p>\r\n              <input id=\"option1\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 733, "\"", 748, 1);
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 740, rdoName, 740, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 760, "\"", 781, 1);
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 768, item.Option1, 768, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
                                                                                             Write(item.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                <input id=\"option2\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 891, "\"", 906, 1);
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 898, rdoName, 898, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 918, "\"", 939, 1);
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 926, item.Option2, 926, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
                                                                                               Write(item.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                <input id=\"optio3\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 1048, "\"", 1063, 1);
#nullable restore
#line 29 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 1055, rdoName, 1055, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 1075, "\"", 1096, 1);
#nullable restore
#line 29 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 1083, item.Option3, 1083, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 29 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
                                                                                              Write(item.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <p>\r\n                <input id=\"option4\" type=\"radio\"");
                BeginWriteAttribute("name", " name=\"", 1206, "\"", 1221, 1);
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 1213, rdoName, 1213, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rb\"");
                BeginWriteAttribute("value", " value=\"", 1233, "\"", 1254, 1);
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
WriteAttributeValue("", 1241, item.Option4, 1241, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
                                                                                               Write(item.Option4);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n            </td> \r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\Users\LENOVO\source\repos\Praveen2333\FinalProject\Areas\Online\Views\QuestionAnswers\Index1.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("  <button class=\"btn btn-primary\" value=\"Submit\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LMS.Web.Models.QuestionAnswer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

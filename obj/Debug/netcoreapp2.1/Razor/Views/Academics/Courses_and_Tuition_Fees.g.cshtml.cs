#pragma checksum "D:\7th Semester\CSC 440\C#\Educational Institute\Educational Institute\Views\Academics\Courses_and_Tuition_Fees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7602a9d2ecb9ff6041fdbdf2af54e51d82794978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Academics_Courses_and_Tuition_Fees), @"mvc.1.0.view", @"/Views/Academics/Courses_and_Tuition_Fees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Academics/Courses_and_Tuition_Fees.cshtml", typeof(AspNetCore.Views_Academics_Courses_and_Tuition_Fees))]
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
#line 1 "D:\7th Semester\CSC 440\C#\Educational Institute\Educational Institute\Views\_ViewImports.cshtml"
using Educational_Institute;

#line default
#line hidden
#line 2 "D:\7th Semester\CSC 440\C#\Educational Institute\Educational Institute\Views\_ViewImports.cshtml"
using Educational_Institute.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7602a9d2ecb9ff6041fdbdf2af54e51d82794978", @"/Views/Academics/Courses_and_Tuition_Fees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f71a5992f2d2c9b2d17a09e0c07fa09e7440341", @"/Views/_ViewImports.cshtml")]
    public class Views_Academics_Courses_and_Tuition_Fees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n");
            EndContext();
            BeginContext(19, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73788d12f19e48d38975a29858bc6036", async() => {
                BeginContext(25, 46, true);
                WriteLiteral("\r\n    <title>Educational Institute</title>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(80, 3399, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9ea22fcaa14f698baa3fe23d5609da", async() => {
                BeginContext(86, 202, true);
                WriteLiteral("\r\n\r\n    <style>\r\n        .Header {\r\n        }\r\n\r\n            .Header img {\r\n                width: 100%;\r\n                height: 150px\r\n            }\r\n    </style>\r\n\r\n    <div class=\"Header\">\r\n        ");
                EndContext();
                BeginContext(288, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd714532928649e3b8b7e889cc062108", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(321, 3151, true);
                WriteLiteral(@"
    </div>


    <nav class=""navbar navbar-inverse"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <a class=""navbar-brand"" href=""Home"">Educational Institute</a>
            </div>
            <ul class=""nav navbar-nav"">
                <li class=""active""><a href=""Home"">Home</a></li>

                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""About"">About<span class=""caret""></span></a>
                    <ul class=""dropdown-menu"">
                        <li><a href=""About/Information"">Information</a></li>
                        <li><a href=""About/Mission"">Mission</a></li>
                        <li><a href=""About/Chancellor_and_Principal_Officers"">Chancellor and Principal Officers</a></li>
                    </ul>
                </li>



                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Academics<span class=""care");
                WriteLiteral(@"t""></span></a>
                    <ul class=""dropdown-menu"">
                        <li><a href=""Academics/Courses_and_Tuition_Fees"">Courses & Tuition Fees</a></li>
                        <li><a href=""Academics/Academic_Calender"">Academic Calender</a></li>
                    </ul>
                </li>

                <li><a href=""Faculty"">Faculty</a></li>
                <li><a href=""Admission"">Admission</a></li>
                <li><a href=""Contact"">Contact</a></li>

            </ul>
            <ul class=""nav navbar-nav navbar-right"">
                <li><a href=""Sign_Up""><span class=""glyphicon glyphicon-user""></span> Sign Up</a></li>
                <li><a href=""Login""><span class=""glyphicon glyphicon-log-in""></span> Login</a></li>
            </ul>
        </div>
    </nav>


    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <th>Department</th>
                    <th>Credit</th>
                    <th>Fees(Taka)</th>
  ");
                WriteLiteral(@"              </tr>
            </thead>
            <tbody>
                <tr>
                    <td>BCSE</td>
                    <td>143</td>
                    <td>650000</td>
                </tr>
                <tr class=""success"">
                    <td>BSEEE</td>
                    <td>166</td>
                    <td>675000</td>
                </tr>
                <tr class=""danger"">
                    <td>BSME</td>
                    <td>165</td>
                    <td>674000</td>
                </tr>
                <tr class=""info"">
                    <td>BSCE</td>
                    <td>167</td>
                    <td>680000</td>
                </tr>
                <tr class=""warning"">
                    <td>BBA</td>
                    <td>136</td>
                    <td>610000</td>
                </tr>
                <tr class=""active"">
                    <td>BSAG</td>
                    <td>149</td>
                    <td>550000</td>
  ");
                WriteLiteral("              </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3479, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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

#pragma checksum "D:\7th Semester\CSC 440\C#\Educational Institute\Educational Institute\Views\Sign_Up\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1fc0e0bfe1d69d5a9d7276a3ce1e0d4b75ca812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sign_Up_Index), @"mvc.1.0.view", @"/Views/Sign_Up/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sign_Up/Index.cshtml", typeof(AspNetCore.Views_Sign_Up_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fc0e0bfe1d69d5a9d7276a3ce1e0d4b75ca812", @"/Views/Sign_Up/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f71a5992f2d2c9b2d17a09e0c07fa09e7440341", @"/Views/_ViewImports.cshtml")]
    public class Views_Sign_Up_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n");
            EndContext();
            BeginContext(19, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2175757563fb49bab4c0920014ec2005", async() => {
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
            BeginContext(80, 4827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d12831ff3a254f429ac1bafa6fda549a", async() => {
                BeginContext(86, 525, true);
                WriteLiteral(@"

    <style>
        .Header {
        }

            .Header img {
                width: 100%;
                height: 150px
            }

        .signup_form {
            margin: auto;
            width: 90%;
            height: 500px;
            border: 3px solid green;
            padding: 10px;
           
        }
        h2{
            text-align:center
        }

        .register-btn {
            text-align: center
        }

    </style>

    <div class=""Header"">
        ");
                EndContext();
                BeginContext(611, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf3448d85bd34c24a6f588f57674d35d", async() => {
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
                BeginContext(644, 1914, true);
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
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">About<span class=""caret""></span></a>
                    <ul class=""dropdown-menu"">
                        <li><a href=""About/Information"">Information</a></li>
                        <li><a href=""About/Mission"">Mission</a></li>
                        <li><a href=""About/Chancellor_and_Principal_Officers"">Chancellor and Principal Officers</a></li>
                    </ul>
                </li>



                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Academics<span class=""caret""><");
                WriteLiteral(@"/span></a>
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


    <div class=""signup_form"">

        <h2><b>Sign-Up</b></h2>

        ");
                EndContext();
                BeginContext(2558, 2324, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9fbd12025b44b0d83cd34506c7ad383", async() => {
                    BeginContext(2588, 2287, true);
                    WriteLiteral(@"
            
            <div class=""form-group"">
                <label for=""inputName"" class=""control-label col-xs-2"">Name</label>
                <div class=""col-xs-10"">
                    <input type=""Name"" class=""form-control"" id=""inputName"" placeholder=""Name"">
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputPhone"" class=""control-label col-xs-2"">Phone Number</label>
                <div class=""col-xs-10"">
                    <input type=""Phone"" class=""form-control"" id=""inputPhone"" placeholder=""Phone"">
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputAddress"" class=""control-label col-xs-2"">Address</label>
                <div class=""col-xs-10"">
                    <input type=""Address"" class=""form-control"" id=""inputAddress"" placeholder=""Address"">
                </div>
            </div>

            <div class=""form-group"">
                <label for=""");
                    WriteLiteral(@"inputAuthorization"" class=""control-label col-xs-2"">Authorization Code</label>
                <div class=""col-xs-10"">
                    <input type=""Authorization"" class=""form-control"" id=""inputAuthorization"" placeholder=""Authorization"">
                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputPassword"" class=""control-label col-xs-2"">Password</label>
                <div class=""col-xs-10"">
                    <input type=""password"" class=""form-control"" id=""inputPassword"" placeholder=""Password"">
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputPassword"" class=""control-label col-xs-2"">Re-type Password</label>
                <div class=""col-xs-10"">
                    <input type=""password"" class=""form-control"" id=""inputPassword"" placeholder=""Re-type Password"">
                </div>
            </div>
            <div class=""register-btn"">
                <div class=""form-");
                    WriteLiteral("group\">\r\n                    <div class=\"col-xs-offset-2 col-xs-10\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4882, 18, true);
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
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
            BeginContext(4907, 11, true);
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
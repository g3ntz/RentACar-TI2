#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "687d651cb5b72c1ca1f7629567bd07281c7a6e66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"687d651cb5b72c1ca1f7629567bd07281c7a6e66", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.ViewModels.LoginViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(73, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "687d651cb5b72c1ca1f7629567bd07281c7a6e662932", async() => {
                BeginContext(79, 83, true);
                WriteLiteral("\r\n    <style>\r\n        label {\r\n            color:white;\r\n        }\r\n    </style>\r\n");
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
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(171, 1405, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "687d651cb5b72c1ca1f7629567bd07281c7a6e664205", async() => {
                BeginContext(177, 225, true);
                WriteLiteral("\r\n    <div class=\"row m-0\">\r\n        <form action=\"/Account/Login\" method=\"POST\" class=\"col-11 col-lg-4 login-page mx-auto mt-5\" style=\"margin-bottom:142px; border-radius: 15px; background-color: currentcolor;\">\r\n            ");
                EndContext();
                BeginContext(403, 23, false);
#line 15 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(426, 195, true);
                WriteLiteral("\r\n            <h3 class=\"text-center pt-3\" style=\"color:var(--primary-color);\">Login</h3>\r\n            <div class=\"form-row \">\r\n                <div class=\"form-group px-3\">\r\n                    ");
                EndContext();
                BeginContext(622, 37, false);
#line 19 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
               Write(Html.LabelFor(x => x.UsernameOrEmail));

#line default
#line hidden
                EndContext();
                BeginContext(659, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(682, 91, false);
#line 20 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
               Write(Html.TextBoxFor(x => x.UsernameOrEmail, new { @class = "form-control", @maxLength = "50" }));

#line default
#line hidden
                EndContext();
                BeginContext(773, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(796, 49, false);
#line 21 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
               Write(Html.ValidationMessageFor(x => x.UsernameOrEmail));

#line default
#line hidden
                EndContext();
                BeginContext(845, 98, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group px-3 pb-3\">\r\n                    ");
                EndContext();
                BeginContext(944, 30, false);
#line 24 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
               Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(974, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(997, 105, false);
#line 25 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
               Write(Html.TextBoxFor(x => x.Password, new { @type = "password", @class = "form-control", @maxLength = "100" }));

#line default
#line hidden
                EndContext();
                BeginContext(1102, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1125, 42, false);
#line 26 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
               Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
                EndContext();
                BeginContext(1167, 28, true);
                WriteLiteral("\r\n                </div>\r\n\r\n");
                EndContext();
#line 29 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
                 if (ViewBag.InvalidData == true)
                {

#line default
#line hidden
                BeginContext(1265, 133, true);
                WriteLiteral("                    <p class=\"field-validation-error text-center\" style=\"margin: 10px auto;\">Invalid Username/Email or Password</p>\r\n");
                EndContext();
#line 32 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Login.cshtml"
                }

#line default
#line hidden
                BeginContext(1417, 152, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn login-btn col-12 mb-3 mt-2\">Sign In</button>\r\n            </div>\r\n        </form>\r\n    </div>\r\n    \r\n");
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
            BeginContext(1576, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.ViewModels.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

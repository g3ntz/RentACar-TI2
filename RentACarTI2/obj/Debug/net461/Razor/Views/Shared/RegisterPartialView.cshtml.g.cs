#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\RegisterPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe7ad91d503f246a0b7661d8da3c146caa7f4e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RegisterPartialView), @"mvc.1.0.view", @"/Views/Shared/RegisterPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/RegisterPartialView.cshtml", typeof(AspNetCore.Views_Shared_RegisterPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe7ad91d503f246a0b7661d8da3c146caa7f4e9", @"/Views/Shared/RegisterPartialView.cshtml")]
    public class Views_Shared_RegisterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.ViewModels.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 4371, true);
            WriteLiteral(@"
<div id=""register-modal"" class=""modal fade"" tabindex=""-1"">
    <div class=""modal-dialog"" style=""max-width: 700px;"">
        <form method=""post"" action=""/account/register"" class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Register</h5>
                <a class=""close"" href=""#"" data-dismiss=""modal"">×</a>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""register-personal-infos row mt-3 px-0 mx-auto"">
                        <h5 style=""color: var(--primary-color);"">Personal Infos</h5>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""name"">Name:</label>
                            <input id=""name"" class=""form-control"" type=""text"" name=""client.Name"">
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""surname"">Surn");
            WriteLiteral(@"ame:</label>
                            <input id=""surname"" class=""form-control"" type=""text"" name=""client.Surname"">
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""age"">Age:</label>
                            <input id=""age"" class=""form-control"" type=""text"" name=""client.Age"">
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""birthdate"">Birthdate:</label>
                            <input id=""birthdate"" class=""form-control"" type=""date"" name=""client.Birthdate"">
                        </div>
                        <div class=""form-group col-12"">
                            <label for=""drivingLicense"">Driving License:</label>
                            <input id=""drivingLicense"" class=""form-control"" type=""text"" name=""client.DrivingLicense"">
                        </div>
                    </div>

                    <");
            WriteLiteral(@"div class=""register-contact-infos row mt-4 px-0 mx-auto"">
                        <h5 style=""color: var(--primary-color);"">Contact Infos</h5>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""address"">Address:</label>
                            <textarea id=""address"" class=""form-control"" name=""client.Address"" type=""text"" style=""height: 63px; max-height: 63px;""></textarea>
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""phoneNr"">Phone Nr:</label>
                            <input id=""phoneNr"" class=""form-control"" type=""tel"" name=""client.PhoneNr"">
                        </div>
                    </div>

                    <div class=""register-login-infos row mb-4 mt-4 px-0 mx-auto"">
                        <h5 style=""color: var(--primary-color);"">Login Infos</h5>
                        <div class=""form-group col-12 col-sm-6"">
                        ");
            WriteLiteral(@"    <label for=""username"">Username:</label>
                            <input id=""username"" class=""form-control"" type=""text"" name=""user.Username"">
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""email"">Email Address:</label>
                            <input id=""email"" class=""form-control"" type=""email"" name=""user.Email"">
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""password"">Password:</label>
                            <input id=""password"" class=""form-control"" type=""password"" name=""user.Password"">
                        </div>
                        <div class=""form-group col-12 col-sm-6"">
                            <label for=""confirmPassword"">Confirm Password:</label>
                            <input id=""confirmPassword"" class=""form-control"" type=""password"">
                        </div>
                    ");
            WriteLiteral(@"</div>

                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""submit"" class=""btn login-btn col-11 col-sm-11 col-md-3 col-lg-2 col-xl-2"">Sign Up</button>
            </div>
        </form>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

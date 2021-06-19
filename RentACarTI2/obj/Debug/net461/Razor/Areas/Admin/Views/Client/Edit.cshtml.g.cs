#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9df580f5546d27e9c6fbefd6bd8d55eb598c403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Client_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Client/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Client/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Client_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9df580f5546d27e9c6fbefd6bd8d55eb598c403", @"/Areas/Admin/Views/Client/Edit.cshtml")]
    public class Areas_Admin_Views_Client_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
  
    ViewBag.ClientActive = "active";
    ViewBag.Page = "Clients";
    ViewBag.Title = "Rent a Car - Edit Client";

#line default
#line hidden
            BeginContext(159, 567, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <form class=""form-row card"" method=""POST"" action=""/Admin/Client/Edit"">
            <input name=""ClientID"" type=""hidden"" />
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Edit Client</h4>
                <p class=""card-category"">Edit existing client</p>
            </div>
            <div class=""card-body row"">
                <div class=""col-12 col-sm-6 input-group form-group no-border"">
                    <input type=""text"" name=""Name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 726, "\"", 745, 1);
#line 18 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
WriteAttributeValue("", 734, Model.Name, 734, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(746, 203, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Name...\">\r\n                </div>\r\n                <div class=\"col-12 col-sm-6 input-group form-group no-border\">\r\n                    <input type=\"text\" name=\"Surname\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 949, "\"", 971, 1);
#line 21 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
WriteAttributeValue("", 957, Model.Surname, 957, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(972, 209, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Surname...\">\r\n                </div>\r\n                <div class=\"col-12 col-sm-6 input-group form-group no-border mt-3\">\r\n                    <input type=\"text\" name=\"Email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1181, "\"", 1201, 1);
#line 24 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
WriteAttributeValue("", 1189, Model.Email, 1189, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1202, 208, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Email...\">\r\n                </div>\r\n                <div class=\"col-12 col-sm-6 input-group form-group no-border mt-3\">\r\n                    <input type=\"tel\" name=\"PhoneNr\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1410, "\"", 1432, 1);
#line 27 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
WriteAttributeValue("", 1418, Model.PhoneNr, 1418, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1433, 214, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Phone Nr...\">\r\n                </div>\r\n                <div class=\"col-12 col-sm-6 input-group form-group no-border mt-3\">\r\n                    <input type=\"date\" name=\"Birthdate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1647, "\"", 1703, 1);
#line 30 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
WriteAttributeValue("", 1655, string.Format("{0:yyyy-MM-dd}",Model.Birthdate), 1655, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1704, 219, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Birthdate...\">\r\n                </div>\r\n                <div class=\"col-12 col-sm-6 input-group form-group no-border mt-3\">\r\n                    <input type=\"tel\" name=\"DrivingLicense\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1923, "\"", 1952, 1);
#line 33 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
WriteAttributeValue("", 1931, Model.DrivingLicense, 1931, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1953, 248, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Driving License...\">\r\n                </div>\r\n                <div class=\"col-12 input-group form-group no-border mt-3\">\r\n                    <textarea class=\"form-control\" name=\"Address\" placeholder=\"Address...\">");
            EndContext();
            BeginContext(2202, 13, false);
#line 36 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Client\Edit.cshtml"
                                                                                      Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2215, 521, true);
            WriteLiteral(@"</textarea>
                </div>
                <div class=""row col-12"">
                    <div class=""col-12 col-sm-6"">
                        <a href=""/Admin/Client/Index"" class=""btn mt-3"">Back to Clients</a>
                    </div>
                    <div class=""col-12 col-sm-6"">
                        <button type=""submit"" class=""btn btn-primary mt-3 float-right"">Edit Client</button>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2755, 71, true);
                WriteLiteral("\r\n    <script src=\"/Admin/Content/js/material-dashboard.js\"></script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591

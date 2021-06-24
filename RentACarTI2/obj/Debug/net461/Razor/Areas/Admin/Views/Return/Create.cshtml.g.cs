#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2285e6cca9aa7004a35416806d526b638a54114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Return_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Return/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Return/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Return_Create))]
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
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
using RentACarTI2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2285e6cca9aa7004a35416806d526b638a54114", @"/Areas/Admin/Views/Return/Create.cshtml")]
    public class Areas_Admin_Views_Return_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.Models.Rental_Return>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
  
    var rental = (Rental_Return)ViewBag.Rental;

#line default
#line hidden
            BeginContext(124, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(143, 421, true);
                WriteLiteral(@"
    <style>
        hr {
            border: 0;
            clear: both;
            display: block;
            width: 100%;
            background-color: #9c27b0;
            height: 1px;
            margin: 0;
        }

        h5 {
            color: #d9e0e0;
            font-size: 1.1em;
        }

        h4 {
            color: white;
            font-size: 1.5em;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(567, 214, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <form class=\"form card\" method=\"POST\" action=\"/Admin/Return/Create\">\r\n            <input type=\"hidden\" id=\"Rental_ReturnID\" name=\"Rental_ReturnID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 781, "\"", 812, 1);
#line 35 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
WriteAttributeValue("", 789, rental.Rental_ReturnID, 789, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(813, 459, true);
            WriteLiteral(@" />
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Create Return</h4>
                <p class=""card-category"">Create a new return</p>
            </div>
            <div class=""card-body row"">
                <div class=""col-6"">
                    <div class=""col-12 input-group form-group justify-content-between mt-3"">
                        <h5>Reservation ID:</h5>
                        <h5>");
            EndContext();
            BeginContext(1273, 16, false);
#line 44 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                       Write(rental.BookingID);

#line default
#line hidden
            EndContext();
            BeginContext(1289, 231, true);
            WriteLiteral("</h5>\r\n                        <hr />\r\n                    </div>\r\n                    <div class=\"col-12 input-group form-group justify-content-between mt-3\">\r\n                        <h5>Client:</h5>\r\n                        <h5>");
            EndContext();
            BeginContext(1521, 18, false);
#line 49 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                       Write(rental.clientInfos);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 232, true);
            WriteLiteral("</h5>\r\n                        <hr />\r\n                    </div>\r\n                    <div class=\"col-12 input-group form-group justify-content-between mt-3\">\r\n                        <h5>Vehicle:</h5>\r\n                        <h5>");
            EndContext();
            BeginContext(1772, 19, false);
#line 54 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                       Write(rental.vehicleInfos);

#line default
#line hidden
            EndContext();
            BeginContext(1791, 301, true);
            WriteLiteral(@"</h5>
                        <hr />
                    </div>
                    <div class=""col-12 input-group form-group justify-content-between mt-3"">
                        <textarea class=""form-control"" name=""VehicleActualConditionRental_Return"" placeholder=""Vehicle Actual Condition..."">");
            EndContext();
            BeginContext(2093, 42, false);
#line 58 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                                                                                                                                       Write(rental.VehicleActualConditionRental_Return);

#line default
#line hidden
            EndContext();
            BeginContext(2135, 907, true);
            WriteLiteral(@"</textarea>
                    </div>
                </div>

                <div class=""col-6"">
                    <div class=""col-12 input-group form-group justify-content-between mt-3"">
                        <input type=""text"" name=""FuelAmount"" class=""form-control"" placeholder=""Fuel Amount..."">
                    </div>
                    <div class=""col-12 input-group form-group justify-content-between mt-3 mb-4"">
                        <input type=""text"" name=""Mileage"" class=""form-control"" placeholder=""Mileage..."">
                    </div>

                    <div class=""col-12 input-group form-group justify-content-between"" style=""margin-top: 80px;"">
                        <textarea class=""form-control"" name=""Fee.Reason"" placeholder=""Damages... (If any)""></textarea>
                    </div>
                    <div class=""col-12 input-group form-group mt-4"">
");
            EndContext();
#line 74 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                         if (ViewBag.DaysLate > 0)
                        {

#line default
#line hidden
            BeginContext(3121, 169, true);
            WriteLiteral("                            <i class=\"material-icons text-info\">info</i>\r\n                            <p class=\"text-info\">hmm... it seems that this vehicle is returned ");
            EndContext();
            BeginContext(3291, 16, false);
#line 77 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                                                                                          Write(ViewBag.DaysLate);

#line default
#line hidden
            EndContext();
            BeginContext(3307, 898, true);
            WriteLiteral(@" days late</p>
                            <p class=""col-12 text-warning"">
                                Late fee will be calculated automatically and this return transaction will stay open.<br>
                                You have to manually close this transaction when late fee is paid by client.
                            </p>
                            <div class=""form-check"">
                                <label class=""form-check-label"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""isReturnedInTime"" value=""true"">No, this vehicle is returned in time... We're late.
                                    <span class=""form-check-sign"">
                                        <span class=""check""></span>
                                    </span>
                                </label>
                            </div>
");
            EndContext();
#line 90 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Create.cshtml"
                        }

#line default
#line hidden
            BeginContext(4232, 897, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col-12 input-group form-group justify-content-between mt-3"">
                        <a href=""#"" rel=""tooltip"" title="""" data-original-title=""Print Invoice"">
                            <i class=""material-icons primary-color"" style=""font-size: 40px;"">print</i>
                        </a>
                    </div>
                </div>

                <div class=""row col-12"">
                    <div class=""col-12 col-sm-6"">
                        <a href=""/Admin/Rental/Index"" class=""btn mt-3"">Back to Rentals</a>
                    </div>
                    <div class=""col-12 col-sm-6"">
                        <button type=""submit"" class=""btn btn-primary mt-3 float-right"">Create Return</button>
                    </div>
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.Models.Rental_Return> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3962f4fbf246404a690b28bddb8d29f205e31473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Return_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Return/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Return/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Return_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3962f4fbf246404a690b28bddb8d29f205e31473", @"/Areas/Admin/Views/Return/Index.cshtml")]
    public class Areas_Admin_Views_Return_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RentACarTI2.Models.Rental_Return>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
  
    ViewBag.ReturnActive = "active";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(111, 459, true);
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

        #fullDetailsModal h5 {
            color: #d9e0e0;
            font-size: 1.1em;
        }

        #fullDetailsModal h4 {
            color: #d9e0e0;
            font-size: 1.5em;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(573, 2399, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""input-group no-border"">
                    <input id=""searchReturn"" onkeyup=""myFunction()"" type=""text"" value="""" class=""form-control"" placeholder=""Search Return..."">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title "">Returns Table</h4>
                        <p class=""card-category""> Returns Informations</p>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table id=""returnsTable"" class=""table table-hover"">
                                <thead class="" text-primary"">
                                    <tr>
                   ");
            WriteLiteral(@"                     <th></th>
                                        <th>
                                            ID
                                        </th>
                                        <th>
                                            Date
                                        </th>
                                        <th>
                                            Client
                                        </th>
                                        <th>
                                            Vehicle
                                        </th>
                                        <th>
                                            Fuel Amount
                                        </th>
                                        <th>
                                            Mileage
                                        </th>
                                        <th>
                                            Has Damage
                   ");
            WriteLiteral(@"                     </th>
                                        <th>
                                            Is Late
                                        </th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 81 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                     foreach (var _return in Model)
                                    {

#line default
#line hidden
            BeginContext(3080, 96, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n");
            EndContext();
#line 85 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                                 if (_return.IsClosed == true)
                                                {

#line default
#line hidden
            BeginContext(3307, 109, true);
            WriteLiteral("                                                    <img src=\"/Admin/Content/assets/img/greenCircle.png\" />\r\n");
            EndContext();
#line 88 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3572, 107, true);
            WriteLiteral("                                                    <img src=\"/Admin/Content/assets/img/redCircle.png\" />\r\n");
            EndContext();
#line 92 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3730, 149, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3880, 23, false);
#line 95 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                           Write(_return.Rental_ReturnID);

#line default
#line hidden
            EndContext();
            BeginContext(3903, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4055, 35, false);
#line 98 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                           Write(_return.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4090, 55, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n");
            EndContext();
#line 101 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                             if (_return.clientInfos == " ")
                                            {

#line default
#line hidden
            BeginContext(4270, 92, true);
            WriteLiteral("                                                <td style=\"color:red;\">Deleted Client</td>\r\n");
            EndContext();
#line 104 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4506, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(4559, 19, false);
#line 107 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                               Write(_return.clientInfos);

#line default
#line hidden
            EndContext();
            BeginContext(4578, 10, true);
            WriteLiteral("</td>   \r\n");
            EndContext();
#line 108 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4635, 100, true);
            WriteLiteral("\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4736, 20, false);
#line 111 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                           Write(_return.vehicleInfos);

#line default
#line hidden
            EndContext();
            BeginContext(4756, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4908, 18, false);
#line 114 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                           Write(_return.FuelAmount);

#line default
#line hidden
            EndContext();
            BeginContext(4926, 153, true);
            WriteLiteral(" L\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5080, 15, false);
#line 117 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                           Write(_return.Mileage);

#line default
#line hidden
            EndContext();
            BeginContext(5095, 55, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n");
            EndContext();
#line 121 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                               bool hasDamage = false; 

#line default
#line hidden
            BeginContext(5302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 123 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                             foreach (var fee in _return.Fees)
                                            {
                                                if(fee.IsLate == false) 
                                                {
                                                    hasDamage = true;
                                                }
                                            }

#line default
#line hidden
            BeginContext(5725, 46, true);
            WriteLiteral("                                            \r\n");
            EndContext();
#line 131 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                             if (hasDamage) 
                                            {

#line default
#line hidden
            BeginContext(5880, 81, true);
            WriteLiteral("                                                <td style=\"color:red;\">Yes</td>\r\n");
            EndContext();
#line 134 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                            }
                                            else 
                                            {

#line default
#line hidden
            BeginContext(6106, 87, true);
            WriteLiteral("                                                <td style=\"color:lightgreen;\">No</td>\r\n");
            EndContext();
#line 138 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(6240, 46, true);
            WriteLiteral("                                            \r\n");
            EndContext();
#line 141 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                               bool isLate = false; 

#line default
#line hidden
            BeginContext(6434, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 143 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                             foreach (var fee in _return.Fees)
                                            {
                                                if(fee.IsLate == true) 
                                                {
                                                    isLate = true;
                                                }
                                            }

#line default
#line hidden
            BeginContext(6853, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 151 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                             if (isLate) 
                                            {

#line default
#line hidden
            BeginContext(6961, 81, true);
            WriteLiteral("                                                <td style=\"color:red;\">Yes</td>\r\n");
            EndContext();
#line 154 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                            }
                                            else 
                                            {

#line default
#line hidden
            BeginContext(7187, 87, true);
            WriteLiteral("                                                <td style=\"color:lightgreen;\">No</td>\r\n");
            EndContext();
#line 158 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(7321, 82, true);
            WriteLiteral("\r\n                                            <td class=\"td-actions text-right\">\r\n");
            EndContext();
            BeginContext(7728, 57, true);
            WriteLiteral("\r\n                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7785, "\"", 7814, 1);
#line 165 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
WriteAttributeValue("", 7790, _return.Rental_ReturnID, 7790, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7815, 407, true);
            WriteLiteral(@" onclick=""showFullDetails(this)"" type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                                        data-original-title=""Full Details"" data-toggle=""modal"" data-target=""#fullDetailsModal"">
                                                    <i class=""material-icons"">list_alt</i>
                                                </button>

");
            EndContext();
            BeginContext(8718, 57, true);
            WriteLiteral("\r\n                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 8775, "\"", 8804, 1);
#line 175 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
WriteAttributeValue("", 8780, _return.Rental_ReturnID, 8780, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8805, 521, true);
            WriteLiteral(@" onclick=""closeTransaction(this)"" type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                                        data-original-title=""Close Transaction"" data-toggle=""modal""
                                                        data-target=""#closeTransactionModal"">
                                                    <i class=""material-icons"">done</i>
                                                </button>

                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9326, "\"", 9394, 3);
            WriteAttributeValue("", 9333, "/Admin/Repair/Create/", 9333, 21, true);
#line 181 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
WriteAttributeValue("", 9354, _return.Rental_ReturnID, 9354, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 9378, "?fromReturn=true", 9378, 16, true);
            EndWriteAttribute();
            BeginContext(9395, 393, true);
            WriteLiteral(@" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                                   data-original-title=""Create Repair"">
                                                    <i class=""material-icons"">build</i>
                                                </a>
                                            </td>
                                        </tr>
");
            EndContext();
#line 187 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(9827, 222, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 198 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
   await Html.RenderPartialAsync("CloseTransactionPartialView"); 

#line default
#line hidden
#line 199 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
   await Html.RenderPartialAsync("FullDetailsPartialView"); 

#line default
#line hidden
            BeginContext(10180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10201, 4601, true);
                WriteLiteral(@"
    <script src=""/Admin/Content/js/material-dashboard.js""></script>
    <script>
        function showFullDetails(item) {
            var returnID = item.getAttribute(""id"");

            $.ajax({
                url: ""/Admin/Return/GetFullDetails/"" + returnID,
                type: 'GET',
                success: function (data) {
                    const dataJson = JSON.parse(data);
                    console.log(dataJson);
                    var dateOptions = { year: 'numeric', month: 'long', day: 'numeric' };

                    // BOOKING TAB
                    $('#bookingID').text(dataJson.booking.BookingID);
                    $('#bookingDate').text(new Date(dataJson.booking.BookingDate).toLocaleDateString(""en-US"", dateOptions));
                    $('#clientID').text(""Client #"" + dataJson.booking.ClientID);
                    $('#clientInfos').text(dataJson.booking.clientInfos);
                    $('#vehicleID').text(""Vehicle #"" + dataJson.booking.VehicleID);
            ");
                WriteLiteral(@"        $('#vehicleInfos').text(dataJson.booking.vehicleInfos);
                    $('#rentalDate').text(new Date(dataJson.booking.RentalDate).toLocaleDateString(""en-US"", dateOptions));
                    $('#returnDate').text(new Date(dataJson.booking.ReturnDate).toLocaleDateString(""en-US"", dateOptions));
                    $('#bookingPrice').text(""$"" + dataJson.booking.TotalPrice.toFixed(2));

                    // RENTAL TAB
                    $('#bookingID2').text(dataJson.rental.BookingID);
                    $('#rentalDate2').text(new Date(dataJson.rental.Date).toLocaleDateString(""en-US"", dateOptions));
                    $('#clientID2').text(""Client #"" + dataJson.rental.ClientID);
                    $('#clientInfos2').text(dataJson.rental.clientInfos);
                    $('#fuelAmount').text(dataJson.rental.FuelAmount.toFixed(1) + ""L"");
                    $('#mileage').text(dataJson.rental.Mileage);
                    $('#vehicleID2').text(""Vehicle #"" + dataJson.rental.VehicleID");
                WriteLiteral(@");
                    $('#vehicleInfos2').text(dataJson.rental.vehicleInfos);
                    $('#rentalDate3').text(new Date(dataJson.rental.Date).toLocaleDateString(""en-US"", dateOptions));
                    $('#returnDate2').text(new Date(dataJson.booking.ReturnDate).toLocaleDateString(""en-US"", dateOptions));
                    $('#condition').val(dataJson.rental.VehicleActualConditionRental_Return);
                    $('#bookingPrice2').text(""$"" + dataJson.booking.TotalPrice.toFixed(2));

                    // RETURN TAB
                    $('#bookingID3').text(dataJson.return.BookingID);
                    $('#returnDate3').text(new Date(dataJson.return.Date).toLocaleDateString(""en-US"", dateOptions));
                    $('#clientID3').text(""Client #"" + dataJson.return.ClientID);
                    $('#clientInfos3').text(dataJson.return.clientInfos);
                    $('#condition2').val(dataJson.return.VehicleActualConditionRental_Return);
                    $('#fuelAmoun");
                WriteLiteral(@"t2').text(dataJson.return.FuelAmount.toFixed(1) + ""L"");
                    $('#mileage2').text(dataJson.return.Mileage);
                    $('#vehicleID3').text(""Vehicle #"" + dataJson.return.VehicleID);
                    $('#vehicleInfos3').text(dataJson.return.vehicleInfos);
                    $('#bookingPrice3').text(""$"" + dataJson.booking.TotalPrice.toFixed(2));

                    var total = 0.00;
                    if (dataJson.damage != null) {
                        $('#damageDetails').val(dataJson.damage.Reason);
                        let damageCosts = parseFloat(dataJson.damage.Costs.toFixed(2));
                        $('#damageCosts').text(""$"" + damageCosts.toFixed(2));
                        total += damageCosts;
                    }
                    if (dataJson.late != null) {
                        let lateCosts = parseFloat(dataJson.late.Costs.toFixed(2));
                        $('#lateCosts').text(""$"" + lateCosts.toFixed(2));
                        total ");
                WriteLiteral(@"+= lateCosts;
                    }

                    total = parseFloat(dataJson.booking.TotalPrice) + total;

                    let daysLate = dataJson.daysLate;
                    if (daysLate != 0) {
                        $('#daysLate').text(""Returned"" + daysLate + ""Days later"");
                    }

                    $('#total').text(""$"" + total.toFixed(2));
                }
            });
        }

        // SHOW MESSAGE BASED ON RESPONSE
        var response = '");
                EndContext();
                BeginContext(14803, 16, false);
#line 279 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
                   Write(ViewBag.Response);

#line default
#line hidden
                EndContext();
                BeginContext(14819, 2822, true);
                WriteLiteral(@"';
        if (response == ""successfully created return"") {
            md.showNotification('top', 'center', 'Successfully created return', 2, 0);
        }
        else if (response == ""successfully closed tran"") {
            md.showNotification('top', 'center', 'Successfully closed transaction', 2, 0);
        }
        else if (response == ""error creating return"") {
            md.showNotification('top', 'center', 'An error happened while creating return, please try again', 1, 2);
        } 
        else if (response == ""error closing tran"") {
            md.showNotification('top', 'center', 'An error happened while closing transaction, please try again', 1, 2);
        }
        else if (response == ""repair is not completed"") {
            md.showNotification('top', 'center', 'The repair for this return is not completed, check if repair is not closed or not created yet', 1, 2);
        }
        else if (response == ""return is closed"") {
            md.showNotification('top', 'center', '");
                WriteLiteral(@"You cannot create repair for closed returns', 1, 2);
        } 
        else if (response == ""return doesnt have damage"") {
            md.showNotification('top', 'center', ""This return doesn't have any damage registered so you cannot add repair"", 1, 2);
        } 
        else if (response == ""repair exists"") {
            md.showNotification('top', 'center', ""There is an repair for this return, please edit instead"", 1, 2);
        }
        else if (response == ""return is already closed"") {
            md.showNotification('top', 'center', ""Return is already closed"", 1, 2);
        }

        function closeTransaction(item) {
            let id = item.getAttribute(""id"");
            $('#closeTransaction').attr(""action"", ""/Admin/Return/CloseTransaction/"" + id);
            console.log(id);
        }

        // FILTERING
        function myFunction() {
            var input, filter, table, tr, td, i;
            input = document.getElementById(""searchReturn"");
            filter = input.");
                WriteLiteral(@"value.toUpperCase();
            table = document.getElementById(""returnsTable"");
            tr = table.getElementsByTagName(""tr"");

            for (i = 1; i < tr.length; i++) {
                // Hide the row initially.
                tr[i].style.display = ""none"";

                td = tr[i].getElementsByTagName(""td"");
                for (var j = 0; j < td.length; j++) {
                    cell = tr[i].getElementsByTagName(""td"")[j];
                    if (cell) {
                        if (cell.innerText.toUpperCase().indexOf(filter) > -1) {
                            tr[i].style.display = """";
                            break;
                        }
                    }
                }
            }

        }
    </script>

");
                EndContext();
                BeginContext(17672, 6, true);
                WriteLiteral("    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RentACarTI2.Models.Rental_Return>> Html { get; private set; }
    }
}
#pragma warning restore 1591

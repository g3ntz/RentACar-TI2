#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c3bdb719d717b5197a490de9ee4a8ecbf13acd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
using RentACarTI2.BLL;

#line default
#line hidden
#line 3 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
using RentACarTI2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c3bdb719d717b5197a490de9ee4a8ecbf13acd", @"/Views/Account/Profile.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.ViewModels.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(103, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(140, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10c3bdb719d717b5197a490de9ee4a8ecbf13acd3609", async() => {
                BeginContext(146, 124, true);
                WriteLiteral("\r\n    <style>\r\n        .form-group {\r\n            margin-left: 20px;\r\n            color: #6F6868;\r\n        }\r\n    </style>\r\n");
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
            BeginContext(277, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(279, 12773, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10c3bdb719d717b5197a490de9ee4a8ecbf13acd4928", async() => {
                BeginContext(318, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
      
        int clientID = int.Parse(ViewBag.ClientID);
        Client client = ClientBLL.dal.Get(clientID);
        var rvm = new RentACarTI2.ViewModels.RegisterViewModel()
        {
            UserID = client.UserID,
            Username = client.user.Username,
            Email = client.user.Email,
            LastLoginDate = client.user.LastLoginDate,
            Name = client.Name,
            Surname = client.Surname,
            Birthdate = client.Birthdate,
            DrivingLicense = client.DrivingLicense,
            PhoneNr = client.PhoneNr,
            Address = client.Address
        };

    

#line default
#line hidden
                BeginContext(957, 170, true);
                WriteLiteral("    <!-- Main -->\r\n    <main>\r\n        <div class=\"container profile-container mt-5\" style=\"margin-bottom:70px;\">\r\n            <div class=\"row justify-content-between\">\r\n");
                EndContext();
#line 38 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
                  
                    await Html.RenderPartialAsync("UserDetailsPartialView", rvm);
                

#line default
#line hidden
                BeginContext(1249, 48, true);
                WriteLiteral("                <div class=\"right-side col-7\">\r\n");
                EndContext();
#line 42 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
                      
                        await Html.RenderPartialAsync("DashboardPartialView");
                    

#line default
#line hidden
                BeginContext(1424, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
                      
                        await Html.RenderPartialAsync("ReservationsPartialView");
                    

#line default
#line hidden
                BeginContext(1556, 75, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n\r\n");
                EndContext();
#line 54 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
      
        await Html.RenderPartialAsync("DetailsModalPartialView");
    

#line default
#line hidden
                BeginContext(1713, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 57 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
      
        await Html.RenderPartialAsync("EditModalPartialView");
    

#line default
#line hidden
                BeginContext(1792, 7713, true);
                WriteLiteral(@"
    <div id=""exampleModal"" class=""modal fade"" tabindex=""-1"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 style=""color:red;"" class=""modal-title"" id=""exampleModalLabel"">Reservation is Canceled</h5>
                    <a class=""close"" href=""#"" data-dismiss=""modal"">×</a>
                </div>
                <div class=""modal-body"">
                    <p id=""modal-content-text"">Sorry, this reservation has been automatically canceled and it's not valid anymore.</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.1.1.min.js""></script>
    <script>
        // SCRIPT ABOVE IS USED FOR .AJAX FUNCTION, THE DEFAULT JQUERY SCRIPT THAT IS LOADED THROUGH LAYOUT DOESN'T ");
                WriteLiteral(@"HAVE .AJAX FUNCTION
        function showDetails(item) {
            var reservationID = item.getAttribute(""id"");
            $.ajax({
                url: ""/reservations/GetReservationDetails/"" + reservationID,
                type: 'GET',
                success: function (data) {
                    const dataJson = JSON.parse(data);
                    $('#normal-price').text(dataJson.normalPrice.toFixed(2) + ""$"");
                    $('#late-costs').html(dataJson.lateCosts.toFixed(2) + ""$"");
                    $('#damage-costs').html(dataJson.damageCosts.toFixed(2) + ""$"");
                    $('#total-price').html(dataJson.totalPrice.toFixed(2) + ""$"");
                    if (dataJson.damageFees != null) {
                        $('#damage-details').html(dataJson.damageFees.Reason);
                    }


                    // fill rental table
                    if (dataJson.rental != null) {
                        $('#rental-table caption').remove();
                        ");
                WriteLiteral(@"$('#rental-table tbody').empty();
                        var options = { year: 'numeric', month: 'long', day: 'numeric' };

                        $('#rental-table').append(""<tr>"" +
                            ""<td>"" + new Date(dataJson.rental.Date).toLocaleDateString(""en-US"", options) + ""</td>"" +
                            ""<td>"" + dataJson.rental.StringFuelAmount + ""</td>"" +
                            ""<td>"" + dataJson.rental.Mileage + ""</td>"" +
                            ""</tr > "");
                    }

                    // fill return table
                    if (dataJson._return != null) {
                        $('#return-table caption').remove();
                        $('#return-table tbody').empty();

                        console.log(dataJson.damageFees);
                        if (dataJson.damageFees != null) {
                            var appendLate = '<td style=""color:#FF0A18"">Yes</td>'
                        }
                        else {
                ");
                WriteLiteral(@"            var appendLate = '<td style=""color:#0EC01F"">No</td>'
                        }

                        if (dataJson.lateFees != nuViewBagl) {
                            var appeViewBagiewBagiewBagdDamage = '<td style=""color:#FF0A18"">Yes</td>'
                        }
                        else {
                            var appendDamage = '<td style=""color:#0EC01F"">No</td>'
                        }

                        $('#return-table').append(""<tr>"" +
                            ""<td>"" + new Date(dataJson._return.Date).toLocaleDateString(""en-US"", options) + ""</td>"" +
                            ""<td>"" + dataJson._return.StringFuelAmount + ""</td>"" +
                            ""<td>"" + dataJson._return.Mileage + ""</td>"" +
                            appendLate +
                            appendDamage +
                            ""</tr > "");

                    }
                }
            });
        }

        function editReservation(item) {
         ");
                WriteLiteral(@"   var reservationID = item.getAttribute(""id"");
            console.log(reservationID)
            $.ajax({
                url: ""/reservations/EditReservationInfos/"" + reservationID,
                type: 'GET',
                success: function (data) {
                    const dataJson = JSON.parse(data);

                    if (dataJson.status != 3) {
                        var rentalDate = document.getElementById('edit-rental-date');
                        var rentalDateJson = new Date(dataJson.rentalDate);
                        rentalDateJson.setDate(rentalDateJson.getDate() + 1);
                        rentalDate.valueAsDate = rentalDateJson;

                        var returnDate = document.getElementById('edit-return-date');
                        var returnDateJson = new Date(dataJson.returnDate);
                        returnDateJson.setDate(returnDateJson.getDate() + 1);
                        returnDate.valueAsDate = returnDateJson;

                        $('.full-");
                WriteLiteral(@"details span').remove();
                        var rentalDate = document.getElementById('edit-rental-date');
                        rentalDate.disabled = false;
                        var returnDate = document.getElementById('edit-return-date');
                        returnDate.disabled = false;
                        var cancel = document.getElementById('cancel-reservation');
                        cancel.disabled = false;

                        $('.car-model').html(dataJson.vehicleInfos);
                        $('#price-val').text(dataJson.totalPrice.toFixed(2) + ""$"");
                        $('#vehicleDailyPrice').val(item.getAttribute(""data-dailyPrice""));
                        $('#inputBookingID').val(item.getAttribute(""id""));
                        $('#cancel-reservation').attr('href', ""/reservations/cancelreservation/"" + item.getAttribute(""id""));
                    }
                    else {
                        var rentalDate = document.getElementById('edit-rental-d");
                WriteLiteral(@"ate');
                        var rentalDateJson = new Date(dataJson.rentalDate);
                        rentalDateJson.setDate(rentalDateJson.getDate() + 1);
                        rentalDate.valueAsDate = rentalDateJson;

                        var returnDate = document.getElementById('edit-return-date');
                        var returnDateJson = new Date(dataJson.returnDate);
                        returnDateJson.setDate(returnDateJson.getDate() + 1);
                        returnDate.valueAsDate = returnDateJson;

                        var rentalDate = document.getElementById('edit-rental-date');
                        rentalDate.disabled = true;
                        var returnDate = document.getElementById('edit-return-date');
                        returnDate.disabled = true;
                        $('#cancel-reservation').attr(""disabled"", ""disabled"");
                        $('.full-details span').remove();
                        $('.full-details').append(""<span class");
                WriteLiteral(@"='text-danger' style='font-size:0.6em;'> - This reservation is canceled</span>"");
                    }
                    
                }
            });

        }

    </script>
    
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    <script>
        // SCRIPT ABOVE IS USED FOR .MODAL FUNCTION
        // SHOW THE MODAL CONTENT BASED ON ACTION
        var action = '");
                EndContext();
                BeginContext(9506, 14, false);
#line 208 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Account\Profile.cshtml"
                 Write(ViewBag.action);

#line default
#line hidden
                EndContext();
                BeginContext(9520, 3525, true);
                WriteLiteral(@"'
        if (action == ""already canceled"") {
            $('#modal-content-text').text(""Sorry, this reservation has been automatically canceled and it's not valid anymore."");
            $('#exampleModal').modal();
        }
        else if (action == ""just canceled"") {
            $('#modal-content-text').text(""You just canceled this Reservation"");
            $('#exampleModal').modal();
        }


        // VALIDATE FROM AND TO DATE
        var today = new Date();

        var rentalDate = document.getElementById('edit-rental-date');
        var fromMinDate = (today.getFullYear()) + '-'
            + ('0' + (today.getMonth() + 1)).slice(-2) + '-'
            + ('0' + today.getDate()).slice(-2);
        rentalDate.setAttribute(""min"", fromMinDate);

        var returnDate = document.getElementById('edit-return-date');
        var returnDate2 = new Date();
        returnDate2.setDate(returnDate2.getDate() + 1);

        var toMinDate = (returnDate2.getFullYear()) + '-'
            +");
                WriteLiteral(@" ('0' + (returnDate2.getMonth() + 1)).slice(-2) + '-'
            + ('0' + returnDate2.getDate()).slice(-2);
        returnDate.setAttribute(""min"", toMinDate);

        function updateTo(item) {
            var rentalDate = new Date(item.value);
            var returnDate = new Date(document.getElementById(""edit-return-date"").value);
            console.log(rentalDate)
            console.log(returnDate)
            var returnDateElement = document.getElementById(""edit-return-date"");

            if (rentalDate >= returnDate) {
                returnDate = new Date(item.value);
                returnDate.setDate(returnDate.getDate() + 1);
                returnDateElement.valueAsDate = returnDate;

                var toMinDate = (returnDate.getFullYear()) + '-'
                    + ('0' + (returnDate.getMonth() + 1)).slice(-2) + '-'
                    + ('0' + returnDate.getDate()).slice(-2);

                returnDateElement.setAttribute(""min"", toMinDate);
            }
            ");
                WriteLiteral(@"else {
                returnDate = new Date(item.value);
                returnDate.setDate(returnDate.getDate() + 1);

                var toMinDate = (returnDate.getFullYear()) + '-'
                    + ('0' + (returnDate.getMonth() + 1)).slice(-2) + '-'
                    + ('0' + returnDate.getDate()).slice(-2);

                returnDateElement.setAttribute(""min"", toMinDate);
            }


            rentalDate = new Date(item.value);
            returnDate = new Date($('#edit-return-date').val());

            var difference = returnDate.getTime() - rentalDate.getTime();
            var Difference_In_Days = difference / (1000 * 3600 * 24);
            calculatePrice(Difference_In_Days);
        }

        function updatePriceFromDate(item) {
            var rentalDate = new Date($('#edit-rental-date').val());
            var returnDate = new Date(item.value);
            console.log(rentalDate);
            console.log(returnDate);

            var difference = returnDa");
                WriteLiteral(@"te.getTime() - rentalDate.getTime();
            var Difference_In_Days = difference / (1000 * 3600 * 24);
            calculatePrice(Difference_In_Days);
        }

        function calculatePrice(days) {
            var vehicleDailyPrice = $('#vehicleDailyPrice').val();
            var price = vehicleDailyPrice * days;
            $('#price-val').text(price.toFixed(2) + ""$"");
            console.log(price);
        }

    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13052, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

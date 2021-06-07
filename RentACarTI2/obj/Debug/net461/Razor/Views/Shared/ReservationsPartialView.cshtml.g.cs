#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c510edbc3676d109ecb020c85e2aecf3882548c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ReservationsPartialView), @"mvc.1.0.view", @"/Views/Shared/ReservationsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ReservationsPartialView.cshtml", typeof(AspNetCore.Views_Shared_ReservationsPartialView))]
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
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
using RentACarTI2.BLL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c510edbc3676d109ecb020c85e2aecf3882548c", @"/Views/Shared/ReservationsPartialView.cshtml")]
    public class Views_Shared_ReservationsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/greenCircle.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/orangeCircle.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/redCircle.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
   
    var reservations = BookingsBLL.dal.GetAll().Where(x => x.ClientID == int.Parse(ViewBag.ClientID)).ToList();

#line default
#line hidden
            BeginContext(147, 880, true);
            WriteLiteral(@"
<div class=""reservation box-shadow"" style=""margin-top: 30px;"">
    <div class=""row"" style=""padding: 0; --bs-gutter-x: 0rem;"">
        <div class=""col-12"">
            <div class=""profile-header"">
                <p class=""dashboard-header-text"">Reservations</p>
            </div>
        </div>
        <div class=""scrollable"">
            <table class=""content-table"">
                <thead>
                    <tr>
                        <th width=""3%"" style=""white-space: nowrap; padding:0;""></th>
                        <th>Date</th>
                        <th>Vehicle</th>
                        <th>Price</th>
                        <th>Rental Date</th>
                        <th>Return Date</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 29 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                      
                        if (reservations.Any() == false)
                        {

#line default
#line hidden
            BeginContext(1136, 137, true);
            WriteLiteral("                            <caption style=\"color:#6F6868; font-size:33px; text-align:center; margin-top:9%;\">No Reservations</caption>\r\n");
            EndContext();
#line 33 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                        }
                        else
                        {
                            foreach (var reservation in reservations)
                            {

#line default
#line hidden
            BeginContext(1459, 38, true);
            WriteLiteral("                                <tr>\r\n");
            EndContext();
#line 39 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                       
                                        if(reservation.BookingStatusID == 1)
                                        {

#line default
#line hidden
            BeginContext(1659, 72, true);
            WriteLiteral("                                            <td class=\"p-0 text-center\">");
            EndContext();
            BeginContext(1731, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c510edbc3676d109ecb020c85e2aecf3882548c6782", async() => {
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
            BeginContext(1773, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 43 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                        }
                                        else if(reservation.BookingStatusID == 2) 
                                        {

#line default
#line hidden
            BeginContext(1950, 72, true);
            WriteLiteral("                                            <td class=\"p-0 text-center\">");
            EndContext();
            BeginContext(2022, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c510edbc3676d109ecb020c85e2aecf3882548c8433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2065, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                        }
                                        else 
                                        {

#line default
#line hidden
            BeginContext(2205, 72, true);
            WriteLiteral("                                            <td class=\"p-0 text-center\">");
            EndContext();
            BeginContext(2277, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c510edbc3676d109ecb020c85e2aecf3882548c10047", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2317, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 51 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                        }
                                    

#line default
#line hidden
            BeginContext(2406, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2447, 46, false);
#line 53 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                   Write(reservation.BookingDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2493, 72, true);
            WriteLiteral("</td>\r\n                                    <td style=\"overflow:hidden;\">");
            EndContext();
            BeginContext(2566, 37, false);
#line 54 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                                            Write(reservation.Vehicle.VehicleBrand.Make);

#line default
#line hidden
            EndContext();
            BeginContext(2603, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2605, 38, false);
#line 54 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                                                                                   Write(reservation.Vehicle.VehicleBrand.Model);

#line default
#line hidden
            EndContext();
            BeginContext(2643, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2691, 22, false);
#line 55 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                   Write(reservation.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2713, 48, true);
            WriteLiteral("$</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2762, 45, false);
#line 56 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                   Write(reservation.RentalDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2807, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2855, 45, false);
#line 57 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                   Write(reservation.ReturnDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2900, 68, true);
            WriteLiteral("</td>\r\n                                    <td style=\"width:10%;\"><a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2968, "\"", 2995, 1);
#line 58 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
WriteAttributeValue("", 2973, reservation.BookingID, 2973, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2996, 98, true);
            WriteLiteral(" class=\"button detail-button\" href=\"#details-modal\" onclick=\"showDetails(this)\">Details</a></td>\r\n");
            EndContext();
#line 59 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                       var vehicleDailyPrice = VehicleBLL.dal.Get(reservation.VehicleID).DailyPrice; 

#line default
#line hidden
            BeginContext(3214, 42, true);
            WriteLiteral("                                    <td><a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3256, "\"", 3283, 1);
#line 60 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
WriteAttributeValue("", 3261, reservation.BookingID, 3261, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3284, 18, true);
            WriteLiteral(" data-dailyPrice=\"");
            EndContext();
            BeginContext(3303, 17, false);
#line 60 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                                                                                   Write(vehicleDailyPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3320, 137, true);
            WriteLiteral("\" href=\"#edit-modal\" onclick=\"editReservation(this)\"><img src=\"../assets/img/edit.png\"></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 62 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Shared\ReservationsPartialView.cshtml"
                            }
                        }
                    

#line default
#line hidden
            BeginContext(3538, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
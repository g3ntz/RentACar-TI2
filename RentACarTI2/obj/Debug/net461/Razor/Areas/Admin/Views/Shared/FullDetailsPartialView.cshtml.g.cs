#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\FullDetailsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184f2ee55eda722eb28c5c26d332ab4871e3864b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_FullDetailsPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/FullDetailsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/FullDetailsPartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_FullDetailsPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184f2ee55eda722eb28c5c26d332ab4871e3864b", @"/Areas/Admin/Views/Shared/FullDetailsPartialView.cshtml")]
    public class Areas_Admin_Views_Shared_FullDetailsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12705, true);
            WriteLiteral(@"<!-- Full Details Modal -->
<div class=""modal fade"" id=""fullDetailsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""fullDetailsModal""
     aria-hidden=""true"">
    <div class=""modal-dialog"" style=""max-width: 900px;"" role=""document"">
        <div class=""modal-content card"">
            <div class=""card-header card-header-tabs card-header-primary"">
                <div class=""nav-tabs-navigation"">
                    <div class=""nav-tabs-wrapper"">
                        <ul class=""nav nav-tabs"" data-tabs=""tabs"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" href=""#reservation"" data-toggle=""tab"">
                                    <i class=""material-icons"">assignment</i> Reservation
                                    <div class=""ripple-container""></div>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""");
            WriteLiteral(@"#rental"" data-toggle=""tab"">
                                    <i class=""material-icons"">car_rental</i> Rental
                                    <div class=""ripple-container""></div>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#return"" data-toggle=""tab"">
                                    <i class=""material-icons"">assignment_return</i> Return
                                    <div class=""ripple-container""></div>
                                </a>
                            </li>
                            <button type=""button"" class=""close text-white ml-auto"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
         ");
            WriteLiteral(@"       <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""reservation"">
                        <div class=""row py-4"">
                            <div class=""col-6"">
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Reservation ID</h5>
                                    <h5>5</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Reservation Date</h5>
                                    <h5>15-06-2021</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Client #12</h5>
                                    <h5>Armend Emini<");
            WriteLiteral(@"/h5>
                                    <hr />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Vehicle #8</h5>
                                    <h5>Golf 6 GTI</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>From</h5>
                                    <h5>15-06-2021</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>To</h5>
                                    <h5>17-06-2021</h5>
                                   ");
            WriteLiteral(@" <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-5"">
                                    <h4>Price</h4>
                                    <h4 class=""text-success font-weight-bold"">$34.50</h4>
                                    <hr />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane"" id=""rental"">
                        <div class=""row py-4"">
                            <div class=""col-6"">
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Reservation ID</h5>
                                    <h5>5</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-betw");
            WriteLiteral(@"een mt-3"">
                                    <h5>Rental Date</h5>
                                    <h5>15-06-2021</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Client #12</h5>
                                    <h5>Armend Emini</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-5"">
                                    <h5>Fuel Amount</h5>
                                    <h5>15.0L</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Mileage</h5>
                                    <h5>93735</");
            WriteLiteral(@"h5>
                                    <hr />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Vehicle #8</h5>
                                    <h5>Golf 6 GTI</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>From</h5>
                                    <h5>15-06-2021</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>To</h5>
                                    <h5>17-06-2021</h5>
                                    ");
            WriteLiteral(@"<hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-5"">
                                    <label for=""condition"" class=""ml-3"">Vehicle Actual Condition</label>
                                    <textarea id=""condition"" class=""form-control mt-1"" style=""color:#d9e0e0;"">The Actual Condition</textarea>
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-5"">
                                    <h4>Price</h4>
                                    <h4 class=""text-success font-weight-bold"">$34.50</h4>
                                    <hr />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane"" id=""return"">
                        <div class=""row py-4"">
                            <div class=""col-6"">");
            WriteLiteral(@"
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Reservation ID</h5>
                                    <h5>5</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Return Date</h5>
                                    <h5>15-06-2021</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Client #12</h5>
                                    <h5>Armend Emini</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-5"">
       ");
            WriteLiteral(@"                             <label for=""condition"" class=""ml-3"">Vehicle Actual Condition</label>
                                    <textarea id=""condition"" class=""form-control mt-1"" style=""color:#d9e0e0;"">The Actual Condition</textarea>
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <label for=""damageDetails"" class=""ml-3"">Damage Details</label>
                                    <textarea id=""damageDetails"" class=""form-control mt-1"" style=""color:#d9e0e0;"">Detaisl about damage</textarea>
                                </div>
                                <div class=""col-12 input-group form-group mt-3"">
                                    <i class=""material-icons text-warning"">watch_later</i>
                                    <p class=""ml-2 text-warning"">Returned 3 Days later</p>
                                </div>
                            </div>
       ");
            WriteLiteral(@"                     <div class=""col-6"">
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Fuel Amount</h5>
                                    <h5>15.0L</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Mileage</h5>
                                    <h5>93735</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Vehicle #8</h5>
                                    <h5>Golf 6 GTI</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-");
            WriteLiteral(@"content-between mt-5"">
                                    <h5>Normal Price</h5>
                                    <h5 class=""text-success font-weight-bold"">$34.50</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Late Costs</h5>
                                    <h5 class=""text-danger font-weight-bold"">$0.00</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-between mt-3"">
                                    <h5>Damage Costs</h5>
                                    <h5 class=""text-danger font-weight-bold"">$0.00</h5>
                                    <hr />
                                </div>
                                <div class=""col-12 input-group form-group justify-content-be");
            WriteLiteral(@"tween mt-5"">
                                    <h4>Total</h4>
                                    <h4 class=""text-secondary font-weight-bold"">$34.50</h4>
                                    <hr />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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

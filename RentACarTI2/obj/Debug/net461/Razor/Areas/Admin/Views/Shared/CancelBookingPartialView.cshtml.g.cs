#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\CancelBookingPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181d3a343392796cec147b84099ae6b4faaa3ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_CancelBookingPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/CancelBookingPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/CancelBookingPartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_CancelBookingPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181d3a343392796cec147b84099ae6b4faaa3ccd", @"/Areas/Admin/Views/Shared/CancelBookingPartialView.cshtml")]
    public class Areas_Admin_Views_Shared_CancelBookingPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1530, true);
            WriteLiteral(@"<!-- Delete Record Modal -->
<div class=""modal fade"" id=""cancelBookingModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""cancelBookingModal""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <form id=""cancelBooking"" class=""modal-content form-row card"" method=""POST"">
            <div class=""modal-header card-header card-header-primary"">
                <h5>Cancel Reservation</h5>
                <button type=""button"" class=""close text-white"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body card-body"">
                <div class=""col-12 py-3"">
                    <i class=""material-icons text-danger"">error</i>
                    <p class="""" style=""font-size: 1.1em;"">
                        Canceled reservations are not deleted, they will stay inactive for statistical purposes
                        and you cannot modify canceled res");
            WriteLiteral(@"ervations. Are you sure you wanna cancel this reservation?
                    </p>
                </div>

                <div class=""row input-group form-group no-border justify-content-between"">
                    <button type=""button"" class=""btn col-4"" data-dismiss=""modal"">Exit</button>
                    <button type=""submit"" class=""btn btn-primary col-4"" style=""background-color:#982245"">Yes, Cancel</button>
                </div>
            </div>
        </form>
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

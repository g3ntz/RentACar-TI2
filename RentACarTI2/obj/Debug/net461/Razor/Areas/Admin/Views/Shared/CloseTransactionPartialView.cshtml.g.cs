#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\CloseTransactionPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ce1dd3899fe9ca6d9d5f50731137f463aee11e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_CloseTransactionPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/CloseTransactionPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/CloseTransactionPartialView.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_CloseTransactionPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ce1dd3899fe9ca6d9d5f50731137f463aee11e", @"/Areas/Admin/Views/Shared/CloseTransactionPartialView.cshtml")]
    public class Areas_Admin_Views_Shared_CloseTransactionPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1406, true);
            WriteLiteral(@"<!-- Close Transaction Modal -->
<div class=""modal fade"" id=""closeTransactionModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""closeTransactionModal""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <form class=""modal-content form-row card"">
            <div class=""modal-header card-header card-header-primary"">
                <h5>Close Transaction</h5>
                <button type=""button"" class=""close text-white"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body card-body"">
                <div class=""col-12 py-3"">
                    <i class=""material-icons text-warning"">warning</i>
                    <p class="""" style=""font-size: 1.1em;"">
                        Closing this transaction means that all late fees or damage fees are
                        paid by client, are you sure?
                    </p>
                <");
            WriteLiteral(@"/div>

                <div class=""row input-group form-group no-border justify-content-between"">
                    <button type=""button"" class=""btn col-4"" data-dismiss=""modal"">Shit.. Go back</button>
                    <button type=""submit"" class=""btn btn-primary col-4"">Yes, close it</button>
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

#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61bfda0d0676b48287098ff43fa0949739aa66f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Test_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Test/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Test/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Test_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61bfda0d0676b48287098ff43fa0949739aa66f", @"/Areas/Admin/Views/Test/Index.cshtml")]
    public class Areas_Admin_Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 499, true);
            WriteLiteral(@"
<form method=""post"" enctype=""multipart/form-data"" asp-controller=""Test"" asp-action=""Index2"">
    <div class=""form-group"">
        <div class=""col-md-10"">
            <p>Upload one or more files using this form:</p>
            <input type=""file"" name=""files"" multiple />
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-10"">
            <label>Upload Files</label>
            <input type=""submit"" value=""Upload"" />
        </div>
    </div>
</form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4078a520438c5a5d9ca98dcf13b92b3473c91e73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Role/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Role_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4078a520438c5a5d9ca98dcf13b92b3473c91e73", @"/Areas/Admin/Views/Role/Edit.cshtml")]
    public class Areas_Admin_Views_Role_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.Models.Role>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Edit.cshtml"
  
    ViewBag.RoleActive = "active";
    ViewBag.Page = "Roles";
    ViewBag.Title = "Rent a Car - Edit Role";

#line default
#line hidden
            BeginContext(151, 109, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <form class=\"form-row card\" method=\"POST\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 260, "\"", 299, 2);
            WriteAttributeValue("", 269, "/Admin/Role/Edit/", 269, 17, true);
#line 10 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Edit.cshtml"
WriteAttributeValue("", 286, Model.RoleID, 286, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(316, 29, false);
#line 11 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Edit.cshtml"
       Write(Html.HiddenFor(x => x.RoleID));

#line default
#line hidden
            EndContext();
            BeginContext(345, 364, true);
            WriteLiteral(@"
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Create Role</h4>
                <p class=""card-category"">Create a new role</p>
            </div>
            <div class=""card-body row"">
                <div class=""col-12 input-group form-group no-border"">
                    <input type=""text"" name=""Name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 709, "\"", 728, 1);
#line 18 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Edit.cshtml"
WriteAttributeValue("", 717, Model.Name, 717, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(729, 240, true);
            WriteLiteral(" class=\"form-control\" placeholder=\"Name...\">\r\n                </div>\r\n                <div class=\"col-12 input-group form-group no-border\">\r\n                    <textarea name=\"Description\" class=\"form-control\" placeholder=\"Description...\">");
            EndContext();
            BeginContext(970, 17, false);
#line 21 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Edit.cshtml"
                                                                                              Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(987, 513, true);
            WriteLiteral(@"</textarea>
                </div>
                <div class=""row col-12"">
                    <div class=""col-12 col-sm-6"">
                        <a href=""/Admin/Role/Index"" class=""btn mt-3"">Back to Roles</a>
                    </div>
                    <div class=""col-12 col-sm-6"">
                        <button type=""submit"" class=""btn btn-primary mt-3 float-right"">Edit Role</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.Models.Role> Html { get; private set; }
    }
}
#pragma warning restore 1591

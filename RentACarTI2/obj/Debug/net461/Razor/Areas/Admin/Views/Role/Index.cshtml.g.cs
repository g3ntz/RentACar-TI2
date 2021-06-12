#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3126984c92f34ed5b75dfcfe1b95dc1389135acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Role/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Role_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3126984c92f34ed5b75dfcfe1b95dc1389135acf", @"/Areas/Admin/Views/Role/Index.cshtml")]
    public class Areas_Admin_Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Role\Index.cshtml"
  
    ViewBag.RoleActive = "active";

#line default
#line hidden
            BeginContext(43, 5731, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""ml-4"">
                <a class=""table-add-btn"" href=""role-crud.html"">
                    <i class=""material-icons primary-color"" style=""font-size: 40px;"">add_box</i>
                </a>
            </div>
            <div class=""col-md-3"">
                <div class=""input-group no-border"">
                    <input type=""text"" value="""" class=""form-control"" placeholder=""Search Role..."">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title "">Roles Table</h4>
                        <p class=""card-category""> Roles Informations</p>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
               ");
            WriteLiteral(@"             <table class=""table table-hover"">
                                <thead class="" text-primary"">
                                <th>
                                    ID
                                </th>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Description
                                </th>
                                <th></th>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            1
                                        </td>
                                        <td>
                                            Admin
                                        </td>
                                        <td>
                                            The Admin");
            WriteLiteral(@" Role has access to all application data
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Edit Task"">
                                                <i class=""material-icons"">edit</i>
                                            </button>
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Remove"">
                                                <i class=""material-icons"">close</i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            2
                                    ");
            WriteLiteral(@"    </td>
                                        <td>
                                            User
                                        </td>
                                        <td>
                                            The User Role has access to all application data except Users and Admins management
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Edit Task"">
                                                <i class=""material-icons"">edit</i>
                                            </button>
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Remove"">
                                                <i class=""material-icons"">close</i>
                             ");
            WriteLiteral(@"               </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            3
                                        </td>
                                        <td>
                                            Client
                                        </td>
                                        <td>
                                            The Client Role has access only in his Reservations,Rentals and Returns
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Edit Task"">
                                                <i class=""material-icons"">edit</i>
                                            </butt");
            WriteLiteral(@"on>
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Remove"">
                                                <i class=""material-icons"">close</i>
                                            </button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
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

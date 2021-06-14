#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48ca13a4a3dfa3bf9d78a7943323e6f09bd8c29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48ca13a4a3dfa3bf9d78a7943323e6f09bd8c29", @"/Areas/Admin/Views/User/Create.cshtml")]
    public class Areas_Admin_Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentACarTI2.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\User\Create.cshtml"
  
    ViewBag.UserActive = "active";
    ViewBag.Page = "Users";
    ViewBag.Title = "Rent a Car - Create User";

#line default
#line hidden
            BeginContext(153, 1159, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <form class=""form-row card"" method=""POST"" action=""/Admin/User/Create"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Create User</h4>
                <p class=""card-category"">Create a new user</p>
            </div>
            <div class=""card-body row"">
                <div class=""col-12 col-sm-6 input-group form-group no-border"">
                    <input type=""text"" name=""Username"" class=""form-control"" placeholder=""Username..."">
                </div>
                <div class=""col-12 col-sm-6 input-group form-group no-border"">
                    <input type=""password"" name=""Password"" class=""form-control"" placeholder=""Password..."">
                </div>
                <div class=""col-12 col-sm-6 input-group form-group no-border mt-3"">
                    <input type=""email"" name=""Email"" class=""form-control"" placeholder=""Email..."">
                </div>
               ");
            WriteLiteral(" <div class=\"col-12 col-sm-6 input-group form-group no-border mt-3\">\r\n                    <select name=\"RoleID\" class=\"form-control\">\r\n");
            EndContext();
#line 27 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\User\Create.cshtml"
                         foreach (var role in (List<RentACarTI2.Models.Role>)ViewBag.Roles)
                        {

#line default
#line hidden
            BeginContext(1432, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1467, "\"", 1487, 1);
#line 29 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\User\Create.cshtml"
WriteAttributeValue("", 1475, role.RoleID, 1475, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1488, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1490, 9, false);
#line 29 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\User\Create.cshtml"
                                                    Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 30 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\User\Create.cshtml"
                        }

#line default
#line hidden
            BeginContext(1537, 533, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""row col-12"">
                    <div class=""col-12 col-sm-6"">
                        <a href=""/Admin/User/Index"" class=""btn mt-3"">Back to Users</a>
                    </div>
                    <div class=""col-12 col-sm-6"">
                        <button type=""submit"" class=""btn btn-primary mt-3 float-right"">Create User</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentACarTI2.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f715c5bf664eecb0b862224b0ec6152601a4b18f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f715c5bf664eecb0b862224b0ec6152601a4b18f", @"/Areas/Admin/Views/Return/Index.cshtml")]
    public class Areas_Admin_Views_Return_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
  
    ViewBag.ReturnActive = "active";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(64, 423, true);
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

        h5 {
            color: #d9e0e0;
            font-size: 1.1em;
        }

        h4 {
            color: #d9e0e0;
            font-size: 1.5em;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(490, 4831, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""input-group no-border"">
                    <input type=""text"" value="""" class=""form-control"" placeholder=""Search Return..."">
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
                            <table class=""table table-hover"">
                                <thead class="" text-primary"">
                                <th>
                                    ID
                                </th>
   ");
            WriteLiteral(@"                             <th>
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
                                </th>
                                <th>
                                    Is Late
                                </th>
                                <th></th>
                                </thead>
                                <tbody>
                                    <tr>
  ");
            WriteLiteral(@"                                      <td>
                                            1
                                        </td>
                                        <td>
                                            18 May
                                        </td>
                                        <td>
                                            Armend Emini
                                        </td>
                                        <td>
                                            Mercedes G-CLASS
                                        </td>
                                        <td>
                                            15.0L
                                        </td>
                                        <td>
                                            94823
                                        </td>
                                        <td>
                                            No
                                        </td>
      ");
            WriteLiteral(@"                                  <td>
                                            No
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                                    data-original-title=""Full Details"" data-toggle=""modal"" data-target=""#fullDetailsModal"">
                                                <i class=""material-icons"">list_alt</i>
                                            </button>
                                            <button type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                                    data-original-title=""Close Transaction"" data-toggle=""modal""
                                                    data-target=""#closeTransactionModal"">
                                                <i class=""material-ic");
            WriteLiteral(@"ons"">done</i>
                                            </button>
                                            <a href=""repair-crud.html"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                               data-original-title=""Create Repair"">
                                                <i class=""material-icons"">build</i>
                                            </a>
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
</div>

");
            EndContext();
#line 128 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
   await Html.RenderPartialAsync("CloseTransactionPartialView"); 

#line default
#line hidden
#line 129 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Return\Index.cshtml"
   await Html.RenderPartialAsync("FullDetailsPartialView"); 

#line default
#line hidden
            BeginContext(5452, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5473, 71, true);
                WriteLiteral("\r\n    <script src=\"/Admin/Content/js/material-dashboard.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
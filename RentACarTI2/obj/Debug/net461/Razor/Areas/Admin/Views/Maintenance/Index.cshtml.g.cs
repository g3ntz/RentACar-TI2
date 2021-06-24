#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370cb01784edbb9a4e9d327df14beae529f03468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Maintenance_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Maintenance/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Maintenance/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Maintenance_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370cb01784edbb9a4e9d327df14beae529f03468", @"/Areas/Admin/Views/Maintenance/Index.cshtml")]
    public class Areas_Admin_Views_Maintenance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RentACarTI2.Models.Maintenance>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
  
    ViewBag.MaintenanceActive = "active";

#line default
#line hidden
            BeginContext(95, 2289, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""input-group no-border"">
                    <input id=""searchMaintenance"" onkeyup=""myFunction()"" type=""text"" value="""" class=""form-control"" placeholder=""Search Maintenance..."">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title "">Maintenances Table</h4>
                        <p class=""card-category""> Maintenances Informations</p>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table id=""maintenancesTable"" class=""table table-hover"">
                                <thead class="" text-primary"">
                                    ");
            WriteLiteral(@"<tr>
                                        <th></th>
                                        <th>
                                            ID
                                        </th>
                                        <th>
                                            Company Name
                                        </th>
                                        <th>
                                            Description
                                        </th>
                                        <th>
                                            Costs
                                        </th>
                                        <th>
                                            Vehicle
                                        </th>
                                        <th>
                                            Start Date
                                        </th>
                                        <th>
                                        ");
            WriteLiteral("    Return Date\r\n                                        </th>\r\n                                        <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                     foreach (var maintenance in Model)
                                    {

#line default
#line hidden
            BeginContext(2496, 96, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n");
            EndContext();
#line 57 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                                 if (maintenance.IsReturned == true)
                                                {

#line default
#line hidden
            BeginContext(2729, 109, true);
            WriteLiteral("                                                    <img src=\"/Admin/Content/assets/img/greenCircle.png\" />\r\n");
            EndContext();
#line 60 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(2994, 107, true);
            WriteLiteral("                                                    <img src=\"/Admin/Content/assets/img/redCircle.png\" />\r\n");
            EndContext();
#line 64 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3152, 149, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3302, 25, false);
#line 67 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                           Write(maintenance.MaintenanceID);

#line default
#line hidden
            EndContext();
            BeginContext(3327, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3479, 30, false);
#line 70 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                           Write(maintenance.ResponsibleCompany);

#line default
#line hidden
            EndContext();
            BeginContext(3509, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3661, 23, false);
#line 73 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                           Write(maintenance.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3684, 152, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                $");
            EndContext();
            BeginContext(3837, 17, false);
#line 76 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                            Write(maintenance.Costs);

#line default
#line hidden
            EndContext();
            BeginContext(3854, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4006, 24, false);
#line 79 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                           Write(maintenance.VehicleInfos);

#line default
#line hidden
            EndContext();
            BeginContext(4030, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4182, 44, false);
#line 82 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                           Write(maintenance.StartDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4226, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4378, 45, false);
#line 85 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                           Write(maintenance.ReturnDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4423, 188, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"td-actions text-right\">\r\n                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4611, "\"", 4642, 1);
#line 88 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
WriteAttributeValue("", 4616, maintenance.MaintenanceID, 4616, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4643, 519, true);
            WriteLiteral(@" onclick=""closeTransaction(this)"" type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm""
                                                        data-original-title=""Close Transaction"" data-toggle=""modal""
                                                        data-target=""#closeTransactionModal"">
                                                    <i class=""material-icons"">done</i>
                                                </button>
                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5162, "\"", 5219, 2);
            WriteAttributeValue("", 5169, "/Admin/Maintenance/Edit/", 5169, 24, true);
#line 93 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
WriteAttributeValue("", 5193, maintenance.MaintenanceID, 5193, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5220, 293, true);
            WriteLiteral(@" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Edit Task"">
                                                    <i class=""material-icons"">edit</i>
                                                </a>
                                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5513, "\"", 5544, 1);
#line 96 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
WriteAttributeValue("", 5518, maintenance.MaintenanceID, 5518, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5545, 497, true);
            WriteLiteral(@" onclick=""deleteMaintenance(this)"" type=""button"" rel=""tooltip"" title="""" class=""btn btn-white btn-link btn-sm"" data-original-title=""Remove""
                                                        data-toggle=""modal"" data-target=""#deleteRecordModal"">
                                                    <i class=""material-icons"">close</i>
                                                </button>
                                            </td>
                                        </tr>
");
            EndContext();
#line 102 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6081, 222, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 113 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
   await Html.RenderPartialAsync("CloseTransactionPartialView"); 

#line default
#line hidden
#line 114 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
   await Html.RenderPartialAsync("DeleteRecordPartialView"); 

#line default
#line hidden
            BeginContext(6435, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6456, 152, true);
                WriteLiteral("\r\n    <script src=\"/Admin/Content/js/material-dashboard.js\"></script>\r\n    <script>\r\n        // SHOW MESSAGE BASED ON RESPONSE\r\n        var response = \'");
                EndContext();
                BeginContext(6609, 16, false);
#line 121 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Maintenance\Index.cshtml"
                   Write(ViewBag.Response);

#line default
#line hidden
                EndContext();
                BeginContext(6625, 2705, true);
                WriteLiteral(@"';
        if (response == ""successfully created maintenance"") {
            md.showNotification('top', 'center', 'Successfully created maintenance', 2, 0);
        }
        else if (response == ""successfully deleted maintenance"") {
            md.showNotification('top', 'center', 'Successfully deleted maintenance', 2, 0);
        }
        else if (response == ""error creating maintenance"") {
            md.showNotification('top', 'center', 'An error happened while creating maintenance, please try again', 1, 2);
        }
        else if (response == ""error deleting maintenance"") {
            md.showNotification('top', 'center', 'An error happened while deleting maintenance, please try again', 1, 2);
        }
        else if (response == ""successfully closed tran"") {
            md.showNotification('top', 'center', 'Successfully closed transaction', 2, 0);
        } 
        else if (response == ""error closing tran"") {
            md.showNotification('top', 'center', 'An error happened whi");
                WriteLiteral(@"le closing transaction, please try again', 1, 2);
        }
        else if (response == ""maintenance is closed"") {
            md.showNotification('top', 'center', 'Maintenance is already closed and you cannot edit it anymore', 1, 2);
        }

        function deleteMaintenance(item) {
            let id = item.getAttribute(""id"");
            $('#deleteTransaction').attr(""action"", ""/Admin/Maintenance/Delete/"" + id);
            console.log(id);
        }

        function closeTransaction(item) {
            let id = item.getAttribute(""id"");
            $('#closeTransaction').attr(""action"", ""/Admin/Maintenance/CloseTransaction/"" + id);
            console.log(id);
        }

        // FILTERING
        function myFunction() {
            var input, filter, table, tr, td, i;
            input = document.getElementById(""searchMaintenance"");
            filter = input.value.toUpperCase();
            table = document.getElementById(""maintenancesTable"");
            tr = table.getEleme");
                WriteLiteral(@"ntsByTagName(""tr"");

            for (i = 1; i < tr.length; i++) {
                // Hide the row initially.
                tr[i].style.display = ""none"";

                td = tr[i].getElementsByTagName(""td"");
                for (var j = 0; j < td.length; j++) {
                    cell = tr[i].getElementsByTagName(""td"")[j];
                    if (cell) {
                        if (cell.innerText.toUpperCase().indexOf(filter) > -1) {
                            tr[i].style.display = """";
                            break;
                        }
                    }
                }
            }

        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RentACarTI2.Models.Maintenance>> Html { get; private set; }
    }
}
#pragma warning restore 1591

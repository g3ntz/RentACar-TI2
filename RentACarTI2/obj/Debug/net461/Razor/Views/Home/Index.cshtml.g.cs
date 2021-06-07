#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c16b3919834c524ae24b95f6dcf539865cc5282d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
using RentACarTI2.BLL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c16b3919834c524ae24b95f6dcf539865cc5282d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RentACarTI2.Models.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
  
    VehicleBrandBLL bll = new VehicleBrandBLL();
    var vehicleBrands = bll.GetAll();
    var makesUnique = vehicleBrands.Select(x => x.Make).Distinct().ToList();
    var categoriesUnique = vehicleBrands.Select(x => x.Category).Distinct().ToList();


#line default
#line hidden
            BeginContext(328, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(365, 298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c16b3919834c524ae24b95f6dcf539865cc5282d4279", async() => {
                BeginContext(371, 285, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <title>Home</title>
    <style>
        .car-card > img {
            height: 240px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(665, 11347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c16b3919834c524ae24b95f6dcf539865cc5282d5756", async() => {
                BeginContext(671, 662, true);
                WriteLiteral(@"

    <!-- Main -->
    <main class=""home-main"">
        <div class=""home-page"">
            <div class=""search-vehicle-container container-fluid"">
                <form class=""search-vehicle-row row"" action=""/vehicles/index"" method=""get"">
                    <h3 class=""search-vehicle-header"">Vehicle Details</h3>

                    <div class=""col-12"">
                        <label for=""make"" class=""mt-2"">Make:</label>
                        <select id=""vehicleMake"" class=""search-vehicle-transmission form-control mt-2 mb-2"" name=""make"" onchange=""addModelsByMake(this)"">
                            <option value="""" selected>Make:</option>
");
                EndContext();
#line 38 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                             foreach (var make in makesUnique)
                            {

#line default
#line hidden
                BeginContext(1428, 40, true);
                WriteLiteral("                                <option>");
                EndContext();
                BeginContext(1469, 4, false);
#line 40 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                   Write(make);

#line default
#line hidden
                EndContext();
                BeginContext(1473, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 41 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1515, 774, true);
                WriteLiteral(@"                        </select>
                    </div>

                    <div class=""col-12"">
                        <label for=""model"" class=""mt-2"">Model:</label>
                        <select id=""vehicleModel"" class=""search-vehicle-transmission form-control mt-2 mb-2"" name=""model"">
                            <option value="""" selected>Model:</option>
                        </select>
                    </div>

                    <div class=""col-12 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                        <label for=""category"" class=""mt-2"">Category:</label>
                        <select class=""search-vehicle-category form-control mt-2 mb-2"" name=""category"">
                            <option value="""" selected>Category:</option>
");
                EndContext();
#line 56 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                             foreach (var category in categoriesUnique)
                            {

#line default
#line hidden
                BeginContext(2393, 40, true);
                WriteLiteral("                                <option>");
                EndContext();
                BeginContext(2434, 8, false);
#line 58 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                   Write(category);

#line default
#line hidden
                EndContext();
                BeginContext(2442, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 59 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(2484, 1591, true);
                WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-12 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                        <label for=""tranmission"" class=""mt-2"">Transmission:</label>
                        <select class=""search-vehicle-transmission form-control mt-2 mb-2"" name=""transmission"">
                            <option value="""" selected>Transmission:</option>
                            <option>Automatic</option>
                            <option>Manual</option>
                        </select>
                    </div>

                    <div class=""col-12 mt-4 mb-3"">
                        <button type=""submit"" class=""btn search-vehicle-btn"">Search</button>
                    </div>
                </form>
            </div>

            <div class=""next-paragraph"">
                <p class=""next-first"">Where will your next road trip take you?</p>
                <p class=""next-second"">Pick a Car and find out. 😉</p>
            </");
                WriteLiteral(@"div>
        </div>

        <div class=""home-cars container-fluid pt-5 pb-5"">
            <div class=""container-fluid"">
                <div id=""carouselExampleControls"" class=""container carousel slide"" data-ride=""carousel"">
                    <h2 style=""color: white; margin-left: 70px;"">Latest Cars</h2>
                    <div class=""carousel-inner pt-4"">
                        <!--#######  FIRST PAGE  ########-->
                        <div class=""carousel-item active"">
                            <div class=""item row justify-content-around"">
");
                EndContext();
#line 91 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                 foreach (var vehicle in Model.Take(3))
                                {

#line default
#line hidden
                BeginContext(4183, 66, true);
                WriteLiteral("                                    <div class=\"car-card col-3\">\r\n");
                EndContext();
#line 94 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                         foreach (var vehicleImage in vehicle.vehicleImages)
                                        {
                                            if (vehicleImage.IsThumbnail)
                                            {

#line default
#line hidden
                BeginContext(4508, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(4556, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c16b3919834c524ae24b95f6dcf539865cc5282d12205", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4566, "~/assets/vehicleImages/", 4566, 23, true);
#line 98 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4589, vehicleImage.Path, 4589, 18, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4643, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 99 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
                BeginContext(4735, 108, true);
                WriteLiteral("                                        \r\n                                        <h5 class=\"card-car-name\">");
                EndContext();
                BeginContext(4844, 25, false);
#line 102 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                                             Write(vehicle.StringVehicleMake);

#line default
#line hidden
                EndContext();
                BeginContext(4869, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4871, 26, false);
#line 102 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                                                                        Write(vehicle.StringVehicleModel);

#line default
#line hidden
                EndContext();
                BeginContext(4897, 73, true);
                WriteLiteral("</h5>\r\n                                        <p class=\"card-car-price\">");
                EndContext();
                BeginContext(4971, 18, false);
#line 103 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                                             Write(vehicle.DailyPrice);

#line default
#line hidden
                EndContext();
                BeginContext(4989, 332, true);
                WriteLiteral(@"$ / Day</p>
                                        <div class=""row car-info-items"">
                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/car-icon.png"" width=""24px"" height=""20px"">
                                                <p>");
                EndContext();
                BeginContext(5322, 20, false);
#line 107 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.Transmission);

#line default
#line hidden
                EndContext();
                BeginContext(5342, 306, true);
                WriteLiteral(@"</p>
                                            </div>

                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/fuel-icon.png"" width=""24px"" height=""20px"">
                                                <p>");
                EndContext();
                BeginContext(5649, 16, false);
#line 112 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.FuelType);

#line default
#line hidden
                EndContext();
                BeginContext(5665, 307, true);
                WriteLiteral(@"</p>
                                            </div>

                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/seats-icon.png"" width=""22px"" height=""22px"">
                                                <p>");
                EndContext();
                BeginContext(5973, 15, false);
#line 117 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.SeatsNr);

#line default
#line hidden
                EndContext();
                BeginContext(5988, 314, true);
                WriteLiteral(@"</p>
                                            </div>

                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/car-category-icon.png"" width=""24px"" height=""20px"">
                                                <p>");
                EndContext();
                BeginContext(6303, 29, false);
#line 122 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.StringVehicleCategory);

#line default
#line hidden
                EndContext();
                BeginContext(6332, 182, true);
                WriteLiteral("</p>\r\n                                            </div>\r\n\r\n                                            <div class=\"car-info-btn\">\r\n                                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6514, "\"", 6557, 2);
                WriteAttributeValue("", 6521, "/vehicles/details/", 6521, 18, true);
#line 126 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
WriteAttributeValue("", 6539, vehicle.VehicleID, 6539, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6558, 170, true);
                WriteLiteral(" class=\"btn\">Reserve</a>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
                EndContext();
#line 130 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(6763, 259, true);
                WriteLiteral(@"                            </div>
                        </div>
                        <!--#######  SECOND PAGE  ########-->
                        <div class=""carousel-item"">
                            <div class=""item row justify-content-around"">
");
                EndContext();
#line 136 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                 foreach (var vehicle in Model.Skip(3).Take(3))
                                {

#line default
#line hidden
                BeginContext(7138, 66, true);
                WriteLiteral("                                    <div class=\"car-card col-3\">\r\n");
                EndContext();
#line 139 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                         foreach (var vehicleImage in vehicle.vehicleImages)
                                        {
                                            if (vehicleImage.IsThumbnail)
                                            {

#line default
#line hidden
                BeginContext(7463, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(7511, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c16b3919834c524ae24b95f6dcf539865cc5282d20936", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7521, "~/assets/vehicleImages/", 7521, 23, true);
#line 143 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7544, vehicleImage.Path, 7544, 18, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7598, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 144 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
                BeginContext(7690, 68, true);
                WriteLiteral("\r\n                                        <h5 class=\"card-car-name\">");
                EndContext();
                BeginContext(7759, 25, false);
#line 147 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                                             Write(vehicle.StringVehicleMake);

#line default
#line hidden
                EndContext();
                BeginContext(7784, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(7786, 26, false);
#line 147 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                                                                        Write(vehicle.StringVehicleModel);

#line default
#line hidden
                EndContext();
                BeginContext(7812, 73, true);
                WriteLiteral("</h5>\r\n                                        <p class=\"card-car-price\">");
                EndContext();
                BeginContext(7886, 18, false);
#line 148 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                                             Write(vehicle.DailyPrice);

#line default
#line hidden
                EndContext();
                BeginContext(7904, 332, true);
                WriteLiteral(@"$ / Day</p>
                                        <div class=""row car-info-items"">
                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/car-icon.png"" width=""24px"" height=""20px"">
                                                <p>");
                EndContext();
                BeginContext(8237, 20, false);
#line 152 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.Transmission);

#line default
#line hidden
                EndContext();
                BeginContext(8257, 306, true);
                WriteLiteral(@"</p>
                                            </div>

                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/fuel-icon.png"" width=""24px"" height=""20px"">
                                                <p>");
                EndContext();
                BeginContext(8564, 16, false);
#line 157 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.FuelType);

#line default
#line hidden
                EndContext();
                BeginContext(8580, 307, true);
                WriteLiteral(@"</p>
                                            </div>

                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/seats-icon.png"" width=""22px"" height=""22px"">
                                                <p>");
                EndContext();
                BeginContext(8888, 15, false);
#line 162 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.SeatsNr);

#line default
#line hidden
                EndContext();
                BeginContext(8903, 314, true);
                WriteLiteral(@"</p>
                                            </div>

                                            <div class=""car-info-item col-3"">
                                                <img src=""../assets/img/car-category-icon.png"" width=""24px"" height=""20px"">
                                                <p>");
                EndContext();
                BeginContext(9218, 29, false);
#line 167 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                              Write(vehicle.StringVehicleCategory);

#line default
#line hidden
                EndContext();
                BeginContext(9247, 182, true);
                WriteLiteral("</p>\r\n                                            </div>\r\n\r\n                                            <div class=\"car-info-btn\">\r\n                                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 9429, "\"", 9472, 2);
                WriteAttributeValue("", 9436, "/vehicles/details/", 9436, 18, true);
#line 171 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
WriteAttributeValue("", 9454, vehicle.VehicleID, 9454, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9473, 170, true);
                WriteLiteral(" class=\"btn\">Reserve</a>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
                EndContext();
#line 175 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(9678, 1427, true);
                WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <a class=""carousel-control-prev custom-carousel-button"" style=""width:70px;"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon change-carousel-custom"" aria-hidden=""true"">
                        </span>
                        <span class=""sr-only""></span>
                    </a>
                    <a class=""carousel-control-next custom-carousel-button"" style=""width:70px;"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon change-carousel-custom"" aria-hidden=""true"">
                        </span>
                        <span class=""sr-only""></span>
                    </a>
                    <div class=""show-container"">
                        <a href=""/vehicles/index"" class=""btn btn-default"">Show All</a>
                    ");
                WriteLiteral(@"</div>
                </div>
            </div>
        </div>
    </main>

    <script>
        // CAROUSEL
        $('.carousel').carousel({
            interval: false
        })

        $(document).ready(function() {
            jQuery.fn.carousel.Constructor.TRANSITION_DURATION = 500  // 2 seconds
        });

        // ADD MODELS BY SELECTED MAKE
        var vehicleBrands = ");
                EndContext();
                BeginContext(11106, 68, false);
#line 208 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Views\Home\Index.cshtml"
                       Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(vehicleBrands)));

#line default
#line hidden
                EndContext();
                BeginContext(11174, 831, true);
                WriteLiteral(@";
        const uniqueMakeSet = [new Set(vehicleBrands.map(obj => obj.Make))];
        var uniqueMakeArray = Array.from(uniqueMakeSet[0]);    

        function addModelsByMake(item) {
            var modelsSelect = document.getElementById('vehicleModel');
            modelsSelect.innerHTML = """";
            modelsSelect.innerHTML = ""<option value=\""\"" selected>Model:</option>"";
            var make = item.value;
            var makesAndModels = vehicleBrands.filter(x => x.Make == make);
            var models = [];
            makesAndModels.forEach(x => models.push(x.Model));

            models.forEach(function (item) {
                var option = document.createElement(""option"");
                option.text = item;
                modelsSelect.add(option);
            })
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12012, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RentACarTI2.Models.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6afea0e86b79072099875ea561b0cdc06033777f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_AdminLayout.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6afea0e86b79072099875ea561b0cdc06033777f", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dark-edition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6afea0e86b79072099875ea561b0cdc06033777f3376", async() => {
                BeginContext(31, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(45, 13, false);
#line 4 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(58, 873, true);
                WriteLiteral(@"</title>
    <meta charset=""utf-8"" />
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""../assets/img/apple-icon.png"">
    <link rel=""icon"" type=""image/png"" href=""../assets/img/favicon.png"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!--     Fonts and icons     -->
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css"">
    <!-- CSS Files -->
    <link href=""/Admin/Content/css/material-dashboard.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Render Style Section From Views -->
    ");
                EndContext();
                BeginContext(932, 39, false);
#line 16 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(RenderSection("Style", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(971, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(980, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(982, 14259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6afea0e86b79072099875ea561b0cdc06033777f6201", async() => {
                BeginContext(1009, 568, true);
                WriteLiteral(@"
    <div class=""wrapper "">
        <div class=""sidebar"" data-color=""purple"" data-background-color=""black"" data-image=""/Admin/Content/assets/img/bmw-background.jpg"">
            <div class=""logo"">
                <a href=""/Admin"" class=""simple-text logo-normal"">
                    <img src=""/Admin/Content/assets/img/rentacar-logo3.png"">
                </a>
            </div>
            <div class=""sidebar-wrapper ps-container ps-theme-default"" data-ps-id=""c729caed-7794-3702-f29c-1ef7047abdfc"">
                <ul class=""nav"">
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1577, "\"", 1618, 2);
                WriteAttributeValue("", 1585, "nav-item", 1585, 8, true);
#line 28 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 1593, ViewBag.DashboardActive, 1594, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1619, 258, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin"">
                            <i class=""material-icons"">dashboard</i>
                            <p>Dashboard</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1877, "\"", 1913, 2);
                WriteAttributeValue("", 1885, "nav-item", 1885, 8, true);
#line 34 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 1893, ViewBag.UserActive, 1894, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1914, 262, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/User/Index"">
                            <i class=""material-icons"">person</i>
                            <p>Users</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2176, "\"", 2212, 2);
                WriteAttributeValue("", 2184, "nav-item", 2184, 8, true);
#line 40 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 2192, ViewBag.RoleActive, 2193, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2213, 260, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Role/Index"">
                            <i class=""material-icons"">lock</i>
                            <p>Roles</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2473, "\"", 2512, 2);
                WriteAttributeValue("", 2481, "nav-item", 2481, 8, true);
#line 46 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 2489, ViewBag.VehicleActive, 2490, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2513, 276, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Vehicle/Index"">
                            <i class=""material-icons"">directions_car</i>
                            <p>Vehicles</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2789, "\"", 2827, 2);
                WriteAttributeValue("", 2797, "nav-item", 2797, 8, true);
#line 52 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 2805, ViewBag.ClientActive, 2806, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2828, 266, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Client/Index"">
                            <i class=""material-icons"">groups</i>
                            <p>Clients</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3094, "\"", 3133, 2);
                WriteAttributeValue("", 3102, "nav-item", 3102, 8, true);
#line 58 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 3110, ViewBag.BookingActive, 3111, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3134, 279, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Reservation/Index"">
                            <i class=""material-icons"">edit_note</i>
                            <p>Reservations</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3413, "\"", 3451, 2);
                WriteAttributeValue("", 3421, "nav-item", 3421, 8, true);
#line 64 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 3429, ViewBag.RentalActive, 3430, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3452, 270, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Rental/Index"">
                            <i class=""material-icons"">car_rental</i>
                            <p>Rentals</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3722, "\"", 3760, 2);
                WriteAttributeValue("", 3730, "nav-item", 3730, 8, true);
#line 70 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 3738, ViewBag.ReturnActive, 3739, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3761, 277, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Return/Index"">
                            <i class=""material-icons"">assignment_return</i>
                            <p>Returns</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4038, "\"", 4076, 2);
                WriteAttributeValue("", 4046, "nav-item", 4046, 8, true);
#line 76 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 4054, ViewBag.RepairActive, 4055, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4077, 265, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Repair/Index"">
                            <i class=""material-icons"">build</i>
                            <p>Repairs</p>
                        </a>
                    </li>
                    <li");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4342, "\"", 4385, 2);
                WriteAttributeValue("", 4350, "nav-item", 4350, 8, true);
#line 82 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
WriteAttributeValue(" ", 4358, ViewBag.MaintenanceActive, 4359, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4386, 4332, true);
                WriteLiteral(@">
                        <a class=""nav-link"" href=""/Admin/Maintenance/Index"">
                            <i class=""material-icons"">engineering</i>
                            <p>Maintenances</p>
                        </a>
                    </li>
                </ul>
                <div class=""ps-scrollbar-x-rail"" style=""left: 0px; bottom: 0px;""><div class=""ps-scrollbar-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps-scrollbar-y-rail"" style=""top: 0px; right: 0px;""><div class=""ps-scrollbar-y"" tabindex=""0"" style=""top: 0px; height: 0px;""></div></div>
            </div>
            <div class=""sidebar-background"" style=""background-image: url(/Admin/Content/assets/img/bmw-background.jpg)""></div>
        </div>
        <div class=""main-panel"">
            <!-- Navbar -->
            <nav class=""navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top "" id=""navigation-example"">
                <div class=""container-fluid"">
                    <div class=""na");
                WriteLiteral(@"vbar-wrapper"">
                        <a class=""navbar-brand"" href=""javascript:void(0)"">Dashboard</a>
                    </div>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index""
                            aria-expanded=""false"" aria-label=""Toggle navigation"" data-target=""#navigation-example"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-end"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link"" href=""javscript:void(0)"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown""
   ");
                WriteLiteral(@"                                aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">notifications</i>
                                    <span class=""notification"">5</span>
                                    <p class=""d-lg-none d-md-block"">
                                        Some Actions
                                    </p>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                                    <a class=""dropdown-item"" href=""javascript:void(0)"">Mike John responded to your email</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0)"">You have 5 new tasks</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0)"">You're now friend with Andrew</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0)"">Another Notificatio");
                WriteLiteral(@"n</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0)"">Another One</a>
                                </div>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""javscript:void(0)"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown""
                                   aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">person</i>
                                    <p class=""d-lg-none d-md-block"">
                                        Account
                                    </p>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                                    <a class=""dropdown-item"" href=""./user.html"">My Profile</a>
                                    <a class=""dropdown-item"" href=""javascript:void(0)"">");
                WriteLiteral("Log Out</a>\r\n                                </div>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </nav>\r\n            <!-- End Navbar -->\r\n            ");
                EndContext();
                BeginContext(8719, 12, false);
#line 144 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(8731, 6459, true);
                WriteLiteral(@"
        </div>
    </div>
    <!--   Core JS Files   -->
    <script src=""/Admin/Content/js/core/jquery.min.js""></script>
    <script src=""/Admin/Content/js/core/popper.min.js""></script>
    <script src=""/Admin/Content/js/core/bootstrap-material-design.min.js""></script>
    <script src=""https://unpkg.com/default-passive-events""></script>
    <script src=""/Admin/Content/js/plugins/perfect-scrollbar.jquery.min.js""></script>
    <!-- Place this tag in your head or just before your close body tag. -->
    <script async defer src=""https://buttons.github.io/buttons.js""></script>
    <!-- Chartist JS -->
    <script src=""/Admin/Content/js/plugins/chartist.min.js""></script>
    <!--  Notifications Plugin    -->
    <script src=""/Admin/Content/js/plugins/bootstrap-notify.js""></script>
    <script>
        $(document).ready(function () {
            $().ready(function () {

                $sidebar = $('.sidebar');

                $sidebar_img_container = $sidebar.find('.sidebar-background');

");
                WriteLiteral(@"                $full_page = $('.full-page');

                $sidebar_responsive = $('body > .navbar-collapse');

                window_width = $(window).width();

                $('.fixed-plugin a').click(function (event) {
                    // Alex if we click on switch, stop propagation of the event, so the dropdown will not be hide, otherwise we set the  section active
                    if ($(this).hasClass('switch-trigger')) {
                        if (event.stopPropagation) {
                            event.stopPropagation();
                        } else if (window.event) {
                            window.event.cancelBubble = true;
                        }
                    }
                });

                $('.fixed-plugin .active-color span').click(function () {
                    $full_page_background = $('.full-page-background');

                    $(this).siblings().removeClass('active');
                    $(this).addClass('active');

           ");
                WriteLiteral(@"         var new_color = $(this).data('color');

                    if ($sidebar.length != 0) {
                        $sidebar.attr('data-color', new_color);
                    }

                    if ($full_page.length != 0) {
                        $full_page.attr('filter-color', new_color);
                    }

                    if ($sidebar_responsive.length != 0) {
                        $sidebar_responsive.attr('data-color', new_color);
                    }
                });

                $('.fixed-plugin .background-color .badge').click(function () {
                    $(this).siblings().removeClass('active');
                    $(this).addClass('active');

                    var new_color = $(this).data('background-color');

                    if ($sidebar.length != 0) {
                        $sidebar.attr('data-background-color', new_color);
                    }
                });

                $('.fixed-plugin .img-holder').click(function () {
");
                WriteLiteral(@"                    $full_page_background = $('.full-page-background');

                    $(this).parent('li').siblings().removeClass('active');
                    $(this).parent('li').addClass('active');


                    var new_image = $(this).find(""img"").attr('src');

                    if ($sidebar_img_container.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                        $sidebar_img_container.fadeOut('fast', function () {
                            $sidebar_img_container.css('background-image', 'url(""' + new_image + '"")');
                            $sidebar_img_container.fadeIn('fast');
                        });
                    }

                    if ($full_page_background.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                        var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');

                        $full_page_background.fadeOut('fast', function () ");
                WriteLiteral(@"{
                            $full_page_background.css('background-image', 'url(""' + new_image_full_page + '"")');
                            $full_page_background.fadeIn('fast');
                        });
                    }

                    if ($('.switch-sidebar-image input:checked').length == 0) {
                        var new_image = $('.fixed-plugin li.active .img-holder').find(""img"").attr('src');
                        var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');

                        $sidebar_img_container.css('background-image', 'url(""' + new_image + '"")');
                        $full_page_background.css('background-image', 'url(""' + new_image_full_page + '"")');
                    }

                    if ($sidebar_responsive.length != 0) {
                        $sidebar_responsive.css('background-image', 'url(""' + new_image + '"")');
                    }
                });

                $('.switch-sidebar-imag");
                WriteLiteral(@"e input').change(function () {
                    $full_page_background = $('.full-page-background');

                    $input = $(this);

                    if ($input.is(':checked')) {
                        if ($sidebar_img_container.length != 0) {
                            $sidebar_img_container.fadeIn('fast');
                            $sidebar.attr('data-image', '#');
                        }

                        if ($full_page_background.length != 0) {
                            $full_page_background.fadeIn('fast');
                            $full_page.attr('data-image', '#');
                        }

                        background_image = true;
                    } else {
                        if ($sidebar_img_container.length != 0) {
                            $sidebar.removeAttr('data-image');
                            $sidebar_img_container.fadeOut('fast');
                        }

                        if ($full_page_background.length != 0) ");
                WriteLiteral(@"{
                            $full_page.removeAttr('data-image', '#');
                            $full_page_background.fadeOut('fast');
                        }

                        background_image = false;
                    }
                });
            });
        });
    </script>
    ");
                EndContext();
                BeginContext(15191, 41, false);
#line 288 "C:\Users\OS\Desktop\RentACarTI2\RentACarTI2\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(15232, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(15241, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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

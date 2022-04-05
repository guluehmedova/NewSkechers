#pragma checksum "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c19c4f456e5927cb6dd9c7cb65055e43ae62313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_DashBoard_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/DashBoard/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Skechers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Skechers.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Skechers.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c19c4f456e5927cb6dd9c7cb65055e43ae62313", @"/Areas/Manage/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1fddda541c9a6bcdf5ea78393a8d2905d713fa", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"      
       <!-- Content Start -->

            <!-- Sale & Revenue Start -->
            <div class=""container-fluid pt-4 px-4"">
                <div class=""row g-4"">
                    <div class=""col-sm-6 col-xl-3"">
                        <div class=""bg-light rounded d-flex align-items-center justify-content-between p-4"">
                            <i class=""fa fa-chart-line fa-3x text-primary""></i>
                            <div class=""ms-3"">
                                <p class=""mb-2"">Today Sale / Accepted</p>
                                <h6 class=""mb-0"">");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                            Write(ViewBag.TodaySale);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</h6>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 col-xl-3"">
                        <div class=""bg-light rounded d-flex align-items-center justify-content-between p-4"">
                            <i class=""fa fa-chart-bar fa-3x text-primary""></i>
                            <div class=""ms-3"">
                                <p class=""mb-2"">Total Sale</p>
                                <h6 class=""mb-0"">");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                            Write(ViewBag.TotalSale);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</h6>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Sale & Revenue End -->

            <!-- Recent Sales Start -->
            <div class=""container-fluid pt-4 px-4"">
                <div class=""bg-light text-center rounded p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <h6 class=""mb-0"">Sales</h6>
                    </div>
                    <div class=""table-responsive"">
                        <table class=""table text-start align-middle table-bordered table-hover mb-0"">
                            <thead>
                                <tr class=""text-dark"">
                                    <th scope=""col"">Date</th>
                                    <th scope=""col"">Customer</th>
                                    <th scope=""col"">Amount</th>
                                    <th scope=""col"">Status</th>
                ");
            WriteLiteral("                </tr>\n                            </thead>\n                            <tbody>\n");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                 foreach (var item in Model.Orders)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                       Write(item.CreateAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                       Write(item.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 53 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\Skechers\Skechers\BackEnd\Skechers\Skechers\Areas\Manage\Views\DashBoard\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <!-- Recent Sales End -->

        <!-- Content End -->



        <!-- Back to Top -->
        <a href=""#"" class=""btn btn-lg btn-primary btn-lg-square back-to-top""><i class=""bi bi-arrow-up""></i></a>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

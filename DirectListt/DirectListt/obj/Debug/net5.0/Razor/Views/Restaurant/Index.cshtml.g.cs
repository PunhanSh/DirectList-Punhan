#pragma checksum "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Restaurant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f68261e7ecd909a095a229f74933ca1e17ff71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Index), @"mvc.1.0.view", @"/Views/Restaurant/Index.cshtml")]
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
#line 1 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\_ViewImports.cshtml"
using DirectListt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\_ViewImports.cshtml"
using DirectListt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\_ViewImports.cshtml"
using DirectListt.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f68261e7ecd909a095a229f74933ca1e17ff71", @"/Views/Restaurant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e68194ac935741a2f546d2fc14afda621ecc4db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Restaurant\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper\">\r\n    <!--Title Bar -->\r\n");
            WriteLiteral(@"
    <!-- Content -->
    <div class=""content"">
        <div class=""container"">
            <div class=""row"">
                <!-- Search -->
                <div class=""col-md-12 grid-full-width page-search mb-3"">
                    <div class=""main-search-input mt-0"">
                        <div class=""col-lg-4 col-sm-6"">
                            <div class=""form-group"">
                                <input type=""text"" placeholder=""What are you looking for?"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-lg-4 col-sm-6"">
                            <div class=""form-group"">
                                <input type=""text"" placeholder=""Location"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-lg-4 col-sm-6 text-right"">
                            <a class=""btn main-search-btn btn-radius btn-lg btn-primary text-white""><span c");
            WriteLiteral(@"lass=""btn-inner--text"">Search</span></a>
                        </div>
                    </div>
                </div>
                <!-- Search Section / End -->
                <div class=""col-md-12"">
                    <!-- Sorting - Filtering Section / End -->
                    <div class=""row"">
                        <!-- Listing Item -->
                        <div class=""col-lg-12 col-md-12 mb-5"">
                            <div class=""listing-item-container list-layout"">
                                <div class=""listing-item"">
                                    <!-- Image -->
                                    <div class=""listing-item-image"">
                                        <a href=""listings-detail-one.html""><img src=""assets/images/most-img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1984, "\"", 1990, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <!-- Content -->
                                    <div class=""listing-item-content"">
                                        <span class=""badge badge-pill list-banner badge-success text-uppercase"">Now Open</span>
                                        <div class=""listing-item-inner"">
                                            <!-- <DirectlistRating [rate]=""list.rating""></DirectlistRating> -->
                                            <a href=""listings-detail-two.html"">
                                                <h3>Tom House</h3>
                                            </a>
                                            <div class=""address-bar""> <small>4340  Cambridge Court Natural Dam, Arkansas</small> </div>
                                            <div class=""mt-3""><span class=""badge badge-pill badge-primary text-uppercase badge-cat"">Eat & Drink</span></div>
                                     ");
            WriteLiteral(@"   </div>
                                        <span class=""round-pill like-banner d-block bg-primary""><i class=""fa fa-heart-o""></i></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-12 col-md-12 mb-5"">
                            <div class=""listing-item-container list-layout"">
                                <div class=""listing-item"">
                                    <!-- Image -->
                                    <div class=""listing-item-image"">
                                        <a href=""listings-detail-one.html""><img src=""assets/images/most-img-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3750, "\"", 3756, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <!-- Content -->
                                    <div class=""listing-item-content"">
                                        <span class=""badge badge-pill list-banner badge-success text-uppercase"">Now Open</span>
                                        <div class=""listing-item-inner"">
                                            <!-- <DirectlistRating [rate]=""list.rating""></DirectlistRating> -->
                                            <a href=""listings-detail-two.html"">
                                                <h3>Burger House</h3>
                                            </a>
                                            <div class=""address-bar""> <small>4340  Cambridge Court Natural Dam, Arkansas</small> </div>
                                            <div class=""mt-3""><span class=""badge badge-pill badge-primary text-uppercase badge-cat"">Eat & Drink</span></div>
                                  ");
            WriteLiteral(@"      </div>
                                        <span class=""round-pill like-banner d-block bg-primary""><i class=""fa fa-heart-o""></i></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-12 col-md-12 mb-5"">
                            <div class=""listing-item-container list-layout"">
                                <div class=""listing-item"">
                                    <!-- Image -->
                                    <div class=""listing-item-image"">
                                        <a href=""listings-detail-one.html""><img src=""assets/images/most-img-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5519, "\"", 5525, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    </div>
                                    <!-- Content -->
                                    <div class=""listing-item-content"">
                                        <span class=""badge badge-pill list-banner badge-success text-uppercase"">Now Open</span>
                                        <div class=""listing-item-inner"">
                                            <!-- <DirectlistRating [rate]=""list.rating""></DirectlistRating> -->
                                            <a href=""listings-detail-two.html"">
                                                <h3>Hotel Govendor</h3>
                                            </a>
                                            <div class=""address-bar""> <small>2924  Elliott Street, Nashua New Hampshire</small> </div>
                                            <div class=""mt-3""><span class=""badge badge-pill badge-primary text-uppercase badge-cat"">Eat & Drink</span></div>
                                 ");
            WriteLiteral(@"       </div>
                                        <span class=""round-pill like-banner d-block bg-primary""><i class=""fa fa-heart-o""></i></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Listing Item / End -->
                    </div>
                    <!-- Pagination -->
                    <div class=""clearfix""></div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <!-- Pagination -->
                            <div class=""mt-3"">
                                <nav aria-label=""Page navigation"">
                                    <ul class=""pagination"">
                                        <li class=""page-item"">
                                            <a class=""page-link""><i class=""fa fa-angle-left""></i></a>
                                        </li>
                       ");
            WriteLiteral(@"                 <li class=""page-item"">
                                            <a class=""page-link"">1</a>
                                        </li>
                                        <li class=""page-item active"">
                                            <a class=""page-link"">2</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">3</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">4</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">5</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-li");
            WriteLiteral(@"nk""><i class=""fa fa-angle-right""></i></a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                    <!-- Pagination / End -->
                </div>
            </div>
        </div>
    </div>
</div>");
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

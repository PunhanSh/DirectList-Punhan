#pragma checksum "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9358269e034564775b3a23c453bc7f1fd0742399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9358269e034564775b3a23c453bc7f1fd0742399", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e68194ac935741a2f546d2fc14afda621ecc4db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("list-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""position-relative"">
    <section class=""section section-lg section-hero section-shaped"">
        <div class=""shape shape-style-1 shape-primary"">
            <span class=""span-150""></span>
            <span class=""span-50""></span>
            <span class=""span-50""></span>
            <span class=""span-75""></span>
            <span class=""span-100""></span>
            <span class=""span-75""></span>
            <span class=""span-50""></span>
            <span class=""span-100""></span>
            <span class=""span-50""></span>
            <span class=""span-100""></span>
            <div class=""overlay-bg""></div>
        </div>
        <div class=""container shape-container d-flex align-items-center py-lg"">
            <div class=""main-search-inner"">
                <h2 class=""text-white display-2"">Find Nearby Attractions</h2>
                <h4 class=""text-white"">Expolore top-rated attractions, activities and more</h4>
                <div class=""main-search-input"">
               ");
            WriteLiteral("     <div class=\"main-search-input-item\">\r\n                        <input type=\"text\" placeholder=\"What are you looking for?\"");
            BeginWriteAttribute("value", " value=\"", 1209, "\"", 1217, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""main-search-input-item location"">
                        <div id=""autocomplete-container"">
                            <input id=""autocomplete-input"" type=""text"" placeholder=""Location"">
                        </div>
                        <a href=""#""><i class=""fa fa-map-marker""></i></a>
                    </div>
                    <a href=""#"" class=""btn main-search-btn btn-radius btn-lg btn-white"">
                        <span class=""btn-inner--text"">Search</span>
                    </a>
                </div>
            </div>
        </div>
        <!-- SVG separator -->
        <div class=""separator separator-bottom separator-skew zindex-100"">
            <svg x=""0"" y=""0"" viewBox=""0 0 2560 100"" preserveAspectRatio=""none"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"">
                <polygon class=""fill-white"" points=""2560 0 2560 100 0 100""></polygon>
            </svg>
        </div>
    </section>
</div>
<div ");
            WriteLiteral(@"class=""block-space"">
    <div class=""container"">
        <div class=""block-head text-center mb-5"">
            <h2 class=""head-line display-3"">
                Restaurants in Website
            </h2>
            <p class=""lead mt-2 head-desc"">Browse the most desirable restaurants</p>
        </div>
    </div>
    <!-- Categories Carousel -->
    <div class=""fullwidth-carousel-container"">
        <div class=""fullwidth-slick-carousel category-carousel"">
            <!-- Item -->
");
#nullable restore
#line 63 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
             foreach (var item in Model.Restaurants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""fw-carousel-item"">
                    <div class=""category-box-container text-center"">
                        <div class=""category-box"">
                            <div class=""category-box-content"">
                                <div class=""icon-title"">
                                    <i class=""fa-2x fa fa-glass""></i>
                                </div>
                                <h3>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9358269e034564775b3a23c453bc7f1fd074239910425", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 74 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h3>\r\n                            </div>\r\n                            <div class=\"category-box-background\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9358269e034564775b3a23c453bc7f1fd074239913444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3658, "~/assets/images/", 3658, 16, true);
#nullable restore
#line 79 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3674, item.Image, 3674, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>            \r\n");
#nullable restore
#line 84 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""block-space bg-secondary"">
    <div class=""container"">
        <div class=""block-head text-center mb-5"">
            <h2 class=""head-line display-3"">
                Most Visited Places
            </h2>
            <p class=""lead mt-2 head-desc"">Discover top-rated local businesses</p>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""simple-slick-carousel dots-nav"">

");
#nullable restore
#line 100 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                     foreach (var item in Model.Restaurants)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""carousel-item"">
                            <div class=""category-box-container"">
                                <div class=""listing-item-container"">
                                    <div class=""listing-item"">
                                        <div class=""mostviewed-bg"" style=""background-image: url('/wwwroot/')"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9358269e034564775b3a23c453bc7f1fd074239916678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4871, "~/assets/images/", 4871, 16, true);
#nullable restore
#line 107 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4887, item.Image, 4887, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <div class=\"listing-item-content\" style=\"padding-top: 30px\">\r\n");
#nullable restore
#line 109 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                 foreach (var tag in item.RestaurantToTags)
                                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"mb-1\"><span class=\"badge badge-pill badge-primary text-uppercase badge-cat\">");
#nullable restore
#line 111 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                                                                       Write(tag.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 112 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <h3 style=\"text-align: center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9358269e034564775b3a23c453bc7f1fd074239919581", async() => {
#nullable restore
#line 113 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                                    <p class=\"mb-0 text-center\"> <small>");
#nullable restore
#line 114 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                                    <span text-uppercase\">\r\n");
#nullable restore
#line 116 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                     if ((item.StartTime.Hour < DateTime.Now.Hour && item.StartTime.Minute <= DateTime.Now.Minute) && (item.EndTime.Hour > DateTime.Now.Hour && item.EndTime.Minute <= DateTime.Now.Minute))
                                                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge badge-pill list-banner badge-success\">Open</span> ");
#nullable restore
#line 118 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                                                             }
                                                     else
                                                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge badge-pill list-banner badge-danger\">Closed</span>");
#nullable restore
#line 121 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </span>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 130 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""block-space bg-primary"">
    <div class=""container"">
        <div class=""block-head text-center mb-5"">
            <h2 class=""head-line text-white display-3"">
                ");
#nullable restore
#line 140 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
           Write(Model.Setting.DreamTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <div class=\"col-12 col-md-7 mx-auto pb-3\">\r\n                <p class=\"lead mt-2 head-desc text-white\">");
#nullable restore
#line 143 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                     Write(Model.Setting.DreamSubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row row-grid mt-5"">
            <div class=""col-lg-4 text-center"">
                <div class=""icon icon-lg icon-shape bg-gradient-white shadow rounded-circle text-primary"">
                    <i class=""fa fa-search""></i>
                </div>
                <h5 class=""text-white mt-3"">Find Interesting Place</h5>
                <p class=""text-white mt-3"">Proin dapibus nisl ornare diam varius tempus. Aenean a quam luctus, finibus tellus ut, convallis eros sollicitudin turpis.</p>
            </div>
            <div class=""col-lg-4 text-center"">
                <div class=""icon icon-lg icon-shape bg-gradient-white shadow rounded-circle text-primary"">
                    <i class=""fa fa-phone-square""></i>
                </div>
                <h5 class=""text-white mt-3"">Contact a Few Owners</h5>
                <p class=""text-white mt-3"">Maecenas pulvinar, risus in facilisis dignissim, quam ni");
            WriteLiteral(@"si hendrerit nulla, id vestibulum metus nullam viverra porta purus.</p>
            </div>
            <div class=""col-lg-4 text-center"">
                <div class=""icon icon-lg icon-shape bg-gradient-white shadow rounded-circle text-primary"">
                    <i class=""fa fa-user-plus""></i>
                </div>
                <h5 class=""text-white mt-3"">Make a Reservation</h5>
                <p class=""text-white mt-3"">Faucibus ante, in porttitor tellus blandit et. Phasellus tincidunt metus lectus sollicitudin feugiat pharetra consectetur.</p>
            </div>
        </div>
    </div>
</div>
<div class=""block-space bg-secondary"">
    <div class=""block-head text-center mb-5"">
        <h2 class=""head-line display-3"">
            Recent Blog
        </h2>
        <p class=""lead mt-2 head-desc"">Added Recently</p>
    </div>
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""row row-grid"">
");
#nullable restore
#line 184 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                     foreach (var item in Model.Blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4\">\r\n                            <div class=\"card card-lift--hover shadow border-0\" style=\"height:550px\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9358269e034564775b3a23c453bc7f1fd074239928481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9559, "~/Uploads/", 9559, 10, true);
#nullable restore
#line 188 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9569, item.Image, 9569, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body py-4\">\r\n                                    <h5>");
#nullable restore
#line 190 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p>");
#nullable restore
#line 191 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                  Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"description mb-4\">");
#nullable restore
#line 192 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9358269e034564775b3a23c453bc7f1fd074239931240", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 193 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 197 "C:\Users\TUF DASH\Desktop\Backend-Project\DirectListt\DirectListt\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmHome> Html { get; private set; }
    }
}
#pragma warning restore 1591

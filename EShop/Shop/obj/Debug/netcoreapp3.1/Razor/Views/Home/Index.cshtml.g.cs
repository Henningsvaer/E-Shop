#pragma checksum "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a9b6851c55d9d2a761b01c8f320de6ac5345a6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a9b6851c55d9d2a761b01c8f320de6ac5345a6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Model.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Интернет - магазин";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div id=\"carouselExampleCaptions\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 9 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li data-target=\"#carouselExampleCaptions\" data-slide-to=\"");
#nullable restore
#line 11 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                                                                 Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 12 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 16 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
             foreach (var product in Model)
            {
                if (product == Model.First())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 706, "\"", 741, 1);
#nullable restore
#line 21 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 712, product.ProductLinkToPicture, 712, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 764, "\"", 790, 1);
#nullable restore
#line 21 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 770, product.ProductName, 770, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h5>");
#nullable restore
#line 23 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                           Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 24 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                          Write(product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 27 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1188, "\"", 1223, 1);
#nullable restore
#line 31 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1194, product.ProductLinkToPicture, 1194, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 1246, "\"", 1272, 1);
#nullable restore
#line 31 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1252, product.ProductName, 1252, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h5>");
#nullable restore
#line 33 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                           Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 34 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                          Write(product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\DNS\Documents\GitHub\E-Shop\EShop\Shop\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Model.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

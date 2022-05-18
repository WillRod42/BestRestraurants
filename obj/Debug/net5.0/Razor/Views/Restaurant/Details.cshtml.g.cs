#pragma checksum "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4096cb96a66f902f6239caed18c598cf911f7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Details), @"mvc.1.0.view", @"/Views/Restaurant/Details.cshtml")]
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
#line 4 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4096cb96a66f902f6239caed18c598cf911f7d", @"/Views/Restaurant/Details.cshtml")]
    public class Views_Restaurant_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h5>");
#nullable restore
#line 10 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<p>");
#nullable restore
#line 11 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Html.ActionLink("Add A Review", "Create", "Reviews", new {id = Model.RestaurantId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n");
#nullable restore
#line 12 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
 foreach(Review review in Model.Reviews)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ul>\r\n    <li><h5>Rating: ");
#nullable restore
#line 15 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
               Write(review.ReviewRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /10</h5></li>\r\n    <li><h5>Author: ");
#nullable restore
#line 16 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
               Write(review.ReviewAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n    <li><p>");
#nullable restore
#line 17 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
      Write(review.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n  </ul>\r\n");
#nullable restore
#line 19 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button class=\"btn btn-primary\">");
#nullable restore
#line 20 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
                           Write(Html.ActionLink("Add A Restaurant", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n<p>");
#nullable restore
#line 21 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Html.ActionLink("Edit Restaurant", "Edit", new { id = Model.RestaurantId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 22 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Html.ActionLink("Delete Restaurant", "Delete", new { id = Model.RestaurantId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 23 "C:\Users\jerem\OneDrive\Desktop\projects\BestRestaurants.Solution\BestRestaurants\Views\Restaurant\Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "841ae9f3add9668a510fb5df4b7f9eb5b84bba2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\_ViewImports.cshtml"
using webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841ae9f3add9668a510fb5df4b7f9eb5b84bba2e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9199b4e53545c67bd84ad2eaa2357bc02933d8df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Welcome to the wedding planner, ");
#nullable restore
#line 3 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
                               Write(ViewBag.LoggedInUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<button class=\"btn btn-danger\">Log out</button>\r\n\r\n<table class=\"table table-dark\">\r\n    <thead>\r\n    <tr>\r\n        <th>Wedding</th>\r\n        <th>Date</th>\r\n        <th>Guests</th>\r\n        <th>Actions</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
      
        foreach (Wedding VARIABLE in ViewBag.Weddings) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
               Write(VARIABLE.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 19 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
                                     Write(VARIABLE.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
               Write(VARIABLE.Date.ToString("MMMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
               Write(VARIABLE.Guests.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
                  
                    if (ViewBag.LoggedInUser.UserId == VARIABLE.UserId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 800, "\"", 834, 2);
            WriteAttributeValue("", 807, "/delete/", 807, 8, true);
#nullable restore
#line 25 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 815, VARIABLE.WeddingId, 815, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                            <a class=\"btn btn-success\">View</a>\r\n\r\n                        </td>\r\n");
#nullable restore
#line 29 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
                    } else {
                        if (VARIABLE.Guests.Any(f => f.UserId == ViewBag.LoggedInUser.UserId)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1165, "\"", 1228, 4);
            WriteAttributeValue("", 1172, "/unrsvp/", 1172, 8, true);
#nullable restore
#line 32 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1180, VARIABLE.WeddingId, 1180, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1199, "/", 1199, 1, true);
#nullable restore
#line 32 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1200, ViewBag.LoggedInUser.UserId, 1200, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Un-RSVP</a>\r\n                                <a class=\"btn btn-success\">View</a>\r\n                            </td>\r\n");
#nullable restore
#line 35 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
                        }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a class=\"btn btn-success\">View</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1566, "\"", 1627, 4);
            WriteAttributeValue("", 1573, "/rsvp/", 1573, 6, true);
#nullable restore
#line 39 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1579, VARIABLE.WeddingId, 1579, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1598, "/", 1598, 1, true);
#nullable restore
#line 39 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1599, ViewBag.LoggedInUser.UserId, 1599, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">RSVP</a>\r\n                            </td>\r\n");
#nullable restore
#line 41 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\aklus\CDProjects\4. C#\Core\12.Wedding Planner\Wedding Planner\webapp\Views\Home\Dashboard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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

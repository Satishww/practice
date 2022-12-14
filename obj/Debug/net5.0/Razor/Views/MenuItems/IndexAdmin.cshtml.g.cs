#pragma checksum "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da20edd6950409de9423fa5fd29e748798121cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuItems_IndexAdmin), @"mvc.1.0.view", @"/Views/MenuItems/IndexAdmin.cshtml")]
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
#line 1 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\_ViewImports.cshtml"
using TruYumCaseStudyMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\_ViewImports.cshtml"
using TruYumCaseStudyMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da20edd6950409de9423fa5fd29e748798121cc", @"/Views/MenuItems/IndexAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb1f26d78375c482443838a1f54f08965f4776f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MenuItems_IndexAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TruYumCaseStudyMVC.Models.MenuItem>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   ViewBag.Title = "Menu Items - TruYum";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Menu Items</h1>\n<hr />\n<p class=\"h4\">");
#nullable restore
#line 7 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
         Write(Html.ActionLink("Create New", "Create", "MenuItems"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
<table class=""table table-striped table-hover"">
    <thead>
        <tr class=""success"">
            <th>Name</th>
            <th>Price</th>
            <th>Active</th>
            <th>Date of Launch</th>
            <th>Name</th>
            <th>Free Delivery</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
         foreach (var menuItem in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 24 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(menuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 25 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(menuItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 26 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(Html.DisplayFor(m => menuItem.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 27 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(Html.DisplayFor(m => menuItem.DateOfLaunch));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 28 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(menuItem.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 29 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(Html.DisplayFor(m => menuItem.FreeDelivery));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
   Write(Html.ActionLink("Edit", "Edit", "MenuItems", new { id = menuItem.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n</tr>\n");
#nullable restore
#line 32 "C:\Users\hp\Documents\TruYumCaseStudyMVC (1)\TruYumCaseStudyMVC\Views\MenuItems\IndexAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TruYumCaseStudyMVC.Models.MenuItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

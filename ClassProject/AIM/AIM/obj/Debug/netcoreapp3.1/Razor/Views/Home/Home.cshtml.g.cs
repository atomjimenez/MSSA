#pragma checksum "C:\Users\adam\Documents\Adam\MSSA\Project\AIM\AIM\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a66d55f3b849038da1fba3f41bad0a8cbbb95b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "C:\Users\adam\Documents\Adam\MSSA\Project\AIM\AIM\Views\_ViewImports.cshtml"
using AIM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adam\Documents\Adam\MSSA\Project\AIM\AIM\Views\_ViewImports.cshtml"
using AIM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a66d55f3b849038da1fba3f41bad0a8cbbb95b4", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d20e5ac9306c9e94fcf18121c4bd9348e958562", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adam\Documents\Adam\MSSA\Project\AIM\AIM\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-3 mt-5"">Ammunition and Inventory Manager</h1>
</div>

<div class=""row justify-content-center"">
    <div class=""col-sm-3 mt-5 goto-box"">
        <h1 class=""mt-2 fon"">Options</h1>
        <hr />
        <button type=""button"" class=""btn btn-secondary font-resize"">New 5515</button>
        <hr />
        <button type=""button"" class=""btn btn-secondary font-resize"">Update 5515</button>
        <hr />
        <button type=""button"" class=""btn btn-secondary font-resize"">New 3020</button>
        <hr />
        <button type=""button"" class=""btn btn-secondary font-resize"">Update 3020</button>
        <hr />
        <button type=""button"" class=""btn btn-secondary font-resize"">Inventory Overview</button>
    </div>

    <div class=""mt-5 jumbotron"">
        <h1 class=""display-4"">Upcoming Events:</h1>
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

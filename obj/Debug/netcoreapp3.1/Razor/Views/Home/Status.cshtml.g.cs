#pragma checksum "C:\Users\2085836\Downloads\Member Portal\Views\Home\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66742a68ab37ea02ecd3a00514cfd4c93c85d195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Status), @"mvc.1.0.view", @"/Views/Home/Status.cshtml")]
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
#line 1 "C:\Users\2085836\Downloads\Member Portal\Views\_ViewImports.cshtml"
using MemberPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\2085836\Downloads\Member Portal\Views\_ViewImports.cshtml"
using MemberPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66742a68ab37ea02ecd3a00514cfd4c93c85d195", @"/Views/Home/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ea551b655a6512dcae8493cddf45d83a89ef24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Status : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\2085836\Downloads\Member Portal\Views\Home\Status.cshtml"
   ViewData["Title"] = "SaveClaim"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\2085836\Downloads\Member Portal\Views\Home\Status.cshtml"
 if (ViewBag.Status != "")
 {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""vh-100"">
        <div class=""container-fluid h-custom"">
            <div class=""row d-flex justify-content-center align-items-center h-100"">
                <div class=""col-md-9 col-lg-4 col-xl-8"">
                    <br />
                    <img src=""http://www.statusseating.com/wp-content/uploads/Status-Logo.png"" class=""img-fluid"" alt=""status image"">
                </div>

                <h1 style=""text-align:center"">Your current status <font color=""#FFA500""> ");
#nullable restore
#line 13 "C:\Users\2085836\Downloads\Member Portal\Views\Home\Status.cshtml"
                                                                                    Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></h1>\n\n            </div>\n        </div>\n    </section>\n");
#nullable restore
#line 18 "C:\Users\2085836\Downloads\Member Portal\Views\Home\Status.cshtml"
 }

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""vh-100"">
        <div class=""container-fluid h-custom"">
            <div class=""row d-flex justify-content-center align-items-center h-100"">
                <div class=""col-md-9 col-lg-4 col-xl-8"">
                    <br />
                    <img src=""https://www.quickanddirtytips.com/sites/default/files/styles/article_3_columns_two_third/public/images/2912/oops-image.jpg?itok=C30nPLom"" class=""img-fluid"" alt=""error image"">
                </div>

                <h1 style=""color:red;text-align:center"">Input data is not valid</h1>

            </div>
        </div>
    </section>
");
#nullable restore
#line 35 "C:\Users\2085836\Downloads\Member Portal\Views\Home\Status.cshtml"
}

#line default
#line hidden
#nullable disable
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

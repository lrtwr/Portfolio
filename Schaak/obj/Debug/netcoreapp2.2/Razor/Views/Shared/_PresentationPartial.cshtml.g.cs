#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\Views\Shared\_PresentationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f3a841c0ce148bafdf8d00fe6db8ac7e7e6f94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Schaak.Pages.Views.Shared.Views_Shared__PresentationPartial), @"mvc.1.0.view", @"/Views/Shared/_PresentationPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PresentationPartial.cshtml", typeof(Schaak.Pages.Views.Shared.Views_Shared__PresentationPartial))]
namespace Schaak.Pages.Views.Shared
{
    #line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using Schaak.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using Schaak;

#line default
#line hidden
#line 4 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using IdentityData;

#line default
#line hidden
#line 5 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#line 6 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using System;

#line default
#line hidden
#line 7 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 8 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 9 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using SchaakData;

#line default
#line hidden
#line 1 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\Views\Shared\_PresentationPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f3a841c0ce148bafdf8d00fe6db8ac7e7e6f94", @"/Views/Shared/_PresentationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942390016f6f2b47498b40a16439dab255c748ea", @"/_ViewImports.cshtml")]
    public class Views_Shared__PresentationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 540, true);
            WriteLiteral(@"<nav id=""navbar-example2"" class=""navbar navbar-light"">
    <ul class=""nav"">
        <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle text-light"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Presentation</a>
            <div class=""dropdown-menu"">
                <a class=""dropdown-item"" href=""/Home/Cookie"">Cookie</a>
                <a class=""dropdown-item"" href=""/Home/Email"">Email</a>
                <div role=""separator"" class=""dropdown-divider""></div>
");
            EndContext();
#line 11 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\Views\Shared\_PresentationPartial.cshtml"
                 if (SignInManager.IsSignedIn(User) && User.IsInRole("Administrators"))
                {

#line default
#line hidden
            BeginContext(740, 425, true);
            WriteLiteral(@"                    <a class=""text-dark"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;User Management</a>
                    <div role=""separator"" class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""/applicationusers"">Users</a>
                    <a class=""dropdown-item"" href=""/applicationroles"">Roles</a>
                    <a class=""dropdown-item"" href=""/applicationuserroles"">Role Membertship</a>
");
            EndContext();
#line 18 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\Views\Shared\_PresentationPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1184, 1518, true);
            WriteLiteral(@"
                <div role=""separator"" class=""dropdown-divider""></div>
                <a class=""text-dark"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Application</a>
                <div role=""separator"" class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""/Admin/Tournements"">Tournement Registration</a>
                <a class=""dropdown-item"" href=""/Admin/Contestents"">Contestent Registration</a>
                <div role=""separator"" class=""dropdown-divider""></div>
                <a class=""text-dark"">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Javascript</a>
                <a class=""dropdown-item"" href=""/iframe?iframeurl=/JQueryMenu/Index.html"">JQuery Menu generated HTML</a>
                <a class=""dropdown-item"" href=""/iframe?iframeurl=/JQuery/3SchoolStart.html"">JQuery Events met CSS</a>
                <a class=""dropdown-item"" href=""/iframe?iframeurl=/Bootstrap1/Index.html"">Iframe Bootstrap with JQuery</a>
                <a class=""dropdown-item"" href=""/modal?modalurl=/JQuery/3SchoolStart.htm");
            WriteLiteral(@"l"">Modal JQuery Events met CSS</a>
                <a class=""dropdown-item"" href=""/modal?modalurl=/Bootstrap1/Index.html"">Modal Bootstrap with JQuery</a>
                <a class=""dropdown-item"" href=""javascript:loadInModal('/JQuery/3SchoolStart.html');"">Load in Modal JQuery Events met CSS</a>
                <a class=""dropdown-item"" href=""javascript:loadInModal('/Bootstrap1/Index.html');"">Load in Modal  Bootstrap with JQuery</a>
            </div>
        </li>
    </ul>
</nav>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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

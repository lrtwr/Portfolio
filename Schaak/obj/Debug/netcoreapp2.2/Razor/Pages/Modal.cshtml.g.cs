#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\Pages\Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e51a69d9fe8e07e6a5364d35dd522f41c4ec524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Schaak.Pages.Pages.Pages_Modal), @"mvc.1.0.razor-page", @"/Pages/Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Modal.cshtml", typeof(Schaak.Pages.Pages.Pages_Modal), null)]
namespace Schaak.Pages.Pages
{
    #line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jeroe\source\repos\core\Portfolio\Schaak\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e51a69d9fe8e07e6a5364d35dd522f41c4ec524", @"/Pages/Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942390016f6f2b47498b40a16439dab255c748ea", @"/_ViewImports.cshtml")]
    public class Pages_Modal : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 123, true);
            WriteLiteral("<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#FrameModal\">\r\n    Open modal\r\n</button>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Schaak.Views.Home.ModalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Schaak.Views.Home.ModalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Schaak.Views.Home.ModalModel>)PageContext?.ViewData;
        public Schaak.Views.Home.ModalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
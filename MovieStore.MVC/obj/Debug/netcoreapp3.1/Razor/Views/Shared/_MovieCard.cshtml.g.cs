#pragma checksum "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\Shared\_MovieCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083f1327288e47fd6db1d4e83363c918dffb60ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MovieCard), @"mvc.1.0.view", @"/Views/Shared/_MovieCard.cshtml")]
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
#line 1 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083f1327288e47fd6db1d4e83363c918dffb60ac", @"/Views/Shared/_MovieCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa387f5e615eecbf69936df9de009cac81cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MovieCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieStore.Core.Entities.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\" col-6 cl-lg-3 col-sm-4 col-xl-2 \">\r\n        \r\n        <a");
            BeginWriteAttribute("href", " href=\"", 112, "\"", 171, 3);
            WriteAttributeValue("", 119, "http://localhost:63474/movies/detail?Id=", 119, 40, true);
            WriteAttributeValue(" ", 159, "+", 160, 2, true);
#nullable restore
#line 4 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\Shared\_MovieCard.cshtml"
WriteAttributeValue(" ", 161, Model.Id, 162, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 191, "\"", 213, 1);
#nullable restore
#line 5 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\Shared\_MovieCard.cshtml"
WriteAttributeValue("", 197, Model.PosterUrl, 197, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 232, "\"", 250, 1);
#nullable restore
#line 5 "C:\Users\yichen wang\Desktop\code\project\MovieStore\MovieStore.MVC\Views\Shared\_MovieCard.cshtml"
WriteAttributeValue("", 238, Model.Title, 238, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </a>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieStore.Core.Entities.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
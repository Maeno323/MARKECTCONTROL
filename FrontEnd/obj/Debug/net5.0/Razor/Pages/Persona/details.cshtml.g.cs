#pragma checksum "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24c4ee8360600c6c90719705081a28995fde9b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Persona.Pages_Persona_details), @"mvc.1.0.razor-page", @"/Pages/Persona/details.cshtml")]
namespace FrontEnd.Pages.Persona
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
#line 1 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24c4ee8360600c6c90719705081a28995fde9b0", @"/Pages/Persona/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persona_details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\details.cshtml"
  
    ViewData["Title"]="Detalles de las personas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"text-align:center\">DETALLES DE LA PERSONA SELECCIONADA</h1>\r\n<br>\r\n<div class=\"row\">\r\n  <div class=\"col-md-4\">\r\n    <div class=\"container\">\r\n      <table class=\"table table-striped table-bordered\">\r\n        <tr>\r\n          <th>");
#nullable restore
#line 13 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\details.cshtml"
         Write(Html.DisplayNameFor(model => Model.Personas.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n          <th>");
#nullable restore
#line 14 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\details.cshtml"
         Write(Html.DisplayNameFor(model => Model.Personas.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    \r\n        <tr>\r\n          <td>");
#nullable restore
#line 18 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\details.cshtml"
         Write(Html.DisplayFor(model => Model.Personas.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 19 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Persona\details.cshtml"
         Write(Html.DisplayFor(model => Model.Personas.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n   \r\n  \r\n      </table>\r\n    </div>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.detailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.detailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.detailsModel>)PageContext?.ViewData;
        public MyApp.Namespace.detailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

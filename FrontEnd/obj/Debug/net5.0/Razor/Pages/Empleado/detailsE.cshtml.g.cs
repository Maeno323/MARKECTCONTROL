#pragma checksum "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\detailsE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b21d47799c0943754e69320c2c0e81c0e9fc8ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Empleado.Pages_Empleado_detailsE), @"mvc.1.0.razor-page", @"/Pages/Empleado/detailsE.cshtml")]
namespace FrontEnd.Pages.Empleado
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b21d47799c0943754e69320c2c0e81c0e9fc8ec", @"/Pages/Empleado/detailsE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleado_detailsE : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\detailsE.cshtml"
  
    ViewData["Title"]="Detalles de los Empleados";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>DETALLES DE LOS EMPLEADOS</h1>\r\n<br>\r\n<div class=\"container\">\r\n  <table class=\"table table-striped table-bordered\">\r\n    <tr>\r\n      <th>ID</th>\r\n      <th>NOMBRE</th>\r\n      \r\n\r\n    </tr>\r\n");
#nullable restore
#line 16 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\detailsE.cshtml"
     foreach(var empleado in Model.Empleados){ 

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>");
#nullable restore
#line 18 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\detailsE.cshtml"
       Write(empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\detailsE.cshtml"
       Write(empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 21 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\detailsE.cshtml"
   
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.detailsEModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.detailsEModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.detailsEModel>)PageContext?.ViewData;
        public MyApp.Namespace.detailsEModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

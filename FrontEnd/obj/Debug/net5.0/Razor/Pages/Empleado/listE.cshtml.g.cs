#pragma checksum "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9d2c694fb9ede303a96fa2b61cc467389a6041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Empleado.Pages_Empleado_listE), @"mvc.1.0.razor-page", @"/Pages/Empleado/listE.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9d2c694fb9ede303a96fa2b61cc467389a6041", @"/Pages/Empleado/listE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleado_listE : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
  <table class=""table table-striped table-bordered"">
    <tr>
      <th>ID</th>
      <th>NOMBRE</th>
      <th>CORREO</th>
      <th>DOCUMENTO ID</th>
      <th>SALARIO BRUTO</th>
      <th>FECHA DE NACIMIENTO</th>
      <th>DETALLES</th>
    </tr>
");
#nullable restore
#line 17 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
     foreach(var empleado in Model.Empleados){ 

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>");
#nullable restore
#line 19 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.DocumentoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.SalarioBruto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.FechaDeNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
       Write(empleado.FechaDeNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee9d2c694fb9ede303a96fa2b61cc467389a60416402", async() => {
                WriteLiteral("<i class=\"far fa-address-book\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ip", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
                                                            WriteLiteral(empleado.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ip"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ip", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ip"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n      </tr>\r\n");
#nullable restore
#line 30 "D:\Downloads\CURSO DE PROGRAMDORES\Curso de programación C #\PROYECTO DE CICLO 3\MarketControl\FrontEnd\Pages\Empleado\listE.cshtml"
   
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.listEModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listEModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.listEModel>)PageContext?.ViewData;
        public MyApp.Namespace.listEModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
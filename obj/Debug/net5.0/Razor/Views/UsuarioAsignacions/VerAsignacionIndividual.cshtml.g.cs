#pragma checksum "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d3c1809882cad601d276284a7bd266faae9b4f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsuarioAsignacions_VerAsignacionIndividual), @"mvc.1.0.view", @"/Views/UsuarioAsignacions/VerAsignacionIndividual.cshtml")]
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
#line 1 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\_ViewImports.cshtml"
using InventarioTI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\_ViewImports.cshtml"
using InventarioTI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
using InventarioTI.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
using InventarioTI.Models.EXT_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
using InventarioTI.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3c1809882cad601d276284a7bd266faae9b4f4", @"/Views/UsuarioAsignacions/VerAsignacionIndividual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UsuarioAsignacions_VerAsignacionIndividual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioTI.Models.UsuarioAsignacion>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvHisAsignacionEquipoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
  
    ViewData["Title"] = "VerAsignacionIndividual";
    CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();
    RH00_Usuarios usuarios = new RH00_Usuarios();

    string json = await conn.GetQueryResult("SELECT * FROM RH00 WHERE IdEmpleado = " + Model.idEmpleado);

    try
    {
        usuarios = JsonConvert.DeserializeObject<List<RH00_Usuarios>>(json).FirstOrDefault();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ver Asignaci??n de ");
#nullable restore
#line 24 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                 Write(usuarios.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                                   Write(usuarios.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d3c1809882cad601d276284a7bd266faae9b4f46268", async() => {
                WriteLiteral("Regresar a la asignaci??n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                                                                    WriteLiteral(Model.idAsignacion);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 30 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
       Write(Html.DisplayNameFor(model => model.fechaInicioAsignacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            <a>");
#nullable restore
#line 34 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
          Write(Model.fechaInicioAsignacion.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </dd>\r\n");
#nullable restore
#line 36 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
          
            if (Model.fechaFinAsignacion == DateTime.Parse("1/1/0001 12:00:00 AM"))
            {

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
               Write(Html.DisplayNameFor(model => model.fechaFinAsignacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    <a>");
#nullable restore
#line 47 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                  Write(Model.fechaFinAsignacion.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </dd>\r\n");
#nullable restore
#line 49 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 52 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
       Write(Html.DisplayNameFor(model => model.asignado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 55 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
              
                if (Model.asignado == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"color:darkcyan\">A??n no finaliza la asignaci??n</a>\r\n");
#nullable restore
#line 59 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"color:darkred\">La asignaci??n ha finalizado</a>\r\n");
#nullable restore
#line 63 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 67 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
       Write(Html.DisplayNameFor(model => model.idEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
       Write(Html.DisplayFor(model => model.idEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<h4>Datos de Contacto</h4>\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-4\">\r\n        <a>Correo empresa</a>\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 81 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
          
            if (usuarios.CorreoEmpresa == null || usuarios.CorreoEmpresa == "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>Sin correo empresarial registrado</a>\r\n");
#nullable restore
#line 85 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 2744, "\"", 2839, 3);
            WriteAttributeValue("", 2751, "mailto:", 2751, 7, true);
#nullable restore
#line 88 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
WriteAttributeValue("", 2758, usuarios.CorreoEmpresa, 2758, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2781, "?Subject=Hola%20,quiero%20tratar%20el%20siguiente%20asunto", 2781, 58, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
                                                                                                              Write(usuarios.CorreoEmpresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 89 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dd>\r\n    <dt class=\"col-sm-4\">\r\n        <a>N??mero Telef??nico</a>\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 96 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
         if (usuarios.TelefonoPersonal != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a>");
#nullable restore
#line 98 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
          Write(usuarios.TelefonoPersonal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 99 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a>Sin n??mero telefonico registrado</a>\r\n");
#nullable restore
#line 103 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\UsuarioAsignacions\VerAsignacionIndividual.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dd>\r\n</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventarioTI.Models.UsuarioAsignacion> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

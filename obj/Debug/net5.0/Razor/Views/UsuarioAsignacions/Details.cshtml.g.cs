#pragma checksum "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e8f63ea17ff0fee39e516fa64ac17e026480bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsuarioAsignacions_Details), @"mvc.1.0.view", @"/Views/UsuarioAsignacions/Details.cshtml")]
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
#line 1 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\_ViewImports.cshtml"
using InventarioTI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\_ViewImports.cshtml"
using InventarioTI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
using InventarioTI.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
using InventarioTI.Models.EXT_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
using InventarioTI.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e8f63ea17ff0fee39e516fa64ac17e026480bc", @"/Views/UsuarioAsignacions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UsuarioAsignacions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioTI.Models.UsuarioAsignacion>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvHisAsignacionEquipoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinalizarAsignacionIndividual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
  
    ViewData["Title"] = "Details";
    InventarioContext context = new InventarioContext();
    CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();

    RH00_Usuarios usuario = new RH00_Usuarios();
    string json = await conn.GetQueryResult("SELECT * FROM RH00 WHERE IdEmpleado = "+Model.IdEmpleado);

    try
    {
        usuario = JsonConvert.DeserializeObject<List<RH00_Usuarios>>(json).FirstOrDefault();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Usuario: ");
#nullable restore
#line 25 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
        Write(usuario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
                         Write(usuario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8f63ea17ff0fee39e516fa64ac17e026480bc7108", async() => {
                WriteLiteral("Regresar a la asignación");
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
#line 28 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
                                                                        WriteLiteral(Model.IdAsignacion);

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
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
      
        bool isActive;
        isActive = context.InvHisAsignacionEquipos.Where(a => a.Id == Model.IdAsignacion).Select(a => a.Activo).FirstOrDefault();

        if (isActive == true)
        {
            List<int> ususariosIds = new List<int>();
            ususariosIds = context.UsuarioAsignacion.Where(ua => ua.IdAsignacion == Model.IdAsignacion && ua.Asignado == true).Select(ua => ua.IdEmpleado).ToList();
            if (ususariosIds != null && ususariosIds.Count > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e8f63ea17ff0fee39e516fa64ac17e026480bc10331", async() => {
                WriteLiteral("\r\n                        <input hidden name=\"idUsuario\"");
                BeginWriteAttribute("value", " value=\"", 1570, "\"", 1597, 1);
#nullable restore
#line 40 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
WriteAttributeValue("", 1578, usuario.IdEmpleado, 1578, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input hidden name=\"idAsignacion\"");
                BeginWriteAttribute("value", " value=\"", 1660, "\"", 1687, 1);
#nullable restore
#line 41 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
WriteAttributeValue("", 1668, Model.IdAsignacion, 1668, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button class=\"btn btn-danger\" type=\"submit\">Descartar Usuario</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n<div>\r\n    <h4>Datos de Asignación</h4>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 53 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdAsignacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdAsignacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 59 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicioAsignacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <a>");
#nullable restore
#line 62 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
          Write(Model.FechaInicioAsignacion.ToString("dddd dd / MMMM / yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 65 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFinAsignacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 68 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
             if (Model.FechaFinAsignacion == Convert.ToDateTime("01/01/0001 12:00:00 a. m."))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a style=\"color:darkcyan\">Aún no finaliza la asignación</a>\r\n");
#nullable restore
#line 71 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>");
#nullable restore
#line 74 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
              Write(Model.FechaFinAsignacion.ToString("dddd dd / MMMM / yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 75 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 78 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asignado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asignado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <hr />\r\n    <h4>Datos de Contacto</h4>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            <a>Correo empresa</a>\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 91 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
              
                if (usuario.CorreoEmpresa == null || usuario.CorreoEmpresa == "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a>Sin correo empresarial registrado</a>\r\n");
#nullable restore
#line 95 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3549, "\"", 3643, 3);
            WriteAttributeValue("", 3556, "mailto:", 3556, 7, true);
#nullable restore
#line 98 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
WriteAttributeValue("", 3563, usuario.CorreoEmpresa, 3563, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3585, "?Subject=Hola%20,quiero%20tratar%20el%20siguiente%20asunto", 3585, 58, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
                                                                                                                 Write(usuario.CorreoEmpresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 99 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            <a>Número Telefónico</a>\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 106 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
             if (usuario.TelefonoPersonal != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>");
#nullable restore
#line 108 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
              Write(usuario.TelefonoPersonal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 109 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>Sin número telefonico registrado</a>\r\n");
#nullable restore
#line 113 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\UsuarioAsignacions\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n");
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

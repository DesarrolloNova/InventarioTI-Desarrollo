#pragma checksum "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2940fb5b83b81029314e2e9d1fc9bdcc127084af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvHisAsignacionEquipoes_Details), @"mvc.1.0.view", @"/Views/InvHisAsignacionEquipoes/Details.cshtml")]
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
#line 1 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
using InventarioTI.Context;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2940fb5b83b81029314e2e9d1fc9bdcc127084af", @"/Views/InvHisAsignacionEquipoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_InvHisAsignacionEquipoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioTI.Models.InvHisAsignacionEquipo>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvTabEquipoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TabUsuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
  
    ViewData["Title"] = "Details";
    InventarioContext context = new InventarioContext();
    InvTabEquipo equipo = new InvTabEquipo();
    equipo = context.InvTabEquipos.Where(e => e.Id == Model.IdEquipo).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Asignación de ");
#nullable restore
#line 10 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
             Write(equipo.NombreEquipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2940fb5b83b81029314e2e9d1fc9bdcc127084af6912", async() => {
                WriteLiteral("Ir al Equipo");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                                                              WriteLiteral(equipo.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnDominio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnDominio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoConexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoConexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdDepartamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 52 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
              
                CatDepartamento departamento = new CatDepartamento();
                departamento = context.CatDepartamentos.Where(d => d.Id == Model.IdDepartamento).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>");
#nullable restore
#line 55 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
              Write(departamento.Departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 55 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                                          Write(departamento.Abreviacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n");
            WriteLiteral("        </dd>\r\n        <dt class=\"col-m-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
#nullable restore
#line 66 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
  
    List<int> idUsuarios = new List<int>();
    List<TabUsuario> usuarios = new List<TabUsuario>();

    idUsuarios = context.UsuarioAsignacion.Where(u => u.IdAsignacion == Model.Id && u.Asignado == true).Select(u => u.IdUsuario).ToList();
    foreach (var idusuario in idUsuarios)
    {
        TabUsuario usuario = new TabUsuario();
        usuario = context.TabUsuarios.Where(u => u.Id == idusuario).FirstOrDefault();
        usuarios.Add(usuario);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <h4>Usuarios Asignados</h4>
    <br />
    <br />
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    <a>Id</a>
                </th>
                <th>
                    <a>Nombre</a>
                </th>
                <th>
                    <a>Correo</a>
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 99 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
             foreach (var item in usuarios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a>");
#nullable restore
#line 106 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                      Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 106 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                                   Write(item.ApellidoPaterno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 106 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                                                         Write(item.ApellidoMaterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2940fb5b83b81029314e2e9d1fc9bdcc127084af18738", async() => {
                WriteLiteral("Ver Usuario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                                                                                                       WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2940fb5b83b81029314e2e9d1fc9bdcc127084af21320", async() => {
                WriteLiteral("Finalizar Asignación");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                                                                        WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 116 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2940fb5b83b81029314e2e9d1fc9bdcc127084af24020", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2940fb5b83b81029314e2e9d1fc9bdcc127084af26213", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventarioTI.Models.InvHisAsignacionEquipo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

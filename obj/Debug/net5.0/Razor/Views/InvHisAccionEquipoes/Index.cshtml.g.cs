#pragma checksum "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72fb39faeed876bac12f7f3708ede954fadd6995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvHisAccionEquipoes_Index), @"mvc.1.0.view", @"/Views/InvHisAccionEquipoes/Index.cshtml")]
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
#line 1 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
using InventarioTI.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
using InventarioTI.Models.EXT_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
using InventarioTI.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72fb39faeed876bac12f7f3708ede954fadd6995", @"/Views/InvHisAccionEquipoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_InvHisAccionEquipoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventarioTI.Models.InvHisAccionEquipo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvTabEquipoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    InventarioContext context = new InventarioContext();
    CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Acciones del equipo: ");
#nullable restore
#line 13 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
                    Write(context.InvTabEquipos.Where(e=>e.Id == Model.FirstOrDefault().IdEquipo).Select(e=>e.NombreEquipo).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72fb39faeed876bac12f7f3708ede954fadd69956020", async() => {
                WriteLiteral("Regresar al equipo");
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
#line 14 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
                                                          WriteLiteral(Model.FirstOrDefault().IdEquipo);

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
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoProceso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdUsuarioRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a>");
#nullable restore
#line 38 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
                  Write(item.FechaInicio.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    <a>");
#nullable restore
#line 41 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
                  Write(item.FechaFin.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoProceso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 47 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
                      
                        string usuario = "";
                        List<RHLMA_SuperUsers> SuperUser = new List<RHLMA_SuperUsers>();
                        string json = await conn.GetQueryResult("SELECT * FROM RHLMA WHERE id=" + item.IdUsuarioRegistro.ToString());
                        try
                        {
                            SuperUser = JsonConvert.DeserializeObject<List<RHLMA_SuperUsers>>(json);
                            usuario = SuperUser.FirstOrDefault().Usuario +" ("+ SuperUser.FirstOrDefault().TipoSop+")";
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a>");
#nullable restore
#line 61 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
                  Write(usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72fb39faeed876bac12f7f3708ede954fadd699512919", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\desarrollo\Desktop\Novaprint\PROYECTOS_DESARROLLO\InventarioTI-Desarrollo\Views\InvHisAccionEquipoes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventarioTI.Models.InvHisAccionEquipo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
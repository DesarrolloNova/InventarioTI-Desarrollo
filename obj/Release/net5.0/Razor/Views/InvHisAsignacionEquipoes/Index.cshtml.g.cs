#pragma checksum "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89df1f1baff836ca53470ecf1fe88f89adb592e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvHisAsignacionEquipoes_Index), @"mvc.1.0.view", @"/Views/InvHisAsignacionEquipoes/Index.cshtml")]
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
#line 1 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
using InventarioTI.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
using InventarioTI.Models.EXT_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
using InventarioTI.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89df1f1baff836ca53470ecf1fe88f89adb592e7", @"/Views/InvHisAsignacionEquipoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_InvHisAsignacionEquipoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventarioTI.Models.InvHisAsignacionEquipo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvTabEquipoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    InventarioContext context = new InventarioContext();
    CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Historial de asignaciones</h1>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89df1f1baff836ca53470ecf1fe88f89adb592e75619", async() => {
                WriteLiteral("Regresar al Equipo");
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
#line 15 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                                                          WriteLiteral(Model.Select(e=>e.IdEquipo).FirstOrDefault());

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
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnDominio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoConexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDSitio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID_Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
            WriteLiteral("                    <a>");
#nullable restore
#line 47 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                  Write(item.FechaInicio.ToString("dd/MMMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <a>");
#nullable restore
#line 51 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                  Write(item.FechaFin.Value.ToString("dd/MMMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EnDominio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoConexion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 60 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                      
                        RHCF10_Plantas planta = new RHCF10_Plantas();
                        string jsonPlanta = await conn.GetQueryResult("SELECT * FROM RHCF10 WHERE IDSitio = " + item.IDSitio.ToString());

                        try
                        {
                            planta = JsonConvert.DeserializeObject<List<RHCF10_Plantas>>(jsonPlanta).FirstOrDefault();
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
#line 74 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                  Write(planta.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 77 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                      
                        RHCF03_Areas departamento = new RHCF03_Areas();
                        string jsonArea = await conn.GetQueryResult("SELECT * FROM RHCF03 WHERE ID_Area = " + item.ID_Area.ToString());

                        try
                        {
                            departamento = JsonConvert.DeserializeObject<List<RHCF03_Areas>>(jsonArea).FirstOrDefault();
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
#line 91 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
                  Write(departamento.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89df1f1baff836ca53470ecf1fe88f89adb592e714668", async() => {
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
#line 94 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
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
#line 97 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionEquipoes\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventarioTI.Models.InvHisAsignacionEquipo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc38bca0d484f6af76aba3157deaf749aba6b45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvHisAsignacionLicencias_Index), @"mvc.1.0.view", @"/Views/InvHisAsignacionLicencias/Index.cshtml")]
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
#line 1 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
using InventarioTI.Models.EXT_WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
using InventarioTI.Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc38bca0d484f6af76aba3157deaf749aba6b45b", @"/Views/InvHisAsignacionLicencias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_InvHisAsignacionLicencias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventarioTI.Models.InvHisAsignacionLicencia>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Licencias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/resources/paloma.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Width", new global::Microsoft.AspNetCore.Html.HtmlString("30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Visible", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ImageAlign", new global::Microsoft.AspNetCore.Html.HtmlString("Right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/resources/tache.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Historial de Asignaciones</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc38bca0d484f6af76aba3157deaf749aba6b45b7295", async() => {
                WriteLiteral("Regresar a la licencia");
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
#line 13 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                                                     WriteLiteral(Model.First().IdLicencia);

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
#line 19 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDSitio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID_Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
            WriteLiteral("                    <a>");
#nullable restore
#line 42 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                  Write(item.FechaInicio.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 46 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                      
                        if (item.Activo == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"color:blue;\">Aún no finaliza la asigación</a>\r\n");
#nullable restore
#line 50 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a>");
#nullable restore
#line 53 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                              Write(item.FechaFin.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 54 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 59 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                      
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
#line 73 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                  Write(planta.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 77 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                      
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
#line 91 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                  Write(departamento.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 94 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                      
                        if (item.Activo == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc38bca0d484f6af76aba3157deaf749aba6b45b16572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc38bca0d484f6af76aba3157deaf749aba6b45b18198", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc38bca0d484f6af76aba3157deaf749aba6b45b19827", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
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
#line 109 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\InvHisAsignacionLicencias\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventarioTI.Models.InvHisAsignacionLicencia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
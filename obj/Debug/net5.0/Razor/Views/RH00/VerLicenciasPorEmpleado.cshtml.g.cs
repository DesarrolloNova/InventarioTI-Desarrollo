#pragma checksum "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133618eb9a3ae5d2f0040b721958e3c2f1a818f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RH00_VerLicenciasPorEmpleado), @"mvc.1.0.view", @"/Views/RH00/VerLicenciasPorEmpleado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133618eb9a3ae5d2f0040b721958e3c2f1a818f7", @"/Views/RH00/VerLicenciasPorEmpleado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164f6d6a541f799c7a7bc06c3d8b512f0a072449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RH00_VerLicenciasPorEmpleado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventarioTI.Models.Licencias>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Licencias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
  
    ViewData["Title"] = "VerLicenciasPorEmpleado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ver Licencias Por Empleado</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
  
    if (Model.ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                   Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133618eb9a3ae5d2f0040b721958e3c2f1a818f78606", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 54 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
    }
    else
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a>No se encontraron registros</a>\r\n");
#nullable restore
#line 58 "C:\Users\desarrollo\Documents\NOVA\INVENTARIO_TI\InventarioTI-Desarrollo\Views\RH00\VerLicenciasPorEmpleado.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventarioTI.Models.Licencias>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

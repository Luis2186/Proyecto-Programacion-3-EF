#pragma checksum "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b88184314e9bfb3d21c137662820163dfa27cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_PlantasPorMayorAltura), @"mvc.1.0.view", @"/Views/Planta/PlantasPorMayorAltura.cshtml")]
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
#line 1 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\_ViewImports.cshtml"
using WebObligatoriop3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\_ViewImports.cshtml"
using WebObligatoriop3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b88184314e9bfb3d21c137662820163dfa27cd", @"/Views/Planta/PlantasPorMayorAltura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147efde788029b96d996e8ef8ca41739e3604884", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_PlantasPorMayorAltura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebObligatoriop3.Models.ViewModelPlanta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
  
    ViewData["Title"] = "ListaDePlantas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Busqueda por altura mayor o igual</h1>\r\n<br>\r\n<br>\r\n<div class=\"row mt-3\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b88184314e9bfb3d21c137662820163dfa27cd5328", async() => {
                WriteLiteral(@"

            <div class=""form-group mt-3"">
                <label class=""control-label font-weight-bold""> Ingrese la altura</label>
                <input type=""number"" name=""altura"" class=""form-control"">
            </div>
            <div class=""form-group mt-3"">
                <input type=""submit"" value=""Buscar"" class=""btn btn-dark"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
 if (Model.Plantas != null && Model.Plantas.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table mt-4"">
        <thead>
            <tr>
                <th>
                    Tipo de Planta
                </th>
                <th>
                    Nombre Cientifico
                </th>
                <th>
                    Descripcion
                </th>
                <th>
                    Nombres Vulgares
                </th>
                <th>
                    Ambiente
                </th>
                <th>
                    Altura Maxima
                </th>
                <th>
                    Foto
                </th>
                <th>
                    Ficha de Cuidados
                </th>
                <th>
                    Precio
                </th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 61 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
             foreach (var item in Model.Plantas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(item.NombreCientifico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <ul>\r\n");
#nullable restore
#line 75 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                             foreach (var nV in @item.NombresVulgares)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 77 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                               Write(nV.NomVulgar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 78 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(item.Ambiente);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(item.AlturaMaxima);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30b88184314e9bfb3d21c137662820163dfa27cd12496", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2483, "~/Imagenes/", 2483, 11, true);
#nullable restore
#line 88 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
AddHtmlAttributeValue("", 2494, item.Foto, 2494, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2599, "\"", 2655, 2);
            WriteAttributeValue("", 2606, "/FichaDeCuidados/Details/", 2606, 25, true);
#nullable restore
#line 91 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
WriteAttributeValue("", 2631, item.FichaDeCuidados.Id, 2631, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-card-list ml-2"" viewBox=""0 0 16 16"">
                                <path d=""M14.5 3a.5.5 0 0 1 .5.5v9a.5.5 0 0 1-.5.5h-13a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5h13zm-13-1A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h13a1.5 1.5 0 0 0 1.5-1.5v-9A1.5 1.5 0 0 0 14.5 2h-13z"" />
                                <path d=""M5 8a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7A.5.5 0 0 1 5 8zm0-2.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm0 5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zm-1-5a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0zM4 8a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0zm0 2.5a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0z"" />
                            </svg>
                        </a>
                    </td>
                    <td>
                        ");
#nullable restore
#line 99 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 103 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 106 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<br>\r\n<a href=\"/Planta/ControlarVistas\"> Volver </a>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

    function openSuccesModal(mensajeError) {
        document.getElementById('mensajeModalError').innerHTML = mensajeError;
        $('#myModalError').modal('show');
        }

    $(document).ready(function () {
        var msgError = """);
#nullable restore
#line 121 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\PlantasPorMayorAltura.cshtml"
                   Write(TempData["MensajeError"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        if (msgError)\r\n            openSuccesModal(msgError);\r\n    });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebObligatoriop3.Models.ViewModelPlanta> Html { get; private set; }
    }
}
#pragma warning restore 1591

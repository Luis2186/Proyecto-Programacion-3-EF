#pragma checksum "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a3654b819998dc1e8a0267db393eb1048ea0117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_Details), @"mvc.1.0.view", @"/Views/Planta/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a3654b819998dc1e8a0267db393eb1048ea0117", @"/Views/Planta/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147efde788029b96d996e8ef8ca41739e3604884", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dominio.EntidadesNegocio.Planta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListaDePlantas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalle Completo </h1>\r\n\r\n<div>\r\n    <h4>Planta</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <ul>\r\n");
#nullable restore
#line 25 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                 foreach (var nV in @Model.NombresVulgares)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 27 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                   Write(nV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tipo de Planta:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Model.Tipo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            Descripcion: ");
#nullable restore
#line 36 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                    Write(Model.Tipo.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayFor(model => model.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm<br><br>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a3654b819998dc1e8a0267db393eb1048ea011711242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1774, "~/Imagenes/", 1774, 11, true);
#nullable restore
#line 60 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
AddHtmlAttributeValue("", 1785, Model.Foto, 1785, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br><br>\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FichaDeCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            Frecuencia de riego: ");
#nullable restore
#line 67 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                            Write(Model.FichaDeCuidados.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                                                            Write(Model.FichaDeCuidados.UnidadDeTiempo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n            Temperatura: ");
#nullable restore
#line 68 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                    Write(Model.FichaDeCuidados.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" °C <br>\r\n            Tipo de Iluminacion: ");
#nullable restore
#line 69 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
                            Write(Model.FichaDeCuidados.TipoDeIluminacion.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "C:\Users\lilp_\Desktop\ORT\Programacion 3\Obligatorio version Final Parte 2\Obli Luis Lopez-278179\Obl P3 EF LQ\Obligatorio P3 278179\Obligatorio P3\WebObligatoriop3\Views\Planta\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a3654b819998dc1e8a0267db393eb1048ea011716031", async() => {
                WriteLiteral("Volver a la lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dominio.EntidadesNegocio.Planta> Html { get; private set; }
    }
}
#pragma warning restore 1591
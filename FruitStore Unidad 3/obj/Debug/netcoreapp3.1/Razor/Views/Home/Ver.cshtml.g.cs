#pragma checksum "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3189f6ac6bc5cf91cfec534c31a65aa6889cef91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ver), @"mvc.1.0.view", @"/Views/Home/Ver.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3189f6ac6bc5cf91cfec534c31a65aa6889cef91", @"/Views/Home/Ver.cshtml")]
    public class Views_Home_Ver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FruitStore_Unidad_3.Models.Productos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imagen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"datosproductos\">\n    <h1 id=\"nombre\">");
#nullable restore
#line 9 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
               Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3189f6ac6bc5cf91cfec534c31a65aa6889cef913484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 159, "~/img_frutas/", 159, 13, true);
#nullable restore
#line 11 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
AddHtmlAttributeValue("", 172, Model.Id, 172, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 183, ".jpg", 183, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <p>\n        <label>Precio:</label>\n        <label id=\"precio\">");
#nullable restore
#line 14 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
                      Write(Model.Precio.Value.ToString("$ 0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n    </p>\n    <p>\n        <label>Categoria:</label>\n        <label id=\"categoria\">");
#nullable restore
#line 18 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
                         Write(Model.IdCategoriaNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n    </p>\n    <p>\n        <label>Unidad de Medida:</label>\n        <label id=\"unidadmedida\">");
#nullable restore
#line 22 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
                            Write(Model.UnidadMedida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n    </p>\n    <p>\n        <label>Descripción:</label>\n        <label id=\"descripcion\">");
#nullable restore
#line 26 "A:\7mo Semestre\Programación Web\FruitStore Unidad 3\FruitStore Unidad 3\Views\Home\Ver.cshtml"
                           Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n    </p>\n\n    <p style=\"text-align:center; margin:20px 0\">\n        <a href=\"javascript:window.history.back()\">Regresar</a>\n    </p>\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FruitStore_Unidad_3.Models.Productos> Html { get; private set; }
    }
}
#pragma warning restore 1591

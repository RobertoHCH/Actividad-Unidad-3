#pragma checksum "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e1d12323983e7db3fbd5abb48f1ac8cb1228db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Clase), @"mvc.1.0.view", @"/Views/Home/Clase.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e1d12323983e7db3fbd5abb48f1ac8cb1228db", @"/Views/Home/Clase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Clase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZooPlanet.Models.Especies>>
    {
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
#nullable restore
#line 2 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
Write(ViewBag.Clase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<ul class=\"especies\">\r\n");
#nullable restore
#line 9 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09e1d12323983e7db3fbd5abb48f1ac8cb1228db3463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 220, "~/especies/", 220, 11, true);
#nullable restore
#line 13 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
AddHtmlAttributeValue("", 231, item.Id, 231, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 241, ".jpg", 241, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <h2>");
#nullable restore
#line 15 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
       Write(item.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n        <p><label>Habitat: </label>");
#nullable restore
#line 16 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
                              Write(item.Habitat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><label>Peso: </label>");
#nullable restore
#line 17 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
                            Write(item.Peso==null?"":item.Peso.Value.ToString("0.00kg"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><label>Tamaño: </label>");
#nullable restore
#line 18 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
                              Write(item.Tamaño==null?"":item.Tamaño.Value.ToString("0cm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 19 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
      Write(item.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </li>\r\n");
#nullable restore
#line 21 "A:\7mo Semestre\Programación Web\ZooPlanet\ZooPlanet\Views\Home\Clase.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZooPlanet.Models.Especies>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e0152d576744e03573ebea39ea1fab3dfa2763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DesvioPadraos_Delete), @"mvc.1.0.view", @"/Views/DesvioPadraos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DesvioPadraos/Delete.cshtml", typeof(AspNetCore.Views_DesvioPadraos_Delete))]
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
#line 1 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\_ViewImports.cshtml"
using CalculoParaAcoes;

#line default
#line hidden
#line 2 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\_ViewImports.cshtml"
using CalculoParaAcoes.Models;

#line default
#line hidden
#line 3 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\_ViewImports.cshtml"
using CalculoParaAcoesMVC.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e0152d576744e03573ebea39ea1fab3dfa2763", @"/Views/DesvioPadraos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be2f9ca392f8c813671237ab4b84b9ca121a387", @"/Views/_ViewImports.cshtml")]
    public class Views_DesvioPadraos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalculoParaAcoes.Models.DesvioPadrao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
  
    ViewData["Title"] = "Excluir";

#line default
#line hidden
            BeginContext(90, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(97, 17, false);
#line 7 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 160, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Voce tem certeza que deseja excluir?</h3>\r\n<div>\r\n    <h4>DesvioPadrao</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(275, 46, false);
#line 15 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(365, 42, false);
#line 18 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(407, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(451, 51, false);
#line 21 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechamentoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(546, 47, false);
#line 24 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechamentoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(637, 50, false);
#line 27 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Abertura1Antes));

#line default
#line hidden
            EndContext();
            BeginContext(687, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(731, 46, false);
#line 30 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Abertura1Antes));

#line default
#line hidden
            EndContext();
            BeginContext(777, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(821, 46, false);
#line 33 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DesvPadrao));

#line default
#line hidden
            EndContext();
            BeginContext(867, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(911, 42, false);
#line 36 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DesvPadrao));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(997, 46, false);
#line 39 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1087, 42, false);
#line 42 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1173, 43, false);
#line 45 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio1));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1260, 39, false);
#line 48 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Desvio1));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1343, 43, false);
#line 51 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio2));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1430, 39, false);
#line 54 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Desvio2));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1513, 44, false);
#line 57 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio1n));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1601, 40, false);
#line 60 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Desvio1n));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1685, 44, false);
#line 63 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio2n));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1773, 40, false);
#line 66 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Desvio2n));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1851, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c00f6dff5c41d289ac652a8c42a02a", async() => {
                BeginContext(1877, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1887, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe7812c51b754e5cb77ef882595800ee", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1923, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Excluir\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2008, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b46101c2be44b5fa9635f7d577cc203", async() => {
                    BeginContext(2030, 19, true);
                    WriteLiteral("Voltar para a lista");
                    EndContext();
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
                EndContext();
                BeginContext(2053, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2066, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalculoParaAcoes.Models.DesvioPadrao> Html { get; private set; }
    }
}
#pragma warning restore 1591

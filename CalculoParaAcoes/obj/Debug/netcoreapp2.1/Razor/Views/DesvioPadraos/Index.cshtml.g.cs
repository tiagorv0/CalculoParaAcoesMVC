#pragma checksum "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d1a16997dfa378720cce1ec02693b56e350dd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DesvioPadraos_Index), @"mvc.1.0.view", @"/Views/DesvioPadraos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DesvioPadraos/Index.cshtml", typeof(AspNetCore.Views_DesvioPadraos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d1a16997dfa378720cce1ec02693b56e350dd4", @"/Views/DesvioPadraos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be2f9ca392f8c813671237ab4b84b9ca121a387", @"/Views/_ViewImports.cshtml")]
    public class Views_DesvioPadraos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesvioPadrao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
            BeginContext(78, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(85, 17, false);
#line 7 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0ccfb76bf6454f856500c9c2552507", async() => {
                BeginContext(167, 12, true);
                WriteLiteral("Novo Cálculo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 180, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\" for=\"UF\">Filtro</label>\r\n        <select class=\"form-control single-select\" name=\"UF\">\r\n            ");
            EndContext();
            BeginContext(363, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a199d4d2d76435bb06186bb05de2a0c", async() => {
                BeginContext(389, 18, true);
                WriteLiteral("[Selecione a ação]");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(475, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(491, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f1061f8db040f59bc920c2147e738a", async() => {
                BeginContext(501, 15, false);
#line 19 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
                    Write(item.NomeDaAcao);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(525, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(542, 121, true);
            WriteLiteral("        </select>\r\n    </div>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(664, 46, false);
#line 28 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(710, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(766, 46, false);
#line 31 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(812, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(868, 51, false);
#line 34 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechamentoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(919, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(975, 50, false);
#line 37 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Abertura1Antes));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1081, 46, false);
#line 40 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DesvPadrao));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1183, 44, false);
#line 43 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Desvio2n));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1283, 44, false);
#line 46 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Desvio1n));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1383, 43, false);
#line 49 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Desvio1));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1482, 43, false);
#line 52 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Desvio2));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1660, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1721, 45, false);
#line 62 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1834, 45, false);
#line 65 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1947, 50, false);
#line 68 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechamentoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2065, 49, false);
#line 71 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Abertura1Antes));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2182, 45, false);
#line 74 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DesvPadrao));

#line default
#line hidden
            EndContext();
            BeginContext(2227, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2295, 43, false);
#line 77 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Desvio2n));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2406, 43, false);
#line 80 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Desvio1n));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2517, 42, false);
#line 83 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Desvio1));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2627, 42, false);
#line 86 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Desvio2));

#line default
#line hidden
            EndContext();
            BeginContext(2669, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2736, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401d052408ce463dbd372df2e6510d96", async() => {
                BeginContext(2781, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2791, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2815, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08841da1e63e468eb96517b42e5d6466", async() => {
                BeginContext(2863, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2875, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2899, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "143938a3f92b46dcb1198b5171361d38", async() => {
                BeginContext(2946, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2957, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 94 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(3014, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DesvioPadrao>> Html { get; private set; }
    }
}
#pragma warning restore 1591

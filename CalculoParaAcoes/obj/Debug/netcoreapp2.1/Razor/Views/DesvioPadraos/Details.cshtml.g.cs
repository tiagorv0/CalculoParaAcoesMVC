#pragma checksum "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6eb71a9497fa07e84a8b333edd28b9d03ae7ca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DesvioPadraos_Details), @"mvc.1.0.view", @"/Views/DesvioPadraos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DesvioPadraos/Details.cshtml", typeof(AspNetCore.Views_DesvioPadraos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6eb71a9497fa07e84a8b333edd28b9d03ae7ca0", @"/Views/DesvioPadraos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eebc2cf94dc4605dbfdca2d70a93d7fd772e019c", @"/Views/_ViewImports.cshtml")]
    public class Views_DesvioPadraos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalculoParaAcoes.Models.DesvioPadrao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DesvioPadrao</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(217, 46, false);
#line 14 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(263, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(307, 42, false);
#line 17 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(393, 51, false);
#line 20 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechamentoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(488, 47, false);
#line 23 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechamentoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(535, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(579, 50, false);
#line 26 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Abertura1Antes));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 46, false);
#line 29 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Abertura1Antes));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 46, false);
#line 32 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DesvPadrao));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 42, false);
#line 35 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DesvPadrao));

#line default
#line hidden
            EndContext();
            BeginContext(895, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(939, 46, false);
#line 38 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(985, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1029, 42, false);
#line 41 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1115, 43, false);
#line 44 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio1));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1202, 39, false);
#line 47 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desvio1));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1285, 43, false);
#line 50 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio2));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1372, 39, false);
#line 53 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desvio2));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1455, 44, false);
#line 56 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio1n));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1543, 40, false);
#line 59 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desvio1n));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1627, 44, false);
#line 62 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desvio2n));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1715, 40, false);
#line 65 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desvio2n));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1802, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a552e65ce05949259052e7175e0d64cc", async() => {
                BeginContext(1848, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\DesvioPadraos\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1856, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1864, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d38411be28843e4bc7a84219eee9ffe", async() => {
                BeginContext(1886, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1902, 10, true);
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
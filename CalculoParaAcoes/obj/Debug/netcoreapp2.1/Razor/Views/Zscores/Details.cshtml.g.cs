#pragma checksum "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9169adf0e1c52b6b1d62012e98036b74bd8acfdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zscores_Details), @"mvc.1.0.view", @"/Views/Zscores/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zscores/Details.cshtml", typeof(AspNetCore.Views_Zscores_Details))]
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
#line 1 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\_ViewImports.cshtml"
using CalculoParaAcoes;

#line default
#line hidden
#line 2 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\_ViewImports.cshtml"
using CalculoParaAcoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9169adf0e1c52b6b1d62012e98036b74bd8acfdc", @"/Views/Zscores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eebc2cf94dc4605dbfdca2d70a93d7fd772e019c", @"/Views/_ViewImports.cshtml")]
    public class Views_Zscores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalculoParaAcoesMVC.Models.ViewModels.ZscoreViewModel>
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(107, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Zscore</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(230, 46, false);
#line 15 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(276, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(320, 42, false);
#line 18 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCriado));

#line default
#line hidden
            EndContext();
            BeginContext(362, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(406, 46, false);
#line 21 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(452, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(496, 42, false);
#line 24 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeDaAcao));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(582, 49, false);
#line 27 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Variacao5Anos));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 45, false);
#line 30 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Variacao5Anos));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(764, 40, false);
#line 33 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dias));

#line default
#line hidden
            EndContext();
            BeginContext(804, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 36, false);
#line 36 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dias));

#line default
#line hidden
            EndContext();
            BeginContext(884, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(928, 45, false);
#line 39 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiasUteis));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1017, 41, false);
#line 42 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiasUteis));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1102, 52, false);
#line 45 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecoAberturaMes));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1198, 48, false);
#line 48 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecoAberturaMes));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1290, 40, false);
#line 51 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ewma));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1374, 36, false);
#line 54 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ewma));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1454, 52, false);
#line 57 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AbaixoValorAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1550, 48, false);
#line 60 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.AbaixoValorAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1642, 46, false);
#line 63 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1732, 42, false);
#line 66 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecoAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1818, 51, false);
#line 69 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AcimaValorAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1913, 47, false);
#line 72 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.AcimaValorAtual));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2004, 47, false);
#line 75 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorZscore));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2095, 43, false);
#line 78 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorZscore));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 51, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2189, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7232489946744618b1db1fddb07a059", async() => {
                BeginContext(2235, 4, true);
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
#line 85 "C:\Users\luang\Desktop\PESSOAL\REPO\CalculoParaAcoesMVC\CalculoParaAcoes\Views\Zscores\Details.cshtml"
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
            BeginContext(2243, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2251, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dfae6491b9e493bb9f419551821d6dc", async() => {
                BeginContext(2273, 12, true);
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
            BeginContext(2289, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalculoParaAcoesMVC.Models.ViewModels.ZscoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\EsqueciSenha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506d8dec67e69d026cf18c118cdf12997309c0d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_EsqueciSenha), @"mvc.1.0.view", @"/Views/Conta/EsqueciSenha.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/EsqueciSenha.cshtml", typeof(AspNetCore.Views_Conta_EsqueciSenha))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506d8dec67e69d026cf18c118cdf12997309c0d4", @"/Views/Conta/EsqueciSenha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be2f9ca392f8c813671237ab4b84b9ca121a387", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_EsqueciSenha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalculoParaAcoesMVC.Models.ViewModels.ContaEsqueciSenhaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(203, 31, true);
            WriteLiteral("\r\n<h2>Esqueci a senha </h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\EsqueciSenha.cshtml"
 using (Html.BeginForm()) 
{ 

#line default
#line hidden
            BeginContext(266, 82, true);
            WriteLiteral("    <h4>Informe o e-mail do seu cadastro para recuperar a senha</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(355, 58, false);
#line 15 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\EsqueciSenha.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(422, 21, false);
#line 17 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\EsqueciSenha.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
            EndContext();
            BeginContext(447, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(461, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Enviar\" />\r\n");
            EndContext();
#line 22 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\EsqueciSenha.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalculoParaAcoesMVC.Models.ViewModels.ContaEsqueciSenhaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee4af51d537739ee91778edd80b2e93d7ed4411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_Login), @"mvc.1.0.view", @"/Views/Conta/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/Login.cshtml", typeof(AspNetCore.Views_Conta_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee4af51d537739ee91778edd80b2e93d7ed4411", @"/Views/Conta/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be2f9ca392f8c813671237ab4b84b9ca121a387", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalculoParaAcoesMVC.Models.ViewModels.ContaLoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(196, 22, true);
            WriteLiteral("\r\n<h2>Login: </h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(253, 58, false);
#line 12 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\Login.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(320, 21, false);
#line 14 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\Login.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
            EndContext();
            BeginContext(352, 54, false);
#line 17 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\Login.cshtml"
Write(Html.ActionLink("Esqueci minha senha", "EsqueciSenha"));

#line default
#line hidden
            EndContext();
            BeginContext(408, 61, true);
            WriteLiteral("    <br />\r\n    <input type=\"submit\" value=\"Fazer Login\" />\r\n");
            EndContext();
#line 20 "C:\Users\Tiago Vazzoller\Documents\GitHub\CalculoParaAcoes\CalculoParaAcoes\Views\Conta\Login.cshtml"
}

#line default
#line hidden
            BeginContext(470, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalculoParaAcoesMVC.Models.ViewModels.ContaLoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

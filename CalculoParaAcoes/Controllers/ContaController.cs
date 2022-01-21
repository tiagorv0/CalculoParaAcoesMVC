using CalculoParaAcoesMVC.Models;
using CalculoParaAcoesMVC.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Controllers
{
    public class ContaController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signManager;

        public ContaController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(ContaLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _userManager.FindByNameAsync(model.UserName);

                if(usuario == null)
                {
                    SenhaOuUsuarioInvalidos(model);
                }

                var signIn = await _signManager.PasswordSignInAsync(
                    usuario.UserName,
                    model.Password,
                    isPersistent: false,
                    lockoutOnFailure: false);

                if (signIn.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    SenhaOuUsuarioInvalidos(model);
                }
            }
            return View(model);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(ContaRegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                var novoUsuario = new Usuario();

                novoUsuario.Email = model.Email;
                novoUsuario.UserName = model.UserName;
                novoUsuario.NomeCompleto = model.NomeCompleto;


                var usuario = await _userManager.FindByEmailAsync(model.Email);

                if (model.Password != model.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Senha Divergente");
                    return View();
                }

                if (usuario != null)
                    return View();

                var resultado = await _userManager.CreateAsync(novoUsuario, model.Password);
                if (resultado.Succeeded)
                {
                    return View("CadastroRealizado");
                }
                else
                {
                    ErroIdentity(resultado);
                }
            }
            return View(model);
        }



        public IActionResult EsqueciSenha()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EsqueciSenha(ContaEsqueciSenhaViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _userManager.FindByEmailAsync(model.Email);

                if (usuario != null)
                {
                    Random newPassword = new Random();


                    var token = await _userManager.GeneratePasswordResetTokenAsync(usuario);

                    await _userManager.ResetPasswordAsync(usuario, token, newPassword.ToString());

                    
                    return View("ConfirmacaoAlteracaoSenha", ConfirmacaoAlteracaoSenha(usuario.Email, newPassword.ToString()));
                }

                    SenhaOuUsuarioInvalidos(model);
            }
            return View();
        }

        public IActionResult ConfirmacaoAlteracaoSenha(string email, string novaSenha)
        {
            var modelo = new ContaConfirmacaoAlteracaoSenhaViewModel
            {
                Email = email,
                NovaSenha = novaSenha
            };
            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> Logoff()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private void ErroIdentity(IdentityResult resultado)
        {
            foreach (var erro in resultado.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }

        private ActionResult SenhaOuUsuarioInvalidos<T>(T model)
        {
            ModelState.AddModelError("", "Credenciais Inválidas!");
            return View(model);
        }
    }
}

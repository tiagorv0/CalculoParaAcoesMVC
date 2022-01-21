using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculoParaAcoes.Models;
using CalculoParaAcoesMVC.Services;
using CalculoParaAcoes.Models.ViewModels;
using System.Diagnostics;
using CalculoParaAcoesMVC.Services.Exceptions;

namespace CalculoParaAcoesMVC.Controllers
{
    public class DesvioPadraosController : Controller
    {
        private readonly DesvioPadraoService _desvioPadraoService;

        public DesvioPadraosController(DesvioPadraoService desvioPadraoService)
        {
            _desvioPadraoService = desvioPadraoService;
        }

        // GET: DesvioPadraos
        public async Task<IActionResult> Index()
        {
            return View(await _desvioPadraoService.FindAllAsync());
        }

       

        // GET: DesvioPadraos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desvioPadrao = await _desvioPadraoService.FindByIdAsync(id.Value);

            if (desvioPadrao == null)
            {
                return NotFound();
            }

            return View(desvioPadrao);
        }

        // GET: DesvioPadraos/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DesvioPadrao desvioPadrao)
        {
            if (ModelState.IsValid)
            {

                await _desvioPadraoService.InsertAsync(desvioPadrao);
                return RedirectToAction(nameof(Index));
            }
            return View(desvioPadrao);
        }

        // GET: DesvioPadraos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id nulo" });
            }

            var desvioPadrao = await _desvioPadraoService.FindByIdAsync(id.Value);
            if (desvioPadrao == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(desvioPadrao);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDaAcao,FechamentoAtual,Abertura1Antes,DesvPadrao,DataCriado,Desvio1,Desvio2,Desvio1n,Desvio2n")] DesvioPadrao desvioPadrao)
        {
            if (id != desvioPadrao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                return View(desvioPadrao);

            }
            try
            {
                await _desvioPadraoService.UpdateAsync(desvioPadrao);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            


        }

        // GET: DesvioPadraos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id nulo" });
            }

            var desvioPadrao = await _desvioPadraoService.FindByIdAsync(id.Value);
                
            if (desvioPadrao == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(desvioPadrao);
        }

        // POST: DesvioPadraos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _desvioPadraoService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }



        private IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}

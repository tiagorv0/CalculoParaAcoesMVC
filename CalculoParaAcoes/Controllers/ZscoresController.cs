using CalculoParaAcoes.Models;
using CalculoParaAcoes.Models.ViewModels;
using CalculoParaAcoesMVC.Services;
using CalculoParaAcoesMVC.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Controllers
{

    public class ZscoresController : Controller
    {

        private readonly ZscoreService _zscoreService;

        public ZscoresController(ZscoreService zscoreService)
        {
            _zscoreService = zscoreService;
        }

        // GET: Zscores
        public async Task<IActionResult> Index()
        {
            return View(await _zscoreService.FindAllAsync());
        }

        //public async Task<IActionResult> BuscaZscore(string pesquisa)
        //{
        //    return View(await _zscoreService.FindAllAsync(pesquisa));
        //}

        // GET: Zscores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id nulo" });
            }

            var zscore = await _zscoreService.FindByIdAsync(id.Value);
            if (zscore == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(zscore);
        }

        // GET: Zscores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zscores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Zscore zscore)
        {
            if (!ModelState.IsValid)
            {
                return View(zscore);
            }
            await _zscoreService.InsertAsync(zscore);
            return RedirectToAction(nameof(Index));

        }

        // GET: Zscores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id nulo" });
            }

            var zscore = await _zscoreService.FindByIdAsync(id.Value);
            if (zscore == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(zscore);
        }

        // POST: Zscores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDaAcao,Variacao5Anos,Dias,DiasUteis,PrecoAberturaMes,Ewma,PrecoAtual")] Zscore zscore)
        {
            if (!ModelState.IsValid)
            {

                return View(zscore);
            }

            if (id != zscore.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id incompatível" });
            }

            try
            {
                await _zscoreService.UpdateAsync(zscore);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        // GET: Zscores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id nulo" });
            }

            var zscore = await _zscoreService.FindByIdAsync(id.Value);
            if (zscore == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(zscore);
        }

        // POST: Zscores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _zscoreService.RemoveAsync(id);
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

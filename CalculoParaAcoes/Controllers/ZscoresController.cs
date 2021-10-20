using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalculoParaAcoes.Data;
using CalculoParaAcoes.Models;
using CalculoParaAcoesMVC.Models.ViewModels;
using CalculoParaAcoesMVC.Services;

namespace CalculoParaAcoesMVC.Controllers
{
    
    public class ZscoresController : Controller
    {
        private readonly IZscoreService zscoreService;

        public ZscoresController(IZscoreService zscoreService)
        {
            this.zscoreService = zscoreService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await zscoreService.ListarAsync());
        }

        //// GET: Zscores/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var zscore = await _context.Zscore
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (zscore == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(zscore);
        //}

        // GET: Zscores/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] ZscoreViewModel zscoreViewModel)
        {
            if (ModelState.IsValid)
            {
                await zscoreService.CadastrarAsync(zscoreViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(zscoreViewModel);
        }

        //// GET: Zscores/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var zscore = await _context.Zscore.FindAsync(id);
        //    if (zscore == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(zscore);
        //}

        //// POST: Zscores/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,DataCriado,NomeDaAcao,Variacao5Anos,Dias,DiasUteis,PrecoAberturaMes,Ewma,PrecoAtual,ValorZscore,AcimaValorAtual,AbaixoValorAtual")] ZscoreModel zscore)
        //{
        //    if (id != zscore.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(zscore);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ZscoreExists(zscore.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(zscore);
        //}

        //// GET: Zscores/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var zscore = await _context.Zscore
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (zscore == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(zscore);
        //}

        //// POST: Zscores/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var zscore = await _context.Zscore.FindAsync(id);
        //    _context.Zscore.Remove(zscore);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ZscoreExists(int id)
        //{
        //    return _context.Zscore.Any(e => e.Id == id);
        //}
    }
}

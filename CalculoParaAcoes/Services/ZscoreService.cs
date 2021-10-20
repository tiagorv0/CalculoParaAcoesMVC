using CalculoParaAcoesMVC.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CalculoParaAcoes.Models;
using System.Threading.Tasks;
using CalculoParaAcoes.Data;
using System;

namespace CalculoParaAcoesMVC.Services
{
    public class ZscoreService : IZscoreService
    {
        private readonly CalculosDbContext _context; 

        public ZscoreService(CalculosDbContext _context)
        {
            this._context = _context;
        }

        public async Task CadastrarAsync(ZscoreViewModel zscoreViewModel)
        {
            var zscore = new ZscoreModel
            {
                AbaixoValorAtual = zscoreViewModel.AbaixoValorAtual,
                AcimaValorAtual = zscoreViewModel.AcimaValorAtual,
                DataCriado = zscoreViewModel.DataCriado,
                Dias = zscoreViewModel.Dias,
                DiasUteis = zscoreViewModel.DiasUteis,
                Ewma = zscoreViewModel.Ewma,
                Id = zscoreViewModel.Id,
                NomeDaAcao = zscoreViewModel.NomeDaAcao,
                PrecoAberturaMes = zscoreViewModel.PrecoAberturaMes,
                PrecoAtual = zscoreViewModel.PrecoAtual,
                ValorZscore = CalcularZscore(zscoreViewModel),
                Variacao5Anos = Convert.ToDouble(zscoreViewModel.Variacao5Anos),
            };

            _context.Add(zscore);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ZscoreModel>> ListarAsync()
        {
            return await _context.Zscore.ToListAsync();
        }

        private double CalcularZscore(ZscoreViewModel zscoreViewModel)
        {
            double variacaoMediaMensal = Math.Pow((1 + Convert.ToDouble(zscoreViewModel.Variacao5Anos)) / 100, (1 / 60.00)) - 1;
            double variacaoMediaPeriodo = Math.Pow(1 + variacaoMediaMensal, zscoreViewModel.Dias / zscoreViewModel.DiasUteis);
            //double retornoMedio = PrecoAberturaMes * variacaoMediaPeriodo;

            double desvioPadraoDiario = zscoreViewModel.Ewma / Math.Sqrt(252);
            double desvioPadraoPeriodo = desvioPadraoDiario * Math.Sqrt(zscoreViewModel.Dias);

            return (((zscoreViewModel.PrecoAtual / zscoreViewModel.PrecoAberturaMes) - 1) - (variacaoMediaPeriodo - 1)) / desvioPadraoPeriodo * 100;
        }
    }
}

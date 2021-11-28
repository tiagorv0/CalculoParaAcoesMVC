using CalculoParaAcoes.Data;
using CalculoParaAcoes.Models;
using CalculoParaAcoesMVC.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Services
{
    public class DesvioPadraoService
    {
        private const double N_Meses = 12.0;
        private readonly CalculosDbContext _context;

        public DesvioPadraoService(CalculosDbContext context)
        {
            _context = context;
        }

        public async Task<List<DesvioPadrao>> FindAllAsync()
        {
            return await _context.DesvioPadrao.ToListAsync();
        }

        public async Task<List<string>> FindByNameAsync()
        {
            return await _context.DesvioPadrao.Select(n => n.NomeDaAcao).ToListAsync();
        }

        public async Task InsertAsync(DesvioPadrao obj)
        {
            DesvioPadrao desvioPadrao = AtribuirValores(obj);

            _context.Add(desvioPadrao);
            await _context.SaveChangesAsync();
        }

        

        public async Task<DesvioPadrao> FindByIdAsync(int id)
        {
            return await _context.DesvioPadrao.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.DesvioPadrao.FindAsync(id);
                _context.DesvioPadrao.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(DesvioPadrao obj)
        {
            bool hasAny = await _context.DesvioPadrao.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                DesvioPadrao desvioPadrao = AtribuirValores(obj);
                _context.Update(desvioPadrao);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }

        private DesvioPadrao AtribuirValores(DesvioPadrao obj)
        {
            var zscore = new DesvioPadrao
            {
                Id = obj.Id,
                NomeDaAcao = obj.NomeDaAcao.ToUpper(),
                FechamentoAtual = obj.FechamentoAtual,
                Abertura1Antes = obj.Abertura1Antes,
                DesvPadrao = obj.DesvPadrao
            };

            zscore.DataCriado = DateTime.Today;
            CalculoDesvioPadrao(zscore);
            return zscore;
        }

        public void CalculoDesvioPadrao(DesvioPadrao desvioPadrao)
        {
            double convertedFechamento = Convert.ToDouble(desvioPadrao.FechamentoAtual);

            double retornoAbsoluto = convertedFechamento / Convert.ToDouble(desvioPadrao.Abertura1Antes) - 1;
            double retornoMediaMensal = Math.Pow(1 + retornoAbsoluto, 1 / N_Meses) - 1;

            double dv = Convert.ToDouble(desvioPadrao.DesvPadrao) / Math.Sqrt(12) / 100;

            desvioPadrao.Desvio1 = convertedFechamento
                + (convertedFechamento * (retornoMediaMensal + dv));
            desvioPadrao.Desvio2 = convertedFechamento 
                + (convertedFechamento * (retornoMediaMensal + dv * 2));

            desvioPadrao.Desvio1n = convertedFechamento 
                + (convertedFechamento * (retornoMediaMensal - dv));
            desvioPadrao.Desvio2n = convertedFechamento 
                + (convertedFechamento * (retornoMediaMensal - dv * 2));
        }
    }
}

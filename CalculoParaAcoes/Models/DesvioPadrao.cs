using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoes.Models
{
    public class DesvioPadrao
    {
        public int Id { get; set; }
        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCriado { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Fechamento atual")]
        public double FechamentoAtual { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Abertura 1 anos antes")]
        public double Abertura1Antes { get; set; }
        [Required]
        [Display(Name = "Desvio Padrão")]
        public double DesvPadrao { get; set; }

        public DesvioPadrao(double fechamentoAtual, double abertura1Antes, double desvPadrao, int id)
        {
            FechamentoAtual = fechamentoAtual;
            Abertura1Antes = abertura1Antes;
            DesvPadrao = desvPadrao;
            Id = id;
            DataCriado = DateTime.Now;
        }

        public void CalculoDP(out double desvio1, out double desvio2, out double desvio1n, out double desvio2n)
        {
            double retornoAbsoluto = FechamentoAtual / Abertura1Antes - 1;
            double retornoMediaMensal = Math.Pow(1 + retornoAbsoluto, 1 / 12.0) - 1;

            double dv = DesvPadrao / Math.Sqrt(12) / 100;

            desvio1 = FechamentoAtual + (FechamentoAtual * (retornoMediaMensal + dv));
            desvio2 = FechamentoAtual + (FechamentoAtual * (retornoMediaMensal + dv*2));

            desvio1n = FechamentoAtual + (FechamentoAtual * (retornoMediaMensal - dv));
            desvio2n = FechamentoAtual + (FechamentoAtual * (retornoMediaMensal - dv*2));
        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalculoParaAcoesMVC.Models.ViewModels
{
    public class ZscoreViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome da Ação")]
        public string NomeDaAcao { get; set; }

        [Required]
        [Display(Name = "Variação % de 5 anos")]
        public double Variacao5Anos { get; set; }

        [Required]
        public int Dias { get; set; }

        [Required]
        [Display(Name = "Dias Úteis de um vencimento a outro")]
        public int DiasUteis { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Preço de abertura do mês atual")]
        public double PrecoAberturaMes { get; set; }

        [Required]
        public double Ewma { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Preço atual")]
        public double PrecoAtual { get; set; }

        [Display(Name = "Valor ZScore")]
        public double ValorZscore { get; set; }

        [Display(Name = "Acima do Valor Atual")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        public double AcimaValorAtual { get; set; }

        [Display(Name = "Abaixo do Valor Atual")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        public double AbaixoValorAtual { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCriado { get; set; }
    }
}

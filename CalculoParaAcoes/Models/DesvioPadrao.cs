using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoes.Models
{
    public class DesvioPadrao
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Nome da Ação")]
        public string NomeDaAcao { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Fechamento atual")]
        public string FechamentoAtual { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Abertura 1 anos antes")]
        public string Abertura1Antes { get; set; }

        [Required]
        [Display(Name = "Desvio Padrão")]
        public string DesvPadrao { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCriado { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Desvio1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Desvio2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Desvio1n { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Desvio2n { get; set; }

        public DesvioPadrao()
        {

        }

        
    }
}

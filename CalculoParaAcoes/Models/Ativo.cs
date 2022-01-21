using System.ComponentModel.DataAnnotations;

namespace CalculoParaAcoesMVC.Models
{
    public class Ativo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome do Ativo")]
        public string Nome { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Preço Médio")]
        public double PrecoMedio { get; set; }

        [Required]
        public string Setor { get; set; }

        public Ativo()
        {

        }
    }
}

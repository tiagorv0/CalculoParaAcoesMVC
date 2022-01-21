using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalculoParaAcoesMVC.Models
{
    public class Carteira
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public IList<Ativo> Ativos { get; set; }
    }
}

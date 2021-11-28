using CalculoParaAcoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Models.ViewModels
{
    public class BuscaZscoreViewModel
    {
        public IList<Zscore> Lista { get; }
        public string Pesquisa { get; set; }

        public BuscaZscoreViewModel(IList<Zscore> lista, string pesquisa)
        {
            Lista = lista;
            Pesquisa = pesquisa;
        }
    }
}

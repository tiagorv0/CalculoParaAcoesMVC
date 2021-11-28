using CalculoParaAcoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Models.ViewModels
{
    public class BuscaDesvioPadraoViewModel
    {
        public IList<DesvioPadrao> Lista { get; }
        public string Pesquisa { get; set; }

        public BuscaDesvioPadraoViewModel(IList<DesvioPadrao> lista, string pesquisa)
        {
            Lista = lista;
            Pesquisa = pesquisa;
        }


    }
}

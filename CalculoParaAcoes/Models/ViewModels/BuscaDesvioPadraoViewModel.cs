using CalculoParaAcoes.Models;
using System.Collections.Generic;

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

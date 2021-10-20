using System.ComponentModel.DataAnnotations;
using System;

namespace CalculoParaAcoes.Models
{
    public class ZscoreModel
    {
        [Key]
        public int Id { get; set; }
        
        public string NomeDaAcao { get; set; }

        public double Variacao5Anos { get; set; }
        
        public int Dias { get; set; }
        
        public int DiasUteis { get; set; }
        
        public double PrecoAberturaMes { get; set; }
        
        public double Ewma { get; set; }
        
        public double PrecoAtual { get; set; }
        
        public double ValorZscore { get; set; }
        
        public double AcimaValorAtual { get; set; }
        
        public double AbaixoValorAtual { get; set; }

        public DateTime DataCriado { get; set; }

        //public Zscore(string nomeDaAcao, double variacao5Anos, int dias, int diasUteis, double precoAberturaMes, double ewma, double precoAtual, int id)
        //{
        //    NomeDaAcao = nomeDaAcao;
        //    Variacao5Anos = variacao5Anos;
        //    Dias = dias;
        //    DiasUteis = diasUteis;
        //    PrecoAberturaMes = precoAberturaMes;
        //    Ewma = ewma;
        //    PrecoAtual = precoAtual;
        //    Id = id;
        //    DataCriado = DateTime.Now;
        //    ValorZscore = Calculo();

        //    if (ValorZscore < 0)
        //    {
        //        AbaixoValorAtual = 1 - CalculoZscore(ValorZscore);
        //        AcimaValorAtual = 1 - AbaixoValorAtual;
        //    }
        //    else
        //    {
        //        AcimaValorAtual = 1 - CalculoZscore(ValorZscore);
        //        AbaixoValorAtual = 1 - AcimaValorAtual;
        //    }
        //}
    }
}


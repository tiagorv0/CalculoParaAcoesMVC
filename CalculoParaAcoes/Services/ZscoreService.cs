using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Services
{
    public class ZscoreService
    {
        public double Calculo()
        {
            double variacaoMediaMensal = Math.Pow((1 + Variacao5Anos) / 100, (1 / 60.00)) - 1;
            double variacaoMediaPeriodo = Math.Pow(1 + variacaoMediaMensal, Dias / DiasUteis);
            //double retornoMedio = PrecoAberturaMes * variacaoMediaPeriodo;

            double desvioPadraoDiario = Ewma / Math.Sqrt(252);
            double desvioPadraoPeriodo = desvioPadraoDiario * Math.Sqrt(Dias);

            return (((PrecoAtual / PrecoAberturaMes) - 1) - (variacaoMediaPeriodo - 1)) / desvioPadraoPeriodo * 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraOps
    {
        private List<string> _historico;
        private DateTime dataAtual = DateTime.Now;

        public CalculadoraOps(DateTime data){
            _historico = new List<string>();
            dataAtual = data;
        }
        public int Somar(int num1, int num2)
        {
            var resultado = num1 + num2;
            _historico.Insert(0, "Resultado: " + resultado + ", em " + dataAtual);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            var resultado = num1 - num2;
            _historico.Insert(0, "Resultado: " + resultado + ", em " + dataAtual);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            var resultado = num1 * num2;
            _historico.Insert(0, "Resultado: " + resultado + ", em " + dataAtual);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            var resultado = num1 / num2;
            _historico.Insert(0, "Resultado: " + resultado + ", em " + dataAtual);
            return resultado;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }

    }
}
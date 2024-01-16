using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    public class Tabuada {
        public int Numero { get; }

        public Tabuada(int numero)
        {
            Numero = numero;
        }

        public string Calcular(int de, int ate)
        {
            var sb = new StringBuilder();

            for (int i = de; i <= ate; i++) {
                sb.AppendLine($"{Numero} x {i} = {OperacoesAritimeticas.Multiplicacao(Numero, i)}");
            }

            return sb.ToString();
        }
    }
}

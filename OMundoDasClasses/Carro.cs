using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClasses
{
    public class Carro {
        public Cor cor;
        public int portas;
        public string modelo;
        public bool ligado = false;

        public string ligar()
        {
            return "O carro está ligado";
        }

        public string desligar()
        {
            return "O carro está desligado";
        }

        public string andar()
        {
            return "O carrro está andando";
        }
    }
}

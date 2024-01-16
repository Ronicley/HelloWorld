using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClasses
{
    public abstract class Animal {
        public string Nome { get; }
        public int Idade { get; }
        public int Som SomEmitido { get; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

    }
}

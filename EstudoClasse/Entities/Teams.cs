using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasse.Entities
{
    internal class Teams
    {
        public string Time;
        public int Titulos;
        public int Criacao;
        public string Rival;
        public double Torcedores;

        public override string ToString()
        {
            return "Seu time de coração é "
                + Time
                + ", ele tem "
                + Titulos
                + " Titulos, sua criação foi em "
                + Criacao
                + ", tem uma torcida com aproximadamente "
                + Torcedores
                + " torcedores, e seu Rival é o "
                + Rival;
        }
    }
}

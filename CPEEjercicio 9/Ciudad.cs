using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_9
{
    internal class Ciudad
    {
        int codigo;
        string nom;

        public Ciudad(int codigo, string nom)
        {
            this.codigo = codigo;
            this.nom = nom;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}

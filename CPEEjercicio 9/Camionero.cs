using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_9
{
    internal class Camionero
    {
        string nom;
        int pobl;
        int telf;
        string direc;
        float sal;
        int rfc;

        public Camionero(string nom, int pobl, int telf, string direc, float sal, int rfc)
        {
            this.Nom = nom;
            this.Pobl = pobl;
            this.Telf = telf;
            this.Direc = direc;
            this.Sal = sal;
            this.Rfc = rfc;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Pobl { get => pobl; set => pobl = value; }
        public int Telf { get => telf; set => telf = value; }
        public string Direc { get => direc; set => direc = value; }
        public float Sal { get => sal; set => sal = value; }
        public int Rfc { get => rfc; set => rfc = value; }
    }
}

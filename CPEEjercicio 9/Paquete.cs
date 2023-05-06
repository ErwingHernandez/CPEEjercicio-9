using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_9
{
    internal class Paquete
    {
        int codigo;
        string desc;
        string destina;
        string direc;

        public Paquete(int codigo, string desc, string destina, string direc)
        {
            this.codigo = codigo;
            this.desc = desc;
            this.destina = destina;
            this.direc = direc;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Destina { get => destina; set => destina = value; }
        public string Direc { get => direc; set => direc = value; }
    }
}

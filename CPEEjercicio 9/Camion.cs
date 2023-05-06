using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_9
{
    internal class Camion
    {
        int potencia;
        string matricula;
        string modelo;
        string tipo;

        public Camion(int potencia, string matricula, string modelo, string tipo)
        {
            this.potencia = potencia;
            this.matricula = matricula;
            this.modelo = modelo;
            this.tipo = tipo;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}

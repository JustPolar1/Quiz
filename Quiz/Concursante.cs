using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Concursante
    {
        private string nombre;
        private int puntos;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}

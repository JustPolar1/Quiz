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
        private int racha;
        // Se crea el constructor para los concursantes, solo hará falta el nombre del concursante
        public Concursante(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Racha { get => racha; set => racha = value; }
    } 
}

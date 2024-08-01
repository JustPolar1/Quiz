using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Quiz
    {
        private string respuesta;

        public virtual void Basico(Concursante concursante)
        { 
            //Ejemplo estructura de las preguntas
            Console.WriteLine($"1. ¿Cuál es la capital de Uruguay?: ");
            Console.WriteLine("\ta) Montevideo");
            Console.WriteLine("\tb) Uruguay");
            Console.WriteLine("\tc) Buenos Aires");
            Console.Write("Escriba el inciso: ");
            respuesta = Console.ReadLine();

            Console.WriteLine();
            if (respuesta.ToLower() == "a" || respuesta.ToLower() == "montevideo")
            {
                concursante.Puntos += 1;
                Console.WriteLine("¡Respuesta correcta!");
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta, la respuesta correcta era Montevideo");
            }

            // Comentarios completamente sanos acerca del código y la raza negra

            Console.WriteLine();

            Console.Write("Enter para continuar ");
            Console.ReadLine();
            Console.Clear();

        }
        public virtual void Intermedio(Concursante concursante)
        {

        }
        public virtual void Avanzado(Concursante concursante) 
        {
            
        }
    }
}

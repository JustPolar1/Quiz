using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prueba, esto no va a estar en la versión final.
            Concursante Avril = new Concursante();
            Avril.Nombre = "Avril";

            Quiz quiz = new Quiz();
            quiz.Basico(Avril);
            quiz.Basico(Avril);
            quiz.Basico(Avril);
            quiz.Basico(Avril);

            //Esto no lo pondremos en las preguntas, se pone al final
            Console.WriteLine($"{Avril.Nombre} tiene: {Avril.Puntos} punto(s)");

            Console.ReadKey();
        }
    }
}

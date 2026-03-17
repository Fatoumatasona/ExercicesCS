using System.Diagnostics;

namespace QuizzCapitales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1ere version du jeu: on pose toutes les questions
            Quizz.Jouer();

            //Variante: on ne pose que certaines questions choisies
            Quizz.Jouer(0, 3, 6, 10, 12);
            // Les numéros de questions 0 et 12 sont volontairement invalides
            // et doivent être ignorés par la methode
           
            Console.ReadKey();
        }
    }
}


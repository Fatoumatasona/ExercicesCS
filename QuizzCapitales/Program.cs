using System.Diagnostics;

namespace QuizzCapitales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1ere version du jeu: on pose toutes les questions
            //Quizz.Jouer();

            //Variante: on ne pose que certaines questions choisies
            // Les numéros de questions 0 et 12 sont volontairement invalides
            // et doivent être ignorés par la methode
            // Quizz.Jouer(0, 3, 6, 10, 12);

            // Génération aléatoire de numéros
           // (int n1, int n2, int n3) = Quizz.Générer3Numéros();
            // Saisie 3 numéros par l'utilisateur
            (int n1, int n2, int n3) = Quizz.Saisir3Numéros();
            Quizz.Jouer(n1, n2, n3);

            Console.ReadKey();
        }
    }
}


using System.Diagnostics;

namespace QuizzCapitales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Etape 1: création du projet 
             * - Créer uune solution surnommé Exercices, contenant un projet nommé QuizCapitales de type
             * application console
             * Etape 2
             * Créer 2 tableaux contenant respectivement les capitales et les pays
             * Itérer sur le 1er tableau pour:
             * - Demander à l'utilisateur la capitale du pays
             * - s'il reponds bien, afficher "Bravo", sinon afficher "Mauvaise reponse. La reponse était XXX"
             * Etape 3
             * Modifier le code précédent pour ne poser qu'une question sur deux
             * Etape 4
             * Remettre le code comme il était pour poser toutes les questions.
             * Modifier le  code poser les questions en partant de la fin.
             * Etape 5
             * Créer un compteur de bonnes reponses, et afficher sa valeur à la fin du jeu.
             * Etape 6
             *  A la fin du jeu, demander à l'utilisateur s'il veut rejouer.
             *  S'il tape "o" ou "O", vider l'écran avec l'instruction Console.Clear(), et faire en sorte 
             *  de relancer le jeu. Sinon, afficher un message  "Merci d'avoir joué" .
             */
           
            // Tableau des pays
            string[] pays = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie",
                "Bosnie-Herzégovine", "Bulgarie", "Chypre", "croatie"};

            // Tableau des capitales
            string[] capitales = { "Tirana", "Berlin", "Andorre-la-vieille", "Vienne", "Bruxelles", "Minsk",
              "Sarajevo", "Sofia", "Nicosie", "Zagreb" };

            int compt = 0;
            bool continuer = true;
            while (continuer)
            {
                    for (int i = pays.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine($"\nQuelle est la capitale de {pays[i]} ?");
                        string? reponse = Console.ReadLine();
                        if (capitales[i] == reponse)
                        {
                            Console.WriteLine("Bravo !"); compt++;
                        }
                        else
                        {
                            Console.WriteLine($"Mauvaise réponse. La reponse était {capitales[i]}");
                        }
                    }
                    Console.WriteLine($"\n{compt} bonnes réponses ");

                    Console.WriteLine($"Voulez-vous rejouer (O/N) ?");
                    string? rep = Console.ReadLine();
                    if (rep == "O" || rep == "o")
                        Console.Clear();
                    else
                    {
                        Console.WriteLine($"Merci d’avoir joué !");
                        continuer = false;
                    }
                }
                Console.ReadKey();
        }
    }
}


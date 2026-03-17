using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QuizzCapitales
{
    /**
     * Exercice QUizz capitales - partie 2
     * Mettre en oeuvre ce que nous avons vu sur les fonctions et les paramètres. 
     * Pour cela ajouter des étapes à l'exercice Quizz capitales.
     * Il s'agit dans un premier temps de découper le code en différentes méthodes, 
     * pour le rendre plus évolutif et maintenable.
     * Tu devras ensuite créer une variante du jeu dans laquelle tu pourras définir facilement les numéros de 
     * questions à poser au joueur, au lieu de poser systématiquement toutes les questions dans l'ordre du tableau.
     * Lire bien toutes les étapes de l'exercice avant de commencer.
     * 
     * Exercice
     * Etape 1: refactorisation du code
     * Ajouter un fichier de classe au projet nommer Quizz.cs
     * Déplacer les tableaux des pays et capitales de la méthode Main dans la classe Quizz et ajouter le mot clé 
     * static devant leur déclaration.
     * Ajouter une méthode Jouer dans la classe Quizz sans paramètres, ni retour.
     * Déplacer le code restant de la méthode Main dans la méthode Jouer.
     * Appeler la méthode Jouer dans la méthode Main
     * Générer le projet pour vérifier qu'il n'y a pas d'erreur.
     * 
     * Etape 2
     * Découper le code de la méthode Jouer en plusieurs méthodes respectant le principe de responsabilité unique.
     * Dans la classe Quizz, créer une seconde méthode statique nommée PoserQuestion qui:
     * - prend en paramètre le numéro de question à poser (= indice du pays ds le tableau)
     * - pose la question
     * - affiche "Bravo !" ou bien "Mauvaise réponse. La reponse était XXX"
     * - renvoie un booléen indiquant si le joueur a bien répondu ou non 
     * 
     * Dans Jouer, remplacer le code qui à l'intérieur de la boucle for par un appel à PoserQuestion.
     * Faire en sorte que le compteur de bonnes réponses fonctionne toujours.
     * Tester le programme.
     */
    internal class Quizz
    {
        // Tableau des pays
        static string[] pays = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie",
                "Bosnie-Herzégovine", "Bulgarie", "Chypre", "croatie"};

        // Tableau des capitales
        static string[] capitales = { "Tirana", "Berlin", "Andorre-la-vieille", "Vienne", "Bruxelles", "Minsk",
              "Sarajevo", "Sofia", "Nicosie", "Zagreb" };

        public static void Jouer()
        {
            bool continuer = true;
            while (continuer)
            {
                int bonnesRep = 0;
                for (int i = pays.Length - 1; i >= 0; i--)
                {
                    if (PoserQuestion(i)) bonnesRep++;
                }
                Console.WriteLine($"\n{bonnesRep} bonnes réponses ");
                continuer = DemanderSiRejouer();
            }
        }
        // Variante acceptant un nombre quelconque de numéros de questions
        public static void Jouer(params int[] numQuestions)
        {
            bool continuer = true;
            while (continuer)
            {
                int bonnesRep = 0;
                foreach (int num in numQuestions)
                {
                    if (num > 0 && num <= pays.Length && PoserQuestion(num - 1)) bonnesRep++;
                }
                Console.WriteLine($"\n{bonnesRep} bonnes réponses ");
                continuer = DemanderSiRejouer();
            }
        }

        static bool PoserQuestion(int numQuestion)
        {
            Console.WriteLine($"\nQuelle est la capitale de {pays[numQuestion]} ?");
            string? reponse = Console.ReadLine();

            if (reponse == capitales[numQuestion])
            {
                Console.WriteLine("Bravo !"); return true;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse. La reponse était {capitales[numQuestion]}");
                return false;
            }
        }

        static bool DemanderSiRejouer()
        {
            Console.WriteLine("Voulez-vous rejouer (O/N) ?");

            string? rep = Console.ReadLine();
            if (rep == "O" || rep == "o")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine($"Merci d’avoir joué !");
                return false;
            }
        }
    }
}

using JeuDe;

internal class Program
{
    public const byte NB_MANCHES = 5;

    private static void Main(string[] args)
    {

        // Saisie des noms des joueurs.
        Console.Write("Nom du premier joueur: ");
        String j1Nom = Console.ReadLine();
        Console.Write("Nom du deuxième joueur: ");
        String j2Nom = Console.ReadLine();
        Console.WriteLine();

        // Création des joueurs.
        Joueur j1 = new Joueur(j1Nom);
        Joueur j2 = new Joueur(j2Nom);



        // Tant qu'aucun joueur n'a gagné 5 manches.
        while (j1.nbManchesGagnees < NB_MANCHES && j2.nbManchesGagnees < NB_MANCHES)
        {
            // Lancer les dés.
            j1.LancerDes();
            j2.LancerDes();

            // Obtenir les sommaires.
            int[] vectJ1NbDesParValeur = j1.ObtenirNbDesParValeur();
            int[] vectJ2NbDesParValeur = j2.ObtenirNbDesParValeur();

            // Déterminer le joueur gagnant.
            // No du joueur gagnant la manche (0 = aucun gagnant, 1 = Joueur 1, 2 = Joueur 2) 
            int noGagnant = 0;

            // Valeur de dé testée pour identifier le gagnant (6 initialement).
            int valeurTestee = 6;

            do
            {
                if (vectJ1NbDesParValeur[valeurTestee - 1] > vectJ2NbDesParValeur[valeurTestee - 1])
                    noGagnant = 1;
                else if (vectJ1NbDesParValeur[valeurTestee - 1] < vectJ2NbDesParValeur[valeurTestee - 1])
                    noGagnant = 2;
                valeurTestee--;
            } while (noGagnant == 0 && valeurTestee > 0);

            Console.WriteLine("SOMMAIRE DE LA MANCHE");
            Console.WriteLine("=====================");
            switch (noGagnant)
            {
                case 0:
                    Console.WriteLine("Manche nulle !");
                    break;
                case 1:
                    Console.WriteLine(j1.nom + " gagne la manche");
                    j1.nbManchesGagnees++;
                    break;
                case 2:
                    Console.WriteLine(j2.nom + " gagne la manche");
                    j2.nbManchesGagnees++;
                    break;
            }

            // Affichage des statistiques

            AfficherStatistiquesJoueur(j1);
            AfficherStatistiquesJoueur(j2);

            Console.ReadKey();
            Console.WriteLine();
        }

        // Affichage du gagnant.
        Console.WriteLine("PARTIE TERMINÉE");
        Console.WriteLine("===============");

        if (j1.nbManchesGagnees == NB_MANCHES)
            Console.WriteLine(j1.nom + " gagne la partie");
        else
            Console.WriteLine(j2.nom + " gagne la partie");
    }

 

    /// <summary>
    /// Permet d'obtenir une représentation du joueur et des ses dés.
    /// </summary>
    /// <returns>Représentation du joueur et des ses dés.</returns>
    static void AfficherStatistiquesJoueur(Joueur joueur)
    {
        String desChaine = "";
        for (int i = 0; i < joueur.vectDes.Length - 1; i++)
        {
            desChaine += joueur.vectDes[i] + ", ";
        }

        desChaine += joueur.vectDes[joueur.vectDes.Length - 1];

        Console.WriteLine(joueur.nom + " : " + desChaine + " ==> " + joueur.nbManchesGagnees + " manche(s) gagnée(s).");
    }
    
}
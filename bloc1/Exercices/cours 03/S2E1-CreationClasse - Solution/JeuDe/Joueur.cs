using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDe
{
    public class Joueur
    {
     

        /// <summary>
        /// Nombre de dés que le joueur a entre les mains.
        /// </summary>
        public const int NB_DES = 5;

        /// <summary>
        /// Générateur de nombre aléatoire.
        /// </summary>
        public Random aleatoire;

    
        /// <summary>
        /// Nom du joueur.
        /// </summary>
        public String nom;

        /// <summary>
        /// Nombre de manches gangées par le jouer.
        /// </summary>
        public byte nbManchesGagnees;


        /// <summary>
        /// Les dés que le joueur a entre les mains (en fait, les valeurs de ces dés).
        /// </summary>
        public int[] vectDes;

      
        /// <summary>
        /// Permet de créer un joueur avec un certain nom.
        /// </summary>
        /// <param name="nom">Nom du joueur.</param>
        public Joueur(string nom)
        {
            this.nom = nom;

            // Création du tableau de dés.
            this.vectDes = new int[Joueur.NB_DES];

            //Instanciation du générateur de nombre aléatoire
            aleatoire = new Random();
        }

     


        /// <summary>
        /// Permet de lancer tous les dés du joueur.
        /// </summary>
        public void LancerDes()
        {
            for (int i = 0; i < this.vectDes.Length; i++)
            {
                this.vectDes[i] = aleatoire.Next(1, 7);
            }
        }

        /// <summary>
        /// </summary>
        /// <returns>Un vecteur de 6 entiers indiquant le nombre de dés pour chacune 
        /// des 6 valeurs possible.</returns>
        public int[] ObtenirNbDesParValeur()
        {
            // Tableau contenant pour chaque casse le nombre de dés
            // dont la valeur correspond à l'indice plus 1.
            int[] vectNbDesParValeur = new int[6];

            // Toutes les casses du tableau sont initialisés à 0.
            // En fait, c'est inutile car un tableau de nombres est déjà initialisé à 0.
            for (int i = 0; i < vectNbDesParValeur.Length; i++)
                vectNbDesParValeur[i] = 0;

            for (int i = 0; i < this.vectDes.Length; i++)
            {
                // Pour éviter que ça plante si un dé n'a pas une valeur entre 1 et 6 inclusivement.
                if (this.vectDes[i] >= 1 && this.vectDes[i] <= 6)
                    vectNbDesParValeur[this.vectDes[i] - 1]++;
            }

            return vectNbDesParValeur;
        }

       
    }
}

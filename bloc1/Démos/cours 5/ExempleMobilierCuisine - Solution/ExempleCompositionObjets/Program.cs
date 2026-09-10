namespace ExempleCompositionObjets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un mobilier Bistro constitué d'une table, de 4 chaises normales et de 2 chaises capitaines.

            // Vecteur de 6 chaises.
            Chaise[] vectChaisesBistro = new Chaise[6];

            // Ajout des chaises normales dans le vecteur.
            for (int i = 0; i < 4; i++)
                vectChaisesBistro[i] = new Chaise("Bistro", false, 90.50m);

            // Ajout des chaises capitaines dans le vecteur.
            for (int i = 4; i < 6; i++)
                vectChaisesBistro[i] = new Chaise("Bistro", true, 130.25m);

            // Création de la table.
            Table tableBistroCarree = new Table("Bistro carrée", 879.00m);

            // Création du mobilier de cuisine.
            MobilierCuisine mobilierBistro = new MobilierCuisine(tableBistroCarree, vectChaisesBistro);

            // Appel de la méthode statique qui affiche certaines informations sur le mobilier.
            Program.AfficherInfoMobilier(mobilierBistro);
        }

        /// <summary>
        /// Affiche certaines informations sur le mobilier.
        /// </summary>
        /// <param name="mobilier">Le mobilier pour lequel on désire afficher des informations.</param>
        private static void AfficherInfoMobilier(MobilierCuisine mobilier)
        {
            // Affichage du prix de vente suggéré du mobilier.
            Console.WriteLine("Prix de vente suggéré = {0:c}", mobilier.PrixVente);

            // Affichage du modèle de la table.
            Console.WriteLine("\nModèle de la table : {0}", mobilier.Table.Modele);

            // Affichage du prix de vente suggéré de la table.
            Console.WriteLine("Prix de vente de la table : {0:c}", mobilier.Table.PrixVente);

            // Affichage du nombre de chaise dans le mobilier.
            Console.WriteLine("Nombre de chaises = " + mobilier.NbChaises);

            // Récupération de la 3e chaise.
            Chaise chaise3E = mobilier.ObtenirChaise(2);

            // Est-ce que la 3e chaise existe dans le mobilier ?
            if (chaise3E != null)
            {
                // Affichage du modèle de la 3e chaise.
                Console.WriteLine("\nModèle de la 3e chaise : {0}", chaise3E.Modele);

                // Affichage du prix de vente suggéré de la 3e chaise.
                Console.WriteLine("Prix de vente de la 3e chaise : {0:c}", mobilier.ObtenirChaise(2).PrixVente());
            }
        }
    }
}

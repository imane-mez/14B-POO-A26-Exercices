using FactureRestaurant;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=======================");
        Console.WriteLine("Système de facturation");
        Console.WriteLine("=======================\n\n");

        //Demande des informations à l'utilisateur pour la création de la facture.

        //Appéritif
        Console.Write("Veuillez indiquer le prix pour de l'appéritif : ");
        decimal prixApperitif = Convert.ToDecimal(Console.ReadLine());

        //Entrée
        Console.Write("Veuillez indiquer le prix pour de l'entrée : ");
        decimal prixEntree = Convert.ToDecimal(Console.ReadLine());

        //Plat principal
        Console.Write("Veuillez indiquer le prix pour du plat principal : ");
        decimal prixPlat = Convert.ToDecimal(Console.ReadLine());

        //Désert
        Console.Write("Veuillez indiquer le prix pour du dessert : ");
        decimal prixDessert = Convert.ToDecimal(Console.ReadLine());

        //Boisson
        Console.Write("Veuillez indiquer le prix pour de la boisson : ");
        decimal prixBoisson = Convert.ToDecimal(Console.ReadLine());

        //Création d'une facture
        Facture facture = new Facture(prixApperitif, prixEntree, prixPlat, prixDessert, prixBoisson);


        //Affichage du contenu de la facture
        AfficherFacture(facture);
    }

    /// <summary>
    /// Affichage du détail de la facture
    /// </summary>
    /// <param name="facture">Facture à afficher</param>
    static void AfficherFacture(Facture facture)
    {
        //On efface le contenu de la console.
        Console.Clear();

        Console.WriteLine("\n\n====================================================");
        Console.WriteLine("Total de la facture");
        Console.WriteLine("======================================================");
        Console.WriteLine("{0,-15} : {1,10:c2}", "Appéritif", facture.PrixApperitif);
        Console.WriteLine("{0,-15} : {1,10:c2}", "Entrée", facture.PrixEntree);
        Console.WriteLine("{0,-15} : {1,10:c2}", "Plat principal", facture.PrixPlat);
        Console.WriteLine("{0,-15} : {1,10:c2}", "Désert", facture.PrixDessert);
        Console.WriteLine("{0,-15} : {1,10:c2}", "Boisson", facture.PrixBoisson);
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("{0,-15} : {1,10:c2}", "Sous-total", facture.SousTotal); ;
        Console.WriteLine("{0,-15} : {1,10:c2}", "Taxe", facture.Taxe);
        Console.WriteLine("{0,-15} : {1,10:c2}", "Pourboire", facture.Pourboire);
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("{0,-15} : {1,10:c2}", "Total", facture.Total);
        Console.WriteLine("======================================================");

    }
}
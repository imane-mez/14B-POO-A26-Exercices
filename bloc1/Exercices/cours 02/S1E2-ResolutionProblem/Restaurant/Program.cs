using Restaurant;

internal class Program
{
    public const float TAUX_TAXES = 0.1f;
    public const float TAUX_POURBOIRE = 0.15f;

    static void Main(string[] args)
    {
        Console.WriteLine("=======================");
        Console.WriteLine("Système de facturation");
        Console.WriteLine("=======================\n\n");

        //Tableau contenant les factures
        Facture[] factures = new Facture[0];

        Facture facture = DemanderMontants();

        //Calcul du sous-total
        facture.montantSousTotal = CalculerSousTotal(facture);

        //Affichage du sous-total
        AfficherSousTotal(facture);

        //Calcul du pourboire
        facture.montantPourboire = CalculerPourboire(facture);

        //Calcul des taxes
        facture.montantTaxes = CalculerTaxes(facture);

        //Calcul du total
        facture.montantTotal = CalculerTotal(facture);

        //Affichage du total de la facture
        AfficherFacture(facture);

        //Montant donné par le client
        decimal montantDonne = DemanderMontantDonne();

        //Calcul de la monnaie à rendre au client
        decimal monnaie = CalculerMonnaie(facture, montantDonne);

        //Ajout de la facture au tableau de factures
        factures = AjouterFacture(factures, facture);

        //Affichage de la monnaie
        AfficherMonnaie(monnaie);

        Console.ReadKey();

    }

    /// <summary>
    /// Demande les différents montant de la facture à l'utilisateur
    /// </summary>
    /// <returns>Une facture avec les montants</returns>
    static Facture DemanderMontants()
    {

        //Création d'une facture
        Facture facture = new Facture();

        //Appéritif
        Console.Write("Veuillez indiquer le prix pour de l'appéritif : ");
        facture.prixApperitif = Convert.ToDecimal(Console.ReadLine());

        //Entrée
        Console.Write("Veuillez indiquer le prix pour de l'entrée : ");
        facture.prixEntree = Convert.ToDecimal(Console.ReadLine());

        //Plat principal
        Console.Write("Veuillez indiquer le prix pour du plat principal : ");
        facture.prixPlat = Convert.ToDecimal(Console.ReadLine());

        //Désert
        Console.Write("Veuillez indiquer le prix pour du dessert : ");
        facture.prixDessert = Convert.ToDecimal(Console.ReadLine());

        //Boisson
        Console.Write("Veuillez indiquer le prix pour la boisson : ");
        facture.prixBoisson = Convert.ToDecimal(Console.ReadLine());

        return facture;

    }

    /// <summary>
    /// Affiche le sous-total d'une facture
    /// </summary>
    /// <param name="facture">Facture à afficher</param>
    static void AfficherSousTotal(Facture facture)
    {
        //On efface le contenu de la console.
        Console.Clear();

        Console.WriteLine("==============================");
        Console.WriteLine("Sous-total de la facture");
        Console.WriteLine("==============================");
        Console.WriteLine("{0,-15} : {1:c2}", "Appéritif", facture.prixApperitif);
        Console.WriteLine("{0,-15} : {1:c2}", "Entrée", facture.prixEntree);
        Console.WriteLine("{0,-15} : {1:c2}", "Plat principal", facture.prixPlat);
        Console.WriteLine("{0,-15} : {1:c2}", "Désert", facture.prixDessert);
        Console.WriteLine("{0,-15} : {1:c2}", "Boisson", facture.prixBoisson);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("{0,-15} : {1:c2}", "Sous-total", facture.montantSousTotal);
        Console.WriteLine("-------------------------------------");

    }


    /// <summary>
    /// Affichage du total de la facture
    /// </summary>
    /// <param name="facture">Facture à afficher</param>
    static void AfficherFacture(Facture facture)
    {

        Console.WriteLine("\n\n====================================================");
        Console.WriteLine("Total de la facture");
        Console.WriteLine("======================================================");
        Console.WriteLine("{0,-15} : {1:c2}", "Appéritif", facture.prixApperitif);
        Console.WriteLine("{0,-15} : {1:c2}", "Entrée", facture.prixEntree);
        Console.WriteLine("{0,-15} : {1:c2}", "Plat principal", facture.prixPlat);
        Console.WriteLine("{0,-15} : {1:c2}", "Désert", facture.prixDessert);
        Console.WriteLine("{0,-15} : {1:c2}", "Boisson", facture.prixBoisson);
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("{0,-15} : {1:c2}", "Sous-total", facture.montantSousTotal);
        Console.WriteLine("{0,-15} : {1:c2}", "Taxes", facture.montantTaxes);
        Console.WriteLine("{0,-15} : {1:c2}", "Pourboire", facture.montantPourboire);
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("{0,-15} : {1:c2}", "Total", facture.montantTotal);
        Console.WriteLine("======================================================");

    }

    static decimal DemanderMontantDonne()
    {
        //Montant donné par le client
        Console.Write("\nVeuillez inscrire le montant donné par le client: ");
        return Convert.ToDecimal(Console.ReadLine());
    }

    static void AfficherMonnaie(decimal monnaie)
    {
        Console.WriteLine("Monnaie à rendre au client : {0:c2}", monnaie);
    }

   

    /// <summary>
    /// Cacul le sous-total d'une facture
    /// </summary>
    /// <param name="facture">Facture dont le sous-total doit être calculé</param>
    /// <returns>Montant du sous-total</returns>
    public static decimal CalculerSousTotal(Facture facture)
    {
        decimal sousTotal = facture.prixApperitif + facture.prixEntree + facture.prixPlat + facture.prixDessert + facture.prixBoisson;

        return sousTotal;
    }

    /// <summary>
    /// Calcul le pourboire d'une facture
    /// </summary>
    /// <param name="facture">Facture sur laquelle le pourboire est calculé</param>
    /// <returns>Montant du pourboire</returns>
    public static decimal CalculerPourboire(Facture facture)
    {
        return facture.montantSousTotal * (decimal)TAUX_POURBOIRE;
    }

    /// <summary>
    /// Calcule la taxe d'une facture
    /// </summary>
    /// <param name="facture">Facture sur laquelle la taxe doit être calculée</param>
    /// <returns>Montant de la taxe</returns>
    public static decimal CalculerTaxes(Facture facture)
    {
        return facture.montantSousTotal * (decimal)TAUX_TAXES;
    }

    /// <summary>
    /// Calcul le total d'une facture
    /// </summary>
    /// <param name="facture">Facture dont le total est à calculé</param>
    /// <returns>Montant total de la facture</returns>
    public static decimal CalculerTotal(Facture facture)
    {
        return facture.montantSousTotal + facture.montantTaxes + facture.montantPourboire;
    }

    /// <summary>
    /// Calcule la monaie à rentre à un client selon le montant donné et le total d'une facture
    /// </summary>
    /// <param name="facture">Facture du client</param>
    /// <param name="montantDonne">Montant donné par le client</param>
    /// <returns>Monnaie à rendre au client</returns>
    public static decimal CalculerMonnaie(Facture facture, decimal montantDonne)
    {
        return montantDonne - facture.montantTotal;
    }

    /// <summary>
    /// Permet d'ajouter la facture à un nouveau tableau de facture
    /// </summary>
    /// <param name="factures">tableau contenant les factures</param>
    /// <param name="facture">facture à ajouter au tableau</param>
    /// <returns>Nouveau tableau contenant la facture ajoutée.</returns>
    public static Facture[] AjouterFacture(Facture[] factures, Facture facture)
    {
        Facture[] nouvellesFactures = new Facture[factures.Length + 1];

        for (int i = 0; i < factures.Length; i++)
        {
            nouvellesFactures[i] = factures[i];
        }

        nouvellesFactures[nouvellesFactures.Length - 1] = facture;

        return nouvellesFactures;
    }


}
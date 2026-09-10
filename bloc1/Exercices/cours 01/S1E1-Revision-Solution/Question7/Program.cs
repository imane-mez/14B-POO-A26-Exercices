using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-CA");

const string cheminFichier  = "C:\\data-420-14b-fx\\produits.csv";


Produit[] produits = ChargerProduits(cheminFichier);
AfficherProduits(produits);

Console.Write("Ajouter un produit ? (o/n): ");

if (Console.ReadKey().KeyChar == 'o')
{
    Console.Write("\nNom: ");
    string nom = Console.ReadLine() ?? "";

    Console.Write("\nQuantité (entier ≥ 0): ");
    uint qte = uint.Parse(Console.ReadLine());

    Console.Write("\nPrix (≥ 0): ");
    decimal prix = decimal.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

    produits = AjouterProduit(produits, nom, qte, prix);

    SauvegarderProduits(cheminFichier, produits);
    Console.WriteLine($"Sauvegardé vers: {cheminFichier}");
}




static Produit[] ChargerProduits(string chemin)
{
   
    string contenuFichier;

    //Ouverture du fichier
    using (StreamReader sr = new StreamReader(chemin))
    {
        // Lecture de l'ensemble du fichier en une seule instruction.
        contenuFichier = sr.ReadToEnd();
    }

    // Retrait des "carriage return" ('\r'), s'il y en a.
    contenuFichier = contenuFichier.Replace("\r", "");

    // Création d'un vecteur de chaînes de caractères contenant chaque ligne individuellement.
    String[] lignes = contenuFichier.Split('\n');

    Produit[] produits;

    //Vérification si la dernière ligne est vide et création du vecteur de produits.
    //On ignore également la première ligne qui contient les en-têtes.
    if (lignes[lignes.Length - 1] == "")
        produits = new Produit[lignes.Length - 2];
    else
        produits = new Produit[lignes.Length - 1];

    //Parcours des lignes pour créer les produits dans le vecteur
    for (int i = 0; i < produits.Length; i++)
    {
        string[] champs = lignes[i+1].Split(';');

        produits[i].Nom = champs[0];
        produits[i].Quantite = uint.Parse(champs[1]);
        produits[i].Prix = decimal.Parse(champs[2]);
    }

    return produits;
}

static void AfficherProduits(Produit[] produits)
{
    Console.WriteLine("=== PRODUITS ===");
    Console.WriteLine("{0,-20} {1,8} {2,10}", "Nom", "Quantité", "Prix");
    for (int i = 0; i < produits.Length; i++)
    {
        var p = produits[i];
        Console.WriteLine("{0,-20} {1,8} {2,10:C}", p.Nom, p.Quantite, p.Prix);
    }
    Console.WriteLine("================\n");
}


/// Saisir un produit depuis la console.
static Produit[] AjouterProduit(Produit[] produits, string nom, uint quantite, decimal prix )
{
    Produit[] nouveauxProduits = new Produit[produits.Length + 1];

    for (int i = 0; i < produits.Length; i++)
        nouveauxProduits[i] = produits[i];

    nouveauxProduits[nouveauxProduits.Length - 1].Nom = nom;
    nouveauxProduits[nouveauxProduits.Length - 1].Quantite = quantite;
    nouveauxProduits[nouveauxProduits.Length - 1].Prix = prix;
    return nouveauxProduits;

}

/// Sauvegarder les produits dans un fichier CSV.
static void SauvegarderProduits(string chemin, Produit[] produits)
{
    using (StreamWriter sw = new StreamWriter(chemin, false))
    {
        sw.WriteLine("Nom;Quantite;Prix");
        for (int i = 0; i < produits.Length; i++)
        {
            var p = produits[i];
            sw.WriteLine($"{p.Nom};{p.Quantite};{p.Prix}");
        }
    } // <- fermeture automatique de sw ici
}


/// Structure représentant un produit.
public struct Produit
{
    public string Nom;
    public uint Quantite;
    public decimal Prix;
}



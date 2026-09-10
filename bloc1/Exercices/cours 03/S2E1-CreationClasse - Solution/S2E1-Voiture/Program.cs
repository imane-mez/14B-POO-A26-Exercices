using S2E1_Voiture;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tests d'utilisation de la classe Voiture");

        //Création d'une voiture
        Voiture voiture1 = new Voiture("Honda", "Civic", "Rouge", 1999, 150000f);

        //Affichage des propriétés de la voiture
        AfficherVoiture(voiture1);

        //On vérifie s'il est possible de ralentir en bas 0 km/h!
        voiture1.Ralentir();

        //Affichage des propriétés de la voiture
        Console.WriteLine("\nTest d'un ralentissement sous 0 km/h :");
        AfficherVoiture(voiture1);

        //On vérifie s'il est possible d'accélérer
        voiture1.Accelerer();

        Console.WriteLine("\nTest d'une accélération de 5 km/h");
        //Affichage des propriétés de la voiture
        AfficherVoiture(voiture1);

        //On accélère jusqu'à la vitesse maximale
        while (voiture1.Vitesse < Voiture.VITESSE_MAX)
        {
            voiture1.Accelerer();
        }

        Console.WriteLine("\nSi la voiture a atteint la vitesse maximale ({0})", Voiture.VITESSE_MAX);
        //Affichage des propriétés de la voiture
        AfficherVoiture(voiture1);


        //On vérifie s'il est possible pour une voiture de dépasser la vitesse maximale
        voiture1.Accelerer();

        Console.WriteLine("\nTest d'une accélération dépassant la vitesse maximale({0})", Voiture.VITESSE_MAX);
        //Affichage des propriétés de la voiture
        AfficherVoiture(voiture1);
    }

    static void AfficherVoiture(Voiture voiture)
    {
        Console.WriteLine("\nMarque : {0}\nModèle : {1}\nAnnée : {2}\nCouleur : {3}\nKilométrage : {4:f2}\nVitesse : {5} km/h", voiture.Marque, voiture.Modele, voiture.Annee, voiture.Couleur, voiture.Kilometrage, voiture.Vitesse);
    }
}
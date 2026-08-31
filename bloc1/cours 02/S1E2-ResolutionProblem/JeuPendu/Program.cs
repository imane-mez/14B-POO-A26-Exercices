using JeuPendu;
using System.Net;
using System.Numerics;

internal class Program
{
    //constantes
    const string CHEMIN_FICHIER = @"C:\data-420-14B-FX\mots.txt";
    const byte NB_ESSAIS_MAX = 6;

    private static void Main(string[] args)
    {

        //sélection du mot aléatoire
        string mot = ChoisirMot(CHEMIN_FICHIER);

        Joueur joueur;

        //Création du vecteur contenant les lettres trouvées par l'utilisateur
        joueur.vectLettresTrouvees = new char[mot.Length];

        //byte nbEssais = 0;
        joueur.nbEssais = 0;

        Boolean motTrouve = false;

        //string lettresUtilisees = "";
        joueur.lettresUtilisees = "";
        do
        {

            AfficherLettresTrouvees(joueur.vectLettresTrouvees);
            Console.WriteLine("\nLettres utilisées: " + joueur.lettresUtilisees);
            Console.WriteLine("Nombre d'essais restant : {0}", NB_ESSAIS_MAX - joueur.nbEssais);

            char lettre = DemanderLettre(joueur.lettresUtilisees);

            //Ajout de la lettre choisie aux lettres utilisées
            //lettresUtilisees += lettre;
            joueur.lettresUtilisees += lettre;

            //Vérification si la lettre existe dans le mot
            if (mot.Contains(lettre))
            {

                // Ajout de la lettre aux positions correspondantes dans le mot du vecteur de lettres trouvées
                joueur.vectLettresTrouvees = AjouterLettreTrouvees(mot, lettre, joueur.vectLettresTrouvees);

                //Vérification si le mot a été trouvé.
                motTrouve = VerifierMot(mot, joueur.vectLettresTrouvees);
            }
            else
                //Modification du nombre d'essai
                joueur.nbEssais++;


        } while (!motTrouve && joueur.nbEssais < NB_ESSAIS_MAX);

        if (motTrouve)
            Console.WriteLine($"\n\nFéliciation! Vous avez trouvé le mot en {joueur.nbEssais} essai(s).");
        else
            Console.WriteLine($"\n\nDésolé! Meilleure chance la prochaine fois. Le mot était : {mot}");

    }

    /// <summary>
    /// Affiche les lettres trouvées dans le mot.
    /// </summary>
    /// <param name="vectLettresTrouvees">vecteur contenant les lettres trouvées.</param>
    static void AfficherLettresTrouvees(char[] vectLettresTrouvees)
    {
        Console.Write("\nLe mot à découvrir est : ");
        for (int i = 0; i < vectLettresTrouvees.Length; i++)
        {
            if (vectLettresTrouvees[i] == '\0') // permet de vérifier si une case est vide.
                Console.Write("{0,-2}", "_");
            else
                Console.Write("{0,-2}", vectLettresTrouvees[i]);
        }
        Console.WriteLine("");
    }

    /// <summary>
    /// Demander à l'utilisateur de saisir une lettre qui n'a pas déjà été utiliée.
    /// </summary>
    /// <param name="lettresUtilisees">Chaîne contenant les lettres déjà utilisées</param>
    /// <returns>Le lettre choisie</returns>
    static char DemanderLettre(string lettresUtilisees)
    {
        Boolean dejaUtilisee;
        char lettre;

        do
        {
            Console.Write("\nVeuillez saisir une lettre : ");

            lettre = Console.ReadKey().KeyChar;


            //Vérification si la lettre fournie par l'utilisateur a déjà été utilisée.
            dejaUtilisee = lettresUtilisees.Contains(lettre);

            if (dejaUtilisee)
                Console.WriteLine("\nVous avez déja utilisé cette lettre!");


        } while (dejaUtilisee);

        return lettre;
    }


    /// <summary>
    /// Permet de lire un fichier et de retourner chaque mots
    /// contenu dans le fichier dans un vecteur de chaînes de caractères
    /// </summary>
    /// <param name="cheminFichier">Chemin d'accès au fichier</param>
    /// <returns>Vecteur de chaînes de caractères représentant les mots du fichier</returns>
    public static string[] LireFichier(string cheminFichier)
    {
        //Ouverture du fichier
        string contenuFichier = "";
        using (StreamReader fichierLecture = new StreamReader(cheminFichier))
        { 
            // Lecture de l'ensemble du fichier en une seule instruction.
            contenuFichier = fichierLecture.ReadToEnd();
        }

        // Retrait des "carriage return" ('\r'), s'il y en a.
        contenuFichier = contenuFichier.Replace("\r", "");

        // Création d'un vecteur de chaînes de caractères contenant chaque mot individuellement.
        String[] vectLignes = contenuFichier.Split(' ');


        return vectLignes;


    }

    /// <summary>
    /// Choisi un mot aléatoire contenu dans un fichier texte.
    /// </summary>
    /// <param name="cheminFichier">Chemin du fichier contenant les mots</param>
    /// <returns>Le mot sélectionné</returns>
    static public string ChoisirMot(string cheminFichier)
    {
        //On obtient les mots contenus dans le fichier
        string[] vectMots = LireFichier(cheminFichier);

        //On obtient une position aléatoire pour la sélection du mot dans le vecteur
        Random aleatoire = new Random();
        int index = aleatoire.Next(0, vectMots.Length);

        return vectMots[index];
    }

    /// <summary>
    /// Vérifie si une lettre existe dans un mot.
    /// </summary>
    /// <param name="mot">Mot contenant la lettre</param>
    /// <param name="lettre">Lettre à vérifier</param>
    /// <returns>True ou fals indiquant si la lettre est trouvée</returns>
    static public bool VerifierLettre(string mot, char lettre)
    {
        //Retourne un booléen indiquant is la lettre existe dans le mot
        return mot.Contains(lettre);
    }

    /// <summary>
    /// Permet d'ajouter une lettre trouvé au bon endroit dans le vecteur de lettre.
    /// </summary>
    /// <param name="mot">Mot à découvrir</param>
    /// <param name="lettre">lettre trouvée</param>
    /// <param name="vectLettresTrouvees">vecteur contenant les lettres trouvées</param>
    /// <returns></returns>
    static public char[] AjouterLettreTrouvees(string mot, char lettre, char[] vectLettresTrouvees)
    {
        //Ajout de la lettre aux positions correspondantes dans le mot du vecteur de lettres trouvées
        for (int i = 0; i < mot.Length; i++)
        {
            if (mot[i] == lettre)
            {
                vectLettresTrouvees[i] = lettre;
            }
        }

        return vectLettresTrouvees;
    }

    /// <summary>
    /// vérifie si le mot a été trouvé`.
    /// </summary>
    /// <param name="mot">Mot à comparer</param>
    /// <param name="vectLettresTrouves">Vecteur de lettres trouvées par l'utilisateur</param>
    /// <returns></returns>
    static public bool VerifierMot(string mot, char[] vectLettresTrouves)
    {
        Boolean trouve = true;
        int i = 0;

        //On compare les lettres trouvées à celles du mot caché tant qu'il sont identique
        //et que nous n'avons pas comparé toutes les lettres.
        do
        {
            //On vérifie la correspondance entre les lettres trouvés et celles du mot à la même position.
            if (mot[i] != vectLettresTrouves[i])
            {
                trouve = false;
            }

            i++;

        } while (trouve && i < vectLettresTrouves.Length);

        return trouve;
    }

}
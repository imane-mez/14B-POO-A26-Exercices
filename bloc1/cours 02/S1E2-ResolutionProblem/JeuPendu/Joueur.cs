
namespace JeuPendu
{
    public struct Joueur
    {
        //Contient le nombre d'essais réalisés par le joueur
        public byte nbEssais;

        //Contient les lettres utilisées par le joueur
        public string lettresUtilisees;

        //contient les lettres du mot trouvé par le joueur
        public char[] vectLettresTrouvees;

    }
}

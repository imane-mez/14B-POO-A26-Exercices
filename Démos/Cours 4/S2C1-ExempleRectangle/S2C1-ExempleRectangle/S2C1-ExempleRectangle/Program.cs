namespace S2C1_ExempleRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exempl d'utilisation d'un objet de type Rectangle");

            //Déclaration
            Rectangle rect1;

            //Instanciation de l'objet
            rect1 = new Rectangle();

            Console.WriteLine("Rectangle avec constructeur par défaut :");
            AfficherRectangle(rect1);

            //Affectation de valeurs à l'objet
            rect1.Hauteur = 10;
            rect1.Largeur = 20;
            rect1.Couleur = "Rouge";


            //Affichage des valeurs de l'objet
            Console.WriteLine("Caractéristiques de rectangle rect1 :");
            AfficherRectangle(rect1);

            //Création d'un autre rètangle avec le consrtructeur paramétré
            Rectangle rect2 = new Rectangle(5, 15, "Vert");

            //Affichage des valeurs de l'objet
            AfficherRectangle(rect1);
        }

        /// <summary>
        /// Méthode permettant d'afficher les caractéristiques d'un rectangle
        /// </summary>
        /// <param name="rectangle">Objet rectangle à afficher</param>
        private static void AfficherRectangle(Rectangle rectangle)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"hauteur : {rectangle.Hauteur}");
            Console.WriteLine($"Largeur : {rectangle.Largeur}");
            Console.WriteLine($"Couleur : {rectangle.Couleur}");
            Console.WriteLine($"Périmètre : {rectangle.Perimetre}");
            Console.WriteLine($"Aire : {rectangle.Aire}");
            Console.WriteLine("====================================\n\n");

        }
    }
}

namespace DemoEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemples d'utilisation d'un enum");

            //Écriture du nom d'un enum
            Console.WriteLine(Categorie.Film);

            //Écriture de la valeur d'un énum
            byte valEnum = (byte)Categorie.Film;
            Console.WriteLine(valEnum);

            //Affectation d'un enum à une variable du même type.
            Categorie categorie;
            categorie = Categorie.Film;
            Console.WriteLine(categorie);

            //Affichage du nom du enum ayant la valeur 11
            Console.WriteLine(Enum.GetName(typeof(Categorie), 11));


            //Obtenir la liste des noms du enum.
            string[] vectCategories = Enum.GetNames(typeof(Categorie));

            for (int i = 0; i < vectCategories.Length; i++)
            {
                Console.WriteLine($"{vectCategories[i]}");
            }
        }
    }
}

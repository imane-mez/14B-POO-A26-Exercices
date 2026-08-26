using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Configure l'encodage de la console en UTF-8 pour les accents.
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Congigure la culture courante en Français (Canada) pour utiliser la virgule comme séparateur de décimal
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-CA");

        Console.Write("Prénom: ");
        string prenom = Console.ReadLine() ?? "";

        Console.Write("Âge (entier): ");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.Write("Taille en mètres (ex: 1,75): ");

        // Utilise la culture courante pour parser le nombre à virgule flottante
        float tailleM = float.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

        Console.WriteLine($"Bonjour {prenom}, vous avez {age} ans et mesurez {tailleM:F2} m.");
        float tailleCm = tailleM * 100.0f;

        Console.WriteLine($"Taille en centimètres: {tailleCm:F2} cm");

        
    }
}

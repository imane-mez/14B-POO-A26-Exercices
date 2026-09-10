
Console.Write("Entrez un nombre entier: ");
int n = int.Parse(Console.ReadLine() ?? "");

if (n > 0) 
    Console.WriteLine("Positif");
else if (n < 0) 
    Console.WriteLine("Négatif");
else 
    Console.WriteLine("Zéro");

Console.WriteLine(n % 2 == 0 ? "Pair" : "Impair");

if (n >= 1 && n <= 10) 
    Console.WriteLine("Petit");
else if (n >= 11 && n <= 100) 
    Console.WriteLine("Moyen");
else if (n > 100) 
    Console.WriteLine("Grand");
else 
    Console.WriteLine("Hors catégorie (<= 0)");
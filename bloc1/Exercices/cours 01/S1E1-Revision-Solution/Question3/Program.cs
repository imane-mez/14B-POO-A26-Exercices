const int N = 10;
int somme = 0;
int max = 0; 

for (int i = 1; i <= N; i++)
{
    int val;
    do
    {
        Console.Write($"Saisir l'entier #{i} (>= 0): ");
        val = int.Parse(Console.ReadLine());
        if (val < 0)
            Console.WriteLine("La valeur doit être >= 0. Réessayez.");
    }
    while (val < 0);

    somme += val;
    if (val > max) 
        max = val;
}

double moyenne = (double) somme / N;

Console.WriteLine($"Somme = {somme}, Moyenne = {moyenne:F2}, Max = {max}");

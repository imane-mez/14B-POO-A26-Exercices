using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-CA");

const int N = 5;
double[] notes = new double[N];

for (int i = 0; i < N; i++)
{
    double val;
    do
    {
        Console.Write($"Veuillez saisir la note #{i + 1} : ");
        val = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

        if (val < 0 || val > 100)
            Console.WriteLine("La note doit être entre 0 et 100. Réessayez.");
    }
    while (val < 0 || val > 100);

    notes[i] = val;
}

double somme = 0;
double min = double.MaxValue, max = double.MinValue;

for (int i = 0; i < N; i++)
{
    double n = notes[i];
    somme += n;

    if (n < min) 
        min = n;

    if (n > max) 
        max = n;
}

double moyenne = somme / N;

Console.WriteLine($"Moyenne = {moyenne:F2} | Min = {min:F2} | Max = {max:F2}");

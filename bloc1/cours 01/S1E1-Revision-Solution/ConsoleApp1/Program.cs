using System.Globalization;


CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-CA");

const int N = 3;
Livre[] livres = new Livre[N];

for (int i = 0; i < N; i++)
{
    Console.Write($"/nTitre du livre #{i + 1}: ");
    string titre = Console.ReadLine() ?? "";    // ?? : opérateur de coalescence de Null

    Console.Write($"Auteur du livre #{i + 1}: ");
    string auteur = Console.ReadLine() ?? "";

    Console.Write($"Prix du livre #{i + 1}: ");
    decimal prix = decimal.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

    livres[i].Titre = titre;
    livres[i].Auteur = auteur;
    livres[i].Prix = prix;
}

int indexMax = 0;
for (int i = 1; i < N; i++)
{
    if (livres[i].Prix > livres[indexMax].Prix)
        indexMax = i;
}
    
var plusCher = livres[indexMax];
Console.WriteLine($"Le plus cher: \"{plusCher.Titre}\" de {plusCher.Auteur} à {plusCher.Prix:C}");

public struct Livre
{
    public string Titre;
    public string Auteur;
    public decimal Prix;
}

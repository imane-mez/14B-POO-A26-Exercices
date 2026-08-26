Console.Write("Entrez une phrase : ");

string chaine = Console.ReadLine();


// Nombre de comparaisons à effectuer dans le pire des cas.
int nbComp = chaine.Length / 2;

bool estPalindrome = true;
int indice = 0;

do
{
    if (chaine[indice] != chaine[chaine.Length - indice - 1])
        estPalindrome = false;

    indice++;
} while (estPalindrome && indice < nbComp);


if (estPalindrome)
    Console.WriteLine("C'est un palindrome");
else
    Console.WriteLine("Ce n'est pas un palindrome");

Console.ReadKey();
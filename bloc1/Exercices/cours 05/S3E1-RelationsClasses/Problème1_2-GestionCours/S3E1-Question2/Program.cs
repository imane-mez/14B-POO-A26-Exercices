namespace S3E1_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez inscrire votre nom : ");
            string nom = Console.ReadLine();

            Console.Write("\nVeuillez inscrire votre nom : ");
            string prenom = Console.ReadLine();

            Professeur professeur = new Professeur(nom, prenom);

            Console.Write("\nCombien de cours désirez-vous saisir ?");

            byte nbCours = Convert.ToByte(Console.ReadLine());

            GestionCours gestionCours = new GestionCours(nbCours);

            for (int i = 0; i < gestionCours.Cours.Length; i++)
            {
                Console.Write($"\nVeuillez inscire le code du cours {i + 1} : ");
                string code = Console.ReadLine();

                Console.Write($"\nVeuillez inscire le titre du cours {i + 1} : ");
                string titre = Console.ReadLine();

                Console.Write($"\nVeuillez inscire le nombre de crédit du cours {i + 1} : ");
                byte nbCredits = Convert.ToByte(Console.ReadLine());

                Console.Write($"\nVeuillez saisire le nombre d'évaluation du cours {i + 1}: ");
                byte nbEvaluations = Convert.ToByte(Console.ReadLine());

                Console.Write($"\nVeuillez saisire le nombre d'étudiants inscrit au cours {i + 1}: ");
                byte nbEtudiants = Convert.ToByte(Console.ReadLine());

                gestionCours.Cours[i] = new Cours(code, titre, nbCredits, professeur, nbEtudiants, nbEvaluations);

                for (int j = 0; j < gestionCours.Cours[i].Etudiants.Length; j++)
                {

                    Console.Write("\nVeuillez saisire le numéro de DA de l'étudiant : ");
                    ushort noDA = ushort.Parse(Console.ReadLine());

                    Console.Write("\nVeuillez saisire le nom de l'étudiant : ");
                    string nomEtudiant = Console.ReadLine();

                    Console.Write("\nVeuillez saisire le prénom de l'étudiant : ");
                    string prenomEtudiant = Console.ReadLine();


                    Etudiant etudiant = new Etudiant(noDA, nomEtudiant, prenomEtudiant, gestionCours.Cours[i].NbEvaluations);

                    for (int k = 0; k < etudiant.Notes.Length; k++)
                    {
                        Console.Write($"\nVeuillez saisire la note pour l'évaluation {k + 1} : ");
                        etudiant.Notes[k] = float.Parse(Console.ReadLine());
                    }



                    gestionCours.Cours[i].Etudiants[j] = etudiant;

                }
            }


            ///Afficage des moyennes du groupe pour chaque évaluation du cours à l'indice 0 :
            for (int i = 0; i < gestionCours.Cours[0].NbEvaluations; i++)
            {
                Console.Write($"\nMoyenne du groupe pour l'évaluation {i + 1} : {gestionCours.Cours[0].CalculerMoyenEvaluation((byte)i)}");
            }

            //Affichage de la moyenne de l'étudiant à l'indice 0 dans le cours  à l'indice 0
            Console.WriteLine($"\nVoici la moyenne pour l'étudiant {gestionCours.Cours[0].Etudiants[0].NoDA} : {gestionCours.Cours[0].Etudiants[0].Moyenne}");

            //Affichage de l'étudiant à l'indice 0
            Console.WriteLine($"\nVoici la note finale pour l'étudiant {gestionCours.Cours[0].Etudiants[0].NoDA} : {gestionCours.Cours[0].Etudiants[0].Moyenne}");


        }
    }
}

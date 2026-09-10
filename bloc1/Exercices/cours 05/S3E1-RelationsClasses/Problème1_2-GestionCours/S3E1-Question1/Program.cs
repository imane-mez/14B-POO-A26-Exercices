namespace S3E1_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez inscrire votre nom : ");
            string nom = Console.ReadLine();

            Console.Write("\nVeuillez inscrire votre prénom : ");
            string prenom = Console.ReadLine();

            Professeur professeur = new Professeur(nom, prenom);


            Console.Write($"\nVeuillez inscire le code du cours : ");
            string code = Console.ReadLine();

            Console.Write($"\nVeuillez inscire le titre du cours : ");
            string titre = Console.ReadLine();

            Console.Write($"\nVeuillez inscire le nombre de crédit du cours : ");
            byte nbCredits = Convert.ToByte(Console.ReadLine());

            Console.Write($"\nVeuillez saisire le nombre d'évaluation du cours : ");
            byte nbEvaluations = Convert.ToByte(Console.ReadLine());

            Console.Write($"\nVeuillez saisire le nombre d'étudiants inscrit au cours : ");
            byte nbEtudiants = Convert.ToByte(Console.ReadLine());


            Cours cours = new Cours(code, titre, nbCredits, professeur, nbEtudiants, nbEvaluations);



            for (int i = 0; i < cours.Etudiants.Length; i++)
            {

                Console.Write("Veuillez saisire le numéro de DA de l'étudiant : ");
                ushort noDA = ushort.Parse(Console.ReadLine());

                Console.Write("Veuillez saisire le nom de l'étudiant : ");
                string nomEtudiant = Console.ReadLine();

                Console.Write("Veuillez saisire le prénom de l'étudiant : ");
                string prenomEtudiant = Console.ReadLine();


                Etudiant etudiant = new Etudiant(noDA, nomEtudiant, prenomEtudiant, cours.NbEvaluations);

                for (int j = 0; j < etudiant.Notes.Length; j++)
                {
                    Console.Write($"\nVeuillez saisir la note pour l'évaluation {j + 1} : ");
                    etudiant.Notes[j] = float.Parse(Console.ReadLine());
                }

                cours.Etudiants[i] = etudiant;

            }

            ///Afficage des moyennes du groupe pour chaque évalation :
            for (int i = 0; i < cours.NbEvaluations; i++)
            {
                Console.Write($"\nMoyenne du groupe pour l'évaluation {i + 1} : {cours.CalculerMoyenEvaluation((byte)i)}");
            }

            //Affichage de la moyenen de l'étudiant 1
            Console.WriteLine($"\nVoici la moyenne pour l'étudiant {cours.Etudiants[0].NoDA} : {cours.Etudiants[0].Moyenne}");

            //Affichage de l'étudiant 1
            Console.WriteLine($"\nVoici la note finale pour l'étudiant {cours.Etudiants[0].NoDA} : {cours.Etudiants[0].NoteFinale}");


        }
    }
}

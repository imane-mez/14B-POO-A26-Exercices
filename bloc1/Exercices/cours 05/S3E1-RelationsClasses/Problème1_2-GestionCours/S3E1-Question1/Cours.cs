
using System.ComponentModel;

namespace S3E1_Question1
{
    /// <summary>
    /// Classe représenant un cours
    /// </summary>
    class Cours
    {
      

        /// <summary>
        /// Nombre d'étudiants pouvant s'inscrire dans un cours
        /// </summary>
        public const byte NB_ETUDIANTS_MAX = 5;


        /// <summary>
        /// Nombre d'évaluation minimum pour un cours
        /// </summary>
        public const byte NB_EVALUATIONS_MIN = 1;
        

        /// <summary>
        /// Nombre de caractères maximum pour le code du cours
        /// </summary>
        public const byte CODE_NB_CARACT = 5;

        /// <summary>
        /// Nombre de crédits maximum pour un cours
        /// </summary>
        public const byte NB_CREDIT_MAX = 5;


        /// <summary>
        /// Nombre de crédits minimum pour un cours
        /// </summary>
        public const byte NB_CREDITS_MIN = 1;


        /// <summary>
        /// Code du cours
        /// </summary>
        private string _code;

        /// <summary>
        /// Titre du cours
        /// </summary>
        private string _titre;

        /// <summary>
        /// Nombres de crédits
        /// </summary>
        private byte _nbCredits;


        /// <summary>
        /// Professeur responsable du cours
        /// </summary>
        private Professeur _professeur;

        /// <summary>
        /// Liste des étudiants inscrits au cours
        /// </summary>
        private Etudiant[] _etudiants;


        /// <summary>
        /// Nombre d'évaluation dans le cours
        /// </summary>
        private byte _nbEvaluation;

    

        /// <summary>
        /// Obtient ou défini code du cours
        /// </summary>
        public string Code
        {
            get { return _code; }
            private set 
            { 
                //Validation si le code n'est pas vide ou null et contient le minimum de caractères
                if(!string.IsNullOrEmpty(value) && value.Trim().Length == CODE_NB_CARACT)
                    _code = value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// titre du cours
        /// </summary>
        public string Titre
        {
            get { return _titre; }
            private set {
                //Validation si le code n'est pas vide ou null ou ne contient que des espaces
                if (!string.IsNullOrWhiteSpace(value))
                    _titre = value.Trim(); 
            }
        }

        /// <summary>
        /// Obtient ou défini le nombre de crédits
        /// </summary>
        public byte NbCredits
        {
            get { return _nbCredits; }
            private set { 
                //Validation du nombre de crédit minimum.
                if(value >= NB_CREDITS_MIN)
                    _nbCredits = value; 
            }
        }

        /// <summary>
        /// Obtien ou définit le professeur responsable du cours
        /// </summary>
        public Professeur Professeur
        {
            get { return _professeur; }
            private set {
                
                //Validation si le professeur n'est pas null
                if(_professeur != null)
                    _professeur = value; 
            }
        }


        /// <summary>
        /// Liste des étudiants inscrits à un cours
        /// </summary>
        public Etudiant[] Etudiants
        {
            get { return _etudiants; }
            set {

                //Validation que le vecteur d'étudiants ne dépasse pas le maximum d'étudiant
                if(value.Length <= NB_ETUDIANTS_MAX)
                    _etudiants = value; 
            }
        }

        /// <summary>
        /// Obtient ou défini le nombre d'évaluation dans le cours
        /// </summary>
        public byte NbEvaluations
        {
            get { return _nbEvaluation; }
            private set {

                //Validation sur le nombre minimum d'évaluation 
                if (value >= NB_EVALUATIONS_MIN)
                    _nbEvaluation = value; 
            }

        }

        /// <summary>
        /// Permet de créer un cours
        /// </summary>
        /// <param name="code">Code du cours</param>
        /// <param name="titre">Titre du cours</param>
        /// <param name="nbCredits">Nombre de crédits du cours</param>
        /// <param name="professeur">Professeurs qui donne le cours</param>  
        /// <param name="nbEtudiants">Nombre d'étudiants inscrit dans le cours</param>
        /// <param name="nbEvaluations" ="nbEvaluations>Nombre d'évaluation dans le cours </param>
        /// 
        public Cours(string code, string titre, byte nbCredits, Professeur professeur, byte nbEtudiants = NB_ETUDIANTS_MAX, byte nbEvaluations = NB_EVALUATIONS_MIN)
        {
            Code = code;
            Titre = titre;
            NbCredits = nbCredits;
            Professeur = Professeur;
            Etudiants = new Etudiant[nbEtudiants];
            NbEvaluations = nbEvaluations;

        }

        /// <summary>
        /// Permet de calculer la moyenne du groupe pour une évaluation
        /// </summary>
        /// <param name="evaluation">Indice (base 0) de l'évaluation pour laquelle nous désirons obtenir la moyenne</param>
        /// <returns>La moyenne du groupe pour l'évaluation spécifiée.</returns>
        public float CalculerMoyenEvaluation(byte evaluation)
        {
            float totalNotes = 0;

            if (Etudiants.Length > 0)
            {
                for (int i = 0; i < Etudiants.Length; i++)
                {
                    totalNotes += Etudiants[i].Notes[evaluation];
                }

                return totalNotes / Etudiants.Length;
            }
            return 0;

        }

        /// <summary>
        /// Permet de calculer la moyenne finale du groupe
        /// </summary>
        /// <returns>Moyenne du groupe</returns>
        public float CalculerMoyenneFinale()
        {
            float totalNoteFinale = 0;

            if (Etudiants.Length > 0)
            {
                for (int i = 0; i < Etudiants.Length; i++)
                {
                    totalNoteFinale += Etudiants[i].NoteFinale;
                }

                return totalNoteFinale / Etudiants.Length;
            }

            return 0;
        }


    }
}

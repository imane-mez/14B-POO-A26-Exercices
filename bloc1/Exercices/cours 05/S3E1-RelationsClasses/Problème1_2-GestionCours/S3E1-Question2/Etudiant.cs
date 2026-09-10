using System;
using System.Collections.Immutable;


namespace S3E1_Question2
{
    class Etudiant
    {

        public const int NO_DA_NB_CARACT = 7;      
        
        /// <summary>
        /// Numéro de DA de l'étudiant
        /// </summary>
        private ushort _noDA;

        /// <summary>
        /// Nom de l'étudiant
        /// </summary>
        private string _nom;

        /// <summary>
        /// Prénom de l'étudiant
        /// </summary>
        private string _prenom;

        /// <summary>
        /// Notes de l'étudiant.
        /// </summary>
        private float[] _notes;



        /// <summary>
        /// Numéro de DA de l'étudiant
        /// </summary>
        public ushort NoDA
        {
            get { return _noDA; }
           private set 
            {
                //Validation du nombre de chiffre minimum dans le numéro de DA
                if(value.ToString().Length == NO_DA_NB_CARACT)    
                    _noDA = value; 
            }
        }

       
        /// <summary>
        /// Nom de l'étudiant
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            private set 
            { 
                //Validation si le nom n'est pas null, vide ou ne contient que des espaces
                if(!String.IsNullOrWhiteSpace(value)) 
                    _nom = value.Trim(); 
            }
        }

      
        /// <summary>
        /// Prénom de l'étudiant
        /// </summary>
        public string Prenom
        {
            get { return _prenom; }
            private set {

                //Validation si le nom n'est pas null, vide ou ne contient que des espaces
                if (!String.IsNullOrEmpty(value))
                    _prenom = value.Trim(); 
            }
        }

     
        /// <summary>
        /// Notes de l'étudiant
        /// </summary>
        public float[] Notes
        {
            get { return _notes; }
            private set { _notes = value; }
        }

       
        /// <summary>
        /// Moyenne de l'étudiant
        /// </summary>
        public float Moyenne
        {
            get {

                return CalculerMoyenne();
            }
            
        }

    
        /// <summary>
        /// Note finale de l'étudiant
        /// </summary>
        public float NoteFinale
        {
            get {
                return CalculerNoteFinale();
            }
         
        }

        /// <summary>
        /// Consructeur pour créer un étudiant
        /// </summary>
        /// <param name="noDA">Numéro de DA</param>
        /// <param name="nom">Nom</param>
        /// <param name="prenom">Prénom</param>
        public Etudiant(ushort noDA, string nom, string prenom, byte nbEvaluations)
        {
            NoDA = noDA;
            Nom = nom;
            Prenom = prenom;

            //Initialisation du vecteurs de notes selon la valeur de la constante.
            Notes = new float[nbEvaluations];
           

        }

        

        /// <summary>
        /// Calcul la note finale d'un étudiant
        /// </summary>
        /// <returns></returns>

        private float CalculerNoteFinale()
        {
            float sommeNotes = 0;

            for (int i = 0; i < this.Notes.Length; i++)
            {
                sommeNotes += Notes[i];
            }

            return sommeNotes;
        }


        /// <summary>
        /// Calcul la moyenne d'un étudiant
        /// </summary>
        /// <returns></returns>
        private float CalculerMoyenne()
        {
            float totalNotes = 0;

            if (Notes.Length > 0)
            {

                for (int i = 0; i < this.Notes.Length; i++)
                {
                    totalNotes += this.Notes[i];
                }

                return totalNotes / this.Notes.Length;
            }
            return 0;
        }

   
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace S3E1_Question2
{
    /// <summary>
    /// Classe représentant un professeur
    /// </summary>
    class Professeur
    {
   

  

        //Nom du professeur
        private string _nom;

        //Prenom du professeur
        private string _prenom;

        
     


       
        /// <summary>
        /// Obtient ou défini le nom du professeur
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            private set 
            { 
                if(!string.IsNullOrEmpty(value))
                    _nom = value.Trim() ; 
            }
        }

        /// <summary>
        /// Obtient ou défini le prénom du professeur
        /// </summary>
        public string Prenom
        {
            get { return _prenom; }
            private set 
            {
                if (!string.IsNullOrEmpty(value))
                    _prenom = value.Trim(); 
            }
        }


 

        public Professeur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }



 
    }
}

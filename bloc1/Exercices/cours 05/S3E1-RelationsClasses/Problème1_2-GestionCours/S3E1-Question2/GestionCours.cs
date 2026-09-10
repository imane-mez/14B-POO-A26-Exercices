using System;
using System.Collections.Generic;
using System.Text;

namespace S3E1_Question2
{
    /// <summary>
    /// Classe permettant la gestion des cours pour un professeur
    /// </summary>
    class GestionCours
    {

  


        /// <summary>
        /// Vecteur contenants les cours 
        /// </summary>
        private Cours[] cours;




  

        /// <summary>
        /// Obtient ou définit la liste des cours
        /// </summary>
        public Cours[] Cours
        {
            get { return cours; }
            set { cours = value; }
        }


  

     

        public GestionCours(byte nbCours)
        {
            //Instanciation du vecteurs contenant les cours
            Cours = new Cours[nbCours];
        }



    
        /// <summary>
        /// Pemert d'obtenir un cours faisant partie de la liste des cours à partir de son code.
        /// </summary>
        /// <param name="code">Code du cours</param>
        /// <returns>Le cours s'il existe dans la liste. Null s'il n'existe pas.</returns>
        public Cours RechercherCours(string code)
        {
            for (int i = 0; i < Cours.Length; i++)
            {
                if (Cours[i].Code.ToLower() == code.ToLower())
                    return cours[i];
            }

            return null;
        }

       
    }
}

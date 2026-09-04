using System;
using System.Collections.Generic;
using System.Text;

namespace S2C1_ExempleRectangle
{
    class Rectangle
    {
        
        public const int HAUTEUR_DEFAUT = 1; 
        public const int HAUTEUR_MIN = 1; 
        public const int HAUTER_MAX = 50; 
        public const int LARGEUR_DEFAUT = 2; 
        public const int LARGEUR_MIN = 1; 
        public const int LARGEUR_MAX = 50; 
        public const string COULEUR_DEFAUT = "Blanc"; 
        public const int COULEUR_NB_CARACTERES_MIN = 3; 
        public const int COULEUR_NB_CARACTERES_MAX = 25;
  

     

        /// <summary>
        /// Hauteur en cm du rectangle
        /// </summary>
        private float _hauteur;


        /// <summary>
        /// Largeur en cm du rectangle
        /// </summary>
        private float _largeur;

       
        /// <summary>
        /// Couleur du rectangle
        /// </summary>
        private string _couleur;

      

        /// <summary>
        /// Obtient ou définit la hauteur du rectangle
        /// </summary>
        public float Hauteur
        {
            get
            {
                return _hauteur;
            }

            set
            {
                if (value >= HAUTEUR_MIN && value <= HAUTER_MAX)
                    _hauteur = value;
            }
        }

        /// <summary>
        /// Obtient ou définit la largeur du rectangle
        /// </summary>
        public float Largeur
        {
            get
            {
                return _largeur;
            }

            set
            {
                if (value >= LARGEUR_MIN && value <= LARGEUR_MAX)
                    _largeur = value;
            }
        }

        /// <summary>
        /// Obtien ou défini la couleur du rectangle
        /// </summary>
        public string Couleur
        {
            get
            {
                return _couleur;
            }

            set
            {
                if (value.Length >= COULEUR_NB_CARACTERES_MIN && value.Length <= COULEUR_NB_CARACTERES_MAX)
                    _couleur = value.Trim();
            }
        }

        public float Perimetre
        {
            get
            {
                return CalculerPerimetre();
            }
        }

        public float Aire
        {
            get
            {
                return CalculerAire();
            }
        }
  
       

        /// <summary>
        /// Constructeur paramétré d'un rectangle
        /// </summary>
        /// <param name="hauteur">Hauteur en cm du rectangle</param>
        /// <param name="largeur">Largeur en cm du rectangle</param>
        /// <param name="couleur">Couleur en cm du rectangle</param>
        public Rectangle(int hauteur = HAUTEUR_DEFAUT, int largeur = LARGEUR_DEFAUT, string couleur = COULEUR_DEFAUT)
        {
            
            Hauteur = hauteur;
            Largeur = largeur;
            Couleur = couleur;
        }
       
        /// <summary>
        /// Calcul le périmètre du rectangle.
        /// </summary>
        /// <returns>Périmètre du rectangle</returns>
        private float CalculerPerimetre()
        {
            return (Hauteur * 2) + (Largeur * 2);
        }

        /// <summary>
        /// Calcul l'aire du rectangle
        /// </summary>
        /// <returns>L'air du rectangle</returns>
        private float CalculerAire()
        {
            return Hauteur * Largeur;
        }
    





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1_Voiture
{
    public class Voiture
    {
        /// <summary>
        /// Vitesse maximale pour une voiture
        /// </summary>
        public const uint VITESSE_MAX = 200;

        /// <summary>
        /// Vitesse de déplacement minimale pour une voiture
        /// </summary>
        public const uint VITESSE_DEPLACEMENT_MIN = 5;

        public const int VITESSE_INIT = 0;


        /// <summary>
        /// Marque de la voiture
        /// </summary>
        private string _marque;

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        private string _modele;

        /// <summary>
        /// Courleur de la voiture
        /// </summary>
        private string _couleur;

        /// <summary>
        /// Année de construction
        /// </summary>
        private ushort _annee;

        /// <summary>
        /// Kilométage
        /// </summary>
        private float _kilometrage;

        /// <summary>
        /// Vitesse actuelle de la voiture
        /// </summary>
        private uint _vitesse;

        /// <summary>
        /// Pour accéder à l'attribut _marque
        /// </summary>
        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }

        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public ushort Annee
        {
            get { return _annee; }
            set { _annee = value; }
        }

        public float Kilometrage
        {
            get { return _kilometrage; }
            set { _kilometrage = value; }
        }

        public uint Vitesse
        {
            get { return _vitesse; }
            set {
                if ( (value <= VITESSE_MAX) && (value >= VITESSE_INIT))
                    _vitesse = value; 
            }
        }



        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="modele">Modèle de la voiture</param>
        /// <param name="marque">Marque de la voiture</param>
        /// <param name="couleur">Couleur de la voiture</param>
        /// <param name="annee">Année de construction</param>
        /// <param name="kilometrage">Kilométrage</param>
        /// <param name="vitesse">Vitesse actuelle</param>
        public Voiture(string marque, string modele, string couleur, ushort annee, float kilometrage)
        {
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
            Annee = annee;
            Kilometrage = kilometrage;
            Vitesse = VITESSE_INIT;
        }

        /// <summary>
        /// Augmente la vitesse actuelle de la voiture de 5 km/h
        /// </summary>
        public void Accelerer()
        {     
                Vitesse += VITESSE_DEPLACEMENT_MIN;

        }

        /// <summary>
        /// Diminue la vitesse de la voiture de 5 km/h
        /// </summary>
        public void Ralentir()
        {
            //if (Vitesse >= VITESSE_DEPLACEMENT_MIN)
                Vitesse -= VITESSE_DEPLACEMENT_MIN;

        }

    }
}

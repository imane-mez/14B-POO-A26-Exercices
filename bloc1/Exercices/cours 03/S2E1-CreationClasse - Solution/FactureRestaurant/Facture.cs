using System;
using System.Collections.Generic;
using System.Text;

namespace FactureRestaurant
{
    class Facture
    {
        public const float TAUX_TAXES = 0.1f;
        public const float TAUX_POURBOIRE = 0.15f;

        /// <summary>
        /// Prix pour un appéritif
        /// </summary>
        private decimal _prixApperitif;

        /// <summary>
        /// Prix pour une entrée
        /// </summary>
        private decimal _prixEntree;

        /// <summary>
        /// prix pour un plat principal
        /// </summary>
        private decimal _prixPlat;

        /// <summary>
        /// Prix pour un dessert
        /// </summary>
        private decimal _prixDessert;

        /// <summary>
        /// Prix pour une boisson
        /// </summary>
        private decimal _prixBoisson;

        public decimal PrixApperitif
        {
            get { return _prixApperitif; }
            private set
            {
                _prixApperitif = value;
            }
        }

        public decimal PrixEntree 
        {
            get { return _prixEntree; }
            private set
            {
                _prixEntree = value;
            }
        }

        public decimal PrixPlat
        {
            get { return _prixPlat; }
            private set
            {
                _prixPlat = value;
            }
        }

        public decimal PrixDessert
        {
            get { return _prixDessert; }
            private set
            {
                _prixDessert = value;
            }
        }

        public decimal PrixBoisson
        {
            get { return _prixBoisson; }
            private set
            {
                _prixBoisson = value;
            }
        }

        public decimal SousTotal
        {
            get
            {
                return CalculerSousTotal();
            }
        }

        public decimal Taxe
        {
            get
            {
                return CalculerTaxe();
            }
        }

        public decimal Total
        {
            get
            {
                return CalculerTotal();
            }
        }

        public decimal Pourboire
        {
            get
            {
                return CalculerPourboire();
            }
        }

        public Facture(decimal prixApperitif, decimal prixEntree, decimal prixPlat, decimal prixDessert, decimal prixBoisson)
        {
            _prixApperitif = prixApperitif;
            _prixEntree = prixEntree;
            _prixPlat = prixPlat;
            _prixDessert = prixDessert;
            _prixBoisson = prixBoisson;

        }

        /// <summary>
        /// Constructeur sans paramètre.
        /// </summary>
        public Facture()
        {
            PrixApperitif = 0m;
            PrixEntree = 0m;
            PrixPlat = 0m;
            PrixDessert = 0m;
            PrixBoisson = 0m;
        }

        /// <summary>
        /// Cacul le sous-total d'une facture
        /// </summary>
        /// <param name="facture">Facture dont le sous-total doit être calculé</param>
        /// <returns>Montant du sous-total</returns>
        private decimal CalculerSousTotal()
        {
            decimal sousTotal = PrixApperitif + PrixEntree + PrixPlat + PrixDessert + PrixBoisson;

            return sousTotal;
        }

        /// <summary>
        /// Calcul le pourboire d'une facture
        /// </summary>
        /// <param name="facture">Facture sur laquelle le pourboire est calculé</param>
        /// <returns>Montant du pourboire</returns>
        private decimal CalculerPourboire()
        {
            decimal sousTotal = CalculerSousTotal();

            return sousTotal * (decimal)TAUX_POURBOIRE;
        }

        /// <summary>
        /// Calcule la taxe d'une facture
        /// </summary>
        /// <param name="facture">Facture sur laquelle la taxe doit être calculée</param>
        /// <returns>Montant de la taxe</returns>
        private decimal CalculerTaxe()
        {
            return CalculerSousTotal() * (decimal)TAUX_TAXES;
        }

        /// <summary>
        /// Calcul le total d'une facture
        /// </summary>
        /// <param name="facture">Facture dont le total est à calculé</param>
        /// <returns>Montant total de la facture</returns>
        private  decimal CalculerTotal()
        {
            return CalculerSousTotal() + CalculerPourboire() + CalculerTaxe();
        }

    }
}

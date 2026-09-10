

namespace Restaurant
{
    struct Facture
    {
        /// <summary>
        /// Prix pour un appéritif
        /// </summary>
        public decimal prixApperitif;

        /// <summary>
        /// Prix pour une entrée
        /// </summary>
        public decimal prixEntree;

        /// <summary>
        /// prix pour un plat principal
        /// </summary>
        public decimal prixPlat;

        /// <summary>
        /// Prix pour un dessert
        /// </summary>
        public decimal prixDessert;

        /// <summary>
        /// Prix pour une boisson
        /// </summary>
        public decimal prixBoisson;

        /// <summary>
        /// Sous-total de la facture
        /// </summary>
        public decimal montantSousTotal;

        /// <summary>
        /// Montant des taxes
        /// </summary>
        public decimal montantTaxes;

        //Montant du pourboire
        public decimal montantPourboire;

        //Total de la facture
        public decimal montantTotal;


    }
}

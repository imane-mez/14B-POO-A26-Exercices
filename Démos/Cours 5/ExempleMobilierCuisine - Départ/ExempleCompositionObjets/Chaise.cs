
namespace ExempleCompositionObjets
{
    /// <summary>
    /// Classe représentant une chaise de cuisine.
    /// </summary>
    public class Chaise
    {
        /// <summary>
        /// Marge de profit en % lors de la vente.
        /// </summary>
        private const float MARGE_DE_PROFIT = 0.25f;

        /// <summary>
        /// Modèle de chaise.
        /// </summary>
        private String _modele;

        /// <summary>
        /// Indique si la chaise est de type capitaine.
        /// </summary>
        private bool _estCapitaine;

        /// <summary>
        /// Coût de fabrication.
        /// </summary>
        private decimal _coutFabrication;

        /// <summary>
        /// Modèle de table.
        /// </summary>
        public String Modele
        {
            get { return _modele; }
            private set { _modele = value; }
        }

        /// <summary>
        /// Indique si la chaise est de type capitaine.
        /// </summary>
        public bool EstCapitaine
        {
            get { return _estCapitaine; }
            private set { _estCapitaine = value; }
        }

        /// <summary>
        /// Coût de fabrication.
        /// </summary>
        public decimal CoutFabrication
        {
            get { return _coutFabrication; }
            private set { _coutFabrication = value; }
        }

        public decimal PrixVente
        {
            get
            {
                return CalculerPrixVente();
            }
        }

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs d'une chaise.
        /// </summary>
        /// <param name="modele">Modèle de chaise.</param>
        /// <param name="estCapitaine">Indique si la chaise est capitaine.</param>
        /// <param name="coutFabrication">Coût de fabrication.</param>
        public Chaise(String modele, bool estCapitaine, decimal coutFabrication)
        {
            Modele = modele;
            EstCapitaine = estCapitaine;
            CoutFabrication = coutFabrication;
        }
       

        /// <summary>
        /// Permet d'obtenir le prix de vente suggéré.
        /// </summary>
        /// <returns>Prix de vente suggéré.</returns>
        private decimal CalculerPrixVente()
        {
            return CoutFabrication *(decimal) (1 + Chaise.MARGE_DE_PROFIT);
        }

       
    }
}
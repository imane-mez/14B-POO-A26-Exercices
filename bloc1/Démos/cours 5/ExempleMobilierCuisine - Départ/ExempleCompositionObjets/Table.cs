
namespace ExempleCompositionObjets
{
    /// <summary>
    /// Classe représentant une table de cuisine.
    /// </summary>
    public class Table
    {
        

        /// <summary>
        /// Marge de profit en % lors de la vente.
        /// </summary>
        private const float MARGE_DE_PROFIT = 0.20f;

        

       

        /// <summary>
        /// Modèle de table.
        /// </summary>
        private String _modele;

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
        /// Constructeur paramétré qui accepte les deux attributs d'une table.
        /// </summary>
        /// <param name="modele">Modèle de table.</param>
        /// <param name="coutFabrication">Coût de fabrication.</param>
        public Table(String modele, decimal coutFabrication)
        {
            Modele = modele;
            CoutFabrication = coutFabrication;
        }

        

       

        /// <summary>
        /// Permet d'obtenir le prix de vente suggéré.
        /// </summary>
        /// <returns>Prix de vente suggéré.</returns>
        private decimal CalculerPrixVente()
        {
            return CoutFabrication * (decimal)(1 + Table.MARGE_DE_PROFIT);
        }

        
    }
}
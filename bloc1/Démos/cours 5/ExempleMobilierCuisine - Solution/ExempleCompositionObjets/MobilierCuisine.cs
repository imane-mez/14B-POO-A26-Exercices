

namespace ExempleCompositionObjets
{
    /// <summary>
    /// Classe représentant un mobilier de cuisine.
    /// </summary>
    public class MobilierCuisine
    {
        

        /// <summary>
        /// Réduction en % lors de l'achat d'un mobilier par rapport à l'achat de chaque article individuellement.
        /// </summary>
        private const float REDUCTION = 0.07f;

    
        /// <summary>
        /// La table du mobilier.
        /// </summary>
        private Table _table;

        /// <summary>
        /// Les chaises du mobilier.
        /// </summary>
        private Chaise[] _lesChaises;

     


        /// <summary>
        /// La table du mobilier.
        /// </summary>
        public Table Table
        {
            get { return _table; }
            private set { _table = value; }
        }

        /// <summary>
        /// Les chaises du mobilier.
        /// Les deux accesseurs sont privés car le vecteur de chaises est protégé contre toute modification.
        /// </summary>
        private Chaise[] LesChaises
        {
            get { return _lesChaises; }
            set { _lesChaises = value; }
        }

        /// <summary>
        /// Nombre de chaises dans le mobilier.
        /// </summary>
        public int NbChaises
        {
            get { return _lesChaises.Length; }
        }

  
        public decimal PrixVente
        {
            get
            {
                return CalulerPrixVente();
            }
        }
        

        /// <summary>
        /// Constructeur paramétré qui accepte les deux attributs d'un mobilier de cuisine.
        /// </summary>
        /// <param name="table">La table du mobilier.</param>
        /// <param name="lesChaises">Les chaises du mobilier.</param>
        public MobilierCuisine(Table table, Chaise[] lesChaises)
        {
            Table = table;
            LesChaises = lesChaises;
        }

        

       

        /// <summary>
        /// Permet d'obtenir le prix de vente suggéré.
        /// </summary>
        /// <returns>Prix de vente suggéré.</returns>
        private decimal CalulerPrixVente()
        {
            decimal prixVente = 0;

            // Ajout du prix de la table
            prixVente += Table.PrixVente;

            // Ajout du prix de chaque chaise.
            for (int i = 0; i < LesChaises.Length; i++)
                prixVente += LesChaises[i].PrixVente();

            // Réduction pour l'achat d'un mobilier.
            prixVente = prixVente * (decimal) (1 - MobilierCuisine.REDUCTION);

            return prixVente;
        }

        /// <summary>
        /// Permet d'obtenir la chaise à l'indice spécifié.
        /// </summary>
        /// <param name="indice">Indice de la chaise dans le vecteur.</param>
        /// <returns>La chaise correspondant à l'indice ou bien "null" si l'indice est invalide.</returns>
        public Chaise ObtenirChaise(int indice)
        {
            // Est-ce que l'indice est valide ?
            if (indice >= 0 && indice < LesChaises.Length)
                return LesChaises[indice];
            else
                return null;
        }

      
    }
}
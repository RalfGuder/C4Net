using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity BiologicalMaterielType.
    /// </summary>
    public class BiologicalMaterielTypeExpression : BaseEntityExpression<BiologicalMaterielTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column bio_mat_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column bio_mat_type_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Subcategory that represents the column subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property Subcategory that represents the column subcat_code.
        /// </value>
        public ColumnExpression Subcategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Persistency that represents the column persist_code.
        /// </summary>
        /// <value>
        /// The value of the property Persistency that represents the column persist_code.
        /// </value>
        public ColumnExpression Persistency 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="BiologicalMaterielTypeExpression"/> class.
        /// </summary>
        public BiologicalMaterielTypeExpression()
            : base("BiologicalMaterielType", typeof(IBiologicalMaterielType))
        {
        }

        #endregion
    }
}

using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Minefield.
    /// </summary>
    public class MinefieldExpression : BaseEntityExpression<MinefieldExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mnfld_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mnfld_id.
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
        /// Expression for the property IdentificationText that represents the column identific_txt.
        /// </summary>
        /// <value>
        /// The value of the property IdentificationText that represents the column identific_txt.
        /// </value>
        public ColumnExpression IdentificationText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MineSpacingDimension that represents the column mine_spc_dim.
        /// </summary>
        /// <value>
        /// The value of the property MineSpacingDimension that represents the column mine_spc_dim.
        /// </value>
        public ColumnExpression MineSpacingDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DestructionDatetime that represents the column destruction_dttm.
        /// </summary>
        /// <value>
        /// The value of the property DestructionDatetime that represents the column destruction_dttm.
        /// </value>
        public ColumnExpression DestructionDatetime 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MinefieldExpression"/> class.
        /// </summary>
        public MinefieldExpression()
            : base("Minefield", typeof(IMinefield))
        {
        }

        #endregion
    }
}

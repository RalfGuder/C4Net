using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Unit.
    /// </summary>
    public class UnitExpression : BaseEntityExpression<UnitExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column unit_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column unit_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property FormalAbbreviatedNameText that represents the column formal_abbrd_name_txt.
        /// </summary>
        /// <value>
        /// The value of the property FormalAbbreviatedNameText that represents the column formal_abbrd_name_txt.
        /// </value>
        public ColumnExpression FormalAbbreviatedNameText 
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
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitExpression"/> class.
        /// </summary>
        public UnitExpression()
            : base("Unit", typeof(IUnit))
        {
        }

        #endregion
    }
}

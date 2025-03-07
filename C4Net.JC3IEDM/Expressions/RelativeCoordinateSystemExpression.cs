using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity RelativeCoordinateSystem.
    /// </summary>
    public class RelativeCoordinateSystemExpression : BaseEntityExpression<RelativeCoordinateSystemExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column rel_coord_sys_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column rel_coord_sys_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ReferenceCategory that represents the column ref_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property ReferenceCategory that represents the column ref_cat_code.
        /// </value>
        public ColumnExpression ReferenceCategory 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[3]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeCoordinateSystemExpression"/> class.
        /// </summary>
        public RelativeCoordinateSystemExpression()
            : base("RelativeCoordinateSystem", typeof(IRelativeCoordinateSystem))
        {
        }

        #endregion
    }
}

using C4Net.Core.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Expressions
{
    /// <summary>
    /// Expression class for query the entity FkAttr.
    /// </summary>
    public class FkAttrExpression : BaseEntityExpression<FkAttrExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the column host_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column host_ent_id.
        /// </value>
        public ColumnExpression HostEntId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the column attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column attr_ix.
        /// </value>
        public ColumnExpression AttrIx 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the column role_def_txt.
        /// </summary>
        /// <value>
        /// The value of the column role_def_txt.
        /// </value>
        public ColumnExpression RoleDefTxt 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the column rona_ind_code.
        /// </summary>
        /// <value>
        /// The value of the column rona_ind_code.
        /// </value>
        public ColumnExpression RonaIndCode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the column src_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column src_ent_id.
        /// </value>
        public ColumnExpression SrcEntId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the column src_attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column src_attr_ix.
        /// </value>
        public ColumnExpression SrcAttrIx 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the column migr_rel_ix.
        /// </summary>
        /// <value>
        /// The value of the column migr_rel_ix.
        /// </value>
        public ColumnExpression MigrRelIx 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the column base_ent_id.
        /// </summary>
        /// <value>
        /// The value of the column base_ent_id.
        /// </value>
        public ColumnExpression BaseEntId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the column base_attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column base_attr_ix.
        /// </value>
        public ColumnExpression BaseAttrIx 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the column unif_attr_ix.
        /// </summary>
        /// <value>
        /// The value of the column unif_attr_ix.
        /// </value>
        public ColumnExpression UnifAttrIx 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="FkAttrExpression"/> class.
        /// </summary>
        public FkAttrExpression()
            : base("[%LogicalName%%]", typeof(IFkAttr))
        {
        }

        #endregion
    }
}

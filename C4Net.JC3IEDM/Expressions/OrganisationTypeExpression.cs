using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationType.
    /// </summary>
    public class OrganisationTypeExpression : BaseEntityExpression<OrganisationTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column org_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column org_type_id.
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
        /// Expression for the property CommandFunctionIndicator that represents the column cmd_func_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property CommandFunctionIndicator that represents the column cmd_func_ind_code.
        /// </value>
        public ColumnExpression CommandFunctionIndicator 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CommandAndControlCategory that represents the column cmd_and_ctrl_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property CommandAndControlCategory that represents the column cmd_and_ctrl_cat_code.
        /// </value>
        public ColumnExpression CommandAndControlCategory 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DescriptionText that represents the column descr_txt.
        /// </summary>
        /// <value>
        /// The value of the property DescriptionText that represents the column descr_txt.
        /// </value>
        public ColumnExpression DescriptionText 
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
        /// Initializes a new instance of the <see cref="OrganisationTypeExpression"/> class.
        /// </summary>
        public OrganisationTypeExpression()
            : base("OrganisationType", typeof(IOrganisationType))
        {
        }

        #endregion
    }
}

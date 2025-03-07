using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationMaterielTypeAssociation.
    /// </summary>
    public class OrganisationMaterielTypeAssociationExpression : BaseEntityExpression<OrganisationMaterielTypeAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property OrganisationId that represents the column org_id.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationId that represents the column org_id.
        /// </value>
        public ColumnExpression OrganisationId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property MaterielTypeId that represents the column mat_type_id.
        /// </summary>
        /// <value>
        /// The value of the property MaterielTypeId that represents the column mat_type_id.
        /// </value>
        public ColumnExpression MaterielTypeId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportableType that represents the column rptbl_type_code.
        /// </summary>
        /// <value>
        /// The value of the property ReportableType that represents the column rptbl_type_code.
        /// </value>
        public ColumnExpression ReportableType 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportableTypeText that represents the column rptbl_type_txt.
        /// </summary>
        /// <value>
        /// The value of the property ReportableTypeText that represents the column rptbl_type_txt.
        /// </value>
        public ColumnExpression ReportableTypeText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ReportableTypeDatetime that represents the column rptbl_type_dttm.
        /// </summary>
        /// <value>
        /// The value of the property ReportableTypeDatetime that represents the column rptbl_type_dttm.
        /// </value>
        public ColumnExpression ReportableTypeDatetime 
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
        /// Initializes a new instance of the <see cref="OrganisationMaterielTypeAssociationExpression"/> class.
        /// </summary>
        public OrganisationMaterielTypeAssociationExpression()
            : base("OrganisationMaterielTypeAssociation", typeof(IOrganisationMaterielTypeAssociation))
        {
        }

        #endregion
    }
}

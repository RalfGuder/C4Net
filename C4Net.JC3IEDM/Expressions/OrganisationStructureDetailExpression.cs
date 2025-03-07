using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationStructureDetail.
    /// </summary>
    public class OrganisationStructureDetailExpression : BaseEntityExpression<OrganisationStructureDetailExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property OrganisationStructureRootOrganisationId that represents the column org_struct_root_org_id.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationStructureRootOrganisationId that represents the column org_struct_root_org_id.
        /// </value>
        public ColumnExpression OrganisationStructureRootOrganisationId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property OrganisationStructureIndex that represents the column org_struct_ix.
        /// </summary>
        /// <value>
        /// The value of the property OrganisationStructureIndex that represents the column org_struct_ix.
        /// </value>
        public ColumnExpression OrganisationStructureIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column org_struct_det_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column org_struct_det_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemAssociationSubjectObjectItemId that represents the column subj_obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemAssociationSubjectObjectItemId that represents the column subj_obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemAssociationSubjectObjectItemId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemAssociationObjectObjectItemId that represents the column obj_obj_item_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemAssociationObjectObjectItemId that represents the column obj_obj_item_id.
        /// </value>
        public ColumnExpression ObjectItemAssociationObjectObjectItemId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemAssociationIndex that represents the column obj_item_assoc_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemAssociationIndex that represents the column obj_item_assoc_ix.
        /// </value>
        public ColumnExpression ObjectItemAssociationIndex 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationStructureDetailExpression"/> class.
        /// </summary>
        public OrganisationStructureDetailExpression()
            : base("OrganisationStructureDetail", typeof(IOrganisationStructureDetail))
        {
        }

        #endregion
    }
}

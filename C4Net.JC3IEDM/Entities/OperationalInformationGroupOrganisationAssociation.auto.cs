using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION that represents the table OIG_ORG_ASSOC.
	///
	/// A relationship of a specific OPERATIONAL-INFORMATION-GROUP with a specific ORGANISATION for specifying the role of the ORGANISATION with respect to the OPERATIONAL-INFORMATION-GROUP.
    /// </summary>
    [Serializable]
    [DefinitionName("OperationalInformationGroupOrganisationAssociation", "C4Net.JC3IEDM.Definitions.OperationalInformationGroupOrganisationAssociation.definition.xml")]
    public class OperationalInformationGroupOrganisationAssociation : IEntity, IOperationalInformationGroupOrganisationAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OperationalInformationGroupOrganisationAssociationExpression _ = new OperationalInformationGroupOrganisationAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column oig_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CONTEXT and to distinguish it from all other CONTEXTs.
        /// </summary>
        /// <value>
        /// Value of the column oig_id
        /// </value>
		public decimal OperationalInformationGroupId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_id
        /// </value>
		public decimal OrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column oig_org_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION for a specific OPERATIONAL-INFORMATION-GROUP and a specific ORGANISATION and to distinguish it from all other OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATIONs for that OPERATIONAL-INFORMATION-GROUP and that ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column oig_org_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a specific OPERATIONAL-INFORMATION-GROUP and a specific ORGANISATION in a specific OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OperationalInformationGroupOrganisationAssociationCategoryEnum OperationalInformationGroupOrganisationAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}

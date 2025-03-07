using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-ACTION-ASSOCIATION that represents the table ORG_ACT_ASSOC.
	///
	/// A relationship indicating the role of a specific ORGANISATION with respect to a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationActionAssociation", "C4Net.JC3IEDM.Definitions.OrganisationActionAssociation.definition.xml")]
    public class OrganisationActionAssociation : IEntity, IOrganisationActionAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationActionAssociationExpression _ = new OrganisationActionAssociationExpression();

        #endregion

        #region - Properties -
		
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
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_act_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-ACTION-ASSOCIATION for a specific ORGANISATION and a specific ACTION and to distinguish it from all other ORGANISATION-ACTION-ASSOCIATIONs for that ORGANISATION and that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column org_act_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a specific ORGANISATION and a specific ACTION for a specific ORGANISATION-ACTION-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationActionAssociationCategoryEnum OrganisationActionAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning of the period of effectiveness for a specific ORGANISATION-ACTION-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
		public string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intent_txt
		///
		/// The character string assigned to represent a statement by a specific ORGANISATION outlining the commander's intent or the concept of operations with regard to a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column intent_txt
        /// </value>
		public string IntentText { get; set; }
		
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

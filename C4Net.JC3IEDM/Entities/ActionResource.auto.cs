using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-RESOURCE that represents the table ACT_RES.
	///
	/// An OBJECT-ITEM or an OBJECT-TYPE that is required, requested, allocated or otherwise used or planned to be used in conducting a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionResource", "C4Net.JC3IEDM.Definitions.ActionResource.definition.xml")]
    public class ActionResource : IEntity, IActionResource
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionResourceExpression _ = new ActionResourceExpression();

        #endregion

        #region - Properties -
		
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
        /// Gets or sets the value of the column act_res_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE for a specific ACTION and to distinguish it from all other ACTION-RESOURCEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_res_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-RESOURCE with respect to item or type. It serves as a discriminator that partitions ACTION-RESOURCE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionResourceCategoryEnum ActionResourceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column criticality_ind_code
		///
		/// The specific value that denotes a judgement whether a specific resource (OBJECT-ITEM or OBJECT-TYPE) associated with a specific ACTION is essential for the effective completion of that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column criticality_ind_code
        /// </value>
		public ActionResourceCriticalityIndicatorEnum? CriticalityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents the type of restriction or other qualification applicable to a specific ACTION-RESOURCE for a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
		public ActionResourceQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column authorising_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column authorising_org_id
        /// </value>
		public decimal? AuthorisingOrganisationId { get; set; }
		
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

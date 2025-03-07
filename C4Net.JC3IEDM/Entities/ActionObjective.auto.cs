using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-OBJECTIVE that represents the table ACT_OBJVE.
	///
	/// The focus, in terms of an OBJECT-ITEM, OBJECT-TYPE, or ACTION-TASK, in conducting a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionObjective", "C4Net.JC3IEDM.Definitions.ActionObjective.definition.xml")]
    public class ActionObjective : IEntity, IActionObjective
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionObjectiveExpression _ = new ActionObjectiveExpression();

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
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-OBJECTIVE with respect to item or type. It serves as a discriminator that partitions ACTION-OBJECTIVE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionObjectiveCategoryEnum ActionObjectiveCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents a restriction or other qualification applicable to a specific ACTION-OBJECTIVE for a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
		public ActionObjectiveQualifierEnum? Qualifier { get; set; }
		
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

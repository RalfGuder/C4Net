using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-TEMPORAL-ASSOCIATION that represents the table ACT_TMPRL_ASSOC.
	///
	/// The relationship of an ACTION as a subject to another ACTION as an object in order to specify time dependence.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionTemporalAssociation", "C4Net.JC3IEDM.Definitions.ActionTemporalAssociation.definition.xml")]
    public class ActionTemporalAssociation : IEntity, IActionTemporalAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionTemporalAssociationExpression _ = new ActionTemporalAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column subj_act_id
        /// </value>
		public decimal SubjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column obj_act_id
        /// </value>
		public decimal ObjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_tmprl_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-TEMPORAL-ASSOCIATION for a specific subject ACTION and a specific object ACTION and to distinguish it from all other ACTION-TEMPORAL-ASSOCIATIONs for those ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_tmprl_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of chronological relationship of a subject ACTION to an object ACTION for a specific ACTION-TEMPORAL-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionTemporalAssociationCategoryEnum ActionTemporalAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds that elapses after the start or end of a specific object ACTION that a subject ACTION is referenced to for its execution.
        /// </summary>
        /// <value>
        /// Value of the column ref_dur
        /// </value>
		public decimal? ReferenceDuration { get; set; }
		
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

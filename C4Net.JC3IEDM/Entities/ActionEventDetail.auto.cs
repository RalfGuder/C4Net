using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-EVENT-DETAIL that represents the table ACT_EVENT_DET.
	///
	/// Supplemental information about the ACTION-EVENT.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionEventDetail", "C4Net.JC3IEDM.Definitions.ActionEventDetail.definition.xml")]
    public class ActionEventDetail : IEntity, IActionEventDetail
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionEventDetailExpression _ = new ActionEventDetailExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_event_id
        /// </value>
		public decimal ActionEventId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_event_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EVENT-DETAIL for a specific ACTION-EVENT and to distinguish it from all other ACTION-EVENT-DETAILs for that ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column act_event_det_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column clsfc_code
		///
		/// The specific value that represents the classification of a specific ACTION-EVENT according to a broad subject area.
        /// </summary>
        /// <value>
        /// Value of the column clsfc_code
        /// </value>
		public ActionEventDetailClassificationEnum? Classification { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crime_ind_code
		///
		/// The specific value that denotes a judgement whether a specific event is a crime or not.
        /// </summary>
        /// <value>
        /// Value of the column crime_ind_code
        /// </value>
		public ActionEventDetailCrimeIndicatorEnum? CrimeIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column txt
		///
		/// The character string assigned to represent the description of the event detail of a specific ACTION-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column txt
        /// </value>
		public string Text { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-EVENT-DETAIL. It serves as a discriminator that partitions ACTION-EVENT-DETAIL into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionEventDetailCategoryEnum ActionEventDetailCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column intended_outcome_code
		///
		/// The specific value that describes the immediate and direct goals or objectives of an enemy’s attack.
        /// </summary>
        /// <value>
        /// Value of the column intended_outcome_code
        /// </value>
		public ActionEventDetailIntendedOutcomeEnum? IntendedOutcome { get; set; }
		
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

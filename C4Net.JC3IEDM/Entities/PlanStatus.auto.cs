using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-STATUS that represents the table PLN_STAT.
	///
	/// A record of the condition of a specific PLAN.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanStatus", "C4Net.JC3IEDM.Definitions.PlanStatus.definition.xml")]
    public class PlanStatus : IEntity, IPlanStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanStatusExpression _ = new PlanStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pln_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_id
        /// </value>
		public decimal PlanId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-STATUS for a specific PLAN and to distinguish it from all other PLAN-STATUSs for that PLAN.
        /// </summary>
        /// <value>
        /// Value of the column pln_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dvlpm_stat_code
		///
		/// The specific value assigned to represent the state of preparation for a specific PLAN.
        /// </summary>
        /// <value>
        /// Value of the column dvlpm_stat_code
        /// </value>
		public PlanStatusDevelopmentStatusEnum DevelopmentStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column state_code
		///
		/// The specific value assigned to represent the condition for a specific PLAN.
        /// </summary>
        /// <value>
        /// Value of the column state_code
        /// </value>
		public PlanStatusStateEnum? State { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time for a specific PLAN-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
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

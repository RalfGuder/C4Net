using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity TARGET-PERSONNEL-PROTECTION that represents the table TARGET_PRSNL_PROTECT.
	///
	/// An assessment of the general protective posture of personnel with respect to first and second volleys for the specific TARGET.
    /// </summary>
    [Serializable]
    [DefinitionName("TargetPersonnelProtection", "C4Net.JC3IEDM.Definitions.TargetPersonnelProtection.definition.xml")]
    public class TargetPersonnelProtection : IEntity, ITargetPersonnelProtection
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly TargetPersonnelProtectionExpression _ = new TargetPersonnelProtectionExpression();

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
		public decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that denotes the protective posture of personnel for the specific TARGET.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public TargetPersonnelProtectionCategoryEnum TargetPersonnelProtectionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal? ReportingDataId { get; set; }
		
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

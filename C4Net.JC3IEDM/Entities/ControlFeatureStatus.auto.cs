using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONTROL-FEATURE-STATUS that represents the table CFEAT_STAT.
	///
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific CONTROL-FEATURE.
    /// </summary>
    [Serializable]
    [DefinitionName("ControlFeatureStatus", "C4Net.JC3IEDM.Definitions.ControlFeatureStatus.definition.xml")]
    public class ControlFeatureStatus : ObjectItemStatus, IControlFeatureStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ControlFeatureStatusExpression _ = new ControlFeatureStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cfeat_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column cfeat_stat_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
		public decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column invstg_stat_code
		///
		/// The specific value that represents the investigation status of the site encompassed by a specific CONTROL-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column invstg_stat_code
        /// </value>
		public ControlFeatureStatusInvestigationStatusEnum? InvestigationStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cbrn_thrt_lvl_code
		///
		/// The specific value that represents the assessed CBRN threat level status of a specific CONTROL-FEATURE that defines a given operational area for friendly forces.
        /// </summary>
        /// <value>
        /// Value of the column cbrn_thrt_lvl_code
        /// </value>
		public ControlFeatureStatusCbrnThreatLevelEnum? CbrnThreatLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_stat_code
		///
		/// The specific value that represents the protection status of the site encompassed by a specific CONTROL-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column security_stat_code
        /// </value>
		public ControlFeatureStatusSecurityStatusEnum? SecurityStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific CONTROL-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
		public UsageStatusEnum? UsageStatus { get; set; }
		
        #endregion
    }
}

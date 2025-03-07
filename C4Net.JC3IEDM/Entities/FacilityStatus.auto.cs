using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FACILITY-STATUS that represents the table FAC_STAT.
	///
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific FACILITY.
    /// </summary>
    [Serializable]
    [DefinitionName("FacilityStatus", "C4Net.JC3IEDM.Definitions.FacilityStatus.definition.xml")]
    public class FacilityStatus : ObjectItemStatus, IFacilityStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FacilityStatusExpression _ = new FacilityStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column fac_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column fac_stat_id
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
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FACILITY-STATUS. It serves as a discriminator that partitions FACILITY-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public FacilityStatusCategoryEnum FacilityStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dmltn_stat_code
		///
		/// The specific value that represents the status of a specific FACILITY destined for demolition.
        /// </summary>
        /// <value>
        /// Value of the column dmltn_stat_code
        /// </value>
		public DemolitionStatusEnum? DemolitionStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column enemy_actv_cond_code
		///
		/// The specific value that represents the status of enemy activity around or at the FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column enemy_actv_cond_code
        /// </value>
		public FacilityStatusEnemyActivityConditionEnum? EnemyActivityCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_prsnc_code
		///
		/// The specific value that indicates whether a specific FACILITY contains mines.
        /// </summary>
        /// <value>
        /// Value of the column mine_prsnc_code
        /// </value>
		public MinePresenceEnum? MinePresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ocptn_prog_ind_code
		///
		/// The specific value that indicates whether an occupation programme is present at the facility.
        /// </summary>
        /// <value>
        /// Value of the column ocptn_prog_ind_code
        /// </value>
		public FacilityStatusOccupationProgramIndicatorEnum? OccupationProgramIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_code
		///
		/// The specific value that represents the operational status of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_code
        /// </value>
		public FacilityStatusOperationalStatusEnum OperationalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_qual_code
		///
		/// The specific value that represents the qualification of the operational status of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_qual_code
        /// </value>
		public FacilityStatusOperationalStatusQualifierEnum? OperationalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific FACILITY has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
		public FacilityStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_stat_code
		///
		/// The specific value that represents the security status of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column security_stat_code
        /// </value>
		public FacilityStatusSecurityStatusEnum? SecurityStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
		public UsageStatusEnum? UsageStatus { get; set; }
		
        #endregion
    }
}

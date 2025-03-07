using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-GROUP that represents the table MFS_INTVL_CAS_GROUP.
	///
	/// A MEDICAL-FACILITY-STATUS that specifies the count of deaths and completed surgeries for each of specified groups during the period defined by the effective beginning and ending datetimes stipulated through REPORTING-DATA.
    /// </summary>
    [Serializable]
    [DefinitionName("MedicalFacilityStatusIntervalCasualtyGroup", "C4Net.JC3IEDM.Definitions.MedicalFacilityStatusIntervalCasualtyGroup.definition.xml")]
    public class MedicalFacilityStatusIntervalCasualtyGroup : IEntity, IMedicalFacilityStatusIntervalCasualtyGroup
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly MedicalFacilityStatusIntervalCasualtyGroupExpression _ = new MedicalFacilityStatusIntervalCasualtyGroupExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mfs_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mfs_id
        /// </value>
		public decimal MedicalFacilityStatusId { get; set; }
		
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
        /// Gets or sets the value of the column mfs_intvl_cas_group_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-GROUP for a specific FACILITY and a specific OBJECT-ITEM-STATUS and to distinguish it from all other instances of MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-GROUPs for that FACILITY and that OBJECT-ITEM-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column mfs_intvl_cas_group_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the categorisation of casualties in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public CasualtyGroupEnum MedicalFacilityStatusIntervalCasualtyGroupCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column completed_surgery_cnt
		///
		/// The integer value representing the number of completed surgeries for casualties in the specified group in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column completed_surgery_cnt
        /// </value>
		public int CompletedSurgeryCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column death_cnt
		///
		/// The integer value representing the number of deceased casualties in the specified group in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column death_cnt
        /// </value>
		public int DeathCount { get; set; }
		
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

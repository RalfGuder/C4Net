using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MEDICAL-FACILITY-STATUS-PENDING-SURGERY that represents the table MFS_PEND_SURGERY.
	///
	/// The count of pending surgeries according to specified triage grouping for a specific MEDICAL-FACILITY-STATUS.
    /// </summary>
    [Serializable]
    [DefinitionName("MedicalFacilityStatusPendingSurgery", "C4Net.JC3IEDM.Definitions.MedicalFacilityStatusPendingSurgery.definition.xml")]
    public class MedicalFacilityStatusPendingSurgery : IEntity, IMedicalFacilityStatusPendingSurgery
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly MedicalFacilityStatusPendingSurgeryExpression _ = new MedicalFacilityStatusPendingSurgeryExpression();

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
        /// Gets or sets the value of the column mfs_pend_surgery_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY for a specific FACILITY and a specific OBJECT-ITEM-STATUS and to distinguish it from all other instances of MEDICAL-FACILITY-STATUS-PENDING-SURGERY for that FACILITY and that OBJECT-ITEM-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column mfs_pend_surgery_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column triage_code
		///
		/// The specific value that represents the categorisation of surgery cases according to multilevel triage classification scheme in a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY.
        /// </summary>
        /// <value>
        /// Value of the column triage_code
        /// </value>
		public MedicalFacilityStatusPendingSurgeryTriageEnum Triage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the number of pending surgeries for the specified triage category in a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
		public int Count { get; set; }
		
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

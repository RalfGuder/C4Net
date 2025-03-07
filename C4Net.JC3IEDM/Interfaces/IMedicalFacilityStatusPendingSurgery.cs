using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MedicalFacilityStatusPendingSurgery that represents the table MFS_PEND_SURGERY
	/// 
	/// The count of pending surgeries according to specified triage grouping for a specific MEDICAL-FACILITY-STATUS.
    /// </summary>
	[EntId(10000181)]
    [EntName("MEDICAL-FACILITY-STATUS-PENDING-SURGERY")]
    [EntTableName("MFS_PEND_SURGERY")]
    [EntDepth(6)]
    public interface IMedicalFacilityStatusPendingSurgery
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mfs_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mfs_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("medical-facility-status-id")]
		[AttrColumnName("mfs_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal MedicalFacilityStatusId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mfs_pend_surgery_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY for a specific FACILITY and a specific OBJECT-ITEM-STATUS and to distinguish it from all other instances of MEDICAL-FACILITY-STATUS-PENDING-SURGERY for that FACILITY and that OBJECT-ITEM-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column mfs_pend_surgery_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("medical-facility-status-pending-surgery-index")]
		[AttrColumnName("mfs_pend_surgery_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column triage_code
		///
		/// The specific value that represents the categorisation of surgery cases according to multilevel triage classification scheme in a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY.
        /// </summary>
        /// <value>
        /// Value of the column triage_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("medical-facility-status-pending-surgery-triage-code")]
		[AttrColumnName("triage_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000324)]
        [DataLength(6)]
        [DataDecimals(0)]
        MedicalFacilityStatusPendingSurgeryTriageEnum Triage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the number of pending surgeries for the specified triage category in a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
        [AttrIx(100005)]
		[AttrName("medical-facility-status-pending-surgery-count")]
		[AttrColumnName("cnt")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int Count { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MedicalFacilityStatusCasualtyBedOccupancy that represents the table MFS_CAS_BED_OCC
	/// 
	/// The count of bed occupancy according to specified source grouping for a specific MEDICAL-FACILITY-STATUS.
    /// </summary>
	[EntId(10000177)]
    [EntName("MEDICAL-FACILITY-STATUS-CASUALTY-BED-OCCUPANCY")]
    [EntTableName("MFS_CAS_BED_OCC")]
    [EntDepth(6)]
    public interface IMedicalFacilityStatusCasualtyBedOccupancy
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
        /// Gets or sets the value of the column mfs_cas_bed_occ_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MEDICAL-FACILITY-STATUS-CASUALTY-BED-OCCUPANCY for a specific FACILITY and a specific OBJECT-ITEM-STATUS and to distinguish it from all other instances of MEDICAL-FACILITY-STATUS-CASUALTY-BED-OCCUPANCY for that FACILITY and that OBJECT-ITEM-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column mfs_cas_bed_occ_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("medical-facility-status-casualty-bed-occupancy-index")]
		[AttrColumnName("mfs_cas_bed_occ_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column group_code
		///
		/// The specific value that represents the categorisation of casualties in a specific MEDICAL-FACILITY-STATUS-CASUALTY-BED-OCCUPANCY.
        /// </summary>
        /// <value>
        /// Value of the column group_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("medical-facility-status-casualty-bed-occupancy-group-code")]
		[AttrColumnName("group_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000321)]
        [DataLength(6)]
        [DataDecimals(0)]
        CasualtyGroupEnum Group { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the aggregated number of beds that are occupied by the specified group in a specific MEDICAL-FACILITY-STATUS-CASUALTY-BED-OCCUPANCY.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
        [AttrIx(100005)]
		[AttrName("medical-facility-status-casualty-bed-occupancy-count")]
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

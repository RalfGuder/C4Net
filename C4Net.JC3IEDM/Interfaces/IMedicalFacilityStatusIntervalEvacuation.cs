using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MedicalFacilityStatusIntervalEvacuation that represents the table MFS_INTVL_EVAC
	/// 
	/// A MEDICAL-FACILITY-STATUS that specifies the count of casualties evacuated in each of specified groups according to the intended destination during the period defined by the effective beginning and ending datetimes stipulated through REPORTING-DATA.
    /// </summary>
	[EntId(10000178)]
    [EntName("MEDICAL-FACILITY-STATUS-INTERVAL-EVACUATION")]
    [EntTableName("MFS_INTVL_EVAC")]
    [EntDepth(6)]
    public interface IMedicalFacilityStatusIntervalEvacuation
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
        /// Gets or sets the value of the column mfs_intvl_evac_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MEDICAL-FACILITY-STATUS-INTERVAL-EVACUATION for a specific FACILITY and a specific OBJECT-ITEM-STATUS and to distinguish it from all other instances of MEDICAL-FACILITY-STATUS-INTERVAL-EVACUATION for that FACILITY and that OBJECT-ITEM-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column mfs_intvl_evac_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("medical-facility-status-interval-evacuation-index")]
		[AttrColumnName("mfs_intvl_evac_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dest_code
		///
		/// The specific value that represents the disposition of casualties according to the evacuation destination in a specific MEDICAL-FACILITY-STATUS-INTERVAL-EVACUATION.
        /// </summary>
        /// <value>
        /// Value of the column dest_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("medical-facility-status-interval-evacuation-destination-code")]
		[AttrColumnName("dest_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000322)]
        [DataLength(6)]
        [DataDecimals(0)]
        EvacuationDestinationEnum Destination { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the number of casualties that have been evacuated to the specified destination in a specific MEDICAL-FACILITY-STATUS-INTERVAL-EVACUATION.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
        [AttrIx(100005)]
		[AttrName("medical-facility-status-interval-evacuation-count")]
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

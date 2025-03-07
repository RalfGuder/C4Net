using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Basin that represents the table BASIN
	/// 
	/// A FACILITY that is an open area of water, usually artificial and enclosed by dock gates lined with wharves, warehouses and berths to enable vessels to load and unload.
    /// </summary>
	[EntId(10000264)]
    [EntName("BASIN")]
    [EntTableName("BASIN")]
    [EntDepth(3)]
    public interface IBasin
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column basin_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column basin_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("basin-id")]
		[AttrColumnName("basin_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage that can be accommodated for a vessel at the specific BASIN. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column ddw_tong_qty
        /// </value>
        [AttrIx(100002)]
		[AttrName("basin-deadweight-tonnage-quantity")]
		[AttrColumnName("ddw_tong_qty")]
        [AttrSeqnr(2)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? DeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_dim
		///
		/// The one-dimensional linear distance representing the depth of water available at the BASIN at low tide.
        /// </summary>
        /// <value>
        /// Value of the column depth_dim
        /// </value>
        [AttrIx(100003)]
		[AttrName("basin-depth-dimension")]
		[AttrColumnName("depth_dim")]
        [AttrSeqnr(3)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific BASIN.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("basin-location-text")]
		[AttrColumnName("loc_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string LocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

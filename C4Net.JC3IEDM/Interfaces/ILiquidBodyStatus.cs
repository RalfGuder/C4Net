using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity LiquidBodyStatus that represents the table LQD_BODY_STAT
	/// 
	/// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific liquid body.
    /// </summary>
	[EntId(10000327)]
    [EntName("LIQUID-BODY-STATUS")]
    [EntTableName("LQD_BODY_STAT")]
    [EntDepth(5)]
    public interface ILiquidBodyStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column lqd_body_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column lqd_body_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("liquid-body-status-id")]
		[AttrColumnName("lqd_body_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
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
        /// Gets or sets the value of the column btm_curr_rate
		///
		/// The numeric value that denotes the rate of the liquid movement at the bottom surface of the sea. The unit of measure is knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column btm_curr_rate
        /// </value>
        [AttrIx(100003)]
		[AttrName("liquid-body-status-bottom-current-rate")]
		[AttrColumnName("btm_curr_rate")]
        [AttrSeqnr(3)]
        [DomId(100001300)]
        [DataLength(4)]
        [DataDecimals(1)]
        double? BottomCurrentRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column thermal_layer_depth_qty
		///
		/// The numeric value that represents the distance below the liquid surface where the distinct interface between surface waters and cooler waters; regions between warmer upper layer (epilimnion) and the lower cold layer (hypolimnion) of the liquid where temperature declines abruptly (1 degree C or more per meter) with increasing depth. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column thermal_layer_depth_qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("liquid-body-status-thermal-layer-depth-quantity")]
		[AttrColumnName("thermal_layer_depth_qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? ThermalLayerDepthQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tidal_stream_rate
		///
		/// The numeric value that represents the horizontal water movements due to tidal forcing. The unit of measure is knots. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column tidal_stream_rate
        /// </value>
        [AttrIx(100005)]
		[AttrName("liquid-body-status-tidal-stream-rate")]
		[AttrColumnName("tidal_stream_rate")]
        [AttrSeqnr(5)]
        [DomId(100001300)]
        [DataLength(4)]
        [DataDecimals(1)]
        double? TidalStreamRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column underwater_visibility_qty
		///
		/// The numeric value that represents the distance at which an object disappears given the ambient light, suspended organic and inorganic particulate measure, dissolved substances, plankton and the waters molecular structure. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column underwater_visibility_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("liquid-body-status-underwater-visibility-quantity")]
		[AttrColumnName("underwater_visibility_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? UnderwaterVisibilityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

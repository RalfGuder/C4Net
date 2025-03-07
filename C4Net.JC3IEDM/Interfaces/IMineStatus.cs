using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MineStatus that represents the table MINE_STAT
	/// 
	/// A MATERIEL-STATUS that is a record of condition of a specific mine.
    /// </summary>
	[EntId(10000330)]
    [EntName("MINE-STATUS")]
    [EntTableName("MINE_STAT")]
    [EntDepth(5)]
    public interface IMineStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mine_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mine_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("mine-status-id")]
		[AttrColumnName("mine_stat_id")]
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
        /// Gets or sets the value of the column mine_buried_rat
		///
		/// The numeric quotient value that represents the percentage of the maritime mine that is buried. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column mine_buried_rat
        /// </value>
        [AttrIx(100003)]
		[AttrName("mine-status-mine-buried-ratio")]
		[AttrColumnName("mine_buried_rat")]
        [AttrSeqnr(3)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? MineBuriedRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the status of a mine.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
        [AttrIx(100004)]
		[AttrName("mine-status-code")]
		[AttrColumnName("code")]
        [AttrSeqnr(4)]
        [DomId(100004339)]
        [DataLength(6)]
        [DataDecimals(0)]
        MineStatusEnum? MineStatusCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column air_drop_effect_code
		///
		/// The specific value that represent the behaviour of air-delivered mine after weapon release.
        /// </summary>
        /// <value>
        /// Value of the column air_drop_effect_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("mine-status-air-drop-effect-code")]
		[AttrColumnName("air_drop_effect_code")]
        [AttrSeqnr(5)]
        [DomId(100004340)]
        [DataLength(6)]
        [DataDecimals(0)]
        MineStatusAirDropEffectEnum? AirDropEffect { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mrt_mine_qual_code
		///
		/// The specific value that represents the qualification status of a specific maritime mine.
        /// </summary>
        /// <value>
        /// Value of the column mrt_mine_qual_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("mine-status-maritime-mine-qualifier-code")]
		[AttrColumnName("mrt_mine_qual_code")]
        [AttrSeqnr(6)]
        [DomId(100004341)]
        [DataLength(6)]
        [DataDecimals(0)]
        MineStatusMaritimeMineQualifierEnum? MaritimeMineQualifier { get; set; }
		
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

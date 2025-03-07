using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Slipway that represents the table SLPWAY
	/// 
	/// A FACILITY that provides a sloping surface or inclined structure leading down to the water.
    /// </summary>
	[EntId(10000269)]
    [EntName("SLIPWAY")]
    [EntTableName("SLPWAY")]
    [EntDepth(3)]
    public interface ISlipway
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column slpway_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column slpway_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("slipway-id")]
		[AttrColumnName("slpway_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gradient_angle
		///
		/// The rotational measurement of a gradient, measured between the top of the slipway to the surface of the water, for a specific SLIPWAY.
        /// </summary>
        /// <value>
        /// Value of the column gradient_angle
        /// </value>
        [AttrIx(100002)]
		[AttrName("slipway-gradient-angle")]
		[AttrColumnName("gradient_angle")]
        [AttrSeqnr(2)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? GradientAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific SLIPWAY.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("slipway-location-text")]
		[AttrColumnName("loc_txt")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

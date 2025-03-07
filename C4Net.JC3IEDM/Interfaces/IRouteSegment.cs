using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RouteSegment that represents the table ROUTE_SGMNT
	/// 
	/// A portion of a route usually without an intermediate stop, as defined by two consecutive significant points.
    /// </summary>
	[EntId(10000309)]
    [EntName("ROUTE-SEGMENT")]
    [EntTableName("ROUTE_SGMNT")]
    [EntDepth(3)]
    public interface IRouteSegment
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column route_sgmnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column route_sgmnt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("route-segment-id")]
		[AttrColumnName("route_sgmnt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ROUTE-SEGMENT. It serves as a discriminator that partitions ROUTE-SEGMENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("route-segment-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004258)]
        [DataLength(6)]
        [DataDecimals(0)]
        RouteSegmentCategoryEnum RouteSegmentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mob_code
		///
		/// The specific value that indicates the suitability of a specific ROUTE-SEGMENT for movement.
        /// </summary>
        /// <value>
        /// Value of the column mob_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("route-segment-mobility-code")]
		[AttrColumnName("mob_code")]
        [AttrSeqnr(3)]
        [DomId(100000202)]
        [DataLength(6)]
        [DataDecimals(0)]
        MobilityEnum? Mobility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mode_of_trnsp_code
		///
		/// The specific value that indicates the mode of transportation of a specific ROUTE-SEGMENT.
        /// </summary>
        /// <value>
        /// Value of the column mode_of_trnsp_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("route-segment-mode-of-transportation-code")]
		[AttrColumnName("mode_of_trnsp_code")]
        [AttrSeqnr(4)]
        [DomId(100004259)]
        [DataLength(6)]
        [DataDecimals(0)]
        ModeOfTransportationEnum? ModeOfTransportation { get; set; }
		
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

using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Bridge that represents the table BRIDGE
	/// 
	/// A FACILITY that is a structure (including overpass and viaduct), fixed or moveable, spanning and/or providing passage over an object.
    /// </summary>
	[EntId(10000019)]
    [EntName("BRIDGE")]
    [EntTableName("BRIDGE")]
    [EntDepth(3)]
    public interface IBridge
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column bridge_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column bridge_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("bridge-id")]
		[AttrColumnName("bridge_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column longest_span_length_dim
		///
		/// The one-dimensional linear distance representing the longest span´s length in a specific BRIDGE.
        /// </summary>
        /// <value>
        /// Value of the column longest_span_length_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("bridge-longest-span-length-dimension")]
		[AttrColumnName("longest_span_length_dim")]
        [AttrSeqnr(2)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? LongestSpanLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column span_cnt
		///
		/// The integer value representing the number of sections that a specific BRIDGE may have.
        /// </summary>
        /// <value>
        /// Value of the column span_cnt
        /// </value>
        [AttrIx(100003)]
		[AttrName("bridge-span-count")]
		[AttrColumnName("span_cnt")]
        [AttrSeqnr(3)]
        [DomId(100001800)]
        [DataLength(3)]
        [DataDecimals(0)]
        short? SpanCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_code
		///
		/// The specific value that represents the usage of a specific BRIDGE.
        /// </summary>
        /// <value>
        /// Value of the column usage_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("bridge-usage-code")]
		[AttrColumnName("usage_code")]
        [AttrSeqnr(4)]
        [DomId(100004120)]
        [DataLength(6)]
        [DataDecimals(0)]
        BridgeUsageEnum? Usage { get; set; }
		
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

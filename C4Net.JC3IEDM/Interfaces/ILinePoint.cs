using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity LinePoint that represents the table LINE_POINT
	/// 
	/// A specification of one of an ordered sequence of POINTs used to define the specific LINE.
    /// </summary>
	[EntId(10000062)]
    [EntName("LINE-POINT")]
    [EntTableName("LINE_POINT")]
    [EntDepth(2)]
    public interface ILinePoint
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column line_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("line-id")]
		[AttrColumnName("line_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal LineId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column line_point_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific LINE-POINT for a specific LINE and to distinguish it from all other LINE-POINTs for that LINE.
        /// </summary>
        /// <value>
        /// Value of the column line_point_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("line-point-index")]
		[AttrColumnName("line_point_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The integer value that indicates the relative order of a LINE-POINT among the set of LINE-POINTs associated with a specific LINE.
        /// </summary>
        /// <value>
        /// Value of the column seq_ord
        /// </value>
        [AttrIx(100003)]
		[AttrName("line-point-sequence-ordinal")]
		[AttrColumnName("seq_ord")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100002200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int SequenceOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("line-point-point-id")]
		[AttrColumnName("point_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal PointId { get; set; }
		
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

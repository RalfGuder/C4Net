using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity UxoStatus that represents the table UXO_STAT
	/// 
	/// A MATERIEL-STATUS that is a record of the condition of an explosive ordnance that has been primed, fused, armed, or otherwise prepared for action, and which has been fired, dropped, launched, placed in such a manner, as to constitute a hazard to operation, and remains unexploded either by malfunction or for any other cause.
    /// </summary>
	[EntId(10000236)]
    [EntName("UXO-STATUS")]
    [EntTableName("UXO_STAT")]
    [EntDepth(5)]
    public interface IUxoStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column uxo_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column uxo_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("uxo-status-id")]
		[AttrColumnName("uxo_stat_id")]
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
        /// Gets or sets the value of the column exp_code
		///
		/// The specific value that represents the visual status of a specific Unexploded Explosive Ordnance.
        /// </summary>
        /// <value>
        /// Value of the column exp_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("uxo-status-exposure-code")]
		[AttrColumnName("exp_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100004133)]
        [DataLength(6)]
        [DataDecimals(0)]
        UxoStatusExposureEnum Exposure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents the qualification status of a specific Unexploded Explosive Ordnance.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("uxo-status-qualifier-code")]
		[AttrColumnName("qual_code")]
        [AttrSeqnr(4)]
        [DomId(100004134)]
        [DataLength(6)]
        [DataDecimals(0)]
        UxoStatusQualifierEnum? Qualifier { get; set; }
		
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

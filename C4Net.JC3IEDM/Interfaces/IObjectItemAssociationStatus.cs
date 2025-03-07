using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemAssociationStatus that represents the table OBJ_ITEM_ASSOC_STAT
	/// 
	/// A record of the perceived condition of a specific OBJECT-ITEM-ASSOCIATION as determined by the reporting organisation.
    /// </summary>
	[EntId(10000244)]
    [EntName("OBJECT-ITEM-ASSOCIATION-STATUS")]
    [EntTableName("OBJ_ITEM_ASSOC_STAT")]
    [EntDepth(6)]
    public interface IObjectItemAssociationStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column subj_obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-association-subject-object-item-id")]
		[AttrColumnName("subj_obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemAssociationSubjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_obj_item_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-association-object-object-item-id")]
		[AttrColumnName("obj_obj_item_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemAssociationObjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION for a subject OBJECT-ITEM and an object OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-ASSOCIATIONs for those OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-association-index")]
		[AttrColumnName("obj_item_assoc_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemAssociationIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION-STATUS for a specific OBJECT-ITEM-ASSOCIATION and to distinguish it from all other OBJECT-ITEM-ASSOCIATION-STATUSs for that OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_stat_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-association-status-index")]
		[AttrColumnName("obj_item_assoc_stat_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates if the status of a specific OBJECT-ITEM-ASSOCIATION-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-association-status-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100004242)]
        [DataLength(6)]
        [DataDecimals(0)]
        AssociationStatusCategoryEnum ObjectItemAssociationStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(6)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
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

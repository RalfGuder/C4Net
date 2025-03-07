using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectItemCapability that represents the table OBJ_ITEM_CAPAB
	/// 
	/// A perceived value of a specific CAPABILITY of an OBJECT-ITEM.
    /// </summary>
	[EntId(10000078)]
    [EntName("OBJECT-ITEM-CAPABILITY")]
    [EntTableName("OBJ_ITEM_CAPAB")]
    [EntDepth(3)]
    public interface IObjectItemCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column capab_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("capability-id")]
		[AttrColumnName("capab_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000902)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CapabilityId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_capab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-CAPABILITY for a specific OBJECT-ITEM and a specific CAPABILITY and to distinguish it from all other OBJECT-ITEM-CAPABILITYs for that OBJECT-ITEM and that CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_capab_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-item-capability-index")]
		[AttrColumnName("obj_item_capab_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column msn_primacy_code
		///
		/// The specific value that represents the priority of the role that a specific capability, restricted to be an OPERATIONAL-CAPABILITY, has for the specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column msn_primacy_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-capability-mission-primacy-code")]
		[AttrColumnName("msn_primacy_code")]
        [AttrSeqnr(4)]
        [DomId(100000327)]
        [DataLength(6)]
        [DataDecimals(0)]
        MissionPrimacyEnum? MissionPrimacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific CAPABILITY that is estimated to be attainable for a specific OBJECT-ITEM. The unit of measure is defined in the CAPABILITY specification.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-item-capability-quantity")]
		[AttrColumnName("qty")]
        [AttrSeqnr(5)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? Quantity { get; set; }
		
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

using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectTypeCapabilityNorm that represents the table OBJ_TYPE_CAPAB_NORM
	/// 
	/// The standard value of a specific CAPABILITY of an OBJECT-TYPE.
    /// </summary>
	[EntId(10000084)]
    [EntName("OBJECT-TYPE-CAPABILITY-NORM")]
    [EntTableName("OBJ_TYPE_CAPAB_NORM")]
    [EntDepth(1)]
    public interface IObjectTypeCapabilityNorm
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
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
        /// Gets or sets the value of the column msn_primacy_code
		///
		/// The specific value that represents the priority of the role that a specific capability, restricted to be an OPERATIONAL-CAPABILITY, has for the specific OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column msn_primacy_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-type-capability-norm-mission-primacy-code")]
		[AttrColumnName("msn_primacy_code")]
        [AttrSeqnr(3)]
        [DomId(100000327)]
        [DataLength(6)]
        [DataDecimals(0)]
        MissionPrimacyEnum? MissionPrimacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific CAPABILITY that is specified in a particular OBJECT-TYPE-CAPABILITY-NORM to be attainable for a specific OBJECT-TYPE. The unit of measure is defined in the CAPABILITY specification.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-type-capability-norm-quantity")]
		[AttrColumnName("qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? Quantity { get; set; }
		
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

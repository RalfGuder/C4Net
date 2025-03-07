using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity OperationalCapability that represents the table OPERAT_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those objects and types of objects that are deemed as having the ability, the training and the equipment to perform an operation.
    /// </summary>
	[EntId(10000335)]
    [EntName("OPERATIONAL-CAPABILITY")]
    [EntTableName("OPERAT_CAPAB")]
    [EntDepth(1)]
    public interface IOperationalCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column operat_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column operat_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("operational-capability-id")]
		[AttrColumnName("operat_capab_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000902)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that identifies a particular OPERATIONAL-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("operational-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004362)]
        [DataLength(6)]
        [DataDecimals(0)]
        OperationalCapabilityCategoryEnum OperationalCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lvl_code
		///
		/// The specific value that represents the force level at which the specific OPERATIONAL-CAPABILITY is intended to be performed.
        /// </summary>
        /// <value>
        /// Value of the column lvl_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("operational-capability-level-code")]
		[AttrColumnName("lvl_code")]
        [AttrSeqnr(3)]
        [DomId(100004363)]
        [DataLength(6)]
        [DataDecimals(0)]
        OperationalCapabilityLevelEnum? Level { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents the degree to which the specific OPERATIONAL-CAPABILITY can be fulfilled.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("operational-capability-qualifier-code")]
		[AttrColumnName("qual_code")]
        [AttrSeqnr(4)]
        [DomId(100004364)]
        [DataLength(6)]
        [DataDecimals(0)]
        OperationalCapabilityQualifierEnum? Qualifier { get; set; }
		
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

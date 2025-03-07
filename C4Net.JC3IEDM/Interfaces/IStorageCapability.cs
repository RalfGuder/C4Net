using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity StorageCapability that represents the table STORAGE_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those FACILITYs and MATERIELs or EQUIPMENT-TYPEs and FACILITY-TYPEs that are deemed as having the ability to hold a specific OBJECT-TYPE.
    /// </summary>
	[EntId(10000117)]
    [EntName("STORAGE-CAPABILITY")]
    [EntTableName("STORAGE_CAPAB")]
    [EntDepth(1)]
    public interface IStorageCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column storage_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column storage_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("storage-capability-id")]
		[AttrColumnName("storage_capab_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000902)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cargo_cat_code
		///
		/// The specific value that represents the class of cargo subject to the STORAGE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cargo_cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("storage-capability-cargo-category-code")]
		[AttrColumnName("cargo_cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004345)]
        [DataLength(6)]
        [DataDecimals(0)]
        CargoCategoryEnum CargoCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the STORAGE-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("storage-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004359)]
        [DataLength(6)]
        [DataDecimals(0)]
        StorageCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cond_code
		///
		/// The specific value that represents the type of storage condition.
        /// </summary>
        /// <value>
        /// Value of the column cond_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("storage-capability-condition-code")]
		[AttrColumnName("cond_code")]
        [AttrSeqnr(4)]
        [DomId(100004360)]
        [DataLength(6)]
        [DataDecimals(0)]
        StorageCapabilityConditionEnum? Condition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("object-type-id")]
		[AttrColumnName("obj_type_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

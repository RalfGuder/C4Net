using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity HandlingCapability that represents the table HNDL_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those FACILITYs and MATERIELs, or FACILITY-TYPEs and EQUIPMENT-TYPEs that are deemed as having the ability to move materiels (raw materials, scrap, semi-finished, and finished) to, through, and from productive processes; in warehouses and storage; and in receiving and shipping areas.
    /// </summary>
	[EntId(10000331)]
    [EntName("HANDLING-CAPABILITY")]
    [EntTableName("HNDL_CAPAB")]
    [EntDepth(1)]
    public interface IHandlingCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column hndl_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column hndl_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("handling-capability-id")]
		[AttrColumnName("hndl_capab_id")]
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
		/// The specific value that represents the class of cargo subject to the HANDLING-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cargo_cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("handling-capability-cargo-category-code")]
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
		/// The specific value that represents the HANDLING-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("handling-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004346)]
        [DataLength(6)]
        [DataDecimals(0)]
        HandlingCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_code
		///
		/// The specific value that represents the type of a specific HANDLING-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column act_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("handling-capability-action-code")]
		[AttrColumnName("act_code")]
        [AttrSeqnr(4)]
        [DomId(100004347)]
        [DataLength(6)]
        [DataDecimals(0)]
        HandlingCapabilityActionEnum? Action { get; set; }
		
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

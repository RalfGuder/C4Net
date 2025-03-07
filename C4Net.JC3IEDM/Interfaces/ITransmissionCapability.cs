using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity TransmissionCapability that represents the table TRNSM_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those MATERIELs or MATERIEL-TYPEs that are deemed as having the ability to generate, receive or affect signals in the electromagnetic spectrum.
    /// </summary>
	[EntId(10000334)]
    [EntName("TRANSMISSION-CAPABILITY")]
    [EntTableName("TRNSM_CAPAB")]
    [EntDepth(4)]
    public interface ITransmissionCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column trnsm_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column trnsm_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("transmission-capability-id")]
		[AttrColumnName("trnsm_capab_id")]
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
		/// The specific value that represents the class of TRANSMISSION-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("transmission-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004352)]
        [DataLength(6)]
        [DataDecimals(0)]
        TransmissionCapabilityCategoryEnum TransmissionCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the TRANSMISSION-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("transmission-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004353)]
        [DataLength(6)]
        [DataDecimals(0)]
        TransmissionCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elctrnc_eqpt_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column elctrnc_eqpt_type_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("electronic-equipment-type-id")]
		[AttrColumnName("elctrnc_eqpt_type_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? ElectronicEquipmentTypeId { get; set; }
		
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

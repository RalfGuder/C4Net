using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity EngineeringCapability that represents the table ENG_CAPAB
	/// 
	/// A CAPABILITY, required for planning, of those ORGANISATIONs and PERSONs or ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the ability to perform construction or destruction activities.
    /// </summary>
	[EntId(10000040)]
    [EntName("ENGINEERING-CAPABILITY")]
    [EntTableName("ENG_CAPAB")]
    [EntDepth(2)]
    public interface IEngineeringCapability
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column eng_capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column eng_capab_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("engineering-capability-id")]
		[AttrColumnName("eng_capab_id")]
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
		/// The specific value that represents the class of ENGINEERING-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("engineering-capability-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004354)]
        [DataLength(6)]
        [DataDecimals(0)]
        EngineeringCapabilityCategoryEnum EngineeringCapabilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents a specific ENGINEERING-CAPABILITY in terms of a measurable quantity.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("engineering-capability-descriptor-code")]
		[AttrColumnName("dscpt_code")]
        [AttrSeqnr(3)]
        [DomId(100004355)]
        [DataLength(6)]
        [DataDecimals(0)]
        EngineeringCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_height_dim
		///
		/// The one-dimensional linear distance representing the vertical distance, measured from the lowest to the highest reference, of either the FACILITY-TYPE itself (in the case of construction) or the breach in the FACILITY-TYPE (in the case of destruction).
        /// </summary>
        /// <value>
        /// Value of the column fac_height_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("engineering-capability-facility-height-dimension")]
		[AttrColumnName("fac_height_dim")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double FacilityHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_length_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance, measured from end to end and parallel to the central axis, of either the FACILITY-TYPE itself (in the case of construction) or the breach in the FACILITY-TYPE (in the case of destruction).
        /// </summary>
        /// <value>
        /// Value of the column fac_length_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("engineering-capability-facility-length-dimension")]
		[AttrColumnName("fac_length_dim")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double FacilityLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_width_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance, measured from side to side and perpendicular to the central axis, of either the FACILITY-TYPE itself (in the case of construction) or the breach in the FACILITY-TYPE (in the case of destruction).
        /// </summary>
        /// <value>
        /// Value of the column fac_width_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("engineering-capability-facility-width-dimension")]
		[AttrColumnName("fac_width_dim")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double FacilityWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column fac_type_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("facility-type-id")]
		[AttrColumnName("fac_type_id")]
        [AttrSeqnr(7)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal FacilityTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

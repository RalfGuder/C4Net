using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity UnitType that represents the table UNIT_TYPE
	/// 
	/// A MILITARY-ORGANISATION-TYPE whose structure is prescribed by competent authority.
    /// </summary>
	[EntId(10000129)]
    [EntName("UNIT-TYPE")]
    [EntTableName("UNIT_TYPE")]
    [EntDepth(4)]
    public interface IUnitType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column unit_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column unit_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("unit-type-id")]
		[AttrColumnName("unit_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("unit-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000333)]
        [DataLength(6)]
        [DataDecimals(0)]
        UnitTypeCategoryEnum UnitTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arm_cat_code
		///
		/// The specific value that represents the designation of a military branch for a particular UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column arm_cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("unit-type-arm-category-code")]
		[AttrColumnName("arm_cat_code")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100000331)]
        [DataLength(6)]
        [DataDecimals(0)]
        UnitTypeArmCategoryEnum ArmCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arm_spclsn_code
		///
		/// The specific value that qualifies the functional specialisation of a particular UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column arm_spclsn_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("unit-type-arm-specialisation-code")]
		[AttrColumnName("arm_spclsn_code")]
        [AttrSeqnr(4)]
        [DomId(100000332)]
        [DataLength(6)]
        [DataDecimals(0)]
        UnitTypeArmSpecialisationEnum? ArmSpecialisation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column suppl_spclsn_code
		///
		/// The specific value that supplements the designation of a particular UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column suppl_spclsn_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("unit-type-supplementary-specialisation-code")]
		[AttrColumnName("suppl_spclsn_code")]
        [AttrSeqnr(5)]
        [DomId(100004186)]
        [DataLength(6)]
        [DataDecimals(0)]
        UnitTypeSupplementarySpecialisationEnum? SupplementarySpecialisation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gen_mob_code
		///
		/// The specific value that represents the general mobility of a unit, seen as a whole.
        /// </summary>
        /// <value>
        /// Value of the column gen_mob_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("unit-type-general-mobility-code")]
		[AttrColumnName("gen_mob_code")]
        [AttrSeqnr(6)]
        [DomId(100004187)]
        [DataLength(6)]
        [DataDecimals(0)]
        UnitTypeGeneralMobilityEnum? GeneralMobility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that conveys additional information on the specified UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("unit-type-qualifier-code")]
		[AttrColumnName("qual_code")]
        [AttrSeqnr(7)]
        [DomId(100004188)]
        [DataLength(6)]
        [DataDecimals(0)]
        UnitTypeQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column size_code
		///
		/// The specific value that represents the relative size of the commonly accepted configuration of military formations.
        /// </summary>
        /// <value>
        /// Value of the column size_code
        /// </value>
        [AttrIx(100008)]
		[AttrName("unit-type-size-code")]
		[AttrColumnName("size_code")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000166)]
        [DataLength(6)]
        [DataDecimals(0)]
        EchelonSizeEnum Size { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column principal_eqpt_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column principal_eqpt_type_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("unit-type-principal-equipment-type-id")]
		[AttrColumnName("principal_eqpt_type_id")]
        [AttrSeqnr(9)]
        [ForeignKey]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? PrincipalEquipmentTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column supported_mil_org_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column supported_mil_org_type_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("unit-type-supported-military-organisation-type-id")]
		[AttrColumnName("supported_mil_org_type_id")]
        [AttrSeqnr(10)]
        [ForeignKey]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? SupportedMilitaryOrganisationTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(11)]
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
        [AttrIx(100012)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(12)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RadioactiveMaterielType that represents the table RADACT_MAT_TYPE
	/// 
	/// A CONSUMABLE-MATERIEL-TYPE that is a substance which spontaneously emits radiation, and which may kill, seriously injure, or incapacitate personnel through its physiological effects or causes the deterioration of materiel.
    /// </summary>
	[EntId(10000196)]
    [EntName("RADIOACTIVE-MATERIEL-TYPE")]
    [EntTableName("RADACT_MAT_TYPE")]
    [EntDepth(3)]
    public interface IRadioactiveMaterielType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column radact_mat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column radact_mat_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("radioactive-materiel-type-id")]
		[AttrColumnName("radact_mat_type_id")]
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
		/// The specific value that represents the class of RADIOACTIVE-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("radioactive-materiel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000364)]
        [DataLength(6)]
        [DataDecimals(0)]
        RadioactiveMaterielTypeCategoryEnum RadioactiveMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prim_rad_code
		///
		/// The specific value that represents the most intense radiation emitted by a RADIOACTIVE-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column prim_rad_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("radioactive-materiel-type-primary-radiation-code")]
		[AttrColumnName("prim_rad_code")]
        [AttrSeqnr(3)]
        [DomId(100000365)]
        [DataLength(6)]
        [DataDecimals(0)]
        RadioactiveMaterielTypePrimaryRadiationEnum? PrimaryRadiation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

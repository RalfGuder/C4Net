using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity WeaponType that represents the table WEAPON_TYPE
	/// 
	/// An EQUIPMENT-TYPE of any kind used in warfare or combat to attack and overcome an enemy.
    /// </summary>
	[EntId(10000187)]
    [EntName("WEAPON-TYPE")]
    [EntTableName("WEAPON_TYPE")]
    [EntDepth(3)]
    public interface IWeaponType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column weapon_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column weapon_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("weapon-type-id")]
		[AttrColumnName("weapon_type_id")]
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
		/// The specific value that represents the class of WEAPON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("weapon-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000342)]
        [DataLength(6)]
        [DataDecimals(0)]
        WeaponTypeCategoryEnum WeaponTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of WEAPON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("weapon-type-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100000343)]
        [DataLength(6)]
        [DataDecimals(0)]
        WeaponTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column calibre_txt
		///
		/// The character string assigned to represent a specific calibre of a WEAPON-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column calibre_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("weapon-type-calibre-text")]
		[AttrColumnName("calibre_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string CalibreText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fire_guidance_ind_code
		///
		/// The specific value that indicates whether a specific WEAPON-TYPE provides fire guidance.
        /// </summary>
        /// <value>
        /// Value of the column fire_guidance_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("weapon-type-fire-guidance-indicator-code")]
		[AttrColumnName("fire_guidance_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100000335)]
        [DataLength(6)]
        [DataDecimals(0)]
        WeaponTypeFireGuidanceIndicatorEnum? FireGuidanceIndicator { get; set; }
		
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

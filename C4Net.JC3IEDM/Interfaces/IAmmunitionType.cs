using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AmmunitionType that represents the table AMMO_TYPE
	/// 
	/// A CONSUMABLE-MATERIEL-TYPE that is a complete device charged with explosives, propellants, pyrotechnics, initiating composition, or nuclear, biological, or chemical material for use in military operations.
    /// </summary>
	[EntId(10000223)]
    [EntName("AMMUNITION-TYPE")]
    [EntTableName("AMMO_TYPE")]
    [EntDepth(3)]
    public interface IAmmunitionType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ammo_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column ammo_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("ammunition-type-id")]
		[AttrColumnName("ammo_type_id")]
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
		/// The specific value that represents the class of AMMUNITION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("ammunition-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004110)]
        [DataLength(6)]
        [DataDecimals(0)]
        AmmunitionTypeCategoryEnum AmmunitionTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column calibre_txt
		///
		/// The character string assigned to represent a specific calibre of an AMMUNITION-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column calibre_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("ammunition-type-calibre-text")]
		[AttrColumnName("calibre_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string CalibreText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_mrt_firing_code
		///
		/// The specific value that represents the firing mechanism for a maritime mine.
        /// </summary>
        /// <value>
        /// Value of the column mine_mrt_firing_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("ammunition-type-mine-maritime-firing-code")]
		[AttrColumnName("mine_mrt_firing_code")]
        [AttrSeqnr(4)]
        [DomId(100004280)]
        [DataLength(6)]
        [DataDecimals(0)]
        AmmunitionTypeMineMaritimeFiringEnum? MineMaritimeFiring { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column exer_mine_flare_colour_code
		///
		/// The specific value that represents the colour of the flare released by the exercise mine.
        /// </summary>
        /// <value>
        /// Value of the column exer_mine_flare_colour_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("ammunition-type-exercise-mine-flare-colour-code")]
		[AttrColumnName("exer_mine_flare_colour_code")]
        [AttrSeqnr(5)]
        [DomId(100004344)]
        [DataLength(6)]
        [DataDecimals(0)]
        AmmunitionTypeExerciseMineFlareColourEnum? ExerciseMineFlareColour { get; set; }
		
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

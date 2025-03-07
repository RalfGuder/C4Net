using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Minefield that represents the table MNFLD
	/// 
	/// A MILITARY-OBSTACLE that is an area or volume containing mines.
    /// </summary>
	[EntId(10000074)]
    [EntName("MINEFIELD")]
    [EntTableName("MNFLD")]
    [EntDepth(4)]
    public interface IMinefield
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("minefield-id")]
		[AttrColumnName("mnfld_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MINEFIELD. It serves as a discriminator that partitions MINEFIELD into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("minefield-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004195)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldCategoryEnum MinefieldCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column identific_txt
		///
		/// The character string assigned to represent the designation of a minefield.
        /// </summary>
        /// <value>
        /// Value of the column identific_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("minefield-identification-text")]
		[AttrColumnName("identific_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string IdentificationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_spc_dim
		///
		/// The one-dimensional linear distance representing the distance between the mines emplaced in a specific MINEFIELD.
        /// </summary>
        /// <value>
        /// Value of the column mine_spc_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("minefield-mine-spacing-dimension")]
		[AttrColumnName("mine_spc_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? MineSpacingDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column destruction_dttm
		///
		/// The character string representing a point in time that designates the destruction of a specific MINEFIELD.
        /// </summary>
        /// <value>
        /// Value of the column destruction_dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("minefield-destruction-datetime")]
		[AttrColumnName("destruction_dttm")]
        [AttrSeqnr(5)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string DestructionDatetime { get; set; }
		
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

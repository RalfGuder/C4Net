using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Unit that represents the table UNIT
	/// 
	/// A military ORGANISATION whose structure is prescribed by competent authority.
    /// </summary>
	[EntId(10000128)]
    [EntName("UNIT")]
    [EntTableName("UNIT")]
    [EntDepth(2)]
    public interface IUnit
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column unit_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column unit_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("unit-id")]
		[AttrColumnName("unit_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column formal_abbrd_name_txt
		///
		/// The character string specifying the common formal abbreviation used to designate a specific UNIT.
        /// </summary>
        /// <value>
        /// Value of the column formal_abbrd_name_txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("unit-formal-abbreviated-name-text")]
		[AttrColumnName("formal_abbrd_name_txt")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string FormalAbbreviatedNameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column identific_txt
		///
		/// The character string assigned to represent a unit’s identification.
        /// </summary>
        /// <value>
        /// Value of the column identific_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("unit-identification-text")]
		[AttrColumnName("identific_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string IdentificationText { get; set; }
		
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

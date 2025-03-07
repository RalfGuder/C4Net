using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Materiel that represents the table MAT
	/// 
	/// An OBJECT-ITEM that is equipment, apparatus or supplies of military interest without distinction as to its application for administrative or combat purposes.
    /// </summary>
	[EntId(10000067)]
    [EntName("MATERIEL")]
    [EntTableName("MAT")]
    [EntDepth(1)]
    public interface IMateriel
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("materiel-id")]
		[AttrColumnName("mat_id")]
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
		/// The specific value that represents the class of MATERIEL. It serves as a discriminator that partitions MATERIEL into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("materiel-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004316)]
        [DataLength(6)]
        [DataDecimals(0)]
        MaterielCategoryEnum MaterielCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column serial_no_id_txt
		///
		/// The character string assigned to represent a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column serial_no_id_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("materiel-serial-number-identification-text")]
		[AttrColumnName("serial_no_id_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string SerialNumberIdentificationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lot_identific_txt
		///
		/// The character string assigned to represent a specific production of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column lot_identific_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("materiel-lot-identification-text")]
		[AttrColumnName("lot_identific_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string LotIdentificationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column hull_no_txt
		///
		/// The character string assigned to represent the number assigned to a specific vessel, which when associated with a specific hull type or ship type, uniquely identifies that vessel.
        /// </summary>
        /// <value>
        /// Value of the column hull_no_txt
        /// </value>
        [AttrIx(100005)]
		[AttrName("materiel-hull-number-text")]
		[AttrColumnName("hull_no_txt")]
        [AttrSeqnr(5)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string HullNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_rqn_case_no_txt
		///
		/// The character string assigned to represent the book/record keeping number to keep track of individual mines.
        /// </summary>
        /// <value>
        /// Value of the column mine_rqn_case_no_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("materiel-mine-requisition-case-number-text")]
		[AttrColumnName("mine_rqn_case_no_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string MineRequisitionCaseNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity AirspaceControlMeans that represents the table ARSP_CTRL_MEANS
	/// 
	/// A CONTROL-FEATURE that reserves airspace for specific airspace users, restricts the action of airspace users, controls the actions of specific airspace users, and/or requires airspace users to accomplish specific actions.
    /// </summary>
	[EntId(10000285)]
    [EntName("AIRSPACE-CONTROL-MEANS")]
    [EntTableName("ARSP_CTRL_MEANS")]
    [EntDepth(3)]
    public interface IAirspaceControlMeans
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column arsp_ctrl_means_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column arsp_ctrl_means_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("airspace-control-means-id")]
		[AttrColumnName("arsp_ctrl_means_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trnst_instr_txt
		///
		/// The character string assigned to represent the specific transit instructions for a specific airspace.
        /// </summary>
        /// <value>
        /// Value of the column trnst_instr_txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("airspace-control-means-transit-instruction-text")]
		[AttrColumnName("trnst_instr_txt")]
        [AttrSeqnr(2)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string TransitInstructionText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

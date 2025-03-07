using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ApproachDirection that represents the table APPR_DIR
	/// 
	/// A CONTROL-FEATURE that specifies approach directional details for takeoff and landing.
    /// </summary>
	[EntId(10000319)]
    [EntName("APPROACH-DIRECTION")]
    [EntTableName("APPR_DIR")]
    [EntDepth(3)]
    public interface IApproachDirection
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column appr_dir_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column appr_dir_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("approach-direction-id")]
		[AttrColumnName("appr_dir_id")]
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
		/// The specific value that differentiates between left, right and centre parallel runways, Short Takeoff and Landing (STOL) or true as applicable.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("approach-direction-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [DomId(100004279)]
        [DataLength(6)]
        [DataDecimals(0)]
        ApproachDirectionCategoryEnum? ApproachDirectionCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column angle_txt
		///
		/// The character string assigned to represent a runway in terms of a whole number nearest one-tenth of the magnetic azimuth of the centreline of the runway, measured clockwise from magnetic north (where six degrees is used as the break off point for the next highest number).
        /// </summary>
        /// <value>
        /// Value of the column angle_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("approach-direction-angle-text")]
		[AttrColumnName("angle_txt")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(3)]
        [DataDecimals(0)]
        string AngleText { get; set; }
		
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

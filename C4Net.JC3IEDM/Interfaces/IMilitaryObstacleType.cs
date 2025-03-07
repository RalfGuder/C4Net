using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MilitaryObstacleType that represents the table MIL_OBS_TYPE
	/// 
	/// A FACILITY-TYPE that is a class of man-made devices or passive defence works that are designed to stop, impede, or divert movement of amphibious or ground forces.
    /// </summary>
	[EntId(10000248)]
    [EntName("MILITARY-OBSTACLE-TYPE")]
    [EntTableName("MIL_OBS_TYPE")]
    [EntDepth(2)]
    public interface IMilitaryObstacleType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mil_obs_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column mil_obs_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("military-obstacle-type-id")]
		[AttrColumnName("mil_obs_type_id")]
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
		/// The specific value that represents the class of MILITARY-OBSTACLE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("military-obstacle-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004147)]
        [DataLength(6)]
        [DataDecimals(0)]
        MilitaryObstacleTypeCategoryEnum MilitaryObstacleTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of MILITARY-OBSTACLE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("military-obstacle-type-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100004379)]
        [DataLength(6)]
        [DataDecimals(0)]
        MilitaryObstacleTypeSubcategoryEnum? Subcategory { get; set; }
		
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

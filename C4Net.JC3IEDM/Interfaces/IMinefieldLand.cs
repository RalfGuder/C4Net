using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MinefieldLand that represents the table MNFLD_LAND
	/// 
	/// A MINEFIELD that is an area of land containing mines.
    /// </summary>
	[EntId(10000274)]
    [EntName("MINEFIELD-LAND")]
    [EntTableName("MNFLD_LAND")]
    [EntDepth(5)]
    public interface IMinefieldLand
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_land_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_land_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("minefield-land-id")]
		[AttrColumnName("mnfld_land_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_plcmnt_code
		///
		/// The specific value that indicates the placement of mines with respect to the surface.
        /// </summary>
        /// <value>
        /// Value of the column depth_plcmnt_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("minefield-land-depth-placement-code")]
		[AttrColumnName("depth_plcmnt_code")]
        [AttrSeqnr(2)]
        [DomId(100000314)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldLandDepthPlacementEnum? DepthPlacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column func_code
		///
		/// The specific value that represents the intended function of the specific MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column func_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("minefield-land-function-code")]
		[AttrColumnName("func_code")]
        [AttrSeqnr(3)]
        [DomId(100004196)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldLandFunctionEnum? Function { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pattern_code
		///
		/// The specific value that represents the pattern of a specific MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column pattern_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("minefield-land-pattern-code")]
		[AttrColumnName("pattern_code")]
        [AttrSeqnr(4)]
        [DomId(100000141)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldLandPatternEnum? Pattern { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persistence_code
		///
		/// The specific value that represents the option for terminating the effectiveness of a specific MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column persistence_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("minefield-land-persistence-code")]
		[AttrColumnName("persistence_code")]
        [AttrSeqnr(5)]
        [DomId(100000142)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldLandPersistenceEnum? Persistence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stopping_power_code
		///
		/// The specific value that represents the stopping power of a particular MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column stopping_power_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("minefield-land-stopping-power-code")]
		[AttrColumnName("stopping_power_code")]
        [AttrSeqnr(6)]
        [DomId(100000315)]
        [DataLength(6)]
        [DataDecimals(0)]
        MinefieldLandStoppingPowerEnum? StoppingPower { get; set; }
		
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

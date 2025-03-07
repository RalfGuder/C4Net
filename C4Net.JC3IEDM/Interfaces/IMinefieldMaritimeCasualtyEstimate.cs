using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MinefieldMaritimeCasualtyEstimate that represents the table MNFLD_MRT_CAS_EST
	/// 
	/// An estimate of the average number of casualties for a given number of vessel transits through a specific MINEFIELD-MARITIME.
    /// </summary>
	[EntId(10000276)]
    [EntName("MINEFIELD-MARITIME-CASUALTY-ESTIMATE")]
    [EntTableName("MNFLD_MRT_CAS_EST")]
    [EntDepth(6)]
    public interface IMinefieldMaritimeCasualtyEstimate
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_mrt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("minefield-maritime-id")]
		[AttrColumnName("mnfld_mrt_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal MinefieldMaritimeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_mrt_cas_est_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MINEFIELD-MARITIME-CASUALTY-ESTIMATE for a specific MINEFIELD-MARITIME and to distinguish it from all other MINEFIELD-MARITIME-CASUALTY-ESTIMATEs for that MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_cas_est_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("minefield-maritime-casualty-estimate-index")]
		[AttrColumnName("mnfld_mrt_cas_est_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column avg_cnt
		///
		/// The integer value representing the planned or estimated number of casualties for a specific MINEFIELD-MARITIME-CASUALTY-ESTIMATE that would occur as an average in a large number of transit attempts.
        /// </summary>
        /// <value>
        /// Value of the column avg_cnt
        /// </value>
        [AttrIx(100003)]
		[AttrName("minefield-maritime-casualty-estimate-average-count")]
		[AttrColumnName("avg_cnt")]
        [AttrSeqnr(3)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? AverageCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column given_transit_cnt
		///
		/// The integer value representing the given number of transits for a specific MINEFIELD-MARITIME-CASUALTY-ESTIMATE.
        /// </summary>
        /// <value>
        /// Value of the column given_transit_cnt
        /// </value>
        [AttrIx(100004)]
		[AttrName("minefield-maritime-casualty-estimate-given-transit-count")]
		[AttrColumnName("given_transit_cnt")]
        [AttrSeqnr(4)]
        [DomId(100001800)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? GivenTransitCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

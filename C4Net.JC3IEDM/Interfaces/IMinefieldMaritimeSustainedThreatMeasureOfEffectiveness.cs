using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity MinefieldMaritimeSustainedThreatMeasureOfEffectiveness that represents the table MNFLD_MRT_SUST_THRT_MOE
	/// 
	/// A measure of effectiveness for a specific MINEFIELD-MARITIME in terms of probability of mine function against a transit vessel over a given period of time.
    /// </summary>
	[EntId(10000277)]
    [EntName("MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS")]
    [EntTableName("MNFLD_MRT_SUST_THRT_MOE")]
    [EntDepth(6)]
    public interface IMinefieldMaritimeSustainedThreatMeasureOfEffectiveness
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
        /// Gets or sets the value of the column mnfld_mrt_sust_thrt_moe_ix
		///
		/// The unique value assigned to represent a specific MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS for a specific MINEFIELD-MARITIME and to distinguish it from all other MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESSs for that MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_sust_thrt_moe_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("minefield-maritime-sustained-threat-measure-of-effectiveness-index")]
		[AttrColumnName("mnfld_mrt_sust_thrt_moe_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plnd_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the planned or estimated duration for a specific MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS.
        /// </summary>
        /// <value>
        /// Value of the column plnd_dur
        /// </value>
        [AttrIx(100003)]
		[AttrName("minefield-maritime-sustained-threat-measure-of-effectiveness-planned-duration")]
		[AttrColumnName("plnd_dur")]
        [AttrSeqnr(3)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? PlannedDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prob_rat
		///
		/// The numeric quotient value that represents the planned or estimated likelihood of threat over an extended period for a specific MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column prob_rat
        /// </value>
        [AttrIx(100004)]
		[AttrName("minefield-maritime-sustained-threat-measure-of-effectiveness-probability-ratio")]
		[AttrColumnName("prob_rat")]
        [AttrSeqnr(4)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? ProbabilityRatio { get; set; }
		
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

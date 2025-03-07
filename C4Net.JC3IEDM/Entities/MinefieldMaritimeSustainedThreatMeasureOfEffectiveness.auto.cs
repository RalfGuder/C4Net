using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS that represents the table MNFLD_MRT_SUST_THRT_MOE.
	///
	/// A measure of effectiveness for a specific MINEFIELD-MARITIME in terms of probability of mine function against a transit vessel over a given period of time.
    /// </summary>
    [Serializable]
    [DefinitionName("MinefieldMaritimeSustainedThreatMeasureOfEffectiveness", "C4Net.JC3IEDM.Definitions.MinefieldMaritimeSustainedThreatMeasureOfEffectiveness.definition.xml")]
    public class MinefieldMaritimeSustainedThreatMeasureOfEffectiveness : IEntity, IMinefieldMaritimeSustainedThreatMeasureOfEffectiveness
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly MinefieldMaritimeSustainedThreatMeasureOfEffectivenessExpression _ = new MinefieldMaritimeSustainedThreatMeasureOfEffectivenessExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_mrt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_id
        /// </value>
		public decimal MinefieldMaritimeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mnfld_mrt_sust_thrt_moe_ix
		///
		/// The unique value assigned to represent a specific MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS for a specific MINEFIELD-MARITIME and to distinguish it from all other MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESSs for that MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_sust_thrt_moe_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column plnd_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the planned or estimated duration for a specific MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS.
        /// </summary>
        /// <value>
        /// Value of the column plnd_dur
        /// </value>
		public decimal? PlannedDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prob_rat
		///
		/// The numeric quotient value that represents the planned or estimated likelihood of threat over an extended period for a specific MINEFIELD-MARITIME-SUSTAINED-THREAT-MEASURE-OF-EFFECTIVENESS. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column prob_rat
        /// </value>
		public double? ProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}

using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINEFIELD-MARITIME-CASUALTY-ESTIMATE that represents the table MNFLD_MRT_CAS_EST.
	///
	/// An estimate of the average number of casualties for a given number of vessel transits through a specific MINEFIELD-MARITIME.
    /// </summary>
    [Serializable]
    [DefinitionName("MinefieldMaritimeCasualtyEstimate", "C4Net.JC3IEDM.Definitions.MinefieldMaritimeCasualtyEstimate.definition.xml")]
    public class MinefieldMaritimeCasualtyEstimate : IEntity, IMinefieldMaritimeCasualtyEstimate
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly MinefieldMaritimeCasualtyEstimateExpression _ = new MinefieldMaritimeCasualtyEstimateExpression();

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
        /// Gets or sets the value of the column mnfld_mrt_cas_est_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MINEFIELD-MARITIME-CASUALTY-ESTIMATE for a specific MINEFIELD-MARITIME and to distinguish it from all other MINEFIELD-MARITIME-CASUALTY-ESTIMATEs for that MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mnfld_mrt_cas_est_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column avg_cnt
		///
		/// The integer value representing the planned or estimated number of casualties for a specific MINEFIELD-MARITIME-CASUALTY-ESTIMATE that would occur as an average in a large number of transit attempts.
        /// </summary>
        /// <value>
        /// Value of the column avg_cnt
        /// </value>
		public int? AverageCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column given_transit_cnt
		///
		/// The integer value representing the given number of transits for a specific MINEFIELD-MARITIME-CASUALTY-ESTIMATE.
        /// </summary>
        /// <value>
        /// Value of the column given_transit_cnt
        /// </value>
		public int? GivenTransitCount { get; set; }
		
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

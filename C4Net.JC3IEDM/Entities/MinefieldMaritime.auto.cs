using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINEFIELD-MARITIME that represents the table MNFLD_MRT.
	///
	/// A MINEFIELD that is an area or volume of water containing mines.
    /// </summary>
    [Serializable]
    [DefinitionName("MinefieldMaritime", "C4Net.JC3IEDM.Definitions.MinefieldMaritime.definition.xml")]
    public class MinefieldMaritime : Minefield, IMinefieldMaritime
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MinefieldMaritimeExpression _ = new MinefieldMaritimeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column depth_plcmnt_code
		///
		/// The specific value that indicates the intended depth placement of maritime mines.
        /// </summary>
        /// <value>
        /// Value of the column depth_plcmnt_code
        /// </value>
		public MinefieldMaritimeDepthPlacementEnum? DepthPlacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column expct_vessel_transit_cnt
		///
		/// The integer value representing the expected number of transiting vessels.
        /// </summary>
        /// <value>
        /// Value of the column expct_vessel_transit_cnt
        /// </value>
		public int? ExpectedVesselTransitCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column func_code
		///
		/// The specific value that represents the intended function of a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column func_code
        /// </value>
		public MinefieldMaritimeFunctionEnum? Function { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mmoe_initial_thrt_prob_rat
		///
		/// The numeric quotient value that represents the planned or estimated likelihood that the first target ship to enter the minefield will be a casualty. MMOE stands for Minefield Measurement Of Effectiveness. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column mmoe_initial_thrt_prob_rat
        /// </value>
		public double? MmoeInitialThreatProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dtctn_prob_rat
		///
		/// The numeric quotient value that represents the probability that a mine will be located during MCM operations. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column dtctn_prob_rat
        /// </value>
		public double? DetectionProbabilityRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column life_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the estimated life of the MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column life_dur
        /// </value>
		public decimal? LifeDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_detld_txt
		///
		/// The character string assigned to represent a description of a specific mine.
        /// </summary>
        /// <value>
        /// Value of the column mine_detld_txt
        /// </value>
		public string MineDetailedText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_laid_cnt
		///
		/// The integer value representing the number of maritime mines laid in a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mines_laid_cnt
        /// </value>
		public int? MinesLaidCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column btm_natural_camo_code
		///
		/// The specific value that represents the description of the ground of a lake, river, or ocean, or other body of water with respect to the ability to hide mines on the bottom at a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column btm_natural_camo_code
        /// </value>
		public MinefieldMaritimeBottomNaturalCamouflageEnum? BottomNaturalCamouflage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subf_code
		///
		/// The specific value that represents the intended purpose of the MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column subf_code
        /// </value>
		public MinefieldMaritimeSubfunctionEnum? Subfunction { get; set; }
		
        #endregion
    }
}

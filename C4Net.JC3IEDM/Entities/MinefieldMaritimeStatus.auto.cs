using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINEFIELD-MARITIME-STATUS that represents the table MNFLD_MRT_STAT.
	///
	/// A FACILITY-STATUS that is a record of condition of a specific MINEFIELD-MARITIME.
    /// </summary>
    [Serializable]
    [DefinitionName("MinefieldMaritimeStatus", "C4Net.JC3IEDM.Definitions.MinefieldMaritimeStatus.definition.xml")]
    public class MinefieldMaritimeStatus : FacilityStatus, IMinefieldMaritimeStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MinefieldMaritimeStatusExpression _ = new MinefieldMaritimeStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the known status of a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public MinefieldMaritimeStatusEnum? MinefieldMaritimeStatusCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column colour_code
		///
		/// The specific value that represents the known status of mined channels of a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column colour_code
        /// </value>
		public MinefieldMaritimeStatusColourEnum? Colour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column expct_lvl_mcm_code
		///
		/// The specific values of expected mine countermeasures (MCM) to be employed against a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column expct_lvl_mcm_code
        /// </value>
		public MinefieldMaritimeStatusExpectedLevelMcmEnum? ExpectedLevelMcm { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_detected_qty
		///
		/// The numeric value representing the number of mines detected in a specific MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mines_detected_qty
        /// </value>
		public int? MinesDetectedQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_detected_cnt
		///
		/// The integer value representing the number of mines detected in a specific MINEFIELD-MARITIME at the time of the report.
        /// </summary>
        /// <value>
        /// Value of the column mines_detected_cnt
        /// </value>
		public int? MinesDetectedCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_zone_risk_code
		///
		/// The specific value that represents the known threat (risk) of a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mine_zone_risk_code
        /// </value>
		public MinefieldMaritimeStatusMineZoneRiskEnum? MineZoneRisk { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seeding_code
		///
		/// The specific value that indicates the seeding details for a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column seeding_code
        /// </value>
		public MinefieldMaritimeStatusSeedingEnum? Seeding { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column swept_depth_qty
		///
		/// The numeric value representing the depth below the surface to which minesweeping has taken place. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column swept_depth_qty
        /// </value>
		public double? SweptDepthQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column thrt_rat
		///
		/// The numeric quotient value that represents the current percentage threat to the enemy of a specific MINEFIELD-MARITIME. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column thrt_rat
        /// </value>
		public double? ThreatRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_dtctn_code
		///
		/// The specific value that represents the status of the means of detection of a mine in a MINEFIELD-MARITIME.
        /// </summary>
        /// <value>
        /// Value of the column mine_dtctn_code
        /// </value>
		public MinefieldMaritimeStatusMineDetectionEnum? MineDetection { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mines_cnt
		///
		/// The integer value representing the number of mines within a specific maritime minefield at the time of the report.
        /// </summary>
        /// <value>
        /// Value of the column mines_cnt
        /// </value>
		public int? MinesCount { get; set; }
		
        #endregion
    }
}

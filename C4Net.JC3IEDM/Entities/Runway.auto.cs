using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RUNWAY that represents the table RUNWAY.
	///
	/// A FACILITY that is a specifically prepared surface along which aircraft take off and land.
    /// </summary>
    [Serializable]
    [DefinitionName("Runway", "C4Net.JC3IEDM.Definitions.Runway.definition.xml")]
    public class Runway : Facility, IRunway
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RunwayExpression _ = new RunwayExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column lgtng_prsnc_ind_code
		///
		/// The specific value that indicates whether a specific RUNWAY has runway lighting.
        /// </summary>
        /// <value>
        /// Value of the column lgtng_prsnc_ind_code
        /// </value>
		public RunwayLightingPresenceIndicatorEnum? LightingPresenceIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wt_brng_cap_qty
		///
		/// The numeric value that denotes the maximum pressure that a specific RUNWAY is capable of carrying. The unit of measure is kilograms per square centimetre.
        /// </summary>
        /// <value>
        /// Value of the column wt_brng_cap_qty
        /// </value>
		public double? WeightBearingCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_clsfc_no_cnt
		///
		/// The integer value representing the pavement Classification Number (PCN), which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_clsfc_no_cnt
        /// </value>
		public int? PavementClassificationNumberCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_type_code
		///
		/// The specific value that represents the type of pavement classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_type_code
        /// </value>
		public RunwayPavementTypeEnum? PavementType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_subgrade_cat_code
		///
		/// The specific value that represents the pavement subgrade classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_subgrade_cat_code
        /// </value>
		public RunwayPavementSubgradeCategoryEnum? PavementSubgradeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_max_tyre_prs_code
		///
		/// The specific value that represents the pavement maximum tyre pressure classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_max_tyre_prs_code
        /// </value>
		public RunwayPavementMaximumTyrePressureEnum? PavementMaximumTyrePressure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pvm_eval_method_code
		///
		/// The specific value that represents the pavement evaluation method classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
        /// </summary>
        /// <value>
        /// Value of the column pvm_eval_method_code
        /// </value>
		public RunwayPavementEvaluationMethodEnum? PavementEvaluationMethod { get; set; }
		
        #endregion
    }
}

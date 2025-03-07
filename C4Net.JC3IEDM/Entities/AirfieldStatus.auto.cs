using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AIRFIELD-STATUS that represents the table AIRFIELD_STAT.
	///
	/// A FACILITY-STATUS that is a record of conditions of a specific AIRFIELD.
    /// </summary>
    [Serializable]
    [DefinitionName("AirfieldStatus", "C4Net.JC3IEDM.Definitions.AirfieldStatus.definition.xml")]
    public class AirfieldStatus : FacilityStatus, IAirfieldStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AirfieldStatusExpression _ = new AirfieldStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column day_opers_code
		///
		/// The specific value that indicates the status of a specific AIRFIELD to only operate during daylight.
        /// </summary>
        /// <value>
        /// Value of the column day_opers_code
        /// </value>
		public AirfieldStatusDayOperationsEnum? DayOperations { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column flight_supp_cat_code
		///
		/// The specific value that indicates the capability of a specific AIRFIELD to function under defined flight rules.
        /// </summary>
        /// <value>
        /// Value of the column flight_supp_cat_code
        /// </value>
		public AirfieldStatusFlightSupportCategoryEnum? FlightSupportCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column eval_ind_code
		///
		/// The specific value that indicates that an AIRFIELD has been checked and its characteristics have been verified.
        /// </summary>
        /// <value>
        /// Value of the column eval_ind_code
        /// </value>
		public AirfieldStatusEvaluationIndicatorEnum? EvaluationIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_nbac_thpt_cnt
		///
		/// The integer value representing the maximum count of narrow body civilian aircrafts (NBAC) that specific AIRFIELD can process per day.
        /// </summary>
        /// <value>
        /// Value of the column max_nbac_thpt_cnt
        /// </value>
		public short? MaximumNbacThroughputCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_nbac_park_cnt
		///
		/// The integer value representing the maximum count of narrow body civilian aircrafts (NBAC) that can be parked at a specific AIRFIELD at one time.
        /// </summary>
        /// <value>
        /// Value of the column max_nbac_park_cnt
        /// </value>
		public short? MaximumNbacParkCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_wbac_thpt_cnt
		///
		/// The integer value representing the maximum count of wide body civilian aircrafts (WBAC) that specific AIRFIELD can process per day.
        /// </summary>
        /// <value>
        /// Value of the column max_wbac_thpt_cnt
        /// </value>
		public short? MaximumWbacThroughputCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_wbac_park_cnt
		///
		/// The integer value representing the maximum count of wide body civilian aircrafts (WBAC) that can be parked at a specific AIRFIELD at one time.
        /// </summary>
        /// <value>
        /// Value of the column max_wbac_park_cnt
        /// </value>
		public short? MaximumWbacParkCount { get; set; }
		
        #endregion
    }
}

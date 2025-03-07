using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RADIOACTIVE-EVENT that represents the table RADACT_EVENT.
	///
	/// A CBRN-EVENT involving radioactive materiel(s).
    /// </summary>
    [Serializable]
    [DefinitionName("RadioactiveEvent", "C4Net.JC3IEDM.Definitions.RadioactiveEvent.definition.xml")]
    public class RadioactiveEvent : CbrnEvent, IRadioactiveEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RadioactiveEventExpression _ = new RadioactiveEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of RADIOACTIVE-EVENT. It serves as a discriminator that partitions RADIOACTIVE-EVENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RadioactiveEventCategoryEnum RadioactiveEventCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dose_qty
		///
		/// The numeric value that represents the total radiation dose accumulated over the duration of the RADIOACTIVE-EVENT. The unit of measure is centiGray (cGy).
        /// </summary>
        /// <value>
        /// Value of the column dose_qty
        /// </value>
		public double? DoseQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dose_rate
		///
		/// The numeric value that denotes the radiation dose rate. The unit of measure is centiGray per Hour (cGy/h). The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column dose_rate
        /// </value>
		public double? DoseRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dose_rate_trend_code
		///
		/// The specific value that represents the rate of change of the ionising radiation emitted by a radioactive materiel.
        /// </summary>
        /// <value>
        /// Value of the column dose_rate_trend_code
        /// </value>
		public RadioactiveEventDoseRateTrendEnum? DoseRateTrend { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vol_cncntr_qty
		///
		/// The numeric value that represents the level of radioactive contamination per unit volume in air or water. The unit of measure is Becquerels per cubic metre (BQM3).
        /// </summary>
        /// <value>
        /// Value of the column vol_cncntr_qty
        /// </value>
		public double? VolumeConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_dep_qty
		///
		/// The numeric value that represents the level of radioactive contamination per unit area on a surface. The unit of measure is Becquerels per square metre (BQM2).
        /// </summary>
        /// <value>
        /// Value of the column surf_dep_qty
        /// </value>
		public double? SurfaceDepositionQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_decay_rate_code
		///
		/// The specific value that represents the rate of decay of fallout relative to the assumed normal value of 1.2 in the Kaufmann equation.
        /// </summary>
        /// <value>
        /// Value of the column rel_decay_rate_code
        /// </value>
		public RadioactiveEventRelativeDecayRateEnum? RelativeDecayRate { get; set; }
		
        #endregion
    }
}

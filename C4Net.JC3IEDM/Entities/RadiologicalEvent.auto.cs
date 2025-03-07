using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RADIOLOGICAL-EVENT that represents the table RADLGC_EVENT.
	///
	/// A RADIOACTIVE-EVENT involving radioactive materiel(s) but not involving nuclear materiel(s) and/or nuclear detonation.
    /// </summary>
    [Serializable]
    [DefinitionName("RadiologicalEvent", "C4Net.JC3IEDM.Definitions.RadiologicalEvent.definition.xml")]
    public class RadiologicalEvent : RadioactiveEvent, IRadiologicalEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RadiologicalEventExpression _ = new RadiologicalEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column release_cat_code
		///
		/// The specific value that represents the type of discharge for a contaminant release in a radioactive release other than attack (ROTA) event.
        /// </summary>
        /// <value>
        /// Value of the column release_cat_code
        /// </value>
		public ReleaseCategoryEnum? ReleaseCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column isotope_cncntr_rat
		///
		/// The numeric quotient value that represents the proportion by weight of an isotope in a release. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column isotope_cncntr_rat
        /// </value>
		public double? IsotopeConcentrationRatio { get; set; }
		
        #endregion
    }
}

using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity APRON that represents the table APRON.
	///
	/// A FACILITY that is an area intended for parking, loading, unloading and/or servicing.
    /// </summary>
    [Serializable]
    [DefinitionName("Apron", "C4Net.JC3IEDM.Definitions.Apron.definition.xml")]
    public class Apron : Facility, IApron
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ApronExpression _ = new ApronExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column wt_brng_cap_qty
		///
		/// The numeric value that denotes the maximum gravitational force exerted on the surface of a specific APRON. The unit of measure is kilograms per square centimetre.
        /// </summary>
        /// <value>
        /// Value of the column wt_brng_cap_qty
        /// </value>
		public double? WeightBearingCapacityQuantity { get; set; }
		
        #endregion
    }
}

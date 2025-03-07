using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AIRFIELD-TYPE that represents the table AIRFIELD_TYPE.
	///
	/// A FACILITY-TYPE that is a class of an area prepared for the accommodation (including any buildings, installations, or equipment) of landing and take off of aircraft.
    /// </summary>
    [Serializable]
    [DefinitionName("AirfieldType", "C4Net.JC3IEDM.Definitions.AirfieldType.definition.xml")]
    public class AirfieldType : FacilityType, IAirfieldType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AirfieldTypeExpression _ = new AirfieldTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column use_cat_code
		///
		/// The specific value indicating an airport's main use.
        /// </summary>
        /// <value>
        /// Value of the column use_cat_code
        /// </value>
		public AirfieldTypeUseCategoryEnum UseCategory { get; set; }
		
        #endregion
    }
}

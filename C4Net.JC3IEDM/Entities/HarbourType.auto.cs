using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity HARBOUR-TYPE that represents the table HRBR_TYPE.
	///
	/// A FACILITY-TYPE that is a restricted body of water, an anchorage, or other limited coastal water area and its water approaches from which and in which shipping operations are projected or supported.
    /// </summary>
    [Serializable]
    [DefinitionName("HarbourType", "C4Net.JC3IEDM.Definitions.HarbourType.definition.xml")]
    public class HarbourType : FacilityType, IHarbourType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly HarbourTypeExpression _ = new HarbourTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of HARBOUR-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public HarbourTypeCategoryEnum HarbourTypeCategory { get; set; }
		
        #endregion
    }
}

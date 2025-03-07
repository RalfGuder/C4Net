using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FACILITY-TYPE that represents the table FAC_TYPE.
	///
	/// An OBJECT-TYPE that is intended to be built, installed or established to serve some particular purpose and is identified by the service it is intended to provide rather than by its content.
    /// </summary>
    [Serializable]
    [DefinitionName("FacilityType", "C4Net.JC3IEDM.Definitions.FacilityType.definition.xml")]
    public class FacilityType : ObjectType, IFacilityType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FacilityTypeExpression _ = new FacilityTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FACILITY-TYPE. It serves as a discriminator that partitions FACILITY-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public FacilityTypeCategoryEnum FacilityTypeCategory { get; set; }
		
        #endregion
    }
}

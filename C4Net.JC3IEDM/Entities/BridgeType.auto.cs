using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity BRIDGE-TYPE that represents the table BRIDGE_TYPE.
	///
	/// A FACILITY-TYPE that is a class of structures (including overpasses and viaducts), fixed or moveable, spanning and/or providing passage over an object.
    /// </summary>
    [Serializable]
    [DefinitionName("BridgeType", "C4Net.JC3IEDM.Definitions.BridgeType.definition.xml")]
    public class BridgeType : FacilityType, IBridgeType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly BridgeTypeExpression _ = new BridgeTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column design_type_code
		///
		/// The specific value that represents the design class of BRIDGE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column design_type_code
        /// </value>
		public BridgeTypeDesignTypeEnum DesignType { get; set; }
		
        #endregion
    }
}

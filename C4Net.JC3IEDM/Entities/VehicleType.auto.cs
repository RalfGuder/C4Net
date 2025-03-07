using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity VEHICLE-TYPE that represents the table VEHICLE_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to operate on land routes (other than rail) with a primary role of transporting personnel, equipment or supplies.
    /// </summary>
    [Serializable]
    [DefinitionName("VehicleType", "C4Net.JC3IEDM.Definitions.VehicleType.definition.xml")]
    public class VehicleType : EquipmentType, IVehicleType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly VehicleTypeExpression _ = new VehicleTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of VEHICLE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public VehicleTypeCategoryEnum VehicleTypeCategory { get; set; }
		
        #endregion
    }
}

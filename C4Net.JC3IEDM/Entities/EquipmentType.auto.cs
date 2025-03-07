using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity EQUIPMENT-TYPE that represents the table EQPT_TYPE.
	///
	/// A MATERIEL-TYPE that is not intended for consumption.
    /// </summary>
    [Serializable]
    [DefinitionName("EquipmentType", "C4Net.JC3IEDM.Definitions.EquipmentType.definition.xml")]
    public class EquipmentType : MaterielType, IEquipmentType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly EquipmentTypeExpression _ = new EquipmentTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of EQUIPMENT-TYPE. It serves as a discriminator that partitions EQUIPMENT-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public EquipmentTypeCategoryEnum EquipmentTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loaded_wt_qty
		///
		/// The numeric value that represents the weight of a specific EQUIPMENT-TYPE including the normal maximum payload, crew, and personal/organisation equipment as well as the basic issue items. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column loaded_wt_qty
        /// </value>
		public double? LoadedWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column unloaded_wt_qty
		///
		/// The numeric value that represents the weight of a specific EQUIPMENT-TYPE including on-equipment materiel that is an integral part of the equipment when issued. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column unloaded_wt_qty
        /// </value>
		public double? UnloadedWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_height_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured perpendicular to the base plane of the specific EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column max_height_dim
        /// </value>
		public double? MaximumHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_length_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from end to end and parallel to the central axis of a specific EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column max_length_dim
        /// </value>
		public double? MaximumLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_width_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from side to side and perpendicular to the central axis of a specific EQUIPMENT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column max_width_dim
        /// </value>
		public double? MaximumWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fuel_cap_qty
		///
		/// The numeric value that represents the usable fuel capacity of an EQUIPMENT-TYPE. The unit of measure is litre.
        /// </summary>
        /// <value>
        /// Value of the column fuel_cap_qty
        /// </value>
		public int? FuelCapacityQuantity { get; set; }
		
        #endregion
    }
}

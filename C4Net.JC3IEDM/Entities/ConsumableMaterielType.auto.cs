using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONSUMABLE-MATERIEL-TYPE that represents the table CONS_MAT_TYPE.
	///
	/// A MATERIEL-TYPE that is an expendable class of supply.
    /// </summary>
    [Serializable]
    [DefinitionName("ConsumableMaterielType", "C4Net.JC3IEDM.Definitions.ConsumableMaterielType.definition.xml")]
    public class ConsumableMaterielType : MaterielType, IConsumableMaterielType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ConsumableMaterielTypeExpression _ = new ConsumableMaterielTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CONSUMABLE-MATERIEL-TYPE. It serves as a discriminator that partitions CONSUMABLE-MATERIEL-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ConsumableMaterielTypeCategoryEnum ConsumableMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of a specific CONSUMABLE-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public ConsumableMaterielTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column hazard_code
		///
		/// The specific value that represents a CONSUMABLE-MATERIEL-TYPE that requires special handling because of environmental or safety reasons.
        /// </summary>
        /// <value>
        /// Value of the column hazard_code
        /// </value>
		public ConsumableMaterielTypeHazardEnum? Hazard { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_elmt_code
		///
		/// The specific value that represents a standard unit in which a specific CONSUMABLE-MATERIEL-TYPE is made available.
        /// </summary>
        /// <value>
        /// Value of the column issuing_elmt_code
        /// </value>
		public ConsumableMaterielTypeIssuingElementEnum? IssuingElement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_cnt
		///
		/// The integer value representing the aggregated units in which a specific CONSUMABLE-MATERIEL-TYPE is made available.
        /// </summary>
        /// <value>
        /// Value of the column issuing_cnt
        /// </value>
		public int? IssuingCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_uom_code
		///
		/// The specific value that represents the unit of measure of which a standard quantity (unit) of a specific CONSUMABLE-MATERIEL-TYPE is made available.
        /// </summary>
        /// <value>
        /// Value of the column issuing_uom_code
        /// </value>
		public ConsumableMaterielTypeIssuingUnitOfMeasureEnum? IssuingUnitOfMeasure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_wt_qty
		///
		/// The numeric value that represents the gravitational force exerted on an amount of a standard unit of issue for a specific CONSUMABLE-MATERIEL-TYPE when it is prepared for delivery. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column issuing_wt_qty
        /// </value>
		public double? IssuingWeightQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column perishability_ind_code
		///
		/// The specific value that represents whether a particular CONSUMABLE-MATERIEL-TYPE is liable to decay or spoil.
        /// </summary>
        /// <value>
        /// Value of the column perishability_ind_code
        /// </value>
		public ConsumableMaterielTypePerishabilityIndicatorEnum? PerishabilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column united_nations_no_code
		///
		/// The specific value that represents the United Nations (UN) Numbers that are four-digit numbers used world-wide in international commerce and transportation to identify hazardous chemicals or classes of hazardous materials.
        /// </summary>
        /// <value>
        /// Value of the column united_nations_no_code
        /// </value>
		public ConsumableMaterielTypeUnitedNationsNumberEnum? UnitedNationsNumber { get; set; }
		
        #endregion
    }
}

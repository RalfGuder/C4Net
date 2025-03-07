using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PERSON-STATUS that represents the table PERS_STAT.
	///
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific PERSON.
    /// </summary>
    [Serializable]
    [DefinitionName("PersonStatus", "C4Net.JC3IEDM.Definitions.PersonStatus.definition.xml")]
    public class PersonStatus : ObjectItemStatus, IPersonStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly PersonStatusExpression _ = new PersonStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pers_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column pers_stat_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
		public decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column duty_stat_code
		///
		/// The specific value that represents the availability of a specific PERSON for duty at a military or civilian post of employment.
        /// </summary>
        /// <value>
        /// Value of the column duty_stat_code
        /// </value>
		public PersonStatusDutyStatusEnum? DutyStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column physcl_stat_code
		///
		/// The specific value that represents the general physical status of a specific PERSON.
        /// </summary>
        /// <value>
        /// Value of the column physcl_stat_code
        /// </value>
		public PersonStatusPhysicalStatusEnum? PhysicalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column physcl_stat_qual_code
		///
		/// The specific value that qualifies the health conditions of a specific PERSON at a specific point in time.
        /// </summary>
        /// <value>
        /// Value of the column physcl_stat_qual_code
        /// </value>
		public PersonStatusPhysicalStatusQualifierEnum? PhysicalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rad_dose_qty
		///
		/// The numeric value that represents the total radiation dose to which a person has been exposed. The unit of measure is centiGray (cGy).
        /// </summary>
        /// <value>
        /// Value of the column rad_dose_qty
        /// </value>
		public int? RadiationDoseQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific PERSON has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
		public PersonStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        #endregion
    }
}

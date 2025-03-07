using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GROUP-CHARACTERISTIC that represents the table GROUP_CHRCT.
	///
	/// A reference to a set of characteristics that may be used for identifying a distinct collection of objects.
    /// </summary>
    [Serializable]
    [DefinitionName("GroupCharacteristic", "C4Net.JC3IEDM.Definitions.GroupCharacteristic.definition.xml")]
    public class GroupCharacteristic : IEntity, IGroupCharacteristic
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly GroupCharacteristicExpression _ = new GroupCharacteristicExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column group_chrct_id
		///
		/// The unique value, or set of characters, assigned to represent a specific GROUP-CHARACTERISTIC and to distinguish it from all other GROUP-CHARACTERISTICs.
        /// </summary>
        /// <value>
        /// Value of the column group_chrct_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column age_group_code
		///
		/// The specific value that identifies the age group in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column age_group_code
        /// </value>
		public GroupCharacteristicAgeGroupEnum? AgeGroup { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column malady_code
		///
		/// The specific value that identifies the type of ill health, ailment or disease in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column malady_code
        /// </value>
		public GroupCharacteristicMaladyEnum? Malady { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column malady_trnsmsbl_ind_code
		///
		/// The specific value that identifies whether the type of ill health, ailment or disease in a specific GROUP-CHARACTERISTIC is communicable.
        /// </summary>
        /// <value>
        /// Value of the column malady_trnsmsbl_ind_code
        /// </value>
		public GroupCharacteristicMaladyTransmissibilityIndicatorEnum? MaladyTransmissibilityIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gender_code
		///
		/// The specific value that identifies the gender in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column gender_code
        /// </value>
		public GenderEnum? Gender { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lang_code
		///
		/// The specific value that identifies the language group in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column lang_code
        /// </value>
		public LanguageCategoryEnum? Language { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column triage_code
		///
		/// The specific value that identifies the triage classification in a specific GROUP-CHARACTERISTIC.
        /// </summary>
        /// <value>
        /// Value of the column triage_code
        /// </value>
		public GroupCharacteristicTriageEnum? Triage { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}

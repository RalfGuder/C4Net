using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CBRN-EVENT that represents the table CBRN_EVENT.
	///
	/// An ACTION-EVENT that involves chemical, biological, radiological or nuclear materiel individually or in combination.
    /// </summary>
    [Serializable]
    [DefinitionName("CbrnEvent", "C4Net.JC3IEDM.Definitions.CbrnEvent.definition.xml")]
    public class CbrnEvent : ActionEvent, ICbrnEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CbrnEventExpression _ = new CbrnEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CBRN-EVENT. It serves as a discriminator that partitions CBRN-EVENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public CbrnEventCategoryEnum CbrnEventCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class or nature of activity prescribed by CBRN-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public CbrnEventSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column alarm_result_ind_code
		///
		/// The specific value that denotes whether a detector has indicated the presence of a CBRN-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column alarm_result_ind_code
        /// </value>
		public CbrnEventAlarmResultIndicatorEnum? AlarmResultIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column conf_test_ind_code
		///
		/// The specific value that denotes whether a test confirms the presence of a CBRN-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column conf_test_ind_code
        /// </value>
		public CbrnEventConfirmationTestIndicatorEnum? ConfirmationTestIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mat_cntr_type_code
		///
		/// The specific value that represents the type of container that stores the materiel (agent) involved in a specific CBRN-EVENT and characterised in ATP-45.
        /// </summary>
        /// <value>
        /// Value of the column mat_cntr_type_code
        /// </value>
		public CbrnEventMaterielContainerTypeEnum? MaterielContainerType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mat_cntr_total_cnt
		///
		/// The integer value representing the number of [materiel] agent containers involved in a specific CBRN-EVENT and characterised in ATP-45.
        /// </summary>
        /// <value>
        /// Value of the column mat_cntr_total_cnt
        /// </value>
		public short? MaterielContainerTotalCount { get; set; }
		
        #endregion
    }
}

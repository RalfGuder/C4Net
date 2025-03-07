using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MEDICAL-FACILITY-STATUS that represents the table MFS.
	///
	/// A FACILITY-STATUS that is a record of condition of a specific medical facility.
    /// </summary>
    [Serializable]
    [DefinitionName("MedicalFacilityStatus", "C4Net.JC3IEDM.Definitions.MedicalFacilityStatus.definition.xml")]
    public class MedicalFacilityStatus : FacilityStatus, IMedicalFacilityStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MedicalFacilityStatusExpression _ = new MedicalFacilityStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column surgery_backlog_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds for the estimated period of effectiveness for performing pending surgeries for a specific MEDICAL-FACILITY-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column surgery_backlog_dur
        /// </value>
		public decimal SurgeryBacklogDuration { get; set; }
		
        #endregion
    }
}

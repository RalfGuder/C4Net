using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity AIRSPACE-CONTROL-MEANS that represents the table ARSP_CTRL_MEANS.
	///
	/// A CONTROL-FEATURE that reserves airspace for specific airspace users, restricts the action of airspace users, controls the actions of specific airspace users, and/or requires airspace users to accomplish specific actions.
    /// </summary>
    [Serializable]
    [DefinitionName("AirspaceControlMeans", "C4Net.JC3IEDM.Definitions.AirspaceControlMeans.definition.xml")]
    public class AirspaceControlMeans : ControlFeature, IAirspaceControlMeans
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly AirspaceControlMeansExpression _ = new AirspaceControlMeansExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column trnst_instr_txt
		///
		/// The character string assigned to represent the specific transit instructions for a specific airspace.
        /// </summary>
        /// <value>
        /// Value of the column trnst_instr_txt
        /// </value>
		public string TransitInstructionText { get; set; }
		
        #endregion
    }
}

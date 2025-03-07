using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity UXO-STATUS that represents the table UXO_STAT.
	///
	/// A MATERIEL-STATUS that is a record of the condition of an explosive ordnance that has been primed, fused, armed, or otherwise prepared for action, and which has been fired, dropped, launched, placed in such a manner, as to constitute a hazard to operation, and remains unexploded either by malfunction or for any other cause.
    /// </summary>
    [Serializable]
    [DefinitionName("UxoStatus", "C4Net.JC3IEDM.Definitions.UxoStatus.definition.xml")]
    public class UxoStatus : MaterielStatus, IUxoStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly UxoStatusExpression _ = new UxoStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column exp_code
		///
		/// The specific value that represents the visual status of a specific Unexploded Explosive Ordnance.
        /// </summary>
        /// <value>
        /// Value of the column exp_code
        /// </value>
		public UxoStatusExposureEnum Exposure { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that represents the qualification status of a specific Unexploded Explosive Ordnance.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
		public UxoStatusQualifierEnum? Qualifier { get; set; }
		
        #endregion
    }
}

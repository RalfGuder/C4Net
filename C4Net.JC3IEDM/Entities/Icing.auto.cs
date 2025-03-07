using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ICING that represents the table ICING.
	///
	/// A METEOROLOGIC-FEATURE that specifies the accumulation of frozen water on stationary or moving surfaces.
    /// </summary>
    [Serializable]
    [DefinitionName("Icing", "C4Net.JC3IEDM.Definitions.Icing.definition.xml")]
    public class Icing : MeteorologicFeature, IIcing
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly IcingExpression _ = new IcingExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of a particular ICING.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public IcingCategoryEnum? IcingCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sev_qual_code
		///
		/// The specific value that represents the severity of a particular ICING.
        /// </summary>
        /// <value>
        /// Value of the column sev_qual_code
        /// </value>
		public IcingSeverityQualifierEnum? SeverityQualifier { get; set; }
		
        #endregion
    }
}

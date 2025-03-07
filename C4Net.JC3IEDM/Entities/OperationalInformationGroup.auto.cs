using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OPERATIONAL-INFORMATION-GROUP that represents the table OIG.
	///
	/// A CONTEXT that encompasses a set of pre-defined operational information.
    /// </summary>
    [Serializable]
    [DefinitionName("OperationalInformationGroup", "C4Net.JC3IEDM.Definitions.OperationalInformationGroup.definition.xml")]
    public class OperationalInformationGroup : Context, IOperationalInformationGroup
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly OperationalInformationGroupExpression _ = new OperationalInformationGroupExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OPERATIONAL-INFORMATION-GROUP.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OperationalInformationGroupCategoryEnum OperationalInformationGroupCategory { get; set; }
		
        #endregion
    }
}

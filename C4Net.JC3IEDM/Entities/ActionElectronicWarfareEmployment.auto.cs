using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-ELECTRONIC-WARFARE-EMPLOYMENT that represents the table ACT_ELCTRNC_WARFARE_EMPLOY.
	///
	/// The technique used by an ACTION-RESOURCE for Electronic Warfare by electronic or mechanical means.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionElectronicWarfareEmployment", "C4Net.JC3IEDM.Definitions.ActionElectronicWarfareEmployment.definition.xml")]
    public class ActionElectronicWarfareEmployment : ActionResourceEmployment, IActionElectronicWarfareEmployment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionElectronicWarfareEmploymentExpression _ = new ActionElectronicWarfareEmploymentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_res_employ_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE-EMPLOYMENT for a specific ACTION-RESOURCE and to distinguish it from all other ACTION-RESOURCE-EMPLOYMENTs for that ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column act_res_employ_ix
        /// </value>
		public decimal ActionResourceEmploymentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents an electronic or mechanical technique.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionElectronicWarfareEmploymentCategoryEnum ActionElectronicWarfareEmploymentCategory { get; set; }
		
        #endregion
    }
}

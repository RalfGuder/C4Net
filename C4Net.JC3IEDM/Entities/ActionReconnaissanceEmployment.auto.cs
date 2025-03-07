using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-RECONNAISSANCE-EMPLOYMENT that represents the table ACT_RECCE_EMPLOY.
	///
	/// The parameters that guide the use of an ACTION-RESOURCE that is employed in a reconnaissance role.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionReconnaissanceEmployment", "C4Net.JC3IEDM.Definitions.ActionReconnaissanceEmployment.definition.xml")]
    public class ActionReconnaissanceEmployment : ActionResourceEmployment, IActionReconnaissanceEmployment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionReconnaissanceEmploymentExpression _ = new ActionReconnaissanceEmploymentExpression();

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
        /// Gets or sets the value of the column img_cvrg_mode_code
		///
		/// The specific value that represents the mode of image coverage required.
        /// </summary>
        /// <value>
        /// Value of the column img_cvrg_mode_code
        /// </value>
		public ActionReconnaissanceEmploymentImageCoverageModeEnum? ImageCoverageMode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column img_view_qual_code
		///
		/// The specific value that represents the recorded media based on the type of imagery the interpreter is viewing.
        /// </summary>
        /// <value>
        /// Value of the column img_view_qual_code
        /// </value>
		public ActionReconnaissanceEmploymentImageViewQualifierEnum? ImageViewQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column type_of_cvrg_code
		///
		/// The specific value that represents the type of coverage required.
        /// </summary>
        /// <value>
        /// Value of the column type_of_cvrg_code
        /// </value>
		public ActionReconnaissanceEmploymentTypeOfCoverageEnum? TypeOfCoverage { get; set; }
		
        #endregion
    }
}

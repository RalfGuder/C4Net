using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity REQUEST that represents the table REQUEST.
	///
	/// An ACTION-TASK that states a requirement.
    /// </summary>
    [Serializable]
    [DefinitionName("Request", "C4Net.JC3IEDM.Definitions.Request.definition.xml")]
    public class Request : ActionTask, IRequest
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RequestExpression _ = new RequestExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type classification of a specific REQUEST.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RequestCategoryEnum RequestCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column immd_interest_ind_code
		///
		/// The specific value that indicates whether the information sought in a request is of immediate interest.
        /// </summary>
        /// <value>
        /// Value of the column immd_interest_ind_code
        /// </value>
		public RequestImmediateInterestIndicatorEnum? ImmediateInterestIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column latest_ans_dttm
		///
		/// The character string representing a point in time that designates the end of the period of usefulness of the information sought in a specific REQUEST.
        /// </summary>
        /// <value>
        /// Value of the column latest_ans_dttm
        /// </value>
		public string LatestAnswerDatetime { get; set; }
		
        #endregion
    }
}

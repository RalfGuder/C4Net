using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CANDIDATE-TARGET-DETAIL-TYPE that represents the table CTGTDET_TYPE.
	///
	/// An instance of CANDIDATE-TARGET-DETAIL that is an OBJECT-TYPE.
    /// </summary>
    [Serializable]
    [DefinitionName("CandidateTargetDetailType", "C4Net.JC3IEDM.Definitions.CandidateTargetDetailType.definition.xml")]
    public class CandidateTargetDetailType : CandidateTargetDetail, ICandidateTargetDetailType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CandidateTargetDetailTypeExpression _ = new CandidateTargetDetailTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
		public decimal ObjectTypeId { get; set; }
		
        #endregion
    }
}

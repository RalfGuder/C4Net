using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CANDIDATE-TARGET-DETAIL-ITEM that represents the table CTGTDET_ITEM.
	///
	/// An instance of CANDIDATE-TARGET-DETAIL that is an OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("CandidateTargetDetailItem", "C4Net.JC3IEDM.Definitions.CandidateTargetDetailItem.definition.xml")]
    public class CandidateTargetDetailItem : CandidateTargetDetail, ICandidateTargetDetailItem
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly CandidateTargetDetailItemExpression _ = new CandidateTargetDetailItemExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        #endregion
    }
}

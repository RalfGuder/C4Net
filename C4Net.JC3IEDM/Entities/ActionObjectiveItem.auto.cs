using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-OBJECTIVE-ITEM that represents the table ACT_OBJVE_ITEM.
	///
	/// A battlespace object (FACILITY, FEATURE, MATERIEL, ORGANISATION or PERSON) which is the focus of a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionObjectiveItem", "C4Net.JC3IEDM.Definitions.ActionObjectiveItem.definition.xml")]
    public class ActionObjectiveItem : ActionObjective, IActionObjectiveItem
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionObjectiveItemExpression _ = new ActionObjectiveItemExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
		public decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-OBJECTIVE-ITEM. It serves as a discriminator that partitions ACTION-OBJECTIVE-ITEM into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionObjectiveItemCategoryEnum ActionObjectiveItemCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column primacy_code
		///
		/// The specific value that represents the relative usage of a specific ACTION-OBJECTIVE-ITEM when more than one instance of ACTION-OBJECTIVE-ITEM is designated for a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column primacy_code
        /// </value>
		public ActionObjectiveItemPrimacyEnum? Primacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtlst_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-LISTs.
        /// </summary>
        /// <value>
        /// Value of the column ctgtlst_id
        /// </value>
		public decimal? CandidateTargetListId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ctgtdet_item_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_item_ix
        /// </value>
		public decimal? CandidateTargetDetailItemIndex { get; set; }
		
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

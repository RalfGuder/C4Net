using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-OBJECTIVE-TYPE that represents the table ACT_OBJVE_TYPE.
	///
	/// A class of battlespace object (FACILITY-TYPE, FEATURE-TYPE, MATERIEL-TYPE, ORGANISATION-TYPE or PERSON-TYPE) which is the focus of a specific ACTION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionObjectiveType", "C4Net.JC3IEDM.Definitions.ActionObjectiveType.definition.xml")]
    public class ActionObjectiveType : ActionObjective, IActionObjectiveType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ActionObjectiveTypeExpression _ = new ActionObjectiveTypeExpression();

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
		/// The specific value that represents the class of ACTION-OBJECTIVE-TYPE. It serves as a discriminator that partitions ACTION-OBJECTIVE-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionObjectiveTypeCategoryEnum ActionObjectiveTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prio_txt
		///
		/// The character string assigned to represent the rank of importance of a specific ACTION-OBJECTIVE-TYPE according to the planning authority.
        /// </summary>
        /// <value>
        /// Value of the column prio_txt
        /// </value>
		public string PriorityText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific ACTION-OBJECTIVE-TYPE. No unit of measure is required.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
		public double? Quantity { get; set; }
		
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
        /// Gets or sets the value of the column ctgtdet_type_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific CANDIDATE-TARGET-DETAIL for a specific CANDIDATE-TARGET-LIST and to distinguish it from all other CANDIDATE-TARGET-DETAILs for that CANDIDATE-TARGET-LIST.
        /// </summary>
        /// <value>
        /// Value of the column ctgtdet_type_ix
        /// </value>
		public decimal? CandidateTargetDetailTypeIndex { get; set; }
		
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

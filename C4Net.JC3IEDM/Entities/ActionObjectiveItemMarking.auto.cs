using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-OBJECTIVE-ITEM-MARKING that represents the table ACT_OBJVE_ITEM_MARKING.
	///
	/// The technique of indicating the position of an ACTION-OBJECTIVE-ITEM at a given time for the benefit of a using ORGANISATION.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionObjectiveItemMarking", "C4Net.JC3IEDM.Definitions.ActionObjectiveItemMarking.definition.xml")]
    public class ActionObjectiveItemMarking : IEntity, IActionObjectiveItemMarking
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionObjectiveItemMarkingExpression _ = new ActionObjectiveItemMarkingExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
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
        /// Gets or sets the value of the column act_objve_item_marking_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE-ITEM-MARKING for a specific ACTION-OBJECTIVE-ITEM and to distinguish it from all other ACTION-OBJECTIVE-ITEM-MARKINGs for that ACTION-OBJECTIVE-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_item_marking_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column laser_correlation_code_txt
		///
		/// The character string assigned to represent the code to be used by both the target designation system and the weapon delivery system.
        /// </summary>
        /// <value>
        /// Value of the column laser_correlation_code_txt
        /// </value>
		public string LaserCorrelationCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column method_code
		///
		/// The specific value that represents the method of marking a position.
        /// </summary>
        /// <value>
        /// Value of the column method_code
        /// </value>
		public ActionObjectiveItemMarkingMethodEnum? Method { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column panel_shape_code
		///
		/// The specific value that represents the shape of the marking panel.
        /// </summary>
        /// <value>
        /// Value of the column panel_shape_code
        /// </value>
		public ActionObjectiveItemMarkingPanelShapeEnum? PanelShape { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rcgn_sgnl_colour_code
		///
		/// The specific value that represents the coloration of the marking signal.
        /// </summary>
        /// <value>
        /// Value of the column rcgn_sgnl_colour_code
        /// </value>
		public ActionObjectiveItemMarkingRecognitionSignalColourEnum? RecognitionSignalColour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column start_dttm
		///
		/// The character string representing a point in time that designates the start of a specific ACTION-OBJECTIVE-ITEM-MARKING.
        /// </summary>
        /// <value>
        /// Value of the column start_dttm
        /// </value>
		public string StartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column using_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column using_org_id
        /// </value>
		public decimal UsingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}

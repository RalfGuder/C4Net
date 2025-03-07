using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionObjectiveItemMarking that represents the table ACT_OBJVE_ITEM_MARKING
	/// 
	/// The technique of indicating the position of an ACTION-OBJECTIVE-ITEM at a given time for the benefit of a using ORGANISATION.
    /// </summary>
	[EntId(10000247)]
    [EntName("ACTION-OBJECTIVE-ITEM-MARKING")]
    [EntTableName("ACT_OBJVE_ITEM_MARKING")]
    [EntDepth(7)]
    public interface IActionObjectiveItemMarking
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-objective-index")]
		[AttrColumnName("act_objve_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_item_marking_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE-ITEM-MARKING for a specific ACTION-OBJECTIVE-ITEM and to distinguish it from all other ACTION-OBJECTIVE-ITEM-MARKINGs for that ACTION-OBJECTIVE-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_item_marking_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-objective-item-marking-index")]
		[AttrColumnName("act_objve_item_marking_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column laser_correlation_code_txt
		///
		/// The character string assigned to represent the code to be used by both the target designation system and the weapon delivery system.
        /// </summary>
        /// <value>
        /// Value of the column laser_correlation_code_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("action-objective-item-marking-laser-correlation-code-text")]
		[AttrColumnName("laser_correlation_code_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(4)]
        [DataDecimals(0)]
        string LaserCorrelationCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column method_code
		///
		/// The specific value that represents the method of marking a position.
        /// </summary>
        /// <value>
        /// Value of the column method_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("action-objective-item-marking-method-code")]
		[AttrColumnName("method_code")]
        [AttrSeqnr(5)]
        [DomId(100000241)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveItemMarkingMethodEnum? Method { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column panel_shape_code
		///
		/// The specific value that represents the shape of the marking panel.
        /// </summary>
        /// <value>
        /// Value of the column panel_shape_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("action-objective-item-marking-panel-shape-code")]
		[AttrColumnName("panel_shape_code")]
        [AttrSeqnr(6)]
        [DomId(100004146)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveItemMarkingPanelShapeEnum? PanelShape { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rcgn_sgnl_colour_code
		///
		/// The specific value that represents the coloration of the marking signal.
        /// </summary>
        /// <value>
        /// Value of the column rcgn_sgnl_colour_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("action-objective-item-marking-recognition-signal-colour-code")]
		[AttrColumnName("rcgn_sgnl_colour_code")]
        [AttrSeqnr(7)]
        [DomId(100004145)]
        [DataLength(6)]
        [DataDecimals(0)]
        ActionObjectiveItemMarkingRecognitionSignalColourEnum? RecognitionSignalColour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column start_dttm
		///
		/// The character string representing a point in time that designates the start of a specific ACTION-OBJECTIVE-ITEM-MARKING.
        /// </summary>
        /// <value>
        /// Value of the column start_dttm
        /// </value>
        [AttrIx(100008)]
		[AttrName("action-objective-item-marking-start-datetime")]
		[AttrColumnName("start_dttm")]
        [AttrSeqnr(8)]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string StartDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column using_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column using_org_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("action-objective-item-marking-using-organisation-id")]
		[AttrColumnName("using_org_id")]
        [AttrSeqnr(9)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal UsingOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(11)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

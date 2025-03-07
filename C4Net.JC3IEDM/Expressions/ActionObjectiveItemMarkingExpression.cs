using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionObjectiveItemMarking.
    /// </summary>
    public class ActionObjectiveItemMarkingExpression : BaseEntityExpression<ActionObjectiveItemMarkingExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionId that represents the column act_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionId that represents the column act_id.
        /// </value>
        public ColumnExpression ActionId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionObjectiveIndex that represents the column act_objve_ix.
        /// </value>
        public ColumnExpression ActionObjectiveIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column act_objve_item_marking_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column act_objve_item_marking_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LaserCorrelationCodeText that represents the column laser_correlation_code_txt.
        /// </summary>
        /// <value>
        /// The value of the property LaserCorrelationCodeText that represents the column laser_correlation_code_txt.
        /// </value>
        public ColumnExpression LaserCorrelationCodeText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Method that represents the column method_code.
        /// </summary>
        /// <value>
        /// The value of the property Method that represents the column method_code.
        /// </value>
        public ColumnExpression Method 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property PanelShape that represents the column panel_shape_code.
        /// </summary>
        /// <value>
        /// The value of the property PanelShape that represents the column panel_shape_code.
        /// </value>
        public ColumnExpression PanelShape 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property RecognitionSignalColour that represents the column rcgn_sgnl_colour_code.
        /// </summary>
        /// <value>
        /// The value of the property RecognitionSignalColour that represents the column rcgn_sgnl_colour_code.
        /// </value>
        public ColumnExpression RecognitionSignalColour 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property StartDatetime that represents the column start_dttm.
        /// </summary>
        /// <value>
        /// The value of the property StartDatetime that represents the column start_dttm.
        /// </value>
        public ColumnExpression StartDatetime 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UsingOrganisationId that represents the column using_org_id.
        /// </summary>
        /// <value>
        /// The value of the property UsingOrganisationId that represents the column using_org_id.
        /// </value>
        public ColumnExpression UsingOrganisationId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[10]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionObjectiveItemMarkingExpression"/> class.
        /// </summary>
        public ActionObjectiveItemMarkingExpression()
            : base("ActionObjectiveItemMarking", typeof(IActionObjectiveItemMarking))
        {
        }

        #endregion
    }
}

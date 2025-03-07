using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity RunwayApproachDirectionAssociation.
    /// </summary>
    public class RunwayApproachDirectionAssociationExpression : BaseEntityExpression<RunwayApproachDirectionAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property RunwayId that represents the column runway_id.
        /// </summary>
        /// <value>
        /// The value of the property RunwayId that represents the column runway_id.
        /// </value>
        public ColumnExpression RunwayId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ApproachDirectionId that represents the column appr_dir_id.
        /// </summary>
        /// <value>
        /// The value of the property ApproachDirectionId that represents the column appr_dir_id.
        /// </value>
        public ColumnExpression ApproachDirectionId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property SlopeRatio that represents the column slope_rat.
        /// </summary>
        /// <value>
        /// The value of the property SlopeRatio that represents the column slope_rat.
        /// </value>
        public ColumnExpression SlopeRatio 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LandingDistanceDimension that represents the column lndg_dist_dim.
        /// </summary>
        /// <value>
        /// The value of the property LandingDistanceDimension that represents the column lndg_dist_dim.
        /// </value>
        public ColumnExpression LandingDistanceDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property TakeoffDistanceDimension that represents the column takeoff_dist_dim.
        /// </summary>
        /// <value>
        /// The value of the property TakeoffDistanceDimension that represents the column takeoff_dist_dim.
        /// </value>
        public ColumnExpression TakeoffDistanceDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayApproachDirectionAssociationExpression"/> class.
        /// </summary>
        public RunwayApproachDirectionAssociationExpression()
            : base("RunwayApproachDirectionAssociation", typeof(IRunwayApproachDirectionAssociation))
        {
        }

        #endregion
    }
}

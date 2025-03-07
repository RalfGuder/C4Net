using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity TrackArea.
    /// </summary>
    public class TrackAreaExpression : BaseEntityExpression<TrackAreaExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column track_area_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column track_area_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property LeftWidthDimension that represents the column left_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property LeftWidthDimension that represents the column left_width_dim.
        /// </value>
        public ColumnExpression LeftWidthDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property RightWidthDimension that represents the column right_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property RightWidthDimension that represents the column right_width_dim.
        /// </value>
        public ColumnExpression RightWidthDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property BeginPointId that represents the column track_area_begin_point_id.
        /// </summary>
        /// <value>
        /// The value of the property BeginPointId that represents the column track_area_begin_point_id.
        /// </value>
        public ColumnExpression BeginPointId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property EndPointId that represents the column track_area_end_point_id.
        /// </summary>
        /// <value>
        /// The value of the property EndPointId that represents the column track_area_end_point_id.
        /// </value>
        public ColumnExpression EndPointId 
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
        /// Initializes a new instance of the <see cref="TrackAreaExpression"/> class.
        /// </summary>
        public TrackAreaExpression()
            : base("TrackArea", typeof(ITrackArea))
        {
        }

        #endregion
    }
}

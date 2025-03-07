using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrbitArea.
    /// </summary>
    public class OrbitAreaExpression : BaseEntityExpression<OrbitAreaExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column orbit_area_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column orbit_area_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Alignment that represents the column alignment_code.
        /// </summary>
        /// <value>
        /// The value of the property Alignment that represents the column alignment_code.
        /// </value>
        public ColumnExpression Alignment 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property WidthDimension that represents the column width_dim.
        /// </summary>
        /// <value>
        /// The value of the property WidthDimension that represents the column width_dim.
        /// </value>
        public ColumnExpression WidthDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property FirstPointId that represents the column orbit_area_first_point_id.
        /// </summary>
        /// <value>
        /// The value of the property FirstPointId that represents the column orbit_area_first_point_id.
        /// </value>
        public ColumnExpression FirstPointId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SecondPointId that represents the column orbit_area_scnd_point_id.
        /// </summary>
        /// <value>
        /// The value of the property SecondPointId that represents the column orbit_area_scnd_point_id.
        /// </value>
        public ColumnExpression SecondPointId 
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
        /// Initializes a new instance of the <see cref="OrbitAreaExpression"/> class.
        /// </summary>
        public OrbitAreaExpression()
            : base("OrbitArea", typeof(IOrbitArea))
        {
        }

        #endregion
    }
}

using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Ellipse.
    /// </summary>
    public class EllipseExpression : BaseEntityExpression<EllipseExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column elps_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column elps_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property CentrePointId that represents the column elps_centre_point_id.
        /// </summary>
        /// <value>
        /// The value of the property CentrePointId that represents the column elps_centre_point_id.
        /// </value>
        public ColumnExpression CentrePointId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property FirstConjugateDiameterPointId that represents the column elps_first_cnjg_diam_point_id.
        /// </summary>
        /// <value>
        /// The value of the property FirstConjugateDiameterPointId that represents the column elps_first_cnjg_diam_point_id.
        /// </value>
        public ColumnExpression FirstConjugateDiameterPointId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property SecondConjugateDiameterPointId that represents the column elps_scnd_cnjg_diam_point_id.
        /// </summary>
        /// <value>
        /// The value of the property SecondConjugateDiameterPointId that represents the column elps_scnd_cnjg_diam_point_id.
        /// </value>
        public ColumnExpression SecondConjugateDiameterPointId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[5]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="EllipseExpression"/> class.
        /// </summary>
        public EllipseExpression()
            : base("Ellipse", typeof(IEllipse))
        {
        }

        #endregion
    }
}

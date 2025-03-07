using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity SphereVolume.
    /// </summary>
    public class SphereVolumeExpression : BaseEntityExpression<SphereVolumeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column sphere_vol_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column sphere_vol_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property RadiusDimension that represents the column radius_dim.
        /// </summary>
        /// <value>
        /// The value of the property RadiusDimension that represents the column radius_dim.
        /// </value>
        public ColumnExpression RadiusDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CentrePointId that represents the column sphere_vol_centre_point_id.
        /// </summary>
        /// <value>
        /// The value of the property CentrePointId that represents the column sphere_vol_centre_point_id.
        /// </value>
        public ColumnExpression CentrePointId 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="SphereVolumeExpression"/> class.
        /// </summary>
        public SphereVolumeExpression()
            : base("SphereVolume", typeof(ISphereVolume))
        {
        }

        #endregion
    }
}

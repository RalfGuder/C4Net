using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity CloudCover.
    /// </summary>
    public class CloudCoverExpression : BaseEntityExpression<CloudCoverExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column cloud_cover_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column cloud_cover_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property BaseDimension that represents the column base_dim.
        /// </summary>
        /// <value>
        /// The value of the property BaseDimension that represents the column base_dim.
        /// </value>
        public ColumnExpression BaseDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property TopDimension that represents the column top_dim.
        /// </summary>
        /// <value>
        /// The value of the property TopDimension that represents the column top_dim.
        /// </value>
        public ColumnExpression TopDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property AverageCoverage that represents the column avg_cvrg_code.
        /// </summary>
        /// <value>
        /// The value of the property AverageCoverage that represents the column avg_cvrg_code.
        /// </value>
        public ColumnExpression AverageCoverage 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property LightRefractionRatio that represents the column light_refraction_rat.
        /// </summary>
        /// <value>
        /// The value of the property LightRefractionRatio that represents the column light_refraction_rat.
        /// </value>
        public ColumnExpression LightRefractionRatio 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudCoverExpression"/> class.
        /// </summary>
        public CloudCoverExpression()
            : base("CloudCover", typeof(ICloudCover))
        {
        }

        #endregion
    }
}

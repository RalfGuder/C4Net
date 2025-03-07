using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ActionReconnaissanceEmployment.
    /// </summary>
    public class ActionReconnaissanceEmploymentExpression : BaseEntityExpression<ActionReconnaissanceEmploymentExpression>
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
        /// Expression for the property ActionResourceIndex that represents the column act_res_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionResourceIndex that represents the column act_res_ix.
        /// </value>
        public ColumnExpression ActionResourceIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionResourceEmploymentIndex that represents the column act_res_employ_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionResourceEmploymentIndex that represents the column act_res_employ_ix.
        /// </value>
        public ColumnExpression ActionResourceEmploymentIndex 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ImageCoverageMode that represents the column img_cvrg_mode_code.
        /// </summary>
        /// <value>
        /// The value of the property ImageCoverageMode that represents the column img_cvrg_mode_code.
        /// </value>
        public ColumnExpression ImageCoverageMode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ImageViewQualifier that represents the column img_view_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property ImageViewQualifier that represents the column img_view_qual_code.
        /// </value>
        public ColumnExpression ImageViewQualifier 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property TypeOfCoverage that represents the column type_of_cvrg_code.
        /// </summary>
        /// <value>
        /// The value of the property TypeOfCoverage that represents the column type_of_cvrg_code.
        /// </value>
        public ColumnExpression TypeOfCoverage 
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
        /// Initializes a new instance of the <see cref="ActionReconnaissanceEmploymentExpression"/> class.
        /// </summary>
        public ActionReconnaissanceEmploymentExpression()
            : base("ActionReconnaissanceEmployment", typeof(IActionReconnaissanceEmployment))
        {
        }

        #endregion
    }
}

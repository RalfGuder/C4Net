using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Materiel.
    /// </summary>
    public class MaterielExpression : BaseEntityExpression<MaterielExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mat_id.
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
        /// Expression for the property SerialNumberIdentificationText that represents the column serial_no_id_txt.
        /// </summary>
        /// <value>
        /// The value of the property SerialNumberIdentificationText that represents the column serial_no_id_txt.
        /// </value>
        public ColumnExpression SerialNumberIdentificationText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property LotIdentificationText that represents the column lot_identific_txt.
        /// </summary>
        /// <value>
        /// The value of the property LotIdentificationText that represents the column lot_identific_txt.
        /// </value>
        public ColumnExpression LotIdentificationText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property HullNumberText that represents the column hull_no_txt.
        /// </summary>
        /// <value>
        /// The value of the property HullNumberText that represents the column hull_no_txt.
        /// </value>
        public ColumnExpression HullNumberText 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MineRequisitionCaseNumberText that represents the column mine_rqn_case_no_txt.
        /// </summary>
        /// <value>
        /// The value of the property MineRequisitionCaseNumberText that represents the column mine_rqn_case_no_txt.
        /// </value>
        public ColumnExpression MineRequisitionCaseNumberText 
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
        /// Initializes a new instance of the <see cref="MaterielExpression"/> class.
        /// </summary>
        public MaterielExpression()
            : base("Materiel", typeof(IMateriel))
        {
        }

        #endregion
    }
}

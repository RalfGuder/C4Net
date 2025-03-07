using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ReferenceAssociation.
    /// </summary>
    public class ReferenceAssociationExpression : BaseEntityExpression<ReferenceAssociationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property SubjectReferenceId that represents the column subj_ref_id.
        /// </summary>
        /// <value>
        /// The value of the property SubjectReferenceId that represents the column subj_ref_id.
        /// </value>
        public ColumnExpression SubjectReferenceId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectReferenceId that represents the column obj_ref_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectReferenceId that represents the column obj_ref_id.
        /// </value>
        public ColumnExpression ObjectReferenceId 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column ref_assoc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column ref_assoc_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
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
        /// Initializes a new instance of the <see cref="ReferenceAssociationExpression"/> class.
        /// </summary>
        public ReferenceAssociationExpression()
            : base("ReferenceAssociation", typeof(IReferenceAssociation))
        {
        }

        #endregion
    }
}

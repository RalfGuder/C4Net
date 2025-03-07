using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PersonIdentificationDocument.
    /// </summary>
    public class PersonIdentificationDocumentExpression : BaseEntityExpression<PersonIdentificationDocumentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property PersonId that represents the column pers_id.
        /// </summary>
        /// <value>
        /// The value of the property PersonId that represents the column pers_id.
        /// </value>
        public ColumnExpression PersonId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column pers_identific_doc_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column pers_identific_doc_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property PersonIdentificationDocumentCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property PersonIdentificationDocumentCode that represents the column code.
        /// </value>
        public ColumnExpression PersonIdentificationDocumentCode 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property NumberText that represents the column no_txt.
        /// </summary>
        /// <value>
        /// The value of the property NumberText that represents the column no_txt.
        /// </value>
        public ColumnExpression NumberText 
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
        /// Initializes a new instance of the <see cref="PersonIdentificationDocumentExpression"/> class.
        /// </summary>
        public PersonIdentificationDocumentExpression()
            : base("PersonIdentificationDocument", typeof(IPersonIdentificationDocument))
        {
        }

        #endregion
    }
}

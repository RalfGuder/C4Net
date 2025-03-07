using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectTypeEstablishmentObjectTypeDetail.
    /// </summary>
    public class ObjectTypeEstablishmentObjectTypeDetailExpression : BaseEntityExpression<ObjectTypeEstablishmentObjectTypeDetailExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property EstablishedObjectTypeId that represents the column estabd_obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property EstablishedObjectTypeId that represents the column estabd_obj_type_id.
        /// </value>
        public ColumnExpression EstablishedObjectTypeId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeEstablishmentIndex that represents the column obj_type_estab_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeEstablishmentIndex that represents the column obj_type_estab_ix.
        /// </value>
        public ColumnExpression ObjectTypeEstablishmentIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column obj_type_estab_objt_det_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_type_estab_objt_det_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MajorPartIndicator that represents the column major_part_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property MajorPartIndicator that represents the column major_part_ind_code.
        /// </value>
        public ColumnExpression MajorPartIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Count that represents the column cnt.
        /// </summary>
        /// <value>
        /// The value of the property Count that represents the column cnt.
        /// </value>
        public ColumnExpression Count 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeId that represents the column det_obj_type_id.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeId that represents the column det_obj_type_id.
        /// </value>
        public ColumnExpression ObjectTypeId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectTypeEstablishmentDetailObjectTypeEstablishmentIndex that represents the column det_obj_type_estab_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectTypeEstablishmentDetailObjectTypeEstablishmentIndex that represents the column det_obj_type_estab_ix.
        /// </value>
        public ColumnExpression ObjectTypeEstablishmentDetailObjectTypeEstablishmentIndex 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeEstablishmentObjectTypeDetailExpression"/> class.
        /// </summary>
        public ObjectTypeEstablishmentObjectTypeDetailExpression()
            : base("ObjectTypeEstablishmentObjectTypeDetail", typeof(IObjectTypeEstablishmentObjectTypeDetail))
        {
        }

        #endregion
    }
}

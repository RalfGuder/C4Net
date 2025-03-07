using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ObjectTypeEstablishment.
    /// </summary>
    public class ObjectTypeEstablishmentExpression : BaseEntityExpression<ObjectTypeEstablishmentExpression>
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
        /// Expression for the property Index that represents the column obj_type_estab_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column obj_type_estab_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property EffectiveDatetime that represents the column effctv_dttm.
        /// </summary>
        /// <value>
        /// The value of the property EffectiveDatetime that represents the column effctv_dttm.
        /// </value>
        public ColumnExpression EffectiveDatetime 
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
        /// Expression for the property EnvironmentCondition that represents the column environ_cond_code.
        /// </summary>
        /// <value>
        /// The value of the property EnvironmentCondition that represents the column environ_cond_code.
        /// </value>
        public ColumnExpression EnvironmentCondition 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property NameText that represents the column name_txt.
        /// </summary>
        /// <value>
        /// The value of the property NameText that represents the column name_txt.
        /// </value>
        public ColumnExpression NameText 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalMode that represents the column operat_mode_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalMode that represents the column operat_mode_code.
        /// </value>
        public ColumnExpression OperationalMode 
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
        /// Initializes a new instance of the <see cref="ObjectTypeEstablishmentExpression"/> class.
        /// </summary>
        public ObjectTypeEstablishmentExpression()
            : base("ObjectTypeEstablishment", typeof(IObjectTypeEstablishment))
        {
        }

        #endregion
    }
}

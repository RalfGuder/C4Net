using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity IedTacticalCharacterization.
    /// </summary>
    public class IedTacticalCharacterizationExpression : BaseEntityExpression<IedTacticalCharacterizationExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property ActionEventId that represents the column act_event_id.
        /// </summary>
        /// <value>
        /// The value of the property ActionEventId that represents the column act_event_id.
        /// </value>
        public ColumnExpression ActionEventId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ActionEventDetailIndex that represents the column act_event_det_ix.
        /// </summary>
        /// <value>
        /// The value of the property ActionEventDetailIndex that represents the column act_event_det_ix.
        /// </value>
        public ColumnExpression ActionEventDetailIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Emplacement that represents the column empl_code.
        /// </summary>
        /// <value>
        /// The value of the property Emplacement that represents the column empl_code.
        /// </value>
        public ColumnExpression Emplacement 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property EmploymentMethod that represents the column employ_mthd_code.
        /// </summary>
        /// <value>
        /// The value of the property EmploymentMethod that represents the column employ_mthd_code.
        /// </value>
        public ColumnExpression EmploymentMethod 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Suicide that represents the column suicide_code.
        /// </summary>
        /// <value>
        /// The value of the property Suicide that represents the column suicide_code.
        /// </value>
        public ColumnExpression Suicide 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property UseSequence that represents the column use_seq_code.
        /// </summary>
        /// <value>
        /// The value of the property UseSequence that represents the column use_seq_code.
        /// </value>
        public ColumnExpression UseSequence 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property VehiclePlacement that represents the column vehicle_plcmnt_code.
        /// </summary>
        /// <value>
        /// The value of the property VehiclePlacement that represents the column vehicle_plcmnt_code.
        /// </value>
        public ColumnExpression VehiclePlacement 
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
        /// Initializes a new instance of the <see cref="IedTacticalCharacterizationExpression"/> class.
        /// </summary>
        public IedTacticalCharacterizationExpression()
            : base("IedTacticalCharacterization", typeof(IIedTacticalCharacterization))
        {
        }

        #endregion
    }
}

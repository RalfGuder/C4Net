using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MaterielStatus.
    /// </summary>
    public class MaterielStatusExpression : BaseEntityExpression<MaterielStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column mat_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column mat_stat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </value>
        public ColumnExpression ObjectItemStatusIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property BodyColour that represents the column body_colour_code.
        /// </summary>
        /// <value>
        /// The value of the property BodyColour that represents the column body_colour_code.
        /// </value>
        public ColumnExpression BodyColour 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Marking that represents the column marking_code.
        /// </summary>
        /// <value>
        /// The value of the property Marking that represents the column marking_code.
        /// </value>
        public ColumnExpression Marking 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MarkingColour that represents the column marking_colour_code.
        /// </summary>
        /// <value>
        /// The value of the property MarkingColour that represents the column marking_colour_code.
        /// </value>
        public ColumnExpression MarkingColour 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property DemolitionStatus that represents the column dmltn_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property DemolitionStatus that represents the column dmltn_stat_code.
        /// </value>
        public ColumnExpression DemolitionStatus 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property ImoCompliantIndicator that represents the column imo_compliant_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ImoCompliantIndicator that represents the column imo_compliant_ind_code.
        /// </value>
        public ColumnExpression ImoCompliantIndicator 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalStatus that represents the column operat_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatus that represents the column operat_stat_code.
        /// </value>
        public ColumnExpression OperationalStatus 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalStatusQualifier that represents the column operat_stat_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatusQualifier that represents the column operat_stat_qual_code.
        /// </value>
        public ColumnExpression OperationalStatusQualifier 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalStatusMode that represents the column operat_stat_mode_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatusMode that represents the column operat_stat_mode_code.
        /// </value>
        public ColumnExpression OperationalStatusMode 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property ReserveIndicator that represents the column reserve_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ReserveIndicator that represents the column reserve_ind_code.
        /// </value>
        public ColumnExpression ReserveIndicator 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property SafetyStatus that represents the column safety_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property SafetyStatus that represents the column safety_stat_code.
        /// </value>
        public ColumnExpression SafetyStatus 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property UsageStatus that represents the column usage_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property UsageStatus that represents the column usage_stat_code.
        /// </value>
        public ColumnExpression UsageStatus 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property BuoyMalfunction that represents the column buoy_malf_code.
        /// </summary>
        /// <value>
        /// The value of the property BuoyMalfunction that represents the column buoy_malf_code.
        /// </value>
        public ColumnExpression BuoyMalfunction 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[15]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[16]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterielStatusExpression"/> class.
        /// </summary>
        public MaterielStatusExpression()
            : base("MaterielStatus", typeof(IMaterielStatus))
        {
        }

        #endregion
    }
}

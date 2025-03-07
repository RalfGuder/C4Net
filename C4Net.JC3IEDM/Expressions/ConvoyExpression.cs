using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Convoy.
    /// </summary>
    public class ConvoyExpression : BaseEntityExpression<ConvoyExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column convoy_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column convoy_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property DaySpeedRate that represents the column day_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property DaySpeedRate that represents the column day_speed_rate.
        /// </value>
        public ColumnExpression DaySpeedRate 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DayVehicleGapDimension that represents the column day_vehicle_gap_dim.
        /// </summary>
        /// <value>
        /// The value of the property DayVehicleGapDimension that represents the column day_vehicle_gap_dim.
        /// </value>
        public ColumnExpression DayVehicleGapDimension 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property HaltDuration that represents the column halt_dur.
        /// </summary>
        /// <value>
        /// The value of the property HaltDuration that represents the column halt_dur.
        /// </value>
        public ColumnExpression HaltDuration 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property NightSpeedRate that represents the column night_speed_rate.
        /// </summary>
        /// <value>
        /// The value of the property NightSpeedRate that represents the column night_speed_rate.
        /// </value>
        public ColumnExpression NightSpeedRate 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property NightVehicleGapDimension that represents the column night_vehicle_gap_dim.
        /// </summary>
        /// <value>
        /// The value of the property NightVehicleGapDimension that represents the column night_vehicle_gap_dim.
        /// </value>
        public ColumnExpression NightVehicleGapDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property PacketGapDimension that represents the column packet_gap_dim.
        /// </summary>
        /// <value>
        /// The value of the property PacketGapDimension that represents the column packet_gap_dim.
        /// </value>
        public ColumnExpression PacketGapDimension 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property PacketSizeCount that represents the column packet_size_cnt.
        /// </summary>
        /// <value>
        /// The value of the property PacketSizeCount that represents the column packet_size_cnt.
        /// </value>
        public ColumnExpression PacketSizeCount 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvoyExpression"/> class.
        /// </summary>
        public ConvoyExpression()
            : base("Convoy", typeof(IConvoy))
        {
        }

        #endregion
    }
}

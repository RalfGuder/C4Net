using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represent the behaviour of air-delivered mine after weapon release.
    /// </summary>
    [DomId(100004340)]
    [DataContract]
    public enum MineStatusAirDropEffectEnum
    {
		
        /// <summary>
        /// Parachute drop and weapon impact where normal.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NORMAL")]
        [EnumMember]
        Normal,
		
        /// <summary>
        /// Parachute failed to fully open.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PARMAL")]
        [EnumMember]
        ParachuteMalfunction,
		
        /// <summary>
        /// Parachute failed to fully open, arming wires not retained.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PARAM")]
        [EnumMember]
        ParachuteArmMalfunction,
		
        /// <summary>
        /// Parachute failed to fully open, arming wires not retained, and case skipped on impact.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PARAMS")]
        [EnumMember]
        ParachuteAndArmMalfunctionSkip,
		
        /// <summary>
        /// Parachute failed to fully open, arming wires not retained, and case skipped and broke up on impact.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PARAMB")]
        [EnumMember]
        ParachuteAndArmMalfunctionSkipBrokeUp,
		
        /// <summary>
        /// Parachute failed to fully open, case skipped on impact.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PARMS")]
        [EnumMember]
        ParachuteMalfunctionSkip,
		
        /// <summary>
        /// Parachute failed to fully open, case broke up on impact.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PARMBU")]
        [EnumMember]
        ParachuteMalfunctionBrokeUp,
		
        /// <summary>
        /// Arming wires not retained.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ARMMAL")]
        [EnumMember]
        ArmMalfunction,
		
        /// <summary>
        /// Arming wires not retained, case skipped on impact.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ARMMS")]
        [EnumMember]
        ArmMalfunctionSkip,
		
        /// <summary>
        /// Arming wires not retained, case skipped and broke up on impact.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ARMMSB")]
        [EnumMember]
        ArmMalfunctionSkipBrokeUp,
		
        /// <summary>
        /// Arming wires not retained, case broke up on impact.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ARMMBU")]
        [EnumMember]
        ArmMalfunctionBrokeUp,
		
        /// <summary>
        /// Case skipped on impact.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SKIP")]
        [EnumMember]
        Skip,
		
        /// <summary>
        /// Case skipped and broke up on impact.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SKIPBU")]
        [EnumMember]
        SkipBrokeUp,
		
        /// <summary>
        /// The type of malfunction is unknown.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("UNK")]
        [EnumMember]
        Unknown,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general mobility of a unit, seen as a whole.
    /// </summary>
    [DomId(100004187)]
    [DataContract]
    public enum UnitTypeGeneralMobilityEnum
    {
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally through the air.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIR")]
        [EnumMember]
        Air,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally through the air by means that combine deriving lift from fixed wings or from airfoils that rotate.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRCMP")]
        [EnumMember]
        AirComposite,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally through the air by deriving lift from fixed wings.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AIRFW")]
        [EnumMember]
        AirFixedWing,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally through the air by deriving lift from airfoils that rotate.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AIRRW")]
        [EnumMember]
        AirRotaryWing,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally through the air by using aircraft able to take off and land on very short distances.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AIRVST")]
        [EnumMember]
        AirVstol,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally both on land and in water.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("AMPH")]
        [EnumMember]
        Amphibious,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally on foot.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DSMNTD")]
        [EnumMember]
        Dismounted,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally while carried by horses.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("HORSE")]
        [EnumMember]
        Horse,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally on the ground.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("LAND")]
        [EnumMember]
        Land,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally on the ground, along rails.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("LNDRAI")]
        [EnumMember]
        LandRailed,
		
        /// <summary>
        /// The main equipment of the specified UNIT-TYPE moves generally on the ground by means of external propulsion (mechanical or animal).
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("LNDTWD")]
        [EnumMember]
        LandTowed,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally on the ground by means of vehicles using caterpillar treads.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("LNDTRC")]
        [EnumMember]
        LandTracked,
		
        /// <summary>
        /// The specified UNIT-TYPE moves generally on the ground by means of vehicles using wheels.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("LNDWHL")]
        [EnumMember]
        LandWheeled,
		
    }
}

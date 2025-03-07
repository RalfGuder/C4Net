using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ENGINEERING-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100000341)]
    [DataContract]
    public enum EngineeringEquipmentTypeCategoryEnum
    {
		
        /// <summary>
        /// A vehicle used to deliver a bridge.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BRDVEH")]
        [EnumMember]
        BridgeVehicle,
		
        /// <summary>
        /// Equipment designed for the crossing of gaps and other obstacles.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BRIDGG")]
        [EnumMember]
        Bridging,
		
        /// <summary>
        /// An equipment used to build a facility.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CONST")]
        [EnumMember]
        Construction,
		
        /// <summary>
        /// A vehicle generally used in the construction trade.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CNSTVE")]
        [EnumMember]
        ConstructionVehicle,
		
        /// <summary>
        /// A heavy caterpillar tractor fitted with a broad steel blade in front, used for removing obstacles, levelling uneven surfaces, etc.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("DOZER")]
        [EnumMember]
        Dozer,
		
        /// <summary>
        /// A vehicle designed for the excavation or shifting of large quantities of earth.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ERTHMV")]
        [EnumMember]
        Earthmover,
		
        /// <summary>
        /// A tracked vehicle designed to carry and lay a removable bridge.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MCBRLY")]
        [EnumMember]
        MechanisedBridgeLayer,
		
        /// <summary>
        /// A vehicle whose purpose is to remove or destroy mines.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MINCLR")]
        [EnumMember]
        MineClearer,
		
        /// <summary>
        /// A vehicle whose purpose is to lay mines.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MINLYR")]
        [EnumMember]
        MineLayer,
		
        /// <summary>
        /// An armoured vehicle whose purpose is to lay mines.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MNLYAR")]
        [EnumMember]
        MineLayerArmouredVehicleMounted,
		
        /// <summary>
        /// A trailer whose purpose is to lay mines.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MNLYTR")]
        [EnumMember]
        MineLayerTrailerMounted,
		
        /// <summary>
        /// An equipment whose purpose is to remove or destroy mines.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MINECL")]
        [EnumMember]
        MineClearing,
		
        /// <summary>
        /// An equipment whose purpose is to detect the presence of mines.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MINEDT")]
        [EnumMember]
        MineDetection,
		
        /// <summary>
        /// An equipment used to delimit a minefield.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MINEMR")]
        [EnumMember]
        MinefieldMarking,
		
        /// <summary>
        /// An equipment whose purpose is to lay mines.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MINLAY")]
        [EnumMember]
        MineLaying,
		
        /// <summary>
        /// A bridge that can be laid on floating structure to permit crossing.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("TFBRID")]
        [EnumMember]
        TacticalFloatingBridge,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A bridge that is carried on an armoured vehicle and is deployed from the vehicle for immediate use (VBPP, AVLB).
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("BRDLVA")]
        [EnumMember]
        BridgeLaunchingVehicleArmoured,
		
        /// <summary>
        /// A machine for raising and lowering heavy weights; in its usual form it consists of a vertical post capable of rotation on its axis, a projecting arm or 'jib' over which passes the chain or rope from which the weight is suspended, and a barrel round which the chain or rope is wound.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("CRANE")]
        [EnumMember]
        Crane,
		
        /// <summary>
        /// A wheeled machine for levelling the ground.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("GRADER")]
        [EnumMember]
        Grader,
		
        /// <summary>
        /// A machine for driving piles into the ground, usually consisting of a heavy block of iron, suspended in a frame between two vertical guide-posts, and alternately let fall upon the pile-head, and raised by steam, manual, or other power; some, working with steam, act on the principle of the steam-hammer.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("PILDRV")]
        [EnumMember]
        PileDriver,
		
        /// <summary>
        /// A mechanically powered spade-like implement, consisting of a broad blade of metal or other material, attached to a handle and used for raising and removing quantities of earth, grain, coal or other loose material.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("POWSHV")]
        [EnumMember]
        PowerShovel,
		
        /// <summary>
        /// A machine used to break down rocks.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("RCKCRH")]
        [EnumMember]
        RockCrusher,
		
        /// <summary>
        /// A machine used to make ditches.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("DITCHR")]
        [EnumMember]
        Ditcher,
		
    }
}

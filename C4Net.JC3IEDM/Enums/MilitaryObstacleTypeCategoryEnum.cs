using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MILITARY-OBSTACLE-TYPE.
    /// </summary>
    [DomId(100004147)]
    [DataContract]
    public enum MilitaryObstacleTypeCategoryEnum
    {
		
        /// <summary>
        /// A vehicular obstacle constructed by felling trees (leaving a 1-2 meter stump above the ground on both sides of a road, trail, gap, or defile) so that they fall, interlocking, toward the expected direction of enemy approach. The trees should remain attached to the stumps, be at a 45 degree angle to the roadway, and the obstacle itself should be at least 75 meters in depth to be most effective.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABATIS")]
        [EnumMember]
        Abatis,
		
        /// <summary>
        /// A facility that is a ditch obstacle designed to stop tanks.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ATDTCH")]
        [EnumMember]
        AntiTankDitch,
		
        /// <summary>
        /// A facility that is an obstacle that is designed or employed to disrupt, fix, turn or block the movement of tanks.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ANTOBS")]
        [EnumMember]
        AntiTankObstacle,
		
        /// <summary>
        /// A wall-like obstacle capable of stopping tanks.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ANTWAL")]
        [EnumMember]
        AntiTankWall,
		
        /// <summary>
        /// An obstacle, consisting of twisted wires armed with barbs or sharp points.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BARBEN")]
        [EnumMember]
        BarbedWireEntanglement,
		
        /// <summary>
        /// A squared-off log or a large, oblong piece of timber, metal, or stone inserted in the ground to obstruct movement.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("BPSOBS")]
        [EnumMember]
        BeamPostObstacle,
		
        /// <summary>
        /// A pit or hole in the ground created by an explosion or an impact in order to be used as an obstacle.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CRATER")]
        [EnumMember]
        CraterObstacle,
		
        /// <summary>
        /// Debris obtained from the demolition of an object in order to be used as an obstacle.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("DMDBRS")]
        [EnumMember]
        DemolitionDebrisObstacle,
		
        /// <summary>
        /// A channel constructed for the purpose of blocking movement.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DCHNOS")]
        [EnumMember]
        DitchObstacleNotOtherwiseSpecified,
		
        /// <summary>
        /// Regular spaced concrete or metal barriers laid in single or multiple rows to prevent vehicle movement.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("DGT")]
        [EnumMember]
        DragonTeeth,
		
        /// <summary>
        /// A structure that is maintained in an elevated position and can be dropped to form an obstacle.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("FBKOBS")]
        [EnumMember]
        FallingBlockObstacle,
		
        /// <summary>
        /// An obstacle made by laying mines of anti-personnel type laid with or without pattern.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MINEAP")]
        [EnumMember]
        MinefieldAntiPersonnel,
		
        /// <summary>
        /// An obstacle made by laying mines of anti-tank type laid with or without pattern.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MINEAT")]
        [EnumMember]
        MinefieldAntiTank,
		
        /// <summary>
        /// A minefield made by laying mines of both anti-personnel and anti-tank type laid with or without pattern.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MINEMX")]
        [EnumMember]
        MinefieldMixed,
		
        /// <summary>
        /// An obstacle made by laying mines of an unspecified type laid with or without pattern.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MINEFD")]
        [EnumMember]
        MinefieldNotOtherwiseSpecified,
		
        /// <summary>
        /// A barrier or obstacle (usually covered by fire) used to block, or limit the movement of, hostile vehicles along a route.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("ROADBL")]
        [EnumMember]
        Roadblock,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("TTRHDN")]
        [EnumMember]
        Tetrahedron,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("TRPWIR")]
        [EnumMember]
        TripWire,
		
        /// <summary>
        /// A continuous, vertical structure, such as a concrete or rock wall created in order to be used as an obstacle.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("WALL")]
        [EnumMember]
        WallObstacle,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("WIRAFN")]
        [EnumMember]
        WireObstacleDoubleApronFence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("WIRDFN")]
        [EnumMember]
        WireObstacleDoubleFence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("WIRDCN")]
        [EnumMember]
        WireObstacleDoubleStrandConcertina,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("WIRHFN")]
        [EnumMember]
        WireObstacleHighWireFence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("WIRLFN")]
        [EnumMember]
        WireObstacleLowWireFence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("WIRNOS")]
        [EnumMember]
        WireObstacleNotOtherwiseSpecified,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("WIRSCN")]
        [EnumMember]
        WireObstacleSingleConcertina,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("WIRSFN")]
        [EnumMember]
        WireObstacleSingleFence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("WIRTCN")]
        [EnumMember]
        WireObstacleTripleStrandConcertina,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// An obstruction made of vehicles erected to bar the advance of persons or vehicles, or to prevent access to a place.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("BARVEH")]
        [EnumMember]
        BarrierVehicle,
		
        /// <summary>
        /// An obstacle that is an area of land containing mines.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("MNFLLA")]
        [EnumMember]
        MinefieldLand,
		
        /// <summary>
        /// An obstacle that is made by laying maritime mines in a body of water with or without pattern.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("MNFLMA")]
        [EnumMember]
        MinefieldMaritime,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the design class of BRIDGE-TYPE.
    /// </summary>
    [DomId(100004118)]
    [DataContract]
    public enum BridgeTypeDesignTypeEnum
    {
		
        /// <summary>
        /// A bridge supported by curved structures.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARCH")]
        [EnumMember]
        Arch,
		
        /// <summary>
        /// A bridge using large iron or steel beams or compound structure for bearing loads.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BXGRDR")]
        [EnumMember]
        BoxGirder,
		
        /// <summary>
        /// A bridge made of cantilevers projecting from the piers and connected by girders.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CNTLVR")]
        [EnumMember]
        Cantilever,
		
        /// <summary>
        /// A movable bridge represented by a ferry moving back and forth between fixed bridging sites.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FERRY")]
        [EnumMember]
        Ferry,
		
        /// <summary>
        /// A bridge that can be raised to allow the passage of ships.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LIFT")]
        [EnumMember]
        Lift,
		
        /// <summary>
        /// A bridge using medium iron or steel beams or compound structure for bearing loads.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MILMDG")]
        [EnumMember]
        MilitaryMediumGirder,
		
        /// <summary>
        /// A bridge that is carried on a vehicle and is deployed from the vehicle for immediate use.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MILVHL")]
        [EnumMember]
        MilitaryVehicleLaunched,
		
        /// <summary>
        /// A movable bridge represented by a raft moving back and forth between fixed bridging sites, usually along wires connected to both these sites.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("RAFT")]
        [EnumMember]
        Raft,
		
        /// <summary>
        /// A bridge made by use of a flat broad fairly thick usu. square or rectangular piece of solid material, esp. stone.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SLAB")]
        [EnumMember]
        Slab,
		
        /// <summary>
        /// A bridge made by use of a longitudinal structural member in a framework.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("STRNGR")]
        [EnumMember]
        Stringer,
		
        /// <summary>
        /// A bridge with a roadway suspended from cables supported by structures at each end.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SSPNSN")]
        [EnumMember]
        Suspension,
		
        /// <summary>
        /// A bridge that can be swung to one side to allow the passage of ships.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SWING")]
        [EnumMember]
        Swing,
		
        /// <summary>
        /// A bridge made by use of a framework, e.g. of rafters and struts.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("TRUSS")]
        [EnumMember]
        Truss,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A bridge on pontoons etc.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("FLTNOS")]
        [EnumMember]
        FloatingNotOtherwiseSpecified,
		
        /// <summary>
        /// A bridge constructed using small boats.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("FLTBOT")]
        [EnumMember]
        FloatingBoat,
		
        /// <summary>
        /// A bridge constructed on pontoons.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("FLTPNT")]
        [EnumMember]
        FloatingPontoon,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the status of a mine.
    /// </summary>
    [DomId(100004339)]
    [DataContract]
    public enum MineStatusEnum
    {
		
        /// <summary>
        /// The specified mine has been activated through either influence or control signal.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACTVED")]
        [EnumMember]
        ActivatedMine,
		
        /// <summary>
        /// The specified mine has been located and has been evaluated by a competent authority.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CLSSFD")]
        [EnumMember]
        ClassifiedMine,
		
        /// <summary>
        /// The specified mine has been exploded by the shock of a nearby explosion of another mine or independent explosive charge.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CNTRMN")]
        [EnumMember]
        CounterminedMine,
		
        /// <summary>
        /// The specified mine has been located, has been processed by a competent authority and its exact nature is known.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("IDNTMN")]
        [EnumMember]
        IdentifiedMine,
		
        /// <summary>
        /// The specified mine is located and its presence is indicated by some form of physical identification device.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MRKDMN")]
        [EnumMember]
        MarkedMine,
		
        /// <summary>
        /// The specified mine is located and remains in its original location.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MNLFPL")]
        [EnumMember]
        MineLeftInPlace,
		
        /// <summary>
        /// The specified mine is rendered, by external means, permanently incapable of firing, although it may remain dangerous to handle. The mine case may remain virtually intact.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NEUTRL")]
        [EnumMember]
        NeutralizedMine,
		
        /// <summary>
        /// The specified mine is salvaged as nearly intact as possible to permit further investigation for intelligence and/or evaluation purposes.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("RECVRD")]
        [EnumMember]
        RecoveredMine,
		
        /// <summary>
        /// The specified mine is taken out of an area where its detonation would be unacceptable.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("REMOVD")]
        [EnumMember]
        RemovedMine,
		
        /// <summary>
        /// The specified mine is made safe by the application of special explosive ordnance disposal methods and tools for the interruption of function or separation of essential components of unexploded ordnance to prevent an unacceptable detonation.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("RNDERD")]
        [EnumMember]
        RenderedSafeMine,
		
        /// <summary>
        /// The specified mine has lost its buoyancy.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SUNKMN")]
        [EnumMember]
        SunkMine,
		
    }
}

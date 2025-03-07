using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of container handling equipment available at a specific QUAY.
    /// </summary>
    [DomId(100004180)]
    [DataContract]
    public enum QuayContainerHandlingTypeEnum
    {
		
        /// <summary>
        /// A freight container lifting frame which straddles a container, is able to lift the container and carry it about inside the frame, can be towed or self-propelled, may have steerable wheels and used for loading, unloading, transportation and stacking of freight containers.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CNTSTR")]
        [EnumMember]
        ContainerStraddleLift,
		
        /// <summary>
        /// A forklift truck or tractor for lifting, moving and stacking only empty freight containers.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EMPCNT")]
        [EnumMember]
        EmptyContainerForklift,
		
        /// <summary>
        /// A vehicle similar to a forklift tractor with a single boom or arm which moves in a vertical plane with on-top spreader for clamping freight containers, used for moving and stacking fully loaded freight containers.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RCHSTK")]
        [EnumMember]
        ReachStacker,
		
        /// <summary>
        /// A vehicle with an attachment or clamp to the forks in front for lifting and carrying ISO freight containers, used for loading and unloading containers and is designed to be used on rough undulating surface conditions or off-road conditions, all wheels are driven.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RGHTER")]
        [EnumMember]
        RoughTerrainContainerHandler,
		
        /// <summary>
        /// A crane designed with sufficient outreach to load and unload freight container vessels berthed alongside.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SHPTSH")]
        [EnumMember]
        ShipToShoreContainerHandlerCrane,
		
        /// <summary>
        /// A vehicle used in port operations to move freight containers between a stacking area and a vessel side by means of a towed trailer upon which the container is placed.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SHNTER")]
        [EnumMember]
        ShuntingTerminalTractor,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

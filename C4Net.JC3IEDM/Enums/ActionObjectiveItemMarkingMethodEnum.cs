using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the method of marking a position.
    /// </summary>
    [DomId(100000241)]
    [DataContract]
    public enum ActionObjectiveItemMarkingMethodEnum
    {
		
        /// <summary>
        /// The marking of an object by a pyrotechnic munition producing illumination or identification.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FLR")]
        [EnumMember]
        Flare,
		
        /// <summary>
        /// The marking of an object by a device that places visible light for illumination or identification.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LIGHT")]
        [EnumMember]
        Light,
		
        /// <summary>
        /// The act or process of marking of an object by visible or near visible light.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ILLUMN")]
        [EnumMember]
        Illumination,
		
        /// <summary>
        /// The marking of an object by a device that produces an electromagnetic beam for illumination or identification.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LAS")]
        [EnumMember]
        Laser,
		
        /// <summary>
        /// A sheet of material that is used as a reference point for object marking.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MPL")]
        [EnumMember]
        MarkerPanel,
		
        /// <summary>
        /// The reference point of an object by a radio transmitter that emits a distinctive, or characteristic, signal used for the determination of bearings, courses or location.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("RBE")]
        [EnumMember]
        RadioBeacon,
		
        /// <summary>
        /// The marking of an object by a munition producing smoke.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SMOKE")]
        [EnumMember]
        Smoke,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The marking of an object by use of a star cluster for illumination or identification.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("STRCLS")]
        [EnumMember]
        StarCluster,
		
        /// <summary>
        /// The marking of an object by use of a strobe beacon for illumination or identification.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("STRBBN")]
        [EnumMember]
        StrobeBeacon,
		
        /// <summary>
        /// The marking of an object by use of strobe lights for illumination or identification.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("STRBLT")]
        [EnumMember]
        StrobeLights,
		
        /// <summary>
        /// The marking of an object by use of a torch for illumination or identification.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("TORCH")]
        [EnumMember]
        Torch,
		
        /// <summary>
        /// The marking of an object by lights from a vehicle for illumination or identification.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("VHCLLT")]
        [EnumMember]
        VehicleLights,
		
    }
}

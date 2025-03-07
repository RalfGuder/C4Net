using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of malfunction of a buoy.
    /// </summary>
    [DomId(100004323)]
    [DataContract]
    public enum MaterielStatusBuoyMalfunctionEnum
    {
		
        /// <summary>
        /// The buoy does not display a marker flag.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NOFLAG")]
        [EnumMember]
        NoFlag,
		
        /// <summary>
        /// The buoy does not produce an acceptable radar reflection.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NORADR")]
        [EnumMember]
        NoRadarReflection,
		
        /// <summary>
        /// The buoy is no longer visible in the location/area deployed.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BUOYNT")]
        [EnumMember]
        BuoyNotInSight,
		
        /// <summary>
        /// The buoy has moved from its original placed location.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SERVCE")]
        [EnumMember]
        ServiceableBuoyHasDraggedItsPosition,
		
        /// <summary>
        /// The buoy no longer has an operable lighting mechanism.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOLGHT")]
        [EnumMember]
        NoLight,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether an aircraft is designed to be manned or unmanned.
    /// </summary>
    [DomId(100004366)]
    [DataContract]
    public enum AircraftTypeManningEnum
    {
		
        /// <summary>
        /// The AIRCRAFT-TYPE is designed to be manned.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MANNED")]
        [EnumMember]
        Manned,
		
        /// <summary>
        /// The AIRCRAFT-TYPE is designed to be unmanned.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("UNMANN")]
        [EnumMember]
        Unmanned,
		
        /// <summary>
        /// The AIRCRAFT-TYPE is designed to be unmanned and remotely piloted.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("UNMRP")]
        [EnumMember]
        UnmannedRemotelyPiloted,
		
        /// <summary>
        /// The AIRCRAFT-TYPE is designed to be unmanned and not remotely piloted.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UNMNRP")]
        [EnumMember]
        UnmannedNotRemotelyPiloted,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

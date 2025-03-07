using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of SURVEILLANCE-CAPABILITY.
    /// </summary>
    [DomId(100000203)]
    [DataContract]
    public enum SurveillanceCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The ability to gain information from exploiting EMS (not imagery) systems.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("SIG")]
        [EnumMember]
        Signal,
		
        /// <summary>
        /// The ability to gain information by exploiting human senses.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HUM")]
        [EnumMember]
        Human,
		
        /// <summary>
        /// The ability to gain information by exploiting imaging systems.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("IMG")]
        [EnumMember]
        Imaging,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The ability to gain information by exploiting communications systems.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("COM")]
        [EnumMember]
        Communication,
		
        /// <summary>
        /// The ability to gain information by exploiting non-communications electronic systems (generally pulsed).
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ELC")]
        [EnumMember]
        Electronic,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

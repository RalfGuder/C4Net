using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether an aircraft is primarily intended for military or civilian use.
    /// </summary>
    [DomId(100004367)]
    [DataContract]
    public enum AircraftTypeMilitaryCivilianEnum
    {
		
        /// <summary>
        /// The AIRCRAFT-TYPE is primarily intended for civilian use.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CIVIL")]
        [EnumMember]
        Civilian,
		
        /// <summary>
        /// The AIRCRAFT-TYPE is primarily intended for military use.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MIL")]
        [EnumMember]
        Military,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

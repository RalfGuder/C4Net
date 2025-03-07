using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the known status of mined channels of a MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004319)]
    [DataContract]
    public enum MinefieldMaritimeStatusColourEnum
    {
		
        /// <summary>
        /// Established channel/RTE where information does not exist on enemy mining or all known mines in the channel have been countered.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("GREEN")]
        [EnumMember]
        Green,
		
        /// <summary>
        /// Channel where mines are known to be present.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// Channel where the degree of danger has been reduced by mine counter measure operations.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("YELLOW")]
        [EnumMember]
        Yellow,
		
    }
}

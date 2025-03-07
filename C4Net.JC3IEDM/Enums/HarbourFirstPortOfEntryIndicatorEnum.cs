using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the port may be used by a vessel that needs to clear foreign goods and personnel through Customs and Immigration.
    /// </summary>
    [DomId(100004299)]
    [DataContract]
    public enum HarbourFirstPortOfEntryIndicatorEnum
    {
		
        /// <summary>
        /// The harbour cannot be used to clear foreign goods and personnel through Customs and Immigration.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The harbour can be used to clear foreign goods and personnel through Customs and Immigration.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the capability of a specific AIRFIELD to function under defined flight rules.
    /// </summary>
    [DomId(100004213)]
    [DataContract]
    public enum AirfieldStatusFlightSupportCategoryEnum
    {
		
        /// <summary>
        /// The specific AIRFIELD is capable of operating according to Instrument or Visual Flight Rules.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("IFR")]
        [EnumMember]
        Ifr,
		
        /// <summary>
        /// The specific AIRFIELD can only operate according to Visual Flight Rules.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("VFR")]
        [EnumMember]
        Vfr,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

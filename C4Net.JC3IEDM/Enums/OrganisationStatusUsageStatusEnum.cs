using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the usage of a specific ORGANISATION.
    /// </summary>
    [DomId(100000265)]
    [DataContract]
    public enum OrganisationStatusUsageStatusEnum
    {
		
        /// <summary>
        /// A status indicating that an ORGANISATION is performing its operational mission.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INACT")]
        [EnumMember]
        InAction,
		
        /// <summary>
        /// A status indicating that an ORGANISATION is not performing its operational mission.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OUTACT")]
        [EnumMember]
        OutOfAction,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

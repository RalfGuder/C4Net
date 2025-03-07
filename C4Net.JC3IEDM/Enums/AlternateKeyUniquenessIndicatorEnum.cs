using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether the alternate key or inversion key is unique.
    /// </summary>
    [DomId(100006001)]
    [DataContract]
    public enum AlternateKeyUniquenessIndicatorEnum
    {
		
        /// <summary>
        /// The alternate key is always unique.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AU")]
        [EnumMember]
        AlwaysUnique,
		
        /// <summary>
        /// The alternate key is mostly unique as in an Inversion entry.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MU")]
        [EnumMember]
        MostlyUnique,
		
    }
}

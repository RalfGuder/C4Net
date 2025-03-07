using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a vessel complies with International Maritime Organisation standards.
    /// </summary>
    [DomId(100004287)]
    [DataContract]
    public enum MaterielStatusImoCompliantIndicatorEnum
    {
		
        /// <summary>
        /// The specific vessel does not comply with International Maritime Organisation (IMO) standards.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific vessel complies with International Maritime Organisation (IMO) standards.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}

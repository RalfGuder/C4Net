using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether the OBJECT-ITEM is permitted by command authority to use a specific ELECTRONIC-ADDRESS.
    /// </summary>
    [DomId(100004128)]
    [DataContract]
    public enum ObjectItemAddressAuthorisationIndicatorEnum
    {
		
        /// <summary>
        /// The specific OBJECT-ITEM is not authorised to use the specific ELECTRONIC-ADDRESS.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific OBJECT-ITEM is authorised to use the specific ELECTRONIC-ADDRESS.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}

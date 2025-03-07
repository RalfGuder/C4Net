using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a specific PERSON professes a religious preference.
    /// </summary>
    [DomId(100004224)]
    [DataContract]
    public enum PersonProfessingIndicatorEnum
    {
		
        /// <summary>
        /// The specific PERSON does not profess a religious preference.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific PERSON does profess a religious preference.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}

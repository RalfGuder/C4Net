using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the property of an ACTION-TASK to be overt or covert.
    /// </summary>
    [DomId(100004201)]
    [DataContract]
    public enum ActionTaskOvertCovertEnum
    {
		
        /// <summary>
        /// The ACTION-TASK is to be conducted secretly.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COVERT")]
        [EnumMember]
        Covert,
		
        /// <summary>
        /// The ACTION-TASK is to be conducted openly.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OVERT")]
        [EnumMember]
        Overt,
		
    }
}

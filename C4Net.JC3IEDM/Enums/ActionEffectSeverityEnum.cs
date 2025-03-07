using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the degree of seriousness of a specific ACTION-EFFECT.
    /// </summary>
    [DomId(100000387)]
    [DataContract]
    public enum ActionEffectSeverityEnum
    {
		
        /// <summary>
        /// A subjective judgement by the reporting organisation that the specific ACTION resulted in no disorder with respect to the object or class that is the focus of the ACTION-EFFECT.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NODSRP")]
        [EnumMember]
        NoDisruption,
		
        /// <summary>
        /// A subjective judgement by the reporting organisation that the specific ACTION resulted in minor disorder with respect to the object or class that is the focus of the ACTION-EFFECT.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MINDSR")]
        [EnumMember]
        MinorDisruption,
		
        /// <summary>
        /// A subjective judgement by the reporting organisation that the specific ACTION resulted in severe disorder with respect to the object or class that is the focus of the ACTION-EFFECT.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SEVDSR")]
        [EnumMember]
        SevereDisruption,
		
        /// <summary>
        /// A subjective judgement by the reporting organisation that the specific ACTION resulted in complete disorder with respect to the object or class that is the focus of the ACTION-EFFECT.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TOTDSR")]
        [EnumMember]
        TotalDisruption,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

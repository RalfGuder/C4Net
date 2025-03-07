using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the emission control status of a specific OBJECT-ITEM.
    /// </summary>
    [DomId(100004158)]
    [DataContract]
    public enum ObjectItemStatusEmissionControlEnum
    {
		
        /// <summary>
        /// Electronic Silence is a deliberate prohibition of electronic radiation to prevent the emission of significant electromagnetic signals.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EMCON1")]
        [EnumMember]
        Emcon1,
		
        /// <summary>
        /// Radio Silence is a restriction placed on the use of all or certain radio equipment. Any commander at any level may impose radio silence.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EMCON2")]
        [EnumMember]
        Emcon2,
		
        /// <summary>
        /// No restrictions, normal operations.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("EMCON3")]
        [EnumMember]
        Emcon3,
		
    }
}

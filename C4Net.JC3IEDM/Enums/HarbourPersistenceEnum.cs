using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR is permanent or temporary.
    /// </summary>
    [DomId(100004168)]
    [DataContract]
    public enum HarbourPersistenceEnum
    {
		
        /// <summary>
        /// The harbour is a fixed installation and cannot be moved.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PERMAN")]
        [EnumMember]
        Permanent,
		
        /// <summary>
        /// The harbour has been constructed using pre-fabricated structures and constructed on a site that was not previously a harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TEMPRY")]
        [EnumMember]
        Temporary,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the operational mode for which a specific OBJECT-TYPE-ESTABLISHMENT is authorised.
    /// </summary>
    [DomId(100004193)]
    [DataContract]
    public enum ObjectTypeEstablishmentOperationalModeEnum
    {
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for civil support operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CV")]
        [EnumMember]
        CivilSupport,
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for humanitarian support operations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HU")]
        [EnumMember]
        HumanitarianSupport,
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for internal security operations.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("IS")]
        [EnumMember]
        InternalSecurity,
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for conditions of peace.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PE")]
        [EnumMember]
        Peace,
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for peace support operations.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PSO")]
        [EnumMember]
        PeaceSupport,
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for peace keeping operations.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PK")]
        [EnumMember]
        PeaceKeeping,
		
        /// <summary>
        /// An indication that the specified OBJECT-TYPE-ESTABLISHMENT is designated for war.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("WA")]
        [EnumMember]
        War,
		
    }
}

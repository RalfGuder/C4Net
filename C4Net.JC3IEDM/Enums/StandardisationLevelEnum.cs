using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the level of common agreement for the object.
    /// </summary>
    [DomId(100006004)]
    [DataContract]
    public enum StandardisationLevelEnum
    {
		
        /// <summary>
        /// All common meta data distributed in support of the Generic Hub data model.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MPCO")]
        [EnumMember]
        MipCore,
		
        /// <summary>
        /// International extensions to the JC3IEDM data model.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INAT")]
        [EnumMember]
        International,
		
        /// <summary>
        /// Local extensions to the JC3IEDM data model.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LOC")]
        [EnumMember]
        Local,
		
        /// <summary>
        /// National extensions to the JC3IEDM data model.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NAT")]
        [EnumMember]
        National,
		
        /// <summary>
        /// MIP extensions to the JC3IEDM data model.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MIP")]
        [EnumMember]
        MultilateralInteroperabilityProgramme,
		
        /// <summary>
        /// MIP-NDAG extensions to the JC3IEDM data model.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MPND")]
        [EnumMember]
        MipNatoDataAdministration,
		
    }
}

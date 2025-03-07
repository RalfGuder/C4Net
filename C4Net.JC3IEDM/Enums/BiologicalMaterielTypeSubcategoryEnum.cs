using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of a specific BIOLOGICAL-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000352)]
    [DataContract]
    public enum BiologicalMaterielTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A very small parasitic bacterium that, like a virus, requires the biochemical mechanisms of another cell in order to reproduce.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CHLMYD")]
        [EnumMember]
        Chlamydia,
		
        /// <summary>
        /// Any of a group of very small bacteria that cause typhus and other febrile diseases.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RCKETS")]
        [EnumMember]
        Rickettsiae,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

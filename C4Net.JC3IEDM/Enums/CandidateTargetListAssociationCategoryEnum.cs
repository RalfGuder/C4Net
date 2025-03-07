using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CANDIDATE-TARGET-LIST-ASSOCIATION.
    /// </summary>
    [DomId(100000272)]
    [DataContract]
    public enum CandidateTargetListAssociationCategoryEnum
    {
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-LIST incorporates the object CANDIDATE-TARGET-LIST in its entirety.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COMPNT")]
        [EnumMember]
        HasAsAComponent,
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-LIST uses details from the object CANDIDATE-TARGET-LIST.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INCPRT")]
        [EnumMember]
        IncorporatesPartsOf,
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-LIST must be considered ahead of the object CANDIDATE-TARGET-LIST.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PRECED")]
        [EnumMember]
        Precedes,
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-LIST is substituted for the object CANDIDATE-TARGET-LIST in its entirety.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("REPLAC")]
        [EnumMember]
        Replaces,
		
    }
}

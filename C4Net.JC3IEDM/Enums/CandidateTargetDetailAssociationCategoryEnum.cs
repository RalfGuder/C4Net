using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CANDIDATE-TARGET-DETAIL-ASSOCIATION.
    /// </summary>
    [DomId(100000270)]
    [DataContract]
    public enum CandidateTargetDetailAssociationCategoryEnum
    {
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-DETAIL includes the object CANDIDATE-TARGET-DETAIL as a functional component.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COMPNT")]
        [EnumMember]
        HasAsAComponent,
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-DETAIL is in the vicinity of the object CANDIDATE-TARGET-DETAIL, but is not functionally related to it.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("COLOC")]
        [EnumMember]
        IsCoLocatedWith,
		
    }
}

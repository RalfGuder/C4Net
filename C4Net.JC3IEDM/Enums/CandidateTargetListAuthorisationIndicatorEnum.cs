using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether a specific CANDIDATE-TARGET-LIST is authorised further consideration in planning military operations.
    /// </summary>
    [DomId(100000273)]
    [DataContract]
    public enum CandidateTargetListAuthorisationIndicatorEnum
    {
		
        /// <summary>
        /// The specific CANDIDATE-TARGET-LIST is not authorised further consideration in planning military operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The subject CANDIDATE-TARGET-LIST is authorised further consideration in planning military operations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}

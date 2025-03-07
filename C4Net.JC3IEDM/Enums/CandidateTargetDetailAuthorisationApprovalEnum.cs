using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of approval that a specific CANDIDATE-TARGET-DETAIL is authorised for further consideration in planning military operations.
    /// </summary>
    [DomId(100000271)]
    [DataContract]
    public enum CandidateTargetDetailAuthorisationApprovalEnum
    {
		
        /// <summary>
        /// The specific CANDIDATE-TARGET-DETAIL is authorised for engagement.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("APPAVL")]
        [EnumMember]
        ApprovedAndAvailable,
		
        /// <summary>
        /// The specific CANDIDATE-TARGET-DETAIL is approved as a planning CANDIDATE-TARGET-LIST but is not authorised for engagement.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("APPEXC")]
        [EnumMember]
        ApprovedAndExcluded,
		
        /// <summary>
        /// The specific CANDIDATE-TARGET-DETAIL is not to be used in planning.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOTAPP")]
        [EnumMember]
        NotApproved,
		
    }
}

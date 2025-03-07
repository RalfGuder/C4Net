using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes a CANDIDATE-TARGET-DETAIL as being an item or a type.
    /// </summary>
    [DomId(100000267)]
    [DataContract]
    public enum CandidateTargetDetailCategoryEnum
    {
		
        /// <summary>
        /// An instance of CANDIDATE-TARGET-DETAIL that is an OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CTDITM")]
        [EnumMember]
        CandidateTargetDetailItem,
		
        /// <summary>
        /// An instance of CANDIDATE-TARGET-DETAIL that is an OBJECT-TYPE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CTDTYP")]
        [EnumMember]
        CandidateTargetDetailType,
		
    }
}

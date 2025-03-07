using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents, for intelligence purpose, the general appraisal of the source in graded terms to indicate the extent to which it has been proven it can be counted on or trusted in to do as expected.
    /// </summary>
    [DomId(100000317)]
    [DataContract]
    public enum ReportingDataReliabilityEnum
    {
		
        /// <summary>
        /// The source of the reported data can be considered as completely reliable, i.e. erroneous information cannot be produced.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("A")]
        [EnumMember]
        CompletelyReliable,
		
        /// <summary>
        /// The source of the reported data can be considered as usually reliable, i.e. erroneous information can be produced, but the probability of such events can be neglected.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("B")]
        [EnumMember]
        UsuallyReliable,
		
        /// <summary>
        /// The source of the reported data can be considered as fairly reliable, i.e. erroneous information can be produced, with a probability that cannot be neglected.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("C")]
        [EnumMember]
        FairlyReliable,
		
        /// <summary>
        /// The source of the reported data is not usually reliable, i.e. the probability of producing erroneous information is high (>30%).
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("D")]
        [EnumMember]
        NotUsuallyReliable,
		
        /// <summary>
        /// The source of the reported data is not reliable, i.e. the produced reported data can generally be considered as erroneous.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("E")]
        [EnumMember]
        Unreliable,
		
        /// <summary>
        /// The reliability of the source of the reported data cannot be estimated.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("F")]
        [EnumMember]
        ReliabilityCannotBeJudged,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of REQUEST-ANSWER.
    /// </summary>
    [DomId(100000208)]
    [DataContract]
    public enum RequestAnswerCategoryEnum
    {
		
        /// <summary>
        /// An answer in the negative.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// An answer in the affirmative.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
        /// <summary>
        /// The information specified in the REQUEST cannot be obtained.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("UNA")]
        [EnumMember]
        Unanswerable,
		
        /// <summary>
        /// Answer cannot be formulated due to the absence of information.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UNK")]
        [EnumMember]
        Unknown,
		
    }
}

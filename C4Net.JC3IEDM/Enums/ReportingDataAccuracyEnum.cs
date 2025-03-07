using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents, for intelligence purpose, the general appraisal of the subject matter in graded terms to indicate the extent or degree to which it has been judged to be free from mistake or error or to conform to truth or some recognised standard value.
    /// </summary>
    [DomId(100000316)]
    [DataContract]
    public enum ReportingDataAccuracyEnum
    {
		
        /// <summary>
        /// Reported data is confirmed by at least 3 independent sources.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("1")]
        [EnumMember]
        Confirmed,
		
        /// <summary>
        /// Reported data is confirmed by 2 independent sources.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("2")]
        [EnumMember]
        Probable,
		
        /// <summary>
        /// Reported data is given by only one source.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("3")]
        [EnumMember]
        Possible,
		
        /// <summary>
        /// Reported data can be viewed with suspicion.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("4")]
        [EnumMember]
        Doubtful,
		
        /// <summary>
        /// Reported data shall be considered as probably erroneous.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("5")]
        [EnumMember]
        Improbable,
		
        /// <summary>
        /// Basis for the estimate of Reported data cannot be estimated.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("6")]
        [EnumMember]
        TruthCannotBeJudged,
		
    }
}

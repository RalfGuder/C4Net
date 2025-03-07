using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the operational status of a specific FACILITY.
    /// </summary>
    [DomId(100000249)]
    [DataContract]
    public enum FacilityStatusOperationalStatusEnum
    {
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be capable of performing the missions or functions for which it is organised or designed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("OPR")]
        [EnumMember]
        Operational,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be marginally capable of performing the missions or functions for which it is organised or designed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MOPS")]
        [EnumMember]
        MarginallyOperational,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be permanently not capable of performing the missions or functions for which it is organised or designed.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOP")]
        [EnumMember]
        NotOperational,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to have minor deficiencies that limit its capability to perform the missions or functions for which it is organised or designed.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SOPS")]
        [EnumMember]
        SubstantiallyOperational,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be temporarily not capable of performing the missions or functions for which it is organised or designed.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("TNOPS")]
        [EnumMember]
        TemporarilyNotOperational,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

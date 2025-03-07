using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the categorisation of surgery cases according to multilevel triage classification scheme in a specific MEDICAL-FACILITY-STATUS-PENDING-SURGERY.
    /// </summary>
    [DomId(100000324)]
    [DataContract]
    public enum MedicalFacilityStatusPendingSurgeryTriageEnum
    {
		
        /// <summary>
        /// Very seriously injured - 1 hour expected duration for surgery.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("T1")]
        [EnumMember]
        T1VerySeriouslyInjured,
		
        /// <summary>
        /// Seriously injured - 2 hours expected duration for surgery.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("T2")]
        [EnumMember]
        T2SeriouslyInjured,
		
        /// <summary>
        /// Minimally injured - 35 minutes expected duration for surgery.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("T3")]
        [EnumMember]
        T3MinimallyInjured,
		
    }
}

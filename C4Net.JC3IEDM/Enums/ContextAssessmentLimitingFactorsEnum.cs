using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the logistic factors, which are degrading operational capability in a specific CONTEXT-ASSESSMENT.
    /// </summary>
    [DomId(100004331)]
    [DataContract]
    public enum ContextAssessmentLimitingFactorsEnum
    {
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects cross-servicing capability limitations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CROSS")]
        [EnumMember]
        CrossServicingCapability,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects equipment limitations affecting direct mission support.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EQPLMT")]
        [EnumMember]
        EquipmentLimitations,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects exceptional supply shortages affecting the unit’s mission.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("EXPSPL")]
        [EnumMember]
        ExceptionalSupply,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects facility limitations affecting direct mission support.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FACLMT")]
        [EnumMember]
        FacilityLimitations,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects maintenance capability limitations, including battle damage repair information.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MNTCAP")]
        [EnumMember]
        MaintenanceCapability,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects medical limitations affecting the unit’s mission.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MEDLMT")]
        [EnumMember]
        MedicalLimitations,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects munitions capability limitations - capability for build-up, storage and transportation, not holdings.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MUNCAP")]
        [EnumMember]
        MunitionsCapability,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects no change limitations since last report.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOCHNG")]
        [EnumMember]
        NoChange,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects no limitations since last report.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOLMTN")]
        [EnumMember]
        NoLimitations,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects personnel limitations in any area.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("PRSLMT")]
        [EnumMember]
        PersonnelLimitations,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects petroleum, oil and lubrication capability limitations – capability to store and deliver, not holdings.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("POL")]
        [EnumMember]
        PetroleumOilAndLubrication,
		
        /// <summary>
        /// The specific CONTEXT-ASSESSMENT reflects capability limitations to perform rapid runway repair.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("RRRCAP")]
        [EnumMember]
        RapidRunwayRepairCapability,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

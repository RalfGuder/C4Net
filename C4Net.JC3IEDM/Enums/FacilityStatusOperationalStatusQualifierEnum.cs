using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the qualification of the operational status of a specific FACILITY.
    /// </summary>
    [DomId(100000250)]
    [DataContract]
    public enum FacilityStatusOperationalStatusQualifierEnum
    {
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is unavailable through means such as removal, contamination or erection of obstructions.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DENIED")]
        [EnumMember]
        Denied,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is not, and not expected ever to be, capable of performing the missions or functions for which it is organised or designed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DSTRYD")]
        [EnumMember]
        Destroyed,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be heavily damaged.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HVYDAM")]
        [EnumMember]
        HeavilyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is deficient or lacking of some mission-critical resources (e.g., fuel, ammunition).
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LVR")]
        [EnumMember]
        LackingVitalResources,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be only lightly damaged.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LGTDAM")]
        [EnumMember]
        LightlyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is missing or captured.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LST")]
        [EnumMember]
        Lost,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be moderately damaged.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MODDAM")]
        [EnumMember]
        ModeratelyDamaged,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is being built.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("UNCNST")]
        [EnumMember]
        UnderConstruction,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY has been penetrated.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BRCHED")]
        [EnumMember]
        Breached,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is being protected by weaponry.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CVRFIR")]
        [EnumMember]
        CoveredByFire,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY has been identified.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MARKED")]
        [EnumMember]
        Marked,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY can be crossed.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("PASABL")]
        [EnumMember]
        Passable,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY has been made ready to assume a particular role.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("PRPEXE")]
        [EnumMember]
        PreparedForExecution,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY has been set on fire and is destroyed.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("BRNOUT")]
        [EnumMember]
        BurnedOut,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is taken apart in a way that it can be reassembled.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("DISASM")]
        [EnumMember]
        Disassembled,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is undergoing service of some kind.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("INMNT")]
        [EnumMember]
        InMaintenance,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY is taken apart to some extent.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("PRTDSM")]
        [EnumMember]
        PartlyDismantled,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a FACILITY has been made incapable of functioning productively or effectively.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("STERLZ")]
        [EnumMember]
        Sterilized,
		
    }
}

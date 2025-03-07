using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CBRN-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100000345)]
    [DataContract]
    public enum CbrnEquipmentTypeCategoryEnum
    {
		
        /// <summary>
        /// An unattended biological detection and alarm system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABIDET")]
        [EnumMember]
        AutomatedBiologicalDetector,
		
        /// <summary>
        /// An unattended chemical and biological detection and alarm system.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ABICHM")]
        [EnumMember]
        AutomatedChemicalAndBiologicalAgentDetector,
		
        /// <summary>
        /// An unattended chemical detection and alarm system.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ACHDET")]
        [EnumMember]
        AutomatedChemicalDetector,
		
        /// <summary>
        /// An unattended radiation detector.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARDDET")]
        [EnumMember]
        AutomatedRadiationDetector,
		
        /// <summary>
        /// An integrated biological detection, alarm, and identification system.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BIOINT")]
        [EnumMember]
        BiologicalIntegratedDetector,
		
        /// <summary>
        /// A detector capable of remotely detecting biological contamination.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("BIOSTO")]
        [EnumMember]
        BiologicalStandOffDetectionSystem,
		
        /// <summary>
        /// A handheld chemical agent detector.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CHMMON")]
        [EnumMember]
        ChemicalAgentMonitor,
		
        /// <summary>
        /// An apparatus used for recording and measuring the mass spectra of particles, especially as a method of analysis.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MSSPTR")]
        [EnumMember]
        MassSpectrometer,
		
        /// <summary>
        /// A vehicle that, as its primary function, is equipped to decontaminate persons or equipment contaminated by an NBC (CBRN) exposure.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("CBRNDC")]
        [EnumMember]
        CbrnDecontaminationVehicle,
		
        /// <summary>
        /// A vehicle that, as its primary function, is equipped to perform by visual observation or other detection methods, information a particular area potentially contaminated by an NBC (CBRN) event.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CBRNRC")]
        [EnumMember]
        CbrnReconnaissanceVehicle,
		
        /// <summary>
        /// An apparatus used for recording and measuring a radiation energy spectra, especially as a method of analysis.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("RDSPTR")]
        [EnumMember]
        RadiationSpectrometer,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A collection of personal dosimeters or detectors for determination of radiation exposure history and protection against radiation hazards issued to a person.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("RADKIT")]
        [EnumMember]
        RadiologicalKit,
		
    }
}

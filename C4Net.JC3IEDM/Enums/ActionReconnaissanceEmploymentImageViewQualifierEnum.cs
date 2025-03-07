using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the recorded media based on the type of imagery the interpreter is viewing.
    /// </summary>
    [DomId(100004250)]
    [DataContract]
    public enum ActionReconnaissanceEmploymentImageViewQualifierEnum
    {
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DBMIEO")]
        [EnumMember]
        DualBandMidInfraredAndElectroOptical,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ELCOPT")]
        [EnumMember]
        ElectroOptical,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MIDINF")]
        [EnumMember]
        MidInfrared,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NSELEN")]
        [EnumMember]
        NonStandardElectronicallyEnhanced,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("THRINF")]
        [EnumMember]
        ThermalInfrared,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("VIDSFT")]
        [EnumMember]
        VideoSoftcopyDisplay,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/6.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DBEOIR")]
        [EnumMember]
        DualBandEoAndIr,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the mode of image coverage required.
    /// </summary>
    [DomId(100004249)]
    [DataContract]
    public enum ActionReconnaissanceEmploymentImageCoverageModeEnum
    {
		
        /// <summary>
        /// Complete imagery coverage in mono mode.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MONOCC")]
        [EnumMember]
        MonoModeCompleteCoverage,
		
        /// <summary>
        /// Partial imagery coverage in mono mode.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MONOPC")]
        [EnumMember]
        MonoModePartialCoverage,
		
        /// <summary>
        /// Complete imagery coverage in partial stereo mode.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PSMCC")]
        [EnumMember]
        PartialStereoModeCompleteCoverage,
		
        /// <summary>
        /// Partial imagery coverage in partial stereo mode.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PSMPC")]
        [EnumMember]
        PartialStereoModePartialCoverage,
		
        /// <summary>
        /// Complete imagery coverage in stereo mode.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("STMCC")]
        [EnumMember]
        StereoModeCompleteCoverage,
		
        /// <summary>
        /// Partial imagery coverage in stereo mode.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("STMPC")]
        [EnumMember]
        StereoModePartialCoverage,
		
    }
}

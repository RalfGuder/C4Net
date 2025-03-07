using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific values of expected mine countermeasures (MCM) to be employed against a MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004320)]
    [DataContract]
    public enum MinefieldMaritimeStatusExpectedLevelMcmEnum
    {
		
        /// <summary>
        /// Heavy mine counter measures are expected to be employed against the MINEFIELD-MARITIME.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HVYMCM")]
        [EnumMember]
        HeavyMcm,
		
        /// <summary>
        /// Moderate mine counter measures are expected to be employed against the MINEFIELD-MARITIME.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MODMCM")]
        [EnumMember]
        ModerateMcm,
		
        /// <summary>
        /// Light mine counter measures are expected to be employed against the MINEFIELD-MARITIME.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LGTMCM")]
        [EnumMember]
        LightMcm,
		
        /// <summary>
        /// No mine counter measures are expected to be employed against the MINEFIELD-MARITIME.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOMCM")]
        [EnumMember]
        NoMcm,
		
    }
}

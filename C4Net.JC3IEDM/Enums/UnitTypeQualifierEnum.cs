using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that conveys additional information on the specified UNIT-TYPE.
    /// </summary>
    [DomId(100004188)]
    [DataContract]
    public enum UnitTypeQualifierEnum
    {
		
        /// <summary>
        /// The specified UNIT-TYPE supports a force of Corps level.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CORPS")]
        [EnumMember]
        Corps,
		
        /// <summary>
        /// The specified UNIT-TYPE operates at Division level.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DIV")]
        [EnumMember]
        Division,
		
        /// <summary>
        /// The specified UNIT-TYPE operates at Force level.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FORCE")]
        [EnumMember]
        Force,
		
        /// <summary>
        /// The specified UNIT-TYPE major equipment is able to intercept threats flying at high or medium altitude.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HMAD")]
        [EnumMember]
        HighMediumAltitudeAirDefence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("HEAVY")]
        [EnumMember]
        Heavy,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LIGHT")]
        [EnumMember]
        Light,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("LR")]
        [EnumMember]
        LongRange,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MR")]
        [EnumMember]
        MediumRange,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SR")]
        [EnumMember]
        ShortRange,
		
        /// <summary>
        /// The specified UNIT-TYPE operates at a strategic level of command.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("STRTGC")]
        [EnumMember]
        Strategic,
		
        /// <summary>
        /// The specified UNIT-TYPE operates at a tactical level of command.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("TACTCL")]
        [EnumMember]
        Tactical,
		
        /// <summary>
        /// The specified UNIT-TYPE supports a force at Theatre level.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("THTRE")]
        [EnumMember]
        Theatre,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("TMD")]
        [EnumMember]
        TheatreMissileDefence,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("VSR")]
        [EnumMember]
        VeryShortRange,
		
    }
}

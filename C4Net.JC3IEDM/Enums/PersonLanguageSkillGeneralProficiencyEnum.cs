using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general level of proficiency of a specific PERSON in a specific language skill.
    /// </summary>
    [DomId(100000396)]
    [DataContract]
    public enum PersonLanguageSkillGeneralProficiencyEnum
    {
		
        /// <summary>
        /// Low performance ability.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ELEM")]
        [EnumMember]
        Elementary,
		
        /// <summary>
        /// Very high performance ability.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EXCLNT")]
        [EnumMember]
        Excellent,
		
        /// <summary>
        /// Moderate performance ability.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FAIR")]
        [EnumMember]
        Fair,
		
        /// <summary>
        /// No significant or practical proficiency.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NONE")]
        [EnumMember]
        NoSignificantOrPracticalProficiency,
		
        /// <summary>
        /// High performance ability.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("VERY")]
        [EnumMember]
        VeryGood,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

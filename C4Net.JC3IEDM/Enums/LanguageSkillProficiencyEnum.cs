using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the level of skill or comprehension of a specific PERSON in a specific language skill.
    /// </summary>
    [DomId(100000397)]
    [DataContract]
    public enum LanguageSkillProficiencyEnum
    {
		
        /// <summary>
        /// No significant or practical proficiency.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("0")]
        [EnumMember]
        _0,
		
        /// <summary>
        /// Elementary: Low performance ability.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("1")]
        [EnumMember]
        _1,
		
        /// <summary>
        /// Fair: Limited working performance ability.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("2")]
        [EnumMember]
        _2,
		
        /// <summary>
        /// Good: Minimum professional performance ability.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("3")]
        [EnumMember]
        _3,
		
        /// <summary>
        /// Very good: Full professional performance ability.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("4")]
        [EnumMember]
        _4,
		
        /// <summary>
        /// Excellent: Native / Bilingual.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("5")]
        [EnumMember]
        _5,
		
    }
}

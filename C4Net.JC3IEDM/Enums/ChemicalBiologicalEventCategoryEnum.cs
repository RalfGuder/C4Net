using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CHEMICAL-BIOLOGICAL-EVENT.
    /// </summary>
    [DomId(100004270)]
    [DataContract]
    public enum ChemicalBiologicalEventCategoryEnum
    {
		
        /// <summary>
        /// An action by which a biological detector is triggered or a group is warned.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BIOALM")]
        [EnumMember]
        BiologicalAlarm,
		
        /// <summary>
        /// Employing the use of biological materiel(s) [agent(s)] to kill, injure, or incapacitate, for a significant period of time, man or animals, and deny or hinder the use of areas, facilities or materiel, or defence against such employment.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BIOATT")]
        [EnumMember]
        BiologicalAttack,
		
        /// <summary>
        /// The release of a biological agent or toxin into the environment intentionally or accidentally but not for the intended purpose of conducting an attack.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BIROTA")]
        [EnumMember]
        BiologicalReleaseOtherThanAttackRota,
		
        /// <summary>
        /// The action of detecting a biological contaminant.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BIOSMP")]
        [EnumMember]
        BiologicalSampling,
		
        /// <summary>
        /// An action by which a chemical detector is triggered or a group is warned.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CHMALM")]
        [EnumMember]
        ChemicalAlarm,
		
        /// <summary>
        /// Employing the use of chemical materiel(s) [agent(s)] to produce casualties in man or animals and damage to plants or materiel; or defence against such employment.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CHMATT")]
        [EnumMember]
        ChemicalAttack,
		
        /// <summary>
        /// The release of chemicals or chemical agents into the environment intentionally or accidentally but not for the intended purpose of conducting an attack.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CHROTA")]
        [EnumMember]
        ChemicalReleaseOtherThanAttackRota,
		
        /// <summary>
        /// The action of detecting a chemical contaminant.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CHMSMP")]
        [EnumMember]
        ChemicalSampling,
		
        /// <summary>
        /// An event that involves viable agent released to the atmosphere following a strike against a facility containing chemical warfare agent(s) and/or biological warfare agent(s).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("CBFAC")]
        [EnumMember]
        ChemicalBiologicalFacilityEvent,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

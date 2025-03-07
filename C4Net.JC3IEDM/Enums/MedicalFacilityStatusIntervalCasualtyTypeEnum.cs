using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the categorisation of casualties according to the type of illness or injury in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE.
    /// </summary>
    [DomId(100000323)]
    [DataContract]
    public enum MedicalFacilityStatusIntervalCasualtyTypeEnum
    {
		
        /// <summary>
        /// Casualties are the result of non-battle injury.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NONBAT")]
        [EnumMember]
        NonBattleInjury,
		
        /// <summary>
        /// Casualties are the result of disease.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DISEAS")]
        [EnumMember]
        Diseased,
		
        /// <summary>
        /// Casualties are the result of being wounded in action.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("WOUND")]
        [EnumMember]
        WoundedInAction,
		
        /// <summary>
        /// Casualties are the result of battle stress or psychiatric reasons.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BTLSTR")]
        [EnumMember]
        BattleStressPsychiatric,
		
    }
}

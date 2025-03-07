using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies the triage classification in a specific GROUP-CHARACTERISTIC.
    /// </summary>
    [DomId(100004156)]
    [DataContract]
    public enum GroupCharacteristicTriageEnum
    {
		
        /// <summary>
        /// A group that consists of those requiring emergency care and life-saving surgery. These procedures should not be time-consuming and be applied only to those with high chances of survival.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("T1")]
        [EnumMember]
        ImmediateTreatmentGroupT1,
		
        /// <summary>
        /// A group that consists of those in need of surgery, but whose general condition permits delay in surgical treatment without unduly endangering life. To mitigate the effect of delay in surgery, sustaining treatment will be required.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("T2")]
        [EnumMember]
        DelayedTreatmentGroupT2,
		
        /// <summary>
        /// A group that consists of those with relatively minor injuries who can effectively care for themselves or who can be helped by untrained personnel.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("T3")]
        [EnumMember]
        MinimalTreatmentGroupT3,
		
        /// <summary>
        /// A group that comprises those who have received serious and often multiple injuries, and whose treatment would be time-consuming and complicated, with a low chance of survival.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("T4")]
        [EnumMember]
        ExpectantTreatmentGroupT4,
		
    }
}

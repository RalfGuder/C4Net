using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the operational level of the specific ACTION-TASK.
    /// </summary>
    [DomId(100004378)]
    [DataContract]
    public enum ActionTaskOperationalLevelEnum
    {
		
        /// <summary>
        /// An ACTION-TASK executed at the strategic or operational level to achieve desired strategic effects and thus are likely to be shaped by political aims and constraints. Strategic attack is carried out against an adversary’s Centre of Gravity (CoG) or other vital target sets including command elements, military production assets and key supporting infrastructure.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("STRTGC")]
        [EnumMember]
        Strategic,
		
        /// <summary>
        /// An ACTION-TASK executed in full respect of fundamental principles designed to provide guidance for the employment of power in tactical operations to attain established objectives.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TACTCL")]
        [EnumMember]
        Tactical,
		
    }
}

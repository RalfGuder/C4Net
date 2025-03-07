using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of NUCLEAR-EVENT.
    /// </summary>
    [DomId(100004272)]
    [DataContract]
    public enum NuclearEventCategoryEnum
    {
		
        /// <summary>
        /// The delivery of a nuclear weapon against a target.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NUCATT")]
        [EnumMember]
        NuclearAttack,
		
        /// <summary>
        /// The release of nuclear material into the environment intentionally or accidentally but not for the intended purpose of conducting an attack.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NROTA")]
        [EnumMember]
        NuclearReleaseOtherThanAttackRota,
		
        /// <summary>
        /// The action of detecting a radiological contaminant.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NUCSMP")]
        [EnumMember]
        NuclearSampling,
		
        /// <summary>
        /// The explosion of a nuclear device for test purpose.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NUCTST")]
        [EnumMember]
        NuclearTest,
		
        /// <summary>
        /// The state of readiness caused by the possibility of atomic bombings.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NUCWAR")]
        [EnumMember]
        NuclearWarAlert,
		
        /// <summary>
        /// Removing nuclear polluted substances to a designated storage area.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NUCWST")]
        [EnumMember]
        NuclearWasteDisposal,
		
        /// <summary>
        /// A NUCLEAR-EVENT that involves the detonation of a nuclear device.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NUCWEP")]
        [EnumMember]
        NuclearWeaponEvent,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that describes the condition of the group counted in a specific OBJECT-ITEM-GROUP-ACCOUNT-DETAIL.
    /// </summary>
    [DomId(100004157)]
    [DataContract]
    public enum ObjectItemGroupAccountDetailQualifierEnum
    {
		
        /// <summary>
        /// The objects included in the grouping are deemed to be suffering from an ailment whose specific basis has not been established.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AILING")]
        [EnumMember]
        Ailing,
		
        /// <summary>
        /// The objects included in the grouping are known to have been captured.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CAPTRD")]
        [EnumMember]
        Captured,
		
        /// <summary>
        /// The objects included in the grouping are deemed to be suffering from combat stress.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COMSTR")]
        [EnumMember]
        CombatStress,
		
        /// <summary>
        /// The objects included in the grouping are known to have deserted from the assigned organisation.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DESRTD")]
        [EnumMember]
        Deserted,
		
        /// <summary>
        /// The objects included in the grouping are performing tasks separate from the assigned organisation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("DETD")]
        [EnumMember]
        Detached,
		
        /// <summary>
        /// The objects included in the grouping are deemed to be diseased.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DISEAS")]
        [EnumMember]
        Diseased,
		
        /// <summary>
        /// The objects included in the grouping are deemed to be healthy.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("HEALTH")]
        [EnumMember]
        Healthy,
		
        /// <summary>
        /// The objects included in the grouping are deemed to be injured or wounded.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("INJRDW")]
        [EnumMember]
        InjuredWounded,
		
        /// <summary>
        /// The objects included in the grouping are deemed to have been killed under circumstances other than military action.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("KILL")]
        [EnumMember]
        Killed,
		
        /// <summary>
        /// The objects included in the grouping are deemed to be missing and the reason for absence is not known.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MIS")]
        [EnumMember]
        Missing,
		
        /// <summary>
        /// The objects included in the grouping are assumed to be killed in action.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ASSKIA")]
        [EnumMember]
        AssumedKilledInAction,
		
        /// <summary>
        /// The objects included in the grouping are awaiting search and rescue pickup.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("AWTNPU")]
        [EnumMember]
        AwaitingPickup,
		
        /// <summary>
        /// The objects included in the grouping were observed in or near the vicinity of the enemy.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("CPTRAI")]
        [EnumMember]
        CaptureAppearsImminent,
		
        /// <summary>
        /// The objects included in the grouping are on the ground and evading the enemy.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("EVADNG")]
        [EnumMember]
        Evading,
		
        /// <summary>
        /// The objects included in the grouping were killed in action.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("KIA")]
        [EnumMember]
        KilledInAction,
		
        /// <summary>
        /// The objects included in the grouping are deemed to be missing in action.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MIA")]
        [EnumMember]
        MissingInAction,
		
        /// <summary>
        /// The aircraft has crashed, but no parachute(s) were sighted.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("NOCHUT")]
        [EnumMember]
        NoChutes,
		
        /// <summary>
        /// The objects included in the grouping were observed parachuting from the plane prior to destruction or impact.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("PARCHT")]
        [EnumMember]
        Parachuted,
		
        /// <summary>
        /// The objects included in the grouping are probably captured.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("PRBCPT")]
        [EnumMember]
        ProbableCaptured,
		
        /// <summary>
        /// The objects included in the grouping were rescued.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("RESCUD")]
        [EnumMember]
        Rescued,
		
        /// <summary>
        /// The objects included in the grouping are not to be in or near the vicinity of the enemy.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SAFCPT")]
        [EnumMember]
        SafeFromCapture,
		
        /// <summary>
        /// Disposition of the objects included in the grouping is unknown.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("UNK")]
        [EnumMember]
        Unknown,
		
    }
}

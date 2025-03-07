using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the rank of importance of a specific ACTION-TASK in view of the planning organisation.
    /// </summary>
    [DomId(100000286)]
    [DataContract]
    public enum ActionTaskPriorityEnum
    {
		
        /// <summary>
        /// The classification that denotes those ACTION-TASKs which meet the criteria for being placed in the highest categorisation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("1")]
        [EnumMember]
        Priority1,
		
        /// <summary>
        /// The classification that denotes those ACTION-TASKs which meet the criteria for being placed in the 2nd highest category.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("2")]
        [EnumMember]
        Priority2,
		
        /// <summary>
        /// The classification that denotes those ACTION-TASKs which meet the criteria for being placed in the 3rd highest category.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("3")]
        [EnumMember]
        Priority3,
		
        /// <summary>
        /// The classification that denotes those ACTION-TASKs which meet the criteria for being placed in the 4th highest category.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("4")]
        [EnumMember]
        Priority4,
		
        /// <summary>
        /// The classification that denotes those ACTION-TASKs which meet the criteria for being placed in the 5th highest category.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("5")]
        [EnumMember]
        Priority5,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that are directed by a head of state or the highest NATO authority.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("1A1")]
        [EnumMember]
        Priority1A1,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that involve forces or activities in combat.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("1A2")]
        [EnumMember]
        Priority1A2,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that are top national priority programs which have been approved by the highest national authority.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("1A3")]
        [EnumMember]
        Priority1A3,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that involve special weapons.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("1A4")]
        [EnumMember]
        Priority1A4,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that are directed by a major NATO command or a nations highest military staff or civilian-military agency.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("1B1")]
        [EnumMember]
        Priority1B1,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that involve UNITs, projects, or plans approved by a major NATO command or a nations highest military staff.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("1B2")]
        [EnumMember]
        Priority1B2,
		
        /// <summary>
        /// The highest classification that denotes those ACTION-TASKs that are scheduled resupply missions.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("1B3")]
        [EnumMember]
        Priority1B3,
		
        /// <summary>
        /// The second highest classification that denotes those ACTION-TASKs that involve forces which are being deployed or are positioned and maintained in a state of readiness for immediate combat or direct combat support.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("2A1")]
        [EnumMember]
        Priority2A1,
		
        /// <summary>
        /// The second highest classification that denotes those ACTION-TASKs that involve industrial production activities; to prevent work stoppage; or to reinstitute production
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("2A2")]
        [EnumMember]
        Priority2A2,
		
        /// <summary>
        /// The second highest classification that denotes those ACTION-TASKs that are NATO or national directed exercises.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("2B1")]
        [EnumMember]
        Priority2B1,
		
        /// <summary>
        /// The second highest classification that denotes those ACTION-TASKs that are NATO or national coordinated exercises.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("2B2")]
        [EnumMember]
        Priority2B2,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that involve unit inspection or evaluation tests; Emergency Deployment Readiness Exercise (EDRE), Operational Readiness Inspection (ORI), etc.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("3A1")]
        [EnumMember]
        Priority3A1,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that involve forces maintained in a state of readiness to deploy for combat.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("3A2")]
        [EnumMember]
        Priority3A2,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that are non-scheduled resupply missions.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("3A3")]
        [EnumMember]
        Priority3A3,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that require service training when it is integral to combat readiness (e.g., field training exercises, proficiency airdrop, and air assault).
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("3B1")]
        [EnumMember]
        Priority3B1,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that require combat support training (e.g., flare drops, unconventional warfare activities, and Joint Airborne Communications Centre/Command Post (JACC/CP)).
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("3B2")]
        [EnumMember]
        Priority3B2,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that are service schools requiring airborne, airdrop, and air transportability training as a part of the training program.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("3B3")]
        [EnumMember]
        Priority3B3,
		
        /// <summary>
        /// The third highest classification that denotes those ACTION-TASKs that require airdrop/air transportability or aircraft certification of new or modified equipment.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("3B4")]
        [EnumMember]
        Priority3B4,
		
        /// <summary>
        /// The fourth highest classification that denotes those ACTION-TASKs that require forces which are planned for employment in support of approved war plans and support activities essential to such forces.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("4A1")]
        [EnumMember]
        Priority4A1,
		
        /// <summary>
        /// The fourth highest classification that denotes those ACTION-TASKs that are static loading exercises.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("4A2")]
        [EnumMember]
        Priority4A2,
		
        /// <summary>
        /// The fourth highest classification that denotes those ACTION-TASKs that are other non-military activities which cannot be accommodated by commercial airlift.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("4B2")]
        [EnumMember]
        Priority4B2,
		
        /// <summary>
        /// The fourth highest classification that denotes those ACTION-TASKs that require a static display for public and military events.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("4B3")]
        [EnumMember]
        Priority4B3,
		
    }
}

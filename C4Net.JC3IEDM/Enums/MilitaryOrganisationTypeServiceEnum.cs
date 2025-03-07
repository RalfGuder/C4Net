using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a military, paramilitary, irregular force, force or group, capable of functioning as an offensive or defensive combat or support organisation.
    /// </summary>
    [DomId(100000374)]
    [DataContract]
    public enum MilitaryOrganisationTypeServiceEnum
    {
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE in question belongs to the Air Force (includes reserves and mobilised air national guard).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRFRC")]
        [EnumMember]
        AirForce,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE in question belongs to the Army (includes territorial army, reserves, and mobilised national guard).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ARMY")]
        [EnumMember]
        Army,
		
        /// <summary>
        /// A paramilitary MILITARY-ORGANISATION-TYPE whose primary task is to maintain the security of national borders.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BRDRGD")]
        [EnumMember]
        BorderGuard,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE that may be responsible for one or more of the following: coastal defence, protection of life and property at sea, and enforcement of customs, immigration, and navigation laws.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("COASTG")]
        [EnumMember]
        CoastGuard,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE contains two or more forces or agencies of two or more allies.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("COMBND")]
        [EnumMember]
        Combined,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE in question is an irregular military force.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("GUERLL")]
        [EnumMember]
        Guerrilla,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE contains elements of more than one Service from the same nation.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("JOINT")]
        [EnumMember]
        Joint,
		
        /// <summary>
        /// A military MILITARY-ORGANISATION-TYPE whose primary task is defence of a specific region (before mobilisation, a national guard is a local defence force).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("LCLDFF")]
        [EnumMember]
        LocalDefenceForce,
		
        /// <summary>
        /// A civilian MILITARY-ORGANISATION-TYPE that has a defence and possibly also a police role (may include irregular civilian MILITARY-ORGANISATION-TYPEs).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("LCLMLT")]
        [EnumMember]
        LocalMilitia,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE in question belongs to the Marines (includes reserves).
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MARINE")]
        [EnumMember]
        Marines,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE in question belongs to the Navy (includes reserves).
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NAVY")]
        [EnumMember]
        Navy,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE in question is trained and equipped for special purposes.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SPFRC")]
        [EnumMember]
        SpecialForce,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE of a nation's armed forces that is responsible for regional defence.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("TERFRC")]
        [EnumMember]
        TerritorialForce,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The MILITARY-ORGANISATION-TYPE that is staffed solely by civilian personnel.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("CVLSVC")]
        [EnumMember]
        CivilService,
		
        /// <summary>
        /// Forces or groups distinct from the regular armed forces of any country, but resembling them in organization, equipment, training, or mission.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("PAR")]
        [EnumMember]
        Paramilitary,
		
    }
}

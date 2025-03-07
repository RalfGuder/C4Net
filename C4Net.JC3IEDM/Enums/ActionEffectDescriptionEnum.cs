using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of outcome of a specific ACTION that is being estimated or recorded.
    /// </summary>
    [DomId(100000112)]
    [DataContract]
    public enum ActionEffectDescriptionEnum
    {
		
        /// <summary>
        /// The ACTION objective is alight.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BURN")]
        [EnumMember]
        Burning,
		
        /// <summary>
        /// The ACTION objective has been captured or acquired and is available for use or interrogation/possession has been taken of an area, normally by force.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CAPTRD")]
        [EnumMember]
        Captured,
		
        /// <summary>
        /// The consumption of specified consumables or CONSUMABLE-MATERIEL-TYPEs.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CONS")]
        [EnumMember]
        Consumed,
		
        /// <summary>
        /// Cannot function as intended nor be repaired or restored to an operational status.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DSTRYK")]
        [EnumMember]
        DestroyedKKill,
		
        /// <summary>
        /// The destruction of a vehicle (or system's) primary weapon system.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FKIL")]
        [EnumMember]
        FirepowerKillFKill,
		
        /// <summary>
        /// The ACTION objective has been either identified (i.e., classified as friend/foe/neutral) or recognised (i.e., the unit designation of the ORGANISATION or object is known).
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("IDNT")]
        [EnumMember]
        Identified,
		
        /// <summary>
        /// The temporary supply of IR or white-light illumination (usually in coordination with direct or indirect fire).
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ILLUMN")]
        [EnumMember]
        Illuminated,
		
        /// <summary>
        /// The subjective categorisation of the physical effect of an ACTION on buildings, infrastructure and/or equipment by a reporting ORGANISATION.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("LDAM")]
        [EnumMember]
        LightDamage,
		
        /// <summary>
        /// The rendering of a vehicle as being temporarily or permanently incapable of tactical movement.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MKIL")]
        [EnumMember]
        MobilityKillMKill,
		
        /// <summary>
        /// The subjective categorisation of the physical effect of an ACTION on buildings, infrastructure and/or equipment by a reporting ORGANISATION.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MODDAM")]
        [EnumMember]
        ModerateDamage,
		
        /// <summary>
        /// The rendering of the ACTION objective temporarily ineffective by the infliction of significant casualties (norm for indirect fire is 10 percent).
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NUTRLD")]
        [EnumMember]
        Neutralized,
		
        /// <summary>
        /// The subjective categorisation of the physical effect of an ACTION on buildings, infrastructure and/or equipment by a reporting ORGANISATION.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SDAM")]
        [EnumMember]
        SevereDamage,
		
        /// <summary>
        /// Reduction of the effectiveness of the ACTION objective for a specific period or purpose (normally to prevent an enemy from interfering with friendly ACTIONs); this effect may be entirely transitory and cause no casualties.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SUPRSD")]
        [EnumMember]
        Suppressed,
		
        /// <summary>
        /// A casualty other than "killed" who has incurred an injury due to an external agent or cause.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("WNDD")]
        [EnumMember]
        Wounded,
		
        /// <summary>
        /// The setting to flight of a PERSON or PERSON-TYPEs from their present location.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("FLIG")]
        [EnumMember]
        ForcedToFlee,
		
        /// <summary>
        /// A person who is not a battle casualty, but who is lost to his organisation by reason of disease or injury, including persons dying from disease or injury, or by reason of being missing where the absence does not appear to be voluntary or due to enemy action or to being interned.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NBCAS")]
        [EnumMember]
        NonBattleCasualty,
		
        /// <summary>
        /// A casualty who is killed outright or dies as a result of wounds, disease or other injuries.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("KILL")]
        [EnumMember]
        Killed,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The ACTION-OBJECTIVE reacted against the ACTION using light physical violence.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("LGTRST")]
        [EnumMember]
        LightResistance,
		
        /// <summary>
        /// The ACTION-OBJECTIVE did not react against the ACTION.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("NORSTN")]
        [EnumMember]
        NoResistance,
		
        /// <summary>
        /// The ACTION-OBJECTIVE reacted against the ACTION using verbal abuse.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("VRBPRT")]
        [EnumMember]
        VerbalProtest,
		
        /// <summary>
        /// The ACTION-OBJECTIVE reacted against the ACTION using heavy physical violence.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("VLNRST")]
        [EnumMember]
        ViolentResistance,
		
        /// <summary>
        /// An equipment lost in an area unsuitable for recovery due to political, military or geographic/environmental considerations.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("INTREC")]
        [EnumMember]
        IntactButUnrecoverable,
		
        /// <summary>
        /// The object is no longer available for military operations.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("LOST")]
        [EnumMember]
        Lost,
		
    }
}

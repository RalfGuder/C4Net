using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of PERSON-TYPE.
    /// </summary>
    [DomId(100000380)]
    [DataContract]
    public enum PersonTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A PERSON-TYPE who has been removed from their home country by military or political pressure and thereafter homeless.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DSPLPR")]
        [EnumMember]
        DisplacedPerson,
		
        /// <summary>
        /// A PERSON-TYPE who is representing a Governmental Organisation and is not a uniformed member of a regular armed force.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GOVEMP")]
        [EnumMember]
        GovernmentEmployee,
		
        /// <summary>
        /// A PERSON-TYPE who is an intellectual being; a person possessing or supposed to possess superior powers of intellect.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INTLCT")]
        [EnumMember]
        Intellectual,
		
        /// <summary>
        /// A PERSON-TYPE who earns a living by editing or writing for a public journal.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("JRNLST")]
        [EnumMember]
        Journalist,
		
        /// <summary>
        /// A PERSON-TYPE who is an owner or proprietor of land.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LNDOWN")]
        [EnumMember]
        Landowner,
		
        /// <summary>
        /// A PERSON-TYPE whose occupation is the purchase and sale of marketable commodities for profit.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MRCHNT")]
        [EnumMember]
        Merchant,
		
        /// <summary>
        /// A PERSON-TYPE who is representing a Non-Governmental Organisation and is not a uniformed member of a regular armed force.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NONGVE")]
        [EnumMember]
        NonGovernmentEmployee,
		
        /// <summary>
        /// A PERSON-TYPE who has the responsibility for the regulation, discipline, and control of a community for the enforcement of law and public order.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("POLCHF")]
        [EnumMember]
        PoliceChief,
		
        /// <summary>
        /// A PERSON-TYPE who, while engaged in combat under orders of his or her government, is captured by the armed forces of the enemy.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("POW")]
        [EnumMember]
        PrisonerOfWar,
		
        /// <summary>
        /// A PERSON-TYPE who, because of real or imagined danger, moves of his own volition, spontaneously, or in violation of a “stay-put” policy.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("REFUGE")]
        [EnumMember]
        Refugee,
		
        /// <summary>
        /// A PERSON-TYPE who attempts to further their views by a system of coercive intimidation.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("TERRST")]
        [EnumMember]
        Terrorist,
		
        /// <summary>
        /// A PERSON-TYPE of ripe years and experience whose counsel is therefore sought and valued.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("VILELD")]
        [EnumMember]
        VillageElder,
		
        /// <summary>
        /// A PERSON-TYPE who practices or performs writing.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("WRITER")]
        [EnumMember]
        Writer,
		
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
        /// A PERSON-TYPE who is reporting for international mass communications, but not taking part in the actions.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MEDINT")]
        [EnumMember]
        MediaInternational,
		
        /// <summary>
        /// A PERSON-TYPE who is reporting for local mass communications, but not taking part in the actions.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MEDLCL")]
        [EnumMember]
        MediaLocal,
		
        /// <summary>
        /// A PERSON-TYPE who is reporting for national mass communications, but not taking part in the actions.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MEDNAT")]
        [EnumMember]
        MediaNational,
		
        /// <summary>
        /// A PERSON-TYPE who is reporting for mass communications (especially television, radio, and newspapers) of an origin not specified.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MEDNOS")]
        [EnumMember]
        MediaNotOtherwiseSpecified,
		
        /// <summary>
        /// A PERSON-TYPE who is employed to obtain intelligence information to which he or she would not normally be allowed access.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SPY")]
        [EnumMember]
        Spy,
		
        /// <summary>
        /// A person detained in custody, especially for political reasons.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("DETNEE")]
        [EnumMember]
        Detainee,
		
        /// <summary>
        /// An individual who is not authorised to take part in hostilities but does.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("UNLCMB")]
        [EnumMember]
        UnlawfulCombatant,
		
        /// <summary>
        /// A PERSON-TYPE who has abandoned their country or cause for another country or cause.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("DEFCTR")]
        [EnumMember]
        Defector,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as one who designs and constructs facilities.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("ENGNER")]
        [EnumMember]
        Engineer,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as a medical practitioner.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("MEDCAL")]
        [EnumMember]
        Medical,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as a carrier of a message.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("MESSNG")]
        [EnumMember]
        Messenger,
		
        /// <summary>
        /// A PERSON-TYPE who is concerned with religious missions in the form of missionary work.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("MISSNR")]
        [EnumMember]
        Missionary,
		
        /// <summary>
        /// A PERSON-TYPE who is specially trained and qualified to penetrate to the site of an incident by land or parachute, render medical aid, accomplish survival methods, and rescue survivors.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("PARARS")]
        [EnumMember]
        PararescueJumper,
		
        /// <summary>
        /// A PERSON-TYPE who is a member of a party of light or irregular troops employed in scouring the country, surprising the enemy's outposts and foraging parties.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("PARTSN")]
        [EnumMember]
        Partisan,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as one who controls an aircraft, balloon, spacecraft, or the like during flight, usually a person duly qualified to do so.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("PILOT")]
        [EnumMember]
        Pilot,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as a member of a police force.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("POLCMN")]
        [EnumMember]
        Policeman,
		
        /// <summary>
        /// A PERSON-TYPE who commits sabotage.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("SABOTR")]
        [EnumMember]
        Saboteur,
		
        /// <summary>
        /// A PERSON-TYPE who has abandoned their country or cause.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("DSRTR")]
        [EnumMember]
        Deserter,
		
        /// <summary>
        /// A PERSON-TYPE in custody on a criminal charge and on trial.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("PRSNR")]
        [EnumMember]
        Prisoner,
		
        /// <summary>
        /// A PERSON-TYPE who has returned to his or her native land.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("REPAT")]
        [EnumMember]
        Repatriate,
		
        /// <summary>
        /// A PERSON-TYPE of high ranking and/or an important individual.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("VIP")]
        [EnumMember]
        VeryImportantPerson,
		
        /// <summary>
        /// A PERSON-TYPE who contracts or undertakes to supply certain articles, or to perform any work or service (esp. for government or other public body) at a certain price or rate.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("CNTRCT")]
        [EnumMember]
        Contractor,
		
        /// <summary>
        /// A PERSON-TYPE who violates the law.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("CRIMIN")]
        [EnumMember]
        Criminal,
		
        /// <summary>
        /// A PERSON-TYPE who provides labour and materiel for the educational process.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("EDUCAL")]
        [EnumMember]
        Educational,
		
        /// <summary>
        /// A PERSON-TYPE who provides financial support.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("FINCAL")]
        [EnumMember]
        Financial,
		
        /// <summary>
        /// A PERSON-TYPE consists of a fighter who is not from the country in which the fighting is taking place supporting belligerents or irregular forces.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("FRNFGT")]
        [EnumMember]
        ForeignFighter,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as one who manufactures products; excluding utility, transportation, and financial companies.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("MANFCT")]
        [EnumMember]
        ManufacturingWorker,
		
        /// <summary>
        /// A PERSON-TYPE that rises in revolt against authority.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("INSRGT")]
        [EnumMember]
        Insurgent,
		
        /// <summary>
        /// A PERSON-TYPE that is employed to gather information.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("INTEL")]
        [EnumMember]
        Intelligence,
		
        /// <summary>
        /// A PERSON-TYPE provides judgment in courts of justice or to the administration of justice.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("JUDCAL")]
        [EnumMember]
        Judicial,
		
        /// <summary>
        /// A PERSON-TYPE that is identified as being involved within a political area of activity and concerned with politics or has ties to a political party.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("POLTCL")]
        [EnumMember]
        Political,
		
        /// <summary>
        /// A PERSON-TYPE that seeks and enjoys companies of others, or characterized by friendly companionship or relations.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("SOCIAL")]
        [EnumMember]
        Social,
		
    }
}

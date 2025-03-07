using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of GROUP-ORGANISATION-TYPE.
    /// </summary>
    [DomId(100000372)]
    [DataContract]
    public enum GroupOrganisationTypeCategoryEnum
    {
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that is provides judgment in courts of justice or the administration of justice.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("JUDCAL")]
        [EnumMember]
        Judicial,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that provides a medical service.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("MEDCAL")]
        [EnumMember]
        Medical,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that is responsible for the regulation, discipline and control of community, civil administration; enforcement of the law; public order.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("POLICE")]
        [EnumMember]
        Police,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that is identified as being involved within a political area of activity and concerned with politics or has ties to a political party.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("POLTCL")]
        [EnumMember]
        Political,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that is an Islamic consultative council or similar advisory body.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("SHURA")]
        [EnumMember]
        Shura,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that seeks and enjoys companies of others, or characterized by friendly companionship or relations.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("SOCIAL")]
        [EnumMember]
        Social,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE consisting of a number of families, clans, or other groups who share a common ancestry and culture.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("TRIBAL")]
        [EnumMember]
        Tribal,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE who contracts or undertakes to supply certain articles, or to perform any work or service (esp. for government or other public body) at a certain price or rate.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("CNTRCT")]
        [EnumMember]
        Contractor,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons removed from their home country by military or political pressure.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DSPLPR")]
        [EnumMember]
        DisplacedPerson,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that go together or act in concert.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GANG")]
        [EnumMember]
        Gang,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises intellectual beings possessing superior powers of intellect.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INTLCT")]
        [EnumMember]
        Intellectual,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that earn their living by editing or writing for a public journal.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("JRNLST")]
        [EnumMember]
        Journalist,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that are owners or proprietors of land.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LNDOWN")]
        [EnumMember]
        Landowner,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that have the responsibility for the regulation, discipline, and control of a community for the enforcement of law and public order.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("POLCHF")]
        [EnumMember]
        PoliceChief,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons whose occupation is the purchase and sale of marketable commodities for profit.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MRCHNT")]
        [EnumMember]
        Merchant,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that have fallen in the hands of or surrendered to an opponent.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("POW")]
        [EnumMember]
        PrisonerOfWar,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons who, owing to religious persecution or political troubles, seek refuge.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("REFUGE")]
        [EnumMember]
        Refugee,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that attempt to further their views by a system of coercive intimidation.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("TERRST")]
        [EnumMember]
        Terrorist,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that are of ripe years and experience whose counsel is therefore sought and valued.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("VILELD")]
        [EnumMember]
        VillageElder,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that practice or perform writing.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("WRITER")]
        [EnumMember]
        Writer,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that report for international mass communications, but do not take part in the actions.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MEDINT")]
        [EnumMember]
        MediaInternational,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that report for local mass communications, but do not take part in the actions.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MEDLCL")]
        [EnumMember]
        MediaLocal,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that report for national mass communications, but do not take part in the actions.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MEDNAT")]
        [EnumMember]
        MediaNational,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons that report for mass communications (especially television, radio, and newspapers) of an origin not specified.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MEDNOS")]
        [EnumMember]
        MediaNotOtherwiseSpecified,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that comprises persons who attempt to profit by violating the law.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("CRIMIN")]
        [EnumMember]
        Criminal,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE of a particular place regarded with reference to that place.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("LOCINH")]
        [EnumMember]
        LocalInhabitant,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE in custody on a criminal charge and on trial.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("PRSNR")]
        [EnumMember]
        Prisoner,
		
        /// <summary>
        /// A class of civilian convoys.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("CIVCON")]
        [EnumMember]
        CivilianConvoyType,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that provides labour and material for the educational process.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("EDUCAL")]
        [EnumMember]
        Educational,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that provides finance, financial advice and guidance, support for the procurement process, providing pay and disbursing support.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("FINCAL")]
        [EnumMember]
        Financial,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that consists of fighters who are not from the country in which the fighting is taking place supporting belligerents or irregular forces.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("FRNFGT")]
        [EnumMember]
        ForeignFighters,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that rises in revolt against authority.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("INSRGT")]
        [EnumMember]
        Insurgent,
		
        /// <summary>
        /// A GROUP-ORGANISATION-TYPE that is employed to gather information.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("INTEL")]
        [EnumMember]
        Intelligence,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a religion in a specific AFFILIATION-RELIGION.
    /// </summary>
    [DomId(100000175)]
    [DataContract]
    public enum AffiliationReligionEnum
    {
		
        /// <summary>
        /// One who adheres to or identifies with the African Methodist Episcopal (Zion) doctrine.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFRMTH")]
        [EnumMember]
        AfricanMethodistEpiscopalZion,
		
        /// <summary>
        /// One who adheres to or identifies with the Anglican doctrine.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ANGLCN")]
        [EnumMember]
        Anglican,
		
        /// <summary>
        /// One who adheres to or identifies with the Animism doctrine.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ANIMSM")]
        [EnumMember]
        Animism,
		
        /// <summary>
        /// One who adheres to or identifies with the Apostolic doctrine.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("APSTLC")]
        [EnumMember]
        Apostolic,
		
        /// <summary>
        /// One who adheres to or identifies with the Armenian doctrine.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ARMNAN")]
        [EnumMember]
        Armenian,
		
        /// <summary>
        /// One who adheres to or identifies with the Armenian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ARMORT")]
        [EnumMember]
        ArmenianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Assembly of God doctrine.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ASMGOD")]
        [EnumMember]
        AssemblyOfGod,
		
        /// <summary>
        /// One who denies or disbelieves the existence of any deity.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ATHEST")]
        [EnumMember]
        Atheist,
		
        /// <summary>
        /// One who adheres to or identifies with the Babylonian doctrine.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BABYLN")]
        [EnumMember]
        Babylonian,
		
        /// <summary>
        /// One who adheres to or identifies with the Baha'i doctrine.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BAHAI")]
        [EnumMember]
        BahaI,
		
        /// <summary>
        /// One who adheres to or identifies with the Baptist doctrine.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("BAPTST")]
        [EnumMember]
        Baptist,
		
        /// <summary>
        /// One who adheres to or identifies with the Beha'i doctrine.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("BEHAI")]
        [EnumMember]
        BehaI,
		
        /// <summary>
        /// One who adheres to or identifies with the Buddhism doctrine.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("BUDHSM")]
        [EnumMember]
        Buddhism,
		
        /// <summary>
        /// One who adheres to or identifies with the Bulgarian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("BLGORT")]
        [EnumMember]
        BulgarianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Calvinist doctrine.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("CALVNS")]
        [EnumMember]
        Calvinist,
		
        /// <summary>
        /// One who adheres to or identifies with the Catholic doctrine.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("CATHLC")]
        [EnumMember]
        Catholic,
		
        /// <summary>
        /// One who adheres to or identifies with the Chondogyo doctrine.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("CHNDGY")]
        [EnumMember]
        Chondogyo,
		
        /// <summary>
        /// One who adheres to or identifies with the Christian doctrine.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("CHRSTN")]
        [EnumMember]
        Christian,
		
        /// <summary>
        /// One who adheres to or identifies with the Christian (Liebenzell Mission) doctrine.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("CHRSLB")]
        [EnumMember]
        ChristianLiebenzellMission,
		
        /// <summary>
        /// One who adheres to or identifies with the Christian (Free Wesleyan Church) doctrine.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("CHRFRW")]
        [EnumMember]
        ChristianFreeWesleyanChurch,
		
        /// <summary>
        /// One who adheres to or identifies with the Church of England doctrine.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("CHRENG")]
        [EnumMember]
        ChurchOfEngland,
		
        /// <summary>
        /// One who adheres to or identifies with the Church of God doctrine.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("CHRGOD")]
        [EnumMember]
        ChurchOfGod,
		
        /// <summary>
        /// One who adheres to or identifies with the Church of Tuvalu doctrine.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("CHRTVL")]
        [EnumMember]
        ChurchOfTuvalu,
		
        /// <summary>
        /// One who adheres to or identifies with the Confucianism doctrine.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("CNFCNS")]
        [EnumMember]
        Confucianism,
		
        /// <summary>
        /// One who adheres to or identifies with the Congregational doctrine.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("CNG")]
        [EnumMember]
        Congregational,
		
        /// <summary>
        /// One who adheres to or identifies with the Congregational Christian Church doctrine.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("CNGCCH")]
        [EnumMember]
        CongregationalChristianChurch,
		
        /// <summary>
        /// One who adheres to or identifies with the Congregational New Church doctrine.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("CNGNCH")]
        [EnumMember]
        CongregationalNewChurch,
		
        /// <summary>
        /// One who adheres to or identifies with the Coptic Christian doctrine.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("CPTCHR")]
        [EnumMember]
        CopticChristian,
		
        /// <summary>
        /// One who adheres to or identifies with the Druze doctrine.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("DRUZE")]
        [EnumMember]
        Druze,
		
        /// <summary>
        /// One who adheres to or identifies with the Eastern Orthodox doctrine.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("ESTORT")]
        [EnumMember]
        EasternOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Ekalesia Nieue doctrine.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("EKLNIE")]
        [EnumMember]
        EkalesiaNieue,
		
        /// <summary>
        /// One who adheres to or identifies with the Episcopalian doctrine.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("EPSCPL")]
        [EnumMember]
        Episcopalian,
		
        /// <summary>
        /// One who adheres to or identifies with the Ethiopian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("ETHORT")]
        [EnumMember]
        EthiopianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Evangelical Alliance doctrine.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("EVNALL")]
        [EnumMember]
        EvangelicalAlliance,
		
        /// <summary>
        /// One who adheres to or identifies with the Evangelical Lutheran doctrine.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("EVNLUT")]
        [EnumMember]
        EvangelicalLutheran,
		
        /// <summary>
        /// One who adheres to or identifies with the Evangelist Church doctrine.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("EVNGCH")]
        [EnumMember]
        EvangelistChurch,
		
        /// <summary>
        /// One who adheres to or identifies with the Georgian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("GEOORT")]
        [EnumMember]
        GeorgianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Greek Catholic doctrine.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("GRKCTH")]
        [EnumMember]
        GreekCatholic,
		
        /// <summary>
        /// One who adheres to or identifies with the Greek Orthodox doctrine.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("GRKORT")]
        [EnumMember]
        GreekOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Gregorian-Armenian doctrine.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("GRGARM")]
        [EnumMember]
        GregorianArmenian,
		
        /// <summary>
        /// One who adheres to or identifies with the Hinduism doctrine.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("HINDU")]
        [EnumMember]
        Hinduism,
		
        /// <summary>
        /// One who adheres to or identifies with the Ibadhi Muslim doctrine.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("IBDMUS")]
        [EnumMember]
        IbadhiMuslim,
		
        /// <summary>
        /// One who adheres to or identifies with the Indigenous doctrine.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("INDGNS")]
        [EnumMember]
        Indigenous,
		
        /// <summary>
        /// One who adheres to or identifies with the Islam (Alawite) doctrine.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("ISLAMA")]
        [EnumMember]
        IslamAlawite,
		
        /// <summary>
        /// One who adheres to or identifies with the Islam (Isma'ilite) doctrine.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("ISLAMI")]
        [EnumMember]
        IslamIsmaIlite,
		
        /// <summary>
        /// One who adheres to or identifies with the Islam (Nusayri) doctrine.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("ISLAMN")]
        [EnumMember]
        IslamNusayri,
		
        /// <summary>
        /// One who adheres to or identifies with the Islamic doctrine.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("ISLAMC")]
        [EnumMember]
        Islamic,
		
        /// <summary>
        /// One who adheres to or identifies with the Jains doctrine.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("JAINS")]
        [EnumMember]
        Jains,
		
        /// <summary>
        /// One who adheres to or identifies with the Jehovah's Witness doctrine.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("JHVWTN")]
        [EnumMember]
        JehovahSWitness,
		
        /// <summary>
        /// One who adheres to or identifies with the Judaism doctrine.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("JUDASM")]
        [EnumMember]
        Judaism,
		
        /// <summary>
        /// One who adheres to or identifies with the Kiev Patriarchate doctrine.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("KIEVPT")]
        [EnumMember]
        KievPatriarchate,
		
        /// <summary>
        /// One who adheres to or identifies with the Kimbanguist doctrine.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("KMBNGS")]
        [EnumMember]
        Kimbanguist,
		
        /// <summary>
        /// One who adheres to or identifies with the Lamaistic Buddhism doctrine.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("LAMBUD")]
        [EnumMember]
        LamaisticBuddhism,
		
        /// <summary>
        /// One who adheres to or identifies with the Latter-day Saints doctrine.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("LTRSNT")]
        [EnumMember]
        LatterDaySaints,
		
        /// <summary>
        /// One who adheres to or identifies with the London Missionary Society doctrine.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("LNDMSN")]
        [EnumMember]
        LondonMissionarySociety,
		
        /// <summary>
        /// One who adheres to or identifies with the Lutheran doctrine.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("LUTHRN")]
        [EnumMember]
        Lutheran,
		
        /// <summary>
        /// One who adheres to or identifies with the Mandeaen doctrine.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("MANDEA")]
        [EnumMember]
        Mandeaen,
		
        /// <summary>
        /// One who adheres to or identifies with the Maronite doctrine.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("MARONT")]
        [EnumMember]
        Maronite,
		
        /// <summary>
        /// One who adheres to or identifies with the Mennonite doctrine.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("MENNTE")]
        [EnumMember]
        Mennonite,
		
        /// <summary>
        /// One who adheres to or identifies with the Methodist doctrine.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("METHDS")]
        [EnumMember]
        Methodist,
		
        /// <summary>
        /// One who adheres to or identifies with the Modekngei doctrine.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("MODKNG")]
        [EnumMember]
        Modekngei,
		
        /// <summary>
        /// One who adheres to or identifies with the Mormon doctrine.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("MORMON")]
        [EnumMember]
        Mormon,
		
        /// <summary>
        /// One who adheres to or identifies with the Moscow Patriarchate doctrine.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("MSCWPT")]
        [EnumMember]
        MoscowPatriarchate,
		
        /// <summary>
        /// One who adheres to or identifies with the Muslim doctrine.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("MUSLIM")]
        [EnumMember]
        Muslim,
		
        /// <summary>
        /// One who adheres to or identifies with the Muslim (Malays) doctrine.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("MUSMLY")]
        [EnumMember]
        MuslimMalays,
		
        /// <summary>
        /// One who adheres to or identifies with the Muslim (Sha'fi) doctrine.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("MUSSHF")]
        [EnumMember]
        MuslimShaFi,
		
        /// <summary>
        /// One who adheres to or identifies with the Muslim (Zaydi) doctrine.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("MUSZYD")]
        [EnumMember]
        MuslimZaydi,
		
        /// <summary>
        /// One who adheres to or identifies with the Niuean Church doctrine.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("NIUNCH")]
        [EnumMember]
        NiueanChurch,
		
        /// <summary>
        /// One who does not adhere to a religion.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("NONE")]
        [EnumMember]
        None,
		
        /// <summary>
        /// One who adheres to or identifies with the Orthodox doctrine.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("ORTHDX")]
        [EnumMember]
        Orthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Pagan African doctrine.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("PGNAFR")]
        [EnumMember]
        PaganAfrican,
		
        /// <summary>
        /// One who adheres to or identifies with the Parsi doctrine.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("PARSI")]
        [EnumMember]
        Parsi,
		
        /// <summary>
        /// One who adheres to or identifies with the Pentecostal doctrine.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("PNTCST")]
        [EnumMember]
        Pentecostal,
		
        /// <summary>
        /// One who adheres to or identifies with the Presbyterian doctrine.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("PRSBYT")]
        [EnumMember]
        Presbyterian,
		
        /// <summary>
        /// One who adheres to or identifies with the Protestant doctrine.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("PRT")]
        [EnumMember]
        Protestant,
		
        /// <summary>
        /// One who adheres to or identifies with the Protestant (Adventist) doctrine.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("PRTADV")]
        [EnumMember]
        ProtestantAdventist,
		
        /// <summary>
        /// One who adheres to or identifies with the Protestant (Evangelical Methodist) doctrine.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("PRTEVN")]
        [EnumMember]
        ProtestantEvangelicalMethodist,
		
        /// <summary>
        /// One who adheres to or identifies with the Protestant (Moravian) doctrine.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("PRTMRV")]
        [EnumMember]
        ProtestantMoravian,
		
        /// <summary>
        /// One who adheres to or identifies with the Roman Catholic doctrine.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("RMNCTH")]
        [EnumMember]
        RomanCatholic,
		
        /// <summary>
        /// One who adheres to or identifies with the Roman Catholic (Uniate) doctrine.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("RMNCTU")]
        [EnumMember]
        RomanCatholicUniate,
		
        /// <summary>
        /// One who adheres to or identifies with the Romanian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("ROMORT")]
        [EnumMember]
        RomanianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Russian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("RUSORT")]
        [EnumMember]
        RussianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Seventh-day Adventist doctrine.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("SVNADV")]
        [EnumMember]
        SeventhDayAdventist,
		
        /// <summary>
        /// One who adheres to or identifies with the Shamanism doctrine.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("SHMNSM")]
        [EnumMember]
        Shamanism,
		
        /// <summary>
        /// One who adheres to or identifies with the Shi'a Muslim doctrine.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("SHIMUS")]
        [EnumMember]
        ShiAMuslim,
		
        /// <summary>
        /// One who adheres to or identifies with the Shinto doctrine.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("SHINTO")]
        [EnumMember]
        Shinto,
		
        /// <summary>
        /// One who adheres to or identifies with the Sikh doctrine.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("SIKH")]
        [EnumMember]
        Sikh,
		
        /// <summary>
        /// One who adheres to or identifies with the Slavic Muslim doctrine.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("SLVMUS")]
        [EnumMember]
        SlavicMuslim,
		
        /// <summary>
        /// One who adheres to or identifies with the Society of Friends doctrine.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("SOCFRD")]
        [EnumMember]
        SocietyOfFriends,
		
        /// <summary>
        /// One who adheres to or identifies with the Spiritual Cults doctrine.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("SPRCLT")]
        [EnumMember]
        SpiritualCults,
		
        /// <summary>
        /// One who adheres to or identifies with the Sunni Muslim doctrine.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("SUNMUS")]
        [EnumMember]
        SunniMuslim,
		
        /// <summary>
        /// One who adheres to or identifies with the Syncretic Chondogyo doctrine.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("SYNCHN")]
        [EnumMember]
        SyncreticChondogyo,
		
        /// <summary>
        /// One who adheres to or identifies with the Taoism doctrine.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("TAOISM")]
        [EnumMember]
        Taoism,
		
        /// <summary>
        /// One who adheres to or identifies with the Theravada Buddhism doctrine.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("THRVBD")]
        [EnumMember]
        TheravadaBuddhism,
		
        /// <summary>
        /// One who adheres to or identifies with the Tibetan Buddhist doctrine.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("TBTBUD")]
        [EnumMember]
        TibetanBuddhist,
		
        /// <summary>
        /// One who adheres to or identifies with the Traditional doctrine.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("TRD")]
        [EnumMember]
        Traditional,
		
        /// <summary>
        /// One who adheres to or identifies with the Traditional Mayan doctrine.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("TRDMYN")]
        [EnumMember]
        TraditionalMayan,
		
        /// <summary>
        /// One who adheres to or identifies with the Tribal Religion doctrine.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("TRBREL")]
        [EnumMember]
        TribalReligion,
		
        /// <summary>
        /// One who adheres to or identifies with the Ukrainian Autocephalous doctrine.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("UKRAUT")]
        [EnumMember]
        UkrainianAutocephalous,
		
        /// <summary>
        /// One who adheres to or identifies with the Ukrainian Catholic (Uniate) doctrine.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("UKRCTH")]
        [EnumMember]
        UkrainianCatholicUniate,
		
        /// <summary>
        /// One who adheres to or identifies with the Ukrainian Orthodox doctrine.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("UKRORT")]
        [EnumMember]
        UkrainianOrthodox,
		
        /// <summary>
        /// One who adheres to or identifies with the Uniate Catholic doctrine.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("UNICTH")]
        [EnumMember]
        UniateCatholic,
		
        /// <summary>
        /// One who adheres to or identifies with the United (Methodist) doctrine.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("UNDMTH")]
        [EnumMember]
        UnitedMethodist,
		
        /// <summary>
        /// One who adheres to or identifies with the United (Presbyterian) doctrine.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("UNDPRB")]
        [EnumMember]
        UnitedPresbyterian,
		
        /// <summary>
        /// One who adheres to or identifies with the United Church doctrine.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("UNCH")]
        [EnumMember]
        UnitedChurch,
		
        /// <summary>
        /// One who adheres to or identifies with the United Church (Congregational) doctrine.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("UNCHCN")]
        [EnumMember]
        UnitedChurchCongregational,
		
        /// <summary>
        /// One who adheres to or identifies with the United Church (Presbyterian) doctrine.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("UNCHPR")]
        [EnumMember]
        UnitedChurchPresbyterian,
		
        /// <summary>
        /// One who adheres to or identifies with the United Free Church doctrine.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("UNFRCH")]
        [EnumMember]
        UnitedFreeChurch,
		
        /// <summary>
        /// One who adheres to or identifies with the Uniting Church in Australia doctrine.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("UNCHAU")]
        [EnumMember]
        UnitingChurchInAustralia,
		
        /// <summary>
        /// One who adheres to or identifies with the Voodoo doctrine.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("VOODOO")]
        [EnumMember]
        Voodoo,
		
        /// <summary>
        /// One who adheres to or identifies with the Zoroastrian doctrine.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("ZRSTRN")]
        [EnumMember]
        Zoroastrian,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

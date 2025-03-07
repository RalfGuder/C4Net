using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents an ethnic group in a specific AFFILIATION-ETHNIC-GROUP.
    /// </summary>
    [DomId(100004129)]
    [DataContract]
    public enum AffiliationEthnicGroupEnum
    {
		
        /// <summary>
        /// The ethnic group of Admiralty Islander people.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADMISL")]
        [EnumMember]
        AdmiraltyIslander,
		
        /// <summary>
        /// The ethnic group of Afghani people.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AFGHAN")]
        [EnumMember]
        Afghani,
		
        /// <summary>
        /// The ethnic group of African American people.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AFRAMR")]
        [EnumMember]
        AfricanAmerican,
		
        /// <summary>
        /// The not further defined ethnic groups of African people.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AFRNFD")]
        [EnumMember]
        AfricanNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Aitutaki Islander people.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AITISL")]
        [EnumMember]
        AitutakiIslander,
		
        /// <summary>
        /// The ethnic group of Albanian people.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ALBNAN")]
        [EnumMember]
        Albanian,
		
        /// <summary>
        /// The ethnic group of Algerian people.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ALGRAN")]
        [EnumMember]
        Algerian,
		
        /// <summary>
        /// The ethnic group of American (US) people.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("AMERUS")]
        [EnumMember]
        AmericanUs,
		
        /// <summary>
        /// The ethnic group of Arab people.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ARAB")]
        [EnumMember]
        Arab,
		
        /// <summary>
        /// The ethnic group of Argentinian people.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ARGNTN")]
        [EnumMember]
        Argentinian,
		
        /// <summary>
        /// The ethnic group of Armenian people.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ARMNAN")]
        [EnumMember]
        Armenian,
		
        /// <summary>
        /// The not further defined ethnic groups of Asian people.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ASNNFD")]
        [EnumMember]
        AsianNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Assyrian people.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("ASSYRN")]
        [EnumMember]
        Assyrian,
		
        /// <summary>
        /// The ethnic group of Atiu Islander people.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ATUISL")]
        [EnumMember]
        AtiuIslander,
		
        /// <summary>
        /// The ethnic group of Austral Islander people.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("AUSISL")]
        [EnumMember]
        AustralIslander,
		
        /// <summary>
        /// The ethnic group of Australian people.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("AUSTRL")]
        [EnumMember]
        Australian,
		
        /// <summary>
        /// The ethnic group of Australian Aboriginal people.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("AUSTRA")]
        [EnumMember]
        AustralianAboriginal,
		
        /// <summary>
        /// The ethnic group of Austrian people.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("AUSTRN")]
        [EnumMember]
        Austrian,
		
        /// <summary>
        /// The ethnic group of Bangladeshi people.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("BANGLS")]
        [EnumMember]
        Bangladeshi,
		
        /// <summary>
        /// The ethnic group of Belau/Palau Islander people.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("BELAU")]
        [EnumMember]
        BelauPalauIslander,
		
        /// <summary>
        /// The ethnic group of Belgian people.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("BELGAN")]
        [EnumMember]
        Belgian,
		
        /// <summary>
        /// The ethnic group of Bengali people.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("BENGLI")]
        [EnumMember]
        Bengali,
		
        /// <summary>
        /// The ethnic group of Bismark Archipelagoan people.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("BISMAR")]
        [EnumMember]
        BismarkArchipelagoan,
		
        /// <summary>
        /// The ethnic group of Black people.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("BLACK")]
        [EnumMember]
        Black,
		
        /// <summary>
        /// The ethnic group of Bolivian people.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("BOLIVN")]
        [EnumMember]
        Bolivian,
		
        /// <summary>
        /// The ethnic group of Bougainvillean people.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("BOUGNV")]
        [EnumMember]
        Bougainvillean,
		
        /// <summary>
        /// The ethnic group of Brazilian people.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("BRAZLN")]
        [EnumMember]
        Brazilian,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of British people.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("BRTNEC")]
        [EnumMember]
        BritishNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of British people.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("BRTNFD")]
        [EnumMember]
        BritishNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Bulgarian people.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("BULGRN")]
        [EnumMember]
        Bulgarian,
		
        /// <summary>
        /// The ethnic group of Burgher people.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("BURGHR")]
        [EnumMember]
        Burgher,
		
        /// <summary>
        /// The ethnic group of Burmese people.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("BURMSE")]
        [EnumMember]
        Burmese,
		
        /// <summary>
        /// The ethnic group of Byelorussian people.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("BYLRSN")]
        [EnumMember]
        Byelorussian,
		
        /// <summary>
        /// The ethnic group of Canadian people.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("CANADN")]
        [EnumMember]
        Canadian,
		
        /// <summary>
        /// The ethnic group of Caroline Islander people.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("CARISL")]
        [EnumMember]
        CarolineIslander,
		
        /// <summary>
        /// The ethnic group of Celtic people.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("CELTIC")]
        [EnumMember]
        Celtic,
		
        /// <summary>
        /// The ethnic group of Central American Indian people.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("CENAMR")]
        [EnumMember]
        CentralAmericanIndian,
		
        /// <summary>
        /// The ethnic group of Channel Islander people.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("CHNISL")]
        [EnumMember]
        ChannelIslander,
		
        /// <summary>
        /// The ethnic group of Chilean people.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("CHLEAN")]
        [EnumMember]
        Chilean,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of Chinese people.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("CHNNEC")]
        [EnumMember]
        ChineseNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Chinese people.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("CHNNFD")]
        [EnumMember]
        ChineseNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Colombian people.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("COLMBN")]
        [EnumMember]
        Colombian,
		
        /// <summary>
        /// The not further defined ethnic groups of Cook Island Maori people.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("COKNFD")]
        [EnumMember]
        CookIslandMaoriNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Cornish people.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("CORNSH")]
        [EnumMember]
        Cornish,
		
        /// <summary>
        /// The ethnic group of Corsican people.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("CORSCN")]
        [EnumMember]
        Corsican,
		
        /// <summary>
        /// The ethnic group of Costa Rican people.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("COSTRN")]
        [EnumMember]
        CostaRican,
		
        /// <summary>
        /// The ethnic group of Creole (Latin America) people.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("CRELLA")]
        [EnumMember]
        CreoleLatinAmerica,
		
        /// <summary>
        /// The ethnic group of Creole (US) people.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("CRELUS")]
        [EnumMember]
        CreoleUs,
		
        /// <summary>
        /// The ethnic group of Croat/Croatian people.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("CROATN")]
        [EnumMember]
        CroatCroatian,
		
        /// <summary>
        /// The not further defined ethnic groups of Cypriot people.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("CYRNFD")]
        [EnumMember]
        CypriotNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Czech people.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("CZECH")]
        [EnumMember]
        Czech,
		
        /// <summary>
        /// The ethnic group of Dalmatian people.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("DALMTN")]
        [EnumMember]
        Dalmatian,
		
        /// <summary>
        /// The ethnic group of Danish people.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("DANISH")]
        [EnumMember]
        Danish,
		
        /// <summary>
        /// The ethnic group of Dutch/Netherlands people.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("DUTCH")]
        [EnumMember]
        DutchNetherlands,
		
        /// <summary>
        /// The ethnic group of Easter Islander people.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("EASISL")]
        [EnumMember]
        EasterIslander,
		
        /// <summary>
        /// The ethnic group of Ecuadorian people.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("ECUDRN")]
        [EnumMember]
        Ecuadorian,
		
        /// <summary>
        /// The ethnic group of Egyptian people.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("EGYPTN")]
        [EnumMember]
        Egyptian,
		
        /// <summary>
        /// The ethnic group of English people.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("ENGLSH")]
        [EnumMember]
        English,
		
        /// <summary>
        /// The ethnic group of Estonian people.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("ESTONN")]
        [EnumMember]
        Estonian,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of European people.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("EURNEC")]
        [EnumMember]
        EuropeanNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of European people.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("EURNFD")]
        [EnumMember]
        EuropeanNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Falkland Islander/Kelper people.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("FLKISL")]
        [EnumMember]
        FalklandIslanderKelper,
		
        /// <summary>
        /// The ethnic group of Fijian (except Fiji Indian/Indo-Fijian) people.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("FIJIAN")]
        [EnumMember]
        FijianExceptFijiIndianIndoFijian,
		
        /// <summary>
        /// The ethnic group of Fijian Indian/Indo-Fijian people.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("FIJNIN")]
        [EnumMember]
        FijianIndianIndoFijian,
		
        /// <summary>
        /// The ethnic group of Filipino people.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("FILPNO")]
        [EnumMember]
        Filipino,
		
        /// <summary>
        /// The ethnic group of Finnish people.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("FINNSH")]
        [EnumMember]
        Finnish,
		
        /// <summary>
        /// The ethnic group of Flemish people.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("FLEMSH")]
        [EnumMember]
        Flemish,
		
        /// <summary>
        /// The ethnic group of French people.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("FRENCH")]
        [EnumMember]
        French,
		
        /// <summary>
        /// The ethnic group of Gaelic people.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("GAELIC")]
        [EnumMember]
        Gaelic,
		
        /// <summary>
        /// The ethnic group of Gambier Islander people.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("GMBISL")]
        [EnumMember]
        GambierIslander,
		
        /// <summary>
        /// The ethnic group of German people.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("GERMAN")]
        [EnumMember]
        German,
		
        /// <summary>
        /// The ethnic group of Greek (incl Greek Cypriot) people.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("GREEK")]
        [EnumMember]
        GreekInclGreekCypriot,
		
        /// <summary>
        /// The ethnic group of Greenlander people.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("GRNLND")]
        [EnumMember]
        Greenlander,
		
        /// <summary>
        /// The ethnic group of Guadalcanalian people.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("GUADLN")]
        [EnumMember]
        Guadalcanalian,
		
        /// <summary>
        /// The ethnic group of Guam Islander/Chamorro people.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("GUMISL")]
        [EnumMember]
        GuamIslanderChamorro,
		
        /// <summary>
        /// The ethnic group of Guatemalan people.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("GUATLN")]
        [EnumMember]
        Guatemalan,
		
        /// <summary>
        /// The ethnic group of Gujarati people.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("GUJART")]
        [EnumMember]
        Gujarati,
		
        /// <summary>
        /// The ethnic group of Guyanese people.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("GUYANS")]
        [EnumMember]
        Guyanese,
		
        /// <summary>
        /// The ethnic group of Hawaiian people.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("HAWIAN")]
        [EnumMember]
        Hawaiian,
		
        /// <summary>
        /// The ethnic group of Honduran people.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("HONDRN")]
        [EnumMember]
        Honduran,
		
        /// <summary>
        /// The ethnic group of Hong Kong Chinese people.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("HKCHNS")]
        [EnumMember]
        HongKongChinese,
		
        /// <summary>
        /// The ethnic group of Hungarian people.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("HUNGRN")]
        [EnumMember]
        Hungarian,
		
        /// <summary>
        /// The ethnic group of Icelander people.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("ICLNDR")]
        [EnumMember]
        Icelander,
		
        /// <summary>
        /// The ethnic group of I-Kiribati/Gilbertese people.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("IKRBAT")]
        [EnumMember]
        IKiribatiGilbertese,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of Indian people.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("INDNEC")]
        [EnumMember]
        IndianNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Indian people.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("INDNFD")]
        [EnumMember]
        IndianNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Indonesian (incl Javanese/Sundanese/Sumatran) people.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("INDOSN")]
        [EnumMember]
        IndonesianInclJavaneseSundaneseSumatran,
		
        /// <summary>
        /// The ethnic group of Inuit/Eskimo people.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("INUIT")]
        [EnumMember]
        InuitEskimo,
		
        /// <summary>
        /// The ethnic group of Iranian/Persian people.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("IRNPER")]
        [EnumMember]
        IranianPersian,
		
        /// <summary>
        /// The ethnic group of Iraqi people.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("IRAQI")]
        [EnumMember]
        Iraqi,
		
        /// <summary>
        /// The ethnic group of Irish people.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("IRISH")]
        [EnumMember]
        Irish,
		
        /// <summary>
        /// The ethnic group of Israeli/Jewish/Hebrew people.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("ISRJEW")]
        [EnumMember]
        IsraeliJewishHebrew,
		
        /// <summary>
        /// The ethnic group of Italian people.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("ITALAN")]
        [EnumMember]
        Italian,
		
        /// <summary>
        /// The ethnic group of Jamaican people.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("JAMACN")]
        [EnumMember]
        Jamaican,
		
        /// <summary>
        /// The ethnic group of Japanese people.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("JAPNES")]
        [EnumMember]
        Japanese,
		
        /// <summary>
        /// The ethnic group of Jordanian people.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("JORDNN")]
        [EnumMember]
        Jordanian,
		
        /// <summary>
        /// The ethnic group of Kampuchean Chinese people.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("KAMCHN")]
        [EnumMember]
        KampucheanChinese,
		
        /// <summary>
        /// The ethnic group of Kanaka/Kanak people.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("KANAKA")]
        [EnumMember]
        KanakaKanak,
		
        /// <summary>
        /// The ethnic group of Kenyan people.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("KENYAN")]
        [EnumMember]
        Kenyan,
		
        /// <summary>
        /// The ethnic group of Khmer/Kampuchean/Cambodian people.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("KHMER")]
        [EnumMember]
        KhmerKampucheanCambodian,
		
        /// <summary>
        /// The ethnic group of Korean people.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("KOREAN")]
        [EnumMember]
        Korean,
		
        /// <summary>
        /// The ethnic group of Kurd people.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("KURD")]
        [EnumMember]
        Kurd,
		
        /// <summary>
        /// The ethnic group of Lao/Laotian people.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("LAOTAN")]
        [EnumMember]
        LaoLaotian,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of Latin American/Hispanic people.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("LATNEC")]
        [EnumMember]
        LatinAmericanHispanicNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Latin American/Hispanic people.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("LATNFD")]
        [EnumMember]
        LatinAmericanHispanicNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Latvian people.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("LATVAN")]
        [EnumMember]
        Latvian,
		
        /// <summary>
        /// The ethnic group of Lebanese people.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("LEBNSE")]
        [EnumMember]
        Lebanese,
		
        /// <summary>
        /// The ethnic group of Libyan people.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("LIBYAN")]
        [EnumMember]
        Libyan,
		
        /// <summary>
        /// The ethnic group of Lithuanian people.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("LITHUN")]
        [EnumMember]
        Lithuanian,
		
        /// <summary>
        /// The ethnic group of Macedonian people.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("MACDNN")]
        [EnumMember]
        Macedonian,
		
        /// <summary>
        /// The ethnic group of Malaitian people.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("MALATN")]
        [EnumMember]
        Malaitian,
		
        /// <summary>
        /// The ethnic group of Malay/Malayan people.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("MALAY")]
        [EnumMember]
        MalayMalayan,
		
        /// <summary>
        /// The ethnic group of Malaysian Chinese people.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("MALCHN")]
        [EnumMember]
        MalaysianChinese,
		
        /// <summary>
        /// The ethnic group of Maltese people.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("MALTSE")]
        [EnumMember]
        Maltese,
		
        /// <summary>
        /// The ethnic group of Malvinian (Spanish-speaking Falkland Islander) people.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("MALVAN")]
        [EnumMember]
        MalvinianSpanishSpeakingFalklandIslander,
		
        /// <summary>
        /// The ethnic group of Mangaia Islander people.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("MANGIS")]
        [EnumMember]
        MangaiaIslander,
		
        /// <summary>
        /// The ethnic group of Manihiki Islander people.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("MANHIS")]
        [EnumMember]
        ManihikiIslander,
		
        /// <summary>
        /// The ethnic group of Manus Islander people.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("MANUIS")]
        [EnumMember]
        ManusIslander,
		
        /// <summary>
        /// The ethnic group of Manx people.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("MANX")]
        [EnumMember]
        Manx,
		
        /// <summary>
        /// The ethnic group of Marianas Islander people.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("MARISL")]
        [EnumMember]
        MarianasIslander,
		
        /// <summary>
        /// The ethnic group of Marquesas Islander people.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("MARQIS")]
        [EnumMember]
        MarquesasIslander,
		
        /// <summary>
        /// The ethnic group of Marshall Islander people.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("MARSIS")]
        [EnumMember]
        MarshallIslander,
		
        /// <summary>
        /// The ethnic group of Mauke Islander people.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("MAUKIS")]
        [EnumMember]
        MaukeIslander,
		
        /// <summary>
        /// The ethnic group of Mauritian people.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("MAURTN")]
        [EnumMember]
        Mauritian,
		
        /// <summary>
        /// The ethnic group of Mexican people.
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("MEXCAN")]
        [EnumMember]
        Mexican,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of Middle Eastern people.
        /// </summary>
        [DomValIx(1000126)]
        [StringValue("MDENEC")]
        [EnumMember]
        MiddleEasternNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Middle Eastern people.
        /// </summary>
        [DomValIx(1000127)]
        [StringValue("MDENFD")]
        [EnumMember]
        MiddleEasternNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Mitiaro Islander people.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("MITISL")]
        [EnumMember]
        MitiaroIslander,
		
        /// <summary>
        /// The ethnic group of Moroccan people.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("MOROCN")]
        [EnumMember]
        Moroccan,
		
        /// <summary>
        /// The ethnic group of Nauru Islander people.
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("NAUISL")]
        [EnumMember]
        NauruIslander,
		
        /// <summary>
        /// The ethnic group of Nepalese people.
        /// </summary>
        [DomValIx(1000131)]
        [StringValue("NEPLSE")]
        [EnumMember]
        Nepalese,
		
        /// <summary>
        /// The ethnic group of New Britain Islander people.
        /// </summary>
        [DomValIx(1000132)]
        [StringValue("NEWBRT")]
        [EnumMember]
        NewBritainIslander,
		
        /// <summary>
        /// The ethnic group of New Caledonian people.
        /// </summary>
        [DomValIx(1000133)]
        [StringValue("NEWCAL")]
        [EnumMember]
        NewCaledonian,
		
        /// <summary>
        /// The ethnic group of New Georgian people.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("NEWGER")]
        [EnumMember]
        NewGeorgian,
		
        /// <summary>
        /// The ethnic group of New Irelander people.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("NEWIRL")]
        [EnumMember]
        NewIrelander,
		
        /// <summary>
        /// The ethnic group of New Zealand European/Pakeha people.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("NEWZLE")]
        [EnumMember]
        NewZealandEuropeanPakeha,
		
        /// <summary>
        /// The ethnic group of New Zealand Maori people.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("NEWZLM")]
        [EnumMember]
        NewZealandMaori,
		
        /// <summary>
        /// The ethnic group of Nicaraguan people.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("NICRGN")]
        [EnumMember]
        Nicaraguan,
		
        /// <summary>
        /// The ethnic group of Nigerian people.
        /// </summary>
        [DomValIx(1000139)]
        [StringValue("NIGRAN")]
        [EnumMember]
        Nigerian,
		
        /// <summary>
        /// The ethnic group of Niuean people.
        /// </summary>
        [DomValIx(1000140)]
        [StringValue("NIUEAN")]
        [EnumMember]
        Niuean,
		
        /// <summary>
        /// The ethnic group of North American Indian people.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("NAINDN")]
        [EnumMember]
        NorthAmericanIndian,
		
        /// <summary>
        /// The ethnic group of Norwegian people.
        /// </summary>
        [DomValIx(1000142)]
        [StringValue("NORWGN")]
        [EnumMember]
        Norwegian,
		
        /// <summary>
        /// The ethnic group of Ocean Islander/Banaban people.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("OCNISL")]
        [EnumMember]
        OceanIslanderBanaban,
		
        /// <summary>
        /// The ethnic group of Omani people.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("OMANI")]
        [EnumMember]
        Omani,
		
        /// <summary>
        /// The ethnic group of Orkney Islander people.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("ORKISL")]
        [EnumMember]
        OrkneyIslander,
		
        /// <summary>
        /// The ethnic group of Other African not elsewhere classified people.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("OAFNEC")]
        [EnumMember]
        OtherAfricanNotElsewhereClassified,
		
        /// <summary>
        /// The ethnic group of Other Asian not elsewhere classified people.
        /// </summary>
        [DomValIx(1000147)]
        [StringValue("OASNEC")]
        [EnumMember]
        OtherAsianNotElsewhereClassified,
		
        /// <summary>
        /// The ethnic group of Other European not further defined people.
        /// </summary>
        [DomValIx(1000148)]
        [StringValue("OEUNFD")]
        [EnumMember]
        OtherEuropeanNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Other Pacific Island Groups not further defined people.
        /// </summary>
        [DomValIx(1000151)]
        [StringValue("OPANFD")]
        [EnumMember]
        OtherPacificIslandGroupsNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Other Pacific Island not elsewhere classified people.
        /// </summary>
        [DomValIx(1000152)]
        [StringValue("OPANEC")]
        [EnumMember]
        OtherPacificIslandNotElsewhereClassified,
		
        /// <summary>
        /// The ethnic group of Other Southeast Asian not elsewhere classified people.
        /// </summary>
        [DomValIx(1000153)]
        [StringValue("OSANEC")]
        [EnumMember]
        OtherSoutheastAsianNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Pacific Island people.
        /// </summary>
        [DomValIx(1000154)]
        [StringValue("PACNFD")]
        [EnumMember]
        PacificIslandNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Pakistani people.
        /// </summary>
        [DomValIx(1000155)]
        [StringValue("PAKSTN")]
        [EnumMember]
        Pakistani,
		
        /// <summary>
        /// The ethnic group of Palestinian people.
        /// </summary>
        [DomValIx(1000156)]
        [StringValue("PALSTN")]
        [EnumMember]
        Palestinian,
		
        /// <summary>
        /// The ethnic group of Palmerston Islander people.
        /// </summary>
        [DomValIx(1000157)]
        [StringValue("PALMIS")]
        [EnumMember]
        PalmerstonIslander,
		
        /// <summary>
        /// The ethnic group of Panamanian people.
        /// </summary>
        [DomValIx(1000158)]
        [StringValue("PANMAN")]
        [EnumMember]
        Panamanian,
		
        /// <summary>
        /// The ethnic group of Papuan/New Guinean/Irian Jayan people.
        /// </summary>
        [DomValIx(1000159)]
        [StringValue("PAPUAN")]
        [EnumMember]
        PapuanNewGuineanIrianJayan,
		
        /// <summary>
        /// The ethnic group of Paraguayan people.
        /// </summary>
        [DomValIx(1000160)]
        [StringValue("PARGYN")]
        [EnumMember]
        Paraguayan,
		
        /// <summary>
        /// The ethnic group of Penrhyn Islander people.
        /// </summary>
        [DomValIx(1000161)]
        [StringValue("PENISL")]
        [EnumMember]
        PenrhynIslander,
		
        /// <summary>
        /// The ethnic group of Peruvian people.
        /// </summary>
        [DomValIx(1000162)]
        [StringValue("PERUVN")]
        [EnumMember]
        Peruvian,
		
        /// <summary>
        /// The ethnic group of Phoenix Islander people.
        /// </summary>
        [DomValIx(1000163)]
        [StringValue("PHNISL")]
        [EnumMember]
        PhoenixIslander,
		
        /// <summary>
        /// The ethnic group of Pitcairn Islander people.
        /// </summary>
        [DomValIx(1000164)]
        [StringValue("PITISL")]
        [EnumMember]
        PitcairnIslander,
		
        /// <summary>
        /// The ethnic group of Polish people.
        /// </summary>
        [DomValIx(1000165)]
        [StringValue("POLISH")]
        [EnumMember]
        Polish,
		
        /// <summary>
        /// The ethnic group of Portuguese people.
        /// </summary>
        [DomValIx(1000166)]
        [StringValue("PORTGS")]
        [EnumMember]
        Portuguese,
		
        /// <summary>
        /// The ethnic group of Puerto Rican people.
        /// </summary>
        [DomValIx(1000167)]
        [StringValue("PUERTR")]
        [EnumMember]
        PuertoRican,
		
        /// <summary>
        /// The ethnic group of Pukapuka Islander people.
        /// </summary>
        [DomValIx(1000168)]
        [StringValue("PUKISL")]
        [EnumMember]
        PukapukaIslander,
		
        /// <summary>
        /// The ethnic group of Punjabi people.
        /// </summary>
        [DomValIx(1000169)]
        [StringValue("PUNJAB")]
        [EnumMember]
        Punjabi,
		
        /// <summary>
        /// The ethnic group of Rakahanga Islander people.
        /// </summary>
        [DomValIx(1000170)]
        [StringValue("RAKISL")]
        [EnumMember]
        RakahangaIslander,
		
        /// <summary>
        /// The ethnic group of Rarotongan people.
        /// </summary>
        [DomValIx(1000171)]
        [StringValue("RARTGN")]
        [EnumMember]
        Rarotongan,
		
        /// <summary>
        /// The ethnic group of Romanian/Rumanian people.
        /// </summary>
        [DomValIx(1000172)]
        [StringValue("ROMANN")]
        [EnumMember]
        RomanianRumanian,
		
        /// <summary>
        /// The ethnic group of Romany/Gypsy people.
        /// </summary>
        [DomValIx(1000173)]
        [StringValue("ROMANY")]
        [EnumMember]
        RomanyGypsy,
		
        /// <summary>
        /// The ethnic group of Rotuman/Rotuman Islander people.
        /// </summary>
        [DomValIx(1000174)]
        [StringValue("ROTUMN")]
        [EnumMember]
        RotumanRotumanIslander,
		
        /// <summary>
        /// The ethnic group of Russian people.
        /// </summary>
        [DomValIx(1000175)]
        [StringValue("RUSSAN")]
        [EnumMember]
        Russian,
		
        /// <summary>
        /// The ethnic group of Samoan people.
        /// </summary>
        [DomValIx(1000176)]
        [StringValue("SAMOAN")]
        [EnumMember]
        Samoan,
		
        /// <summary>
        /// The ethnic group of Santa Cruz Islander people.
        /// </summary>
        [DomValIx(1000177)]
        [StringValue("SANISL")]
        [EnumMember]
        SantaCruzIslander,
		
        /// <summary>
        /// The ethnic group of Sardinian people.
        /// </summary>
        [DomValIx(1000178)]
        [StringValue("SARDNN")]
        [EnumMember]
        Sardinian,
		
        /// <summary>
        /// The ethnic group of Scottish (Scots) people.
        /// </summary>
        [DomValIx(1000179)]
        [StringValue("SCOTSH")]
        [EnumMember]
        ScottishScots,
		
        /// <summary>
        /// The ethnic group of Serb/Serbian people.
        /// </summary>
        [DomValIx(1000180)]
        [StringValue("SERBAN")]
        [EnumMember]
        SerbSerbian,
		
        /// <summary>
        /// The ethnic group of Seychelles Islander people.
        /// </summary>
        [DomValIx(1000181)]
        [StringValue("SEYISL")]
        [EnumMember]
        SeychellesIslander,
		
        /// <summary>
        /// The ethnic group of Shetland Islander people.
        /// </summary>
        [DomValIx(1000182)]
        [StringValue("SHTISL")]
        [EnumMember]
        ShetlandIslander,
		
        /// <summary>
        /// The ethnic group of Sikh people.
        /// </summary>
        [DomValIx(1000183)]
        [StringValue("SIKH")]
        [EnumMember]
        Sikh,
		
        /// <summary>
        /// The ethnic group of Singaporean Chinese people.
        /// </summary>
        [DomValIx(1000184)]
        [StringValue("SINCHN")]
        [EnumMember]
        SingaporeanChinese,
		
        /// <summary>
        /// The ethnic group of Sinhalese people.
        /// </summary>
        [DomValIx(1000185)]
        [StringValue("SINHLS")]
        [EnumMember]
        Sinhalese,
		
        /// <summary>
        /// The ethnic group of Slavic/Slav people.
        /// </summary>
        [DomValIx(1000186)]
        [StringValue("SLAVIC")]
        [EnumMember]
        SlavicSlav,
		
        /// <summary>
        /// The ethnic group of Slovak people.
        /// </summary>
        [DomValIx(1000187)]
        [StringValue("SLOVAK")]
        [EnumMember]
        Slovak,
		
        /// <summary>
        /// The ethnic group of Slovene/Slovenian people.
        /// </summary>
        [DomValIx(1000188)]
        [StringValue("SLOVNE")]
        [EnumMember]
        SloveneSlovenian,
		
        /// <summary>
        /// The ethnic group of Society Islander (including Tahitian) people.
        /// </summary>
        [DomValIx(1000189)]
        [StringValue("SOCISL")]
        [EnumMember]
        SocietyIslanderIncludingTahitian,
		
        /// <summary>
        /// The ethnic group of Solomon Islander people.
        /// </summary>
        [DomValIx(1000190)]
        [StringValue("SOLISL")]
        [EnumMember]
        SolomonIslander,
		
        /// <summary>
        /// The ethnic group of Somali people.
        /// </summary>
        [DomValIx(1000191)]
        [StringValue("SOMALI")]
        [EnumMember]
        Somali,
		
        /// <summary>
        /// The ethnic group of South African people.
        /// </summary>
        [DomValIx(1000192)]
        [StringValue("SOUAFR")]
        [EnumMember]
        SouthAfrican,
		
        /// <summary>
        /// The ethnic group of South American Indian people.
        /// </summary>
        [DomValIx(1000193)]
        [StringValue("SOUAMR")]
        [EnumMember]
        SouthAmericanIndian,
		
        /// <summary>
        /// The not further defined ethnic groups of South Slav (formerly Yugoslav groups) people.
        /// </summary>
        [DomValIx(1000194)]
        [StringValue("SLVNFD")]
        [EnumMember]
        SouthSlavFormerlyYugoslavGroupsNotFurtherDefined,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of South Slav (formerly Yugoslav) people.
        /// </summary>
        [DomValIx(1000195)]
        [StringValue("SLVNEC")]
        [EnumMember]
        SouthSlavFormerlyYugoslavNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Southeast Asian people.
        /// </summary>
        [DomValIx(1000196)]
        [StringValue("SOUNFD")]
        [EnumMember]
        SoutheastAsianNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Spanish people.
        /// </summary>
        [DomValIx(1000197)]
        [StringValue("SPANSH")]
        [EnumMember]
        Spanish,
		
        /// <summary>
        /// The not elsewhere classified ethnic groups of Sri Lankan people.
        /// </summary>
        [DomValIx(1000198)]
        [StringValue("SRINEC")]
        [EnumMember]
        SriLankanNotElsewhereClassified,
		
        /// <summary>
        /// The not further defined ethnic groups of Sri Lankan people.
        /// </summary>
        [DomValIx(1000199)]
        [StringValue("SRINFD")]
        [EnumMember]
        SriLankanNotFurtherDefined,
		
        /// <summary>
        /// The ethnic group of Sri Lankan Tamil people.
        /// </summary>
        [DomValIx(1000200)]
        [StringValue("SRITML")]
        [EnumMember]
        SriLankanTamil,
		
        /// <summary>
        /// The ethnic group of Swedish people.
        /// </summary>
        [DomValIx(1000201)]
        [StringValue("SWEDSH")]
        [EnumMember]
        Swedish,
		
        /// <summary>
        /// The ethnic group of Swiss people.
        /// </summary>
        [DomValIx(1000202)]
        [StringValue("SWISS")]
        [EnumMember]
        Swiss,
		
        /// <summary>
        /// The ethnic group of Syrian people.
        /// </summary>
        [DomValIx(1000203)]
        [StringValue("SYRIAN")]
        [EnumMember]
        Syrian,
		
        /// <summary>
        /// The ethnic group of Tahitian (including Society Islander) people.
        /// </summary>
        [DomValIx(1000204)]
        [StringValue("TAHITN")]
        [EnumMember]
        TahitianIncludingSocietyIslander,
		
        /// <summary>
        /// The ethnic group of Taiwanese Chinese people.
        /// </summary>
        [DomValIx(1000205)]
        [StringValue("TAICHN")]
        [EnumMember]
        TaiwaneseChinese,
		
        /// <summary>
        /// The ethnic group of Tamil people.
        /// </summary>
        [DomValIx(1000206)]
        [StringValue("TAMIL")]
        [EnumMember]
        Tamil,
		
        /// <summary>
        /// The ethnic group of Thai/Tai/Siamese people.
        /// </summary>
        [DomValIx(1000207)]
        [StringValue("THAI")]
        [EnumMember]
        ThaiTaiSiamese,
		
        /// <summary>
        /// The ethnic group of Tibetan people.
        /// </summary>
        [DomValIx(1000208)]
        [StringValue("TIBETN")]
        [EnumMember]
        Tibetan,
		
        /// <summary>
        /// The ethnic group of Tokelauan people.
        /// </summary>
        [DomValIx(1000209)]
        [StringValue("TOKELN")]
        [EnumMember]
        Tokelauan,
		
        /// <summary>
        /// The ethnic group of Tongan people.
        /// </summary>
        [DomValIx(1000210)]
        [StringValue("TONGAN")]
        [EnumMember]
        Tongan,
		
        /// <summary>
        /// The ethnic group of Torres Strait Islander/Thursday Islander people.
        /// </summary>
        [DomValIx(1000211)]
        [StringValue("TORISL")]
        [EnumMember]
        TorresStraitIslanderThursdayIslander,
		
        /// <summary>
        /// The ethnic group of Tuamotu Islander people.
        /// </summary>
        [DomValIx(1000212)]
        [StringValue("TUAISL")]
        [EnumMember]
        TuamotuIslander,
		
        /// <summary>
        /// The ethnic group of Tunisian people.
        /// </summary>
        [DomValIx(1000213)]
        [StringValue("TUNISN")]
        [EnumMember]
        Tunisian,
		
        /// <summary>
        /// The ethnic group of Turkish (incl Turkish Cypriot) people.
        /// </summary>
        [DomValIx(1000214)]
        [StringValue("TURKSH")]
        [EnumMember]
        TurkishInclTurkishCypriot,
		
        /// <summary>
        /// The ethnic group of Tuvalu Islander/Ellice Islander people.
        /// </summary>
        [DomValIx(1000215)]
        [StringValue("TUVISL")]
        [EnumMember]
        TuvaluIslanderElliceIslander,
		
        /// <summary>
        /// The ethnic group of Ugandan people.
        /// </summary>
        [DomValIx(1000216)]
        [StringValue("UGANDN")]
        [EnumMember]
        Ugandan,
		
        /// <summary>
        /// The ethnic group of Ukrainian people.
        /// </summary>
        [DomValIx(1000217)]
        [StringValue("UKRANN")]
        [EnumMember]
        Ukrainian,
		
        /// <summary>
        /// The ethnic group of Uruguayan people.
        /// </summary>
        [DomValIx(1000218)]
        [StringValue("URUGYN")]
        [EnumMember]
        Uruguayan,
		
        /// <summary>
        /// The ethnic group of Vanuatu Islander/New Hebridean people.
        /// </summary>
        [DomValIx(1000219)]
        [StringValue("VANUAT")]
        [EnumMember]
        VanuatuIslanderNewHebridean,
		
        /// <summary>
        /// The ethnic group of Venezuelan people.
        /// </summary>
        [DomValIx(1000220)]
        [StringValue("VENEZN")]
        [EnumMember]
        Venezuelan,
		
        /// <summary>
        /// The ethnic group of Vietnamese people.
        /// </summary>
        [DomValIx(1000221)]
        [StringValue("VIETNM")]
        [EnumMember]
        Vietnamese,
		
        /// <summary>
        /// The ethnic group of Vietnamese Chinese people.
        /// </summary>
        [DomValIx(1000222)]
        [StringValue("VITCHN")]
        [EnumMember]
        VietnameseChinese,
		
        /// <summary>
        /// The ethnic group of Wake Islander people.
        /// </summary>
        [DomValIx(1000223)]
        [StringValue("WAKISL")]
        [EnumMember]
        WakeIslander,
		
        /// <summary>
        /// The ethnic group of Wallis Islander people.
        /// </summary>
        [DomValIx(1000224)]
        [StringValue("WALISL")]
        [EnumMember]
        WallisIslander,
		
        /// <summary>
        /// The ethnic group of Welsh people.
        /// </summary>
        [DomValIx(1000225)]
        [StringValue("WELSH")]
        [EnumMember]
        Welsh,
		
        /// <summary>
        /// The ethnic group of West Indian/Caribbean people.
        /// </summary>
        [DomValIx(1000226)]
        [StringValue("WSTIND")]
        [EnumMember]
        WestIndianCaribbean,
		
        /// <summary>
        /// The ethnic group of Yap Islander people.
        /// </summary>
        [DomValIx(1000227)]
        [StringValue("YAPISL")]
        [EnumMember]
        YapIslander,
		
        /// <summary>
        /// The ethnic group of Yemeni people.
        /// </summary>
        [DomValIx(1000228)]
        [StringValue("YEMENI")]
        [EnumMember]
        Yemeni,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000229)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The ethnic group of Abkhaz people.
        /// </summary>
        [DomValIx(1000230)]
        [StringValue("ABKHAZ")]
        [EnumMember]
        Abkhaz,
		
        /// <summary>
        /// The ethnic group of Aboriginal people.
        /// </summary>
        [DomValIx(1000231)]
        [StringValue("ABORGN")]
        [EnumMember]
        Aboriginal,
		
        /// <summary>
        /// The ethnic group of Afar people.
        /// </summary>
        [DomValIx(1000232)]
        [StringValue("AFAR")]
        [EnumMember]
        Afar,
		
        /// <summary>
        /// The ethnic group of African (Adja) people.
        /// </summary>
        [DomValIx(1000233)]
        [StringValue("AFRADJ")]
        [EnumMember]
        AfricanAdja,
		
        /// <summary>
        /// The ethnic group of African (Balanta) people.
        /// </summary>
        [DomValIx(1000234)]
        [StringValue("AFRBAL")]
        [EnumMember]
        AfricanBalanta,
		
        /// <summary>
        /// The ethnic group of African (Bariba) people.
        /// </summary>
        [DomValIx(1000235)]
        [StringValue("AFRBAR")]
        [EnumMember]
        AfricanBariba,
		
        /// <summary>
        /// The ethnic group of African (Bassa) people.
        /// </summary>
        [DomValIx(1000236)]
        [StringValue("AFRBAS")]
        [EnumMember]
        AfricanBassa,
		
        /// <summary>
        /// The ethnic group of African (Bella) people.
        /// </summary>
        [DomValIx(1000237)]
        [StringValue("AFRBEL")]
        [EnumMember]
        AfricanBella,
		
        /// <summary>
        /// The ethnic group of African (Burkinabe) people.
        /// </summary>
        [DomValIx(1000238)]
        [StringValue("AFRBUR")]
        [EnumMember]
        AfricanBurkinabe,
		
        /// <summary>
        /// The ethnic group of African (Fon) people.
        /// </summary>
        [DomValIx(1000239)]
        [StringValue("AFRFON")]
        [EnumMember]
        AfricanFon,
		
        /// <summary>
        /// The ethnic group of African (Fula) people.
        /// </summary>
        [DomValIx(1000240)]
        [StringValue("AFRFUL")]
        [EnumMember]
        AfricanFula,
		
        /// <summary>
        /// The ethnic group of African (Gbandi) people.
        /// </summary>
        [DomValIx(1000241)]
        [StringValue("AFRGBA")]
        [EnumMember]
        AfricanGbandi,
		
        /// <summary>
        /// The ethnic group of African (Gio) people.
        /// </summary>
        [DomValIx(1000242)]
        [StringValue("AFRGIO")]
        [EnumMember]
        AfricanGio,
		
        /// <summary>
        /// The ethnic group of African (Gola) people.
        /// </summary>
        [DomValIx(1000243)]
        [StringValue("AFRGOL")]
        [EnumMember]
        AfricanGola,
		
        /// <summary>
        /// The ethnic group of African (Grebo) people.
        /// </summary>
        [DomValIx(1000244)]
        [StringValue("AFRGRE")]
        [EnumMember]
        AfricanGrebo,
		
        /// <summary>
        /// The ethnic group of African (Jola) people.
        /// </summary>
        [DomValIx(1000245)]
        [StringValue("AFRJOL")]
        [EnumMember]
        AfricanJola,
		
        /// <summary>
        /// The ethnic group of African (Kissi) people.
        /// </summary>
        [DomValIx(1000246)]
        [StringValue("AFRKIS")]
        [EnumMember]
        AfricanKissi,
		
        /// <summary>
        /// The ethnic group of African (Kpelle) people.
        /// </summary>
        [DomValIx(1000247)]
        [StringValue("AFRKPE")]
        [EnumMember]
        AfricanKpelle,
		
        /// <summary>
        /// The ethnic group of African (Krahn) people.
        /// </summary>
        [DomValIx(1000248)]
        [StringValue("AFRKRA")]
        [EnumMember]
        AfricanKrahn,
		
        /// <summary>
        /// The ethnic group of African (Kru) people.
        /// </summary>
        [DomValIx(1000249)]
        [StringValue("AFRKRU")]
        [EnumMember]
        AfricanKru,
		
        /// <summary>
        /// The ethnic group of African (Loma) people.
        /// </summary>
        [DomValIx(1000250)]
        [StringValue("AFRLOM")]
        [EnumMember]
        AfricanLoma,
		
        /// <summary>
        /// The ethnic group of African (Mandinga) people.
        /// </summary>
        [DomValIx(1000251)]
        [StringValue("AFRMAN")]
        [EnumMember]
        AfricanMandinga,
		
        /// <summary>
        /// The ethnic group of African (Mandinka) people.
        /// </summary>
        [DomValIx(1000252)]
        [StringValue("AFRMND")]
        [EnumMember]
        AfricanMandinka,
		
        /// <summary>
        /// The ethnic group of African (Manjaca) people.
        /// </summary>
        [DomValIx(1000253)]
        [StringValue("AFRMNJ")]
        [EnumMember]
        AfricanManjaca,
		
        /// <summary>
        /// The ethnic group of African (Mano) people.
        /// </summary>
        [DomValIx(1000254)]
        [StringValue("AFRMNO")]
        [EnumMember]
        AfricanMano,
		
        /// <summary>
        /// The ethnic group of African (Mende) people.
        /// </summary>
        [DomValIx(1000255)]
        [StringValue("AFRMEN")]
        [EnumMember]
        AfricanMende,
		
        /// <summary>
        /// The ethnic group of African (Ndebele) people.
        /// </summary>
        [DomValIx(1000256)]
        [StringValue("AFRNDE")]
        [EnumMember]
        AfricanNdebele,
		
        /// <summary>
        /// The ethnic group of African (Papel) people.
        /// </summary>
        [DomValIx(1000257)]
        [StringValue("AFRPAP")]
        [EnumMember]
        AfricanPapel,
		
        /// <summary>
        /// The ethnic group of African (Serahuli) people.
        /// </summary>
        [DomValIx(1000258)]
        [StringValue("AFRSER")]
        [EnumMember]
        AfricanSerahuli,
		
        /// <summary>
        /// The ethnic group of African (Shona) people.
        /// </summary>
        [DomValIx(1000259)]
        [StringValue("AFRSHO")]
        [EnumMember]
        AfricanShona,
		
        /// <summary>
        /// The ethnic group of African (Temne) people.
        /// </summary>
        [DomValIx(1000260)]
        [StringValue("AFRTEM")]
        [EnumMember]
        AfricanTemne,
		
        /// <summary>
        /// The ethnic group of African (Vai) people.
        /// </summary>
        [DomValIx(1000261)]
        [StringValue("AFRVAI")]
        [EnumMember]
        AfricanVai,
		
        /// <summary>
        /// The ethnic group of African (Wolof) people.
        /// </summary>
        [DomValIx(1000262)]
        [StringValue("AFRWOL")]
        [EnumMember]
        AfricanWolof,
		
        /// <summary>
        /// The ethnic group of African (Yoruba) people.
        /// </summary>
        [DomValIx(1000263)]
        [StringValue("AFRYOR")]
        [EnumMember]
        AfricanYoruba,
		
        /// <summary>
        /// The ethnic group of Afro-Arab people.
        /// </summary>
        [DomValIx(1000264)]
        [StringValue("AFROAR")]
        [EnumMember]
        AfroArab,
		
        /// <summary>
        /// The ethnic group of Afro-Asian people.
        /// </summary>
        [DomValIx(1000265)]
        [StringValue("AFROAS")]
        [EnumMember]
        AfroAsian,
		
        /// <summary>
        /// The ethnic group of Afro-Chinese people.
        /// </summary>
        [DomValIx(1000266)]
        [StringValue("AFROCH")]
        [EnumMember]
        AfroChinese,
		
        /// <summary>
        /// The ethnic group of Afro-East Indian people.
        /// </summary>
        [DomValIx(1000267)]
        [StringValue("AFROEA")]
        [EnumMember]
        AfroEastIndian,
		
        /// <summary>
        /// The ethnic group of Afro-European people.
        /// </summary>
        [DomValIx(1000268)]
        [StringValue("AFROEU")]
        [EnumMember]
        AfroEuropean,
		
        /// <summary>
        /// The ethnic group of Agni people.
        /// </summary>
        [DomValIx(1000269)]
        [StringValue("AGNI")]
        [EnumMember]
        Agni,
		
        /// <summary>
        /// The ethnic group of Albanian-Italians people.
        /// </summary>
        [DomValIx(1000270)]
        [StringValue("ALBANN")]
        [EnumMember]
        AlbanianItalians,
		
        /// <summary>
        /// The ethnic group of Alemannic people.
        /// </summary>
        [DomValIx(1000271)]
        [StringValue("ALEMAN")]
        [EnumMember]
        Alemannic,
		
        /// <summary>
        /// The ethnic group of Americo-Liberians people.
        /// </summary>
        [DomValIx(1000272)]
        [StringValue("AMERIC")]
        [EnumMember]
        AmericoLiberians,
		
        /// <summary>
        /// The ethnic group of Amerindian people.
        /// </summary>
        [DomValIx(1000273)]
        [StringValue("AMERIN")]
        [EnumMember]
        Amerindian,
		
        /// <summary>
        /// The ethnic group of Amhara people.
        /// </summary>
        [DomValIx(1000274)]
        [StringValue("AMHARA")]
        [EnumMember]
        Amhara,
		
        /// <summary>
        /// The ethnic group of Andorran people.
        /// </summary>
        [DomValIx(1000275)]
        [StringValue("ANDORR")]
        [EnumMember]
        Andorran,
		
        /// <summary>
        /// The ethnic group of Angolares people.
        /// </summary>
        [DomValIx(1000276)]
        [StringValue("ANGOLA")]
        [EnumMember]
        Angolares,
		
        /// <summary>
        /// The ethnic group of Antaisaka people.
        /// </summary>
        [DomValIx(1000277)]
        [StringValue("ANTASA")]
        [EnumMember]
        Antaisaka,
		
        /// <summary>
        /// The ethnic group of Arab-Berber people.
        /// </summary>
        [DomValIx(1000278)]
        [StringValue("ARABBE")]
        [EnumMember]
        ArabBerber,
		
        /// <summary>
        /// The ethnic group of Aymara people.
        /// </summary>
        [DomValIx(1000279)]
        [StringValue("AYMARA")]
        [EnumMember]
        Aymara,
		
        /// <summary>
        /// The ethnic group of Azerbaijani people.
        /// </summary>
        [DomValIx(1000280)]
        [StringValue("AZERBA")]
        [EnumMember]
        Azerbaijani,
		
        /// <summary>
        /// The ethnic group of Azeri people.
        /// </summary>
        [DomValIx(1000281)]
        [StringValue("AZERI")]
        [EnumMember]
        Azeri,
		
        /// <summary>
        /// The ethnic group of Bahraini people.
        /// </summary>
        [DomValIx(1000282)]
        [StringValue("BAHRAN")]
        [EnumMember]
        Bahraini,
		
        /// <summary>
        /// The ethnic group of Bakongo people.
        /// </summary>
        [DomValIx(1000283)]
        [StringValue("BAKONG")]
        [EnumMember]
        Bakongo,
		
        /// <summary>
        /// The ethnic group of Baloch people.
        /// </summary>
        [DomValIx(1000284)]
        [StringValue("BALOCH")]
        [EnumMember]
        Baloch,
		
        /// <summary>
        /// The ethnic group of Banda people.
        /// </summary>
        [DomValIx(1000285)]
        [StringValue("BANDA")]
        [EnumMember]
        Banda,
		
        /// <summary>
        /// The ethnic group of Bantu people.
        /// </summary>
        [DomValIx(1000286)]
        [StringValue("BANTU")]
        [EnumMember]
        Bantu,
		
        /// <summary>
        /// The ethnic group of Bantu (Bapounou) people.
        /// </summary>
        [DomValIx(1000287)]
        [StringValue("BANTBA")]
        [EnumMember]
        BantuBapounou,
		
        /// <summary>
        /// The ethnic group of Bantu (Bateke) people.
        /// </summary>
        [DomValIx(1000288)]
        [StringValue("BANTBT")]
        [EnumMember]
        BantuBateke,
		
        /// <summary>
        /// The ethnic group of Bantu (Eshira) people.
        /// </summary>
        [DomValIx(1000289)]
        [StringValue("BANTES")]
        [EnumMember]
        BantuEshira,
		
        /// <summary>
        /// The ethnic group of Bantu (Fang) people.
        /// </summary>
        [DomValIx(1000290)]
        [StringValue("BANTFA")]
        [EnumMember]
        BantuFang,
		
        /// <summary>
        /// The ethnic group of Bantu (Kongo) people.
        /// </summary>
        [DomValIx(1000291)]
        [StringValue("BANTKO")]
        [EnumMember]
        BantuKongo,
		
        /// <summary>
        /// The ethnic group of Bantu (Luba) people.
        /// </summary>
        [DomValIx(1000292)]
        [StringValue("BANTLU")]
        [EnumMember]
        BantuLuba,
		
        /// <summary>
        /// The ethnic group of Bantu (Mongo) people.
        /// </summary>
        [DomValIx(1000293)]
        [StringValue("BANTMO")]
        [EnumMember]
        BantuMongo,
		
        /// <summary>
        /// The ethnic group of Baoule people.
        /// </summary>
        [DomValIx(1000294)]
        [StringValue("BAOULE")]
        [EnumMember]
        Baoule,
		
        /// <summary>
        /// The ethnic group of Basarwa people.
        /// </summary>
        [DomValIx(1000295)]
        [StringValue("BASARW")]
        [EnumMember]
        Basarwa,
		
        /// <summary>
        /// The ethnic group of Bashkir people.
        /// </summary>
        [DomValIx(1000296)]
        [StringValue("BASHKR")]
        [EnumMember]
        Bashkir,
		
        /// <summary>
        /// The ethnic group of Basque people.
        /// </summary>
        [DomValIx(1000297)]
        [StringValue("BASQUE")]
        [EnumMember]
        Basque,
		
        /// <summary>
        /// The ethnic group of Batswana people.
        /// </summary>
        [DomValIx(1000298)]
        [StringValue("BATSWA")]
        [EnumMember]
        Batswana,
		
        /// <summary>
        /// The ethnic group of Baya people.
        /// </summary>
        [DomValIx(1000299)]
        [StringValue("BAYA")]
        [EnumMember]
        Baya,
		
        /// <summary>
        /// The ethnic group of Beja people.
        /// </summary>
        [DomValIx(1000300)]
        [StringValue("BEJA")]
        [EnumMember]
        Beja,
		
        /// <summary>
        /// The ethnic group of Belorussian people.
        /// </summary>
        [DomValIx(1000301)]
        [StringValue("BELORU")]
        [EnumMember]
        Belorussian,
		
        /// <summary>
        /// The ethnic group of Berber people.
        /// </summary>
        [DomValIx(1000302)]
        [StringValue("BERBER")]
        [EnumMember]
        Berber,
		
        /// <summary>
        /// The ethnic group of Beri (Kanouri) people.
        /// </summary>
        [DomValIx(1000303)]
        [StringValue("BERIKA")]
        [EnumMember]
        BeriKanouri,
		
        /// <summary>
        /// The ethnic group of Bete people.
        /// </summary>
        [DomValIx(1000304)]
        [StringValue("BETE")]
        [EnumMember]
        Bete,
		
        /// <summary>
        /// The ethnic group of Betsimisaraka people.
        /// </summary>
        [DomValIx(1000305)]
        [StringValue("BETSIM")]
        [EnumMember]
        Betsimisaraka,
		
        /// <summary>
        /// The ethnic group of Bhote people.
        /// </summary>
        [DomValIx(1000306)]
        [StringValue("BHOTE")]
        [EnumMember]
        Bhote,
		
        /// <summary>
        /// The ethnic group of Bhotias people.
        /// </summary>
        [DomValIx(1000307)]
        [StringValue("BHOTIA")]
        [EnumMember]
        Bhotias,
		
        /// <summary>
        /// The ethnic group of Biharis people.
        /// </summary>
        [DomValIx(1000308)]
        [StringValue("BIHARS")]
        [EnumMember]
        Biharis,
		
        /// <summary>
        /// The ethnic group of Bioko (Bubi) people.
        /// </summary>
        [DomValIx(1000309)]
        [StringValue("BIOKOB")]
        [EnumMember]
        BiokoBubi,
		
        /// <summary>
        /// The ethnic group of Bioko (Fernandinos) people.
        /// </summary>
        [DomValIx(1000310)]
        [StringValue("BIOKOF")]
        [EnumMember]
        BiokoFernandinos,
		
        /// <summary>
        /// The ethnic group of Black African people.
        /// </summary>
        [DomValIx(1000311)]
        [StringValue("BLACKA")]
        [EnumMember]
        BlackAfrican,
		
        /// <summary>
        /// The ethnic group of Bobo people.
        /// </summary>
        [DomValIx(1000312)]
        [StringValue("BOBO")]
        [EnumMember]
        Bobo,
		
        /// <summary>
        /// The ethnic group of Bosnian Croat people.
        /// </summary>
        [DomValIx(1000313)]
        [StringValue("BOSCRO")]
        [EnumMember]
        BosnianCroat,
		
        /// <summary>
        /// The ethnic group of Bosnian Muslim people.
        /// </summary>
        [DomValIx(1000314)]
        [StringValue("BOSMUS")]
        [EnumMember]
        BosnianMuslim,
		
        /// <summary>
        /// The ethnic group of Bosnian Serb people.
        /// </summary>
        [DomValIx(1000315)]
        [StringValue("BOSSER")]
        [EnumMember]
        BosnianSerb,
		
        /// <summary>
        /// The ethnic group of Bretons people.
        /// </summary>
        [DomValIx(1000316)]
        [StringValue("BRETON")]
        [EnumMember]
        Bretons,
		
        /// <summary>
        /// The ethnic group of Burman people.
        /// </summary>
        [DomValIx(1000317)]
        [StringValue("BURMAN")]
        [EnumMember]
        Burman,
		
        /// <summary>
        /// The ethnic group of Buyi people.
        /// </summary>
        [DomValIx(1000318)]
        [StringValue("BUYI")]
        [EnumMember]
        Buyi,
		
        /// <summary>
        /// The ethnic group of Cafre people.
        /// </summary>
        [DomValIx(1000319)]
        [StringValue("CAFRE")]
        [EnumMember]
        Cafre,
		
        /// <summary>
        /// The ethnic group of Cameroon Highlanders people.
        /// </summary>
        [DomValIx(1000320)]
        [StringValue("CAMERO")]
        [EnumMember]
        CameroonHighlanders,
		
        /// <summary>
        /// The ethnic group of Carib Indian people.
        /// </summary>
        [DomValIx(1000321)]
        [StringValue("CARIBN")]
        [EnumMember]
        CaribIndian,
		
        /// <summary>
        /// The ethnic group of Caucasian people.
        /// </summary>
        [DomValIx(1000322)]
        [StringValue("CAUCAS")]
        [EnumMember]
        Caucasian,
		
        /// <summary>
        /// The ethnic group of Chahar Aimaks people.
        /// </summary>
        [DomValIx(1000323)]
        [StringValue("CHAHAR")]
        [EnumMember]
        ChaharAimaks,
		
        /// <summary>
        /// The ethnic group of Cham people.
        /// </summary>
        [DomValIx(1000324)]
        [StringValue("CHAM")]
        [EnumMember]
        Cham,
		
        /// <summary>
        /// The ethnic group of Chamorro people.
        /// </summary>
        [DomValIx(1000325)]
        [StringValue("CHAMOR")]
        [EnumMember]
        Chamorro,
		
        /// <summary>
        /// The ethnic group of Chewa people.
        /// </summary>
        [DomValIx(1000326)]
        [StringValue("CHEWA")]
        [EnumMember]
        Chewa,
		
        /// <summary>
        /// The ethnic group of Christian Malay people.
        /// </summary>
        [DomValIx(1000327)]
        [StringValue("CHRSTN")]
        [EnumMember]
        ChristianMalay,
		
        /// <summary>
        /// The ethnic group of Chuvash people.
        /// </summary>
        [DomValIx(1000328)]
        [StringValue("CHUVAS")]
        [EnumMember]
        Chuvash,
		
        /// <summary>
        /// The ethnic group of Circassian people.
        /// </summary>
        [DomValIx(1000329)]
        [StringValue("CIRCAS")]
        [EnumMember]
        Circassian,
		
        /// <summary>
        /// The ethnic group of Coastal Malays people.
        /// </summary>
        [DomValIx(1000330)]
        [StringValue("COASTA")]
        [EnumMember]
        CoastalMalays,
		
        /// <summary>
        /// The ethnic group of Cocos Malays people.
        /// </summary>
        [DomValIx(1000331)]
        [StringValue("COCOSM")]
        [EnumMember]
        CocosMalays,
		
        /// <summary>
        /// The ethnic group of Comoran people.
        /// </summary>
        [DomValIx(1000332)]
        [StringValue("COMORA")]
        [EnumMember]
        Comoran,
		
        /// <summary>
        /// The ethnic group of Cotiers people.
        /// </summary>
        [DomValIx(1000333)]
        [StringValue("COTIER")]
        [EnumMember]
        Cotiers,
		
        /// <summary>
        /// The ethnic group of Creole people.
        /// </summary>
        [DomValIx(1000334)]
        [StringValue("CREOLE")]
        [EnumMember]
        Creole,
		
        /// <summary>
        /// The ethnic group of Creole (Mulatto) people.
        /// </summary>
        [DomValIx(1000335)]
        [StringValue("CREOLM")]
        [EnumMember]
        CreoleMulatto,
		
        /// <summary>
        /// The ethnic group of Daghestanis people.
        /// </summary>
        [DomValIx(1000336)]
        [StringValue("DAGHES")]
        [EnumMember]
        Daghestanis,
		
        /// <summary>
        /// The ethnic group of Diola people.
        /// </summary>
        [DomValIx(1000337)]
        [StringValue("DIOLA")]
        [EnumMember]
        Diola,
		
        /// <summary>
        /// The ethnic group of Djerma people.
        /// </summary>
        [DomValIx(1000338)]
        [StringValue("DJERMA")]
        [EnumMember]
        Djerma,
		
        /// <summary>
        /// The ethnic group of Dravidian people.
        /// </summary>
        [DomValIx(1000339)]
        [StringValue("DRAVID")]
        [EnumMember]
        Dravidian,
		
        /// <summary>
        /// The ethnic group of Equatorial Bantu people.
        /// </summary>
        [DomValIx(1000340)]
        [StringValue("EQUATO")]
        [EnumMember]
        EquatorialBantu,
		
        /// <summary>
        /// The ethnic group of Eririan people.
        /// </summary>
        [DomValIx(1000341)]
        [StringValue("ERIRIA")]
        [EnumMember]
        Eririan,
		
        /// <summary>
        /// The ethnic group of Ethnic Nepalese people.
        /// </summary>
        [DomValIx(1000342)]
        [StringValue("ETHNCN")]
        [EnumMember]
        EthnicNepalese,
		
        /// <summary>
        /// The ethnic group of Ethnic Tigrays people.
        /// </summary>
        [DomValIx(1000343)]
        [StringValue("ETHNCT")]
        [EnumMember]
        EthnicTigrays,
		
        /// <summary>
        /// The ethnic group of Euro-Africans people.
        /// </summary>
        [DomValIx(1000344)]
        [StringValue("EUROAF")]
        [EnumMember]
        EuroAfricans,
		
        /// <summary>
        /// The ethnic group of Euronesians people.
        /// </summary>
        [DomValIx(1000345)]
        [StringValue("EUROIN")]
        [EnumMember]
        Euronesians,
		
        /// <summary>
        /// The ethnic group of European-Indian people.
        /// </summary>
        [DomValIx(1000346)]
        [StringValue("EUROPE")]
        [EnumMember]
        EuropeanIndian,
		
        /// <summary>
        /// The ethnic group of Ewe people.
        /// </summary>
        [DomValIx(1000347)]
        [StringValue("EWE")]
        [EnumMember]
        Ewe,
		
        /// <summary>
        /// The ethnic group of Faroese people.
        /// </summary>
        [DomValIx(1000348)]
        [StringValue("FAROES")]
        [EnumMember]
        Faroese,
		
        /// <summary>
        /// The ethnic group of Forros people.
        /// </summary>
        [DomValIx(1000349)]
        [StringValue("FORROS")]
        [EnumMember]
        Forros,
		
        /// <summary>
        /// The ethnic group of Franco-Mauritian people.
        /// </summary>
        [DomValIx(1000350)]
        [StringValue("FRANCO")]
        [EnumMember]
        FrancoMauritian,
		
        /// <summary>
        /// The ethnic group of Fula people.
        /// </summary>
        [DomValIx(1000351)]
        [StringValue("FULA")]
        [EnumMember]
        Fula,
		
        /// <summary>
        /// The ethnic group of Fulani people.
        /// </summary>
        [DomValIx(1000352)]
        [StringValue("FULANI")]
        [EnumMember]
        Fulani,
		
        /// <summary>
        /// The ethnic group of Gagauz people.
        /// </summary>
        [DomValIx(1000353)]
        [StringValue("GAGAUZ")]
        [EnumMember]
        Gagauz,
		
        /// <summary>
        /// The ethnic group of Garifuna people.
        /// </summary>
        [DomValIx(1000354)]
        [StringValue("GARIFU")]
        [EnumMember]
        Garifuna,
		
        /// <summary>
        /// The ethnic group of Georgian people.
        /// </summary>
        [DomValIx(1000355)]
        [StringValue("GEORGN")]
        [EnumMember]
        Georgian,
		
        /// <summary>
        /// The ethnic group of Germanic (Alpine) people.
        /// </summary>
        [DomValIx(1000356)]
        [StringValue("GERMAL")]
        [EnumMember]
        GermanicAlpine,
		
        /// <summary>
        /// The ethnic group of Germanic (Baltic) people.
        /// </summary>
        [DomValIx(1000357)]
        [StringValue("GERMAB")]
        [EnumMember]
        GermanicBaltic,
		
        /// <summary>
        /// The ethnic group of Germanic (Nordic) people.
        /// </summary>
        [DomValIx(1000358)]
        [StringValue("GERMAR")]
        [EnumMember]
        GermanicNordic,
		
        /// <summary>
        /// The ethnic group of Gilaki people.
        /// </summary>
        [DomValIx(1000359)]
        [StringValue("GILAKI")]
        [EnumMember]
        Gilaki,
		
        /// <summary>
        /// The ethnic group of Goulaye people.
        /// </summary>
        [DomValIx(1000360)]
        [StringValue("GOULAY")]
        [EnumMember]
        Goulaye,
		
        /// <summary>
        /// The ethnic group of Gourmantche people.
        /// </summary>
        [DomValIx(1000361)]
        [StringValue("GOURMA")]
        [EnumMember]
        Gourmantche,
		
        /// <summary>
        /// The ethnic group of Greek-Italians people.
        /// </summary>
        [DomValIx(1000362)]
        [StringValue("GREEKT")]
        [EnumMember]
        GreekItalians,
		
        /// <summary>
        /// The ethnic group of Greenlander (Caucasian) people.
        /// </summary>
        [DomValIx(1000363)]
        [StringValue("GREENC")]
        [EnumMember]
        GreenlanderCaucasian,
		
        /// <summary>
        /// The ethnic group of Greenlander (Eskimo) people.
        /// </summary>
        [DomValIx(1000364)]
        [StringValue("GREENA")]
        [EnumMember]
        GreenlanderEskimo,
		
        /// <summary>
        /// The ethnic group of Gurage people.
        /// </summary>
        [DomValIx(1000365)]
        [StringValue("GURAGE")]
        [EnumMember]
        Gurage,
		
        /// <summary>
        /// The ethnic group of Gurungs people.
        /// </summary>
        [DomValIx(1000366)]
        [StringValue("GURUNG")]
        [EnumMember]
        Gurungs,
		
        /// <summary>
        /// The ethnic group of Gurunsi people.
        /// </summary>
        [DomValIx(1000367)]
        [StringValue("GURUNS")]
        [EnumMember]
        Gurunsi,
		
        /// <summary>
        /// The ethnic group of Gypsy people.
        /// </summary>
        [DomValIx(1000368)]
        [StringValue("GYPSY")]
        [EnumMember]
        Gypsy,
		
        /// <summary>
        /// The ethnic group of Hamitic people.
        /// </summary>
        [DomValIx(1000369)]
        [StringValue("HAMTC")]
        [EnumMember]
        Hamitic,
		
        /// <summary>
        /// The ethnic group of Hamitic (Mangbetu-Azande) people.
        /// </summary>
        [DomValIx(1000370)]
        [StringValue("HAMTCM")]
        [EnumMember]
        HamiticMangbetuAzande,
		
        /// <summary>
        /// The ethnic group of Han Chinese people.
        /// </summary>
        [DomValIx(1000371)]
        [StringValue("HAN")]
        [EnumMember]
        HanChinese,
		
        /// <summary>
        /// The ethnic group of Hausa people.
        /// </summary>
        [DomValIx(1000372)]
        [StringValue("HAUSA")]
        [EnumMember]
        Hausa,
		
        /// <summary>
        /// The ethnic group of Hazara people.
        /// </summary>
        [DomValIx(1000373)]
        [StringValue("HAZARA")]
        [EnumMember]
        Hazara,
		
        /// <summary>
        /// The ethnic group of Hindustani people.
        /// </summary>
        [DomValIx(1000374)]
        [StringValue("HINDUS")]
        [EnumMember]
        Hindustani,
		
        /// <summary>
        /// The ethnic group of Hispanic people.
        /// </summary>
        [DomValIx(1000375)]
        [StringValue("HISPAN")]
        [EnumMember]
        Hispanic,
		
        /// <summary>
        /// The ethnic group of Hmong people.
        /// </summary>
        [DomValIx(1000376)]
        [StringValue("HMONG")]
        [EnumMember]
        Hmong,
		
        /// <summary>
        /// The ethnic group of Hui people.
        /// </summary>
        [DomValIx(1000377)]
        [StringValue("HUI")]
        [EnumMember]
        Hui,
		
        /// <summary>
        /// The ethnic group of Hutu people.
        /// </summary>
        [DomValIx(1000378)]
        [StringValue("HUTU")]
        [EnumMember]
        Hutu,
		
        /// <summary>
        /// The ethnic group of Hutu (Bantu) people.
        /// </summary>
        [DomValIx(1000379)]
        [StringValue("HUTUBA")]
        [EnumMember]
        HutuBantu,
		
        /// <summary>
        /// The ethnic group of Ibos people.
        /// </summary>
        [DomValIx(1000380)]
        [StringValue("IBOS")]
        [EnumMember]
        Ibos,
		
        /// <summary>
        /// The ethnic group of Indigenous Eskimo people.
        /// </summary>
        [DomValIx(1000381)]
        [StringValue("INDIGE")]
        [EnumMember]
        IndigenousEskimo,
		
        /// <summary>
        /// The ethnic group of Indigenous Indian people.
        /// </summary>
        [DomValIx(1000382)]
        [StringValue("INDIGN")]
        [EnumMember]
        IndigenousIndian,
		
        /// <summary>
        /// The ethnic group of Indigenous Melanesian people.
        /// </summary>
        [DomValIx(1000383)]
        [StringValue("INDIGM")]
        [EnumMember]
        IndigenousMelanesian,
		
        /// <summary>
        /// The ethnic group of Indo-Aryan people.
        /// </summary>
        [DomValIx(1000384)]
        [StringValue("INDOAR")]
        [EnumMember]
        IndoAryan,
		
        /// <summary>
        /// The ethnic group of Indo-Mauritian people.
        /// </summary>
        [DomValIx(1000385)]
        [StringValue("INDOMA")]
        [EnumMember]
        IndoMauritian,
		
        /// <summary>
        /// The ethnic group of Indochinese people.
        /// </summary>
        [DomValIx(1000386)]
        [StringValue("INDOCH")]
        [EnumMember]
        Indochinese,
		
        /// <summary>
        /// The ethnic group of Italian-French people.
        /// </summary>
        [DomValIx(1000387)]
        [StringValue("ITALFR")]
        [EnumMember]
        ItalianFrench,
		
        /// <summary>
        /// The ethnic group of Italian-German people.
        /// </summary>
        [DomValIx(1000388)]
        [StringValue("ITALGE")]
        [EnumMember]
        ItalianGerman,
		
        /// <summary>
        /// The ethnic group of Italian-Slovene people.
        /// </summary>
        [DomValIx(1000389)]
        [StringValue("ITALSL")]
        [EnumMember]
        ItalianSlovene,
		
        /// <summary>
        /// The ethnic group of Javanese people.
        /// </summary>
        [DomValIx(1000390)]
        [StringValue("JAVANE")]
        [EnumMember]
        Javanese,
		
        /// <summary>
        /// The ethnic group of Jewish people.
        /// </summary>
        [DomValIx(1000391)]
        [StringValue("JEWISH")]
        [EnumMember]
        Jewish,
		
        /// <summary>
        /// The ethnic group of Kabye people.
        /// </summary>
        [DomValIx(1000392)]
        [StringValue("KABYE")]
        [EnumMember]
        Kabye,
		
        /// <summary>
        /// The ethnic group of Kalanga people.
        /// </summary>
        [DomValIx(1000393)]
        [StringValue("KALANG")]
        [EnumMember]
        Kalanga,
		
        /// <summary>
        /// The ethnic group of Kalenjin people.
        /// </summary>
        [DomValIx(1000394)]
        [StringValue("KALENJ")]
        [EnumMember]
        Kalenjin,
		
        /// <summary>
        /// The ethnic group of Kamba people.
        /// </summary>
        [DomValIx(1000395)]
        [StringValue("KAMBA")]
        [EnumMember]
        Kamba,
		
        /// <summary>
        /// The ethnic group of Karakalpaks people.
        /// </summary>
        [DomValIx(1000396)]
        [StringValue("KARAKA")]
        [EnumMember]
        Karakalpaks,
		
        /// <summary>
        /// The ethnic group of Karen people.
        /// </summary>
        [DomValIx(1000397)]
        [StringValue("KAREN")]
        [EnumMember]
        Karen,
		
        /// <summary>
        /// The ethnic group of Kazakh people.
        /// </summary>
        [DomValIx(1000398)]
        [StringValue("KAZAKH")]
        [EnumMember]
        Kazakh,
		
        /// <summary>
        /// The ethnic group of Kazakh (Qazaq) people.
        /// </summary>
        [DomValIx(1000399)]
        [StringValue("KAZAKQ")]
        [EnumMember]
        KazakhQazaq,
		
        /// <summary>
        /// The ethnic group of Kgalagadi people.
        /// </summary>
        [DomValIx(1000400)]
        [StringValue("KGALAG")]
        [EnumMember]
        Kgalagadi,
		
        /// <summary>
        /// The ethnic group of Kikuyu people.
        /// </summary>
        [DomValIx(1000401)]
        [StringValue("KIKUYU")]
        [EnumMember]
        Kikuyu,
		
        /// <summary>
        /// The ethnic group of Kimbundu people.
        /// </summary>
        [DomValIx(1000402)]
        [StringValue("KIMBUN")]
        [EnumMember]
        Kimbundu,
		
        /// <summary>
        /// The ethnic group of Kirdi people.
        /// </summary>
        [DomValIx(1000403)]
        [StringValue("KIRDI")]
        [EnumMember]
        Kirdi,
		
        /// <summary>
        /// The ethnic group of Kirghiz people.
        /// </summary>
        [DomValIx(1000404)]
        [StringValue("KIRGHZ")]
        [EnumMember]
        Kirghiz,
		
        /// <summary>
        /// The ethnic group of Kisii people.
        /// </summary>
        [DomValIx(1000405)]
        [StringValue("KISII")]
        [EnumMember]
        Kisii,
		
        /// <summary>
        /// The ethnic group of Kongo people.
        /// </summary>
        [DomValIx(1000406)]
        [StringValue("KONGO")]
        [EnumMember]
        Kongo,
		
        /// <summary>
        /// The ethnic group of Kunama people.
        /// </summary>
        [DomValIx(1000407)]
        [StringValue("KUNAMA")]
        [EnumMember]
        Kunama,
		
        /// <summary>
        /// The ethnic group of Kuwaiti people.
        /// </summary>
        [DomValIx(1000408)]
        [StringValue("KUWAIT")]
        [EnumMember]
        Kuwaiti,
		
        /// <summary>
        /// The ethnic group of Ladino (Indian/European) people.
        /// </summary>
        [DomValIx(1000409)]
        [StringValue("LADINO")]
        [EnumMember]
        LadinoIndianEuropean,
		
        /// <summary>
        /// The ethnic group of Lapp people.
        /// </summary>
        [DomValIx(1000410)]
        [StringValue("LAPP")]
        [EnumMember]
        Lapp,
		
        /// <summary>
        /// The ethnic group of Latin people.
        /// </summary>
        [DomValIx(1000411)]
        [StringValue("LATIN")]
        [EnumMember]
        Latin,
		
        /// <summary>
        /// The ethnic group of Limbus people.
        /// </summary>
        [DomValIx(1000412)]
        [StringValue("LIMBUS")]
        [EnumMember]
        Limbus,
		
        /// <summary>
        /// The ethnic group of Lobi people.
        /// </summary>
        [DomValIx(1000413)]
        [StringValue("LOBI")]
        [EnumMember]
        Lobi,
		
        /// <summary>
        /// The ethnic group of Lomwe people.
        /// </summary>
        [DomValIx(1000414)]
        [StringValue("LOMWE")]
        [EnumMember]
        Lomwe,
		
        /// <summary>
        /// The ethnic group of Luhya people.
        /// </summary>
        [DomValIx(1000415)]
        [StringValue("LUHYA")]
        [EnumMember]
        Luhya,
		
        /// <summary>
        /// The ethnic group of Luo people.
        /// </summary>
        [DomValIx(1000416)]
        [StringValue("LUO")]
        [EnumMember]
        Luo,
		
        /// <summary>
        /// The ethnic group of Lur people.
        /// </summary>
        [DomValIx(1000417)]
        [StringValue("LUR")]
        [EnumMember]
        Lur,
		
        /// <summary>
        /// The ethnic group of Madurese people.
        /// </summary>
        [DomValIx(1000418)]
        [StringValue("MADURE")]
        [EnumMember]
        Madurese,
		
        /// <summary>
        /// The ethnic group of Magars people.
        /// </summary>
        [DomValIx(1000419)]
        [StringValue("MAGARS")]
        [EnumMember]
        Magars,
		
        /// <summary>
        /// The ethnic group of Makoa people.
        /// </summary>
        [DomValIx(1000420)]
        [StringValue("MAKOA")]
        [EnumMember]
        Makoa,
		
        /// <summary>
        /// The ethnic group of Malagasy people.
        /// </summary>
        [DomValIx(1000421)]
        [StringValue("MALAGA")]
        [EnumMember]
        Malagasy,
		
        /// <summary>
        /// The ethnic group of Malaya-Indonesian (Betwileo) people.
        /// </summary>
        [DomValIx(1000422)]
        [StringValue("MALAYA")]
        [EnumMember]
        MalayaIndonesianBetwileo,
		
        /// <summary>
        /// The ethnic group of Malayo-Indonesian people.
        /// </summary>
        [DomValIx(1000423)]
        [StringValue("MALAYI")]
        [EnumMember]
        MalayoIndonesian,
		
        /// <summary>
        /// The ethnic group of Malayo-Indonesian (Merina) people.
        /// </summary>
        [DomValIx(1000424)]
        [StringValue("MALAYM")]
        [EnumMember]
        MalayoIndonesianMerina,
		
        /// <summary>
        /// The ethnic group of Malinke people.
        /// </summary>
        [DomValIx(1000425)]
        [StringValue("MALINK")]
        [EnumMember]
        Malinke,
		
        /// <summary>
        /// The ethnic group of Man people.
        /// </summary>
        [DomValIx(1000426)]
        [StringValue("MAN")]
        [EnumMember]
        Man,
		
        /// <summary>
        /// The ethnic group of Manchu people.
        /// </summary>
        [DomValIx(1000427)]
        [StringValue("MANCHU")]
        [EnumMember]
        Manchu,
		
        /// <summary>
        /// The ethnic group of Mande people.
        /// </summary>
        [DomValIx(1000428)]
        [StringValue("MANDE")]
        [EnumMember]
        Mande,
		
        /// <summary>
        /// The ethnic group of Mande (Bambara) people.
        /// </summary>
        [DomValIx(1000429)]
        [StringValue("MANDEB")]
        [EnumMember]
        MandeBambara,
		
        /// <summary>
        /// The ethnic group of Mande (Malinke) people.
        /// </summary>
        [DomValIx(1000430)]
        [StringValue("MANDEM")]
        [EnumMember]
        MandeMalinke,
		
        /// <summary>
        /// The ethnic group of Mande (Sarakole) people.
        /// </summary>
        [DomValIx(1000431)]
        [StringValue("MANDES")]
        [EnumMember]
        MandeSarakole,
		
        /// <summary>
        /// The ethnic group of Mandingo people.
        /// </summary>
        [DomValIx(1000432)]
        [StringValue("MANDNG")]
        [EnumMember]
        Mandingo,
		
        /// <summary>
        /// The ethnic group of Mandjia people.
        /// </summary>
        [DomValIx(1000433)]
        [StringValue("MANDJI")]
        [EnumMember]
        Mandjia,
		
        /// <summary>
        /// The ethnic group of Maori people.
        /// </summary>
        [DomValIx(1000434)]
        [StringValue("MAORI")]
        [EnumMember]
        Maori,
		
        /// <summary>
        /// The ethnic group of Massa people.
        /// </summary>
        [DomValIx(1000435)]
        [StringValue("MASSA")]
        [EnumMember]
        Massa,
		
        /// <summary>
        /// The ethnic group of Maur people.
        /// </summary>
        [DomValIx(1000436)]
        [StringValue("MAUR")]
        [EnumMember]
        Maur,
		
        /// <summary>
        /// The ethnic group of Maya people.
        /// </summary>
        [DomValIx(1000437)]
        [StringValue("MAYA")]
        [EnumMember]
        Maya,
		
        /// <summary>
        /// The ethnic group of Mazandarani people.
        /// </summary>
        [DomValIx(1000438)]
        [StringValue("MAZAND")]
        [EnumMember]
        Mazandarani,
		
        /// <summary>
        /// The ethnic group of Mbaka people.
        /// </summary>
        [DomValIx(1000439)]
        [StringValue("MBAKA")]
        [EnumMember]
        Mbaka,
		
        /// <summary>
        /// The ethnic group of Mbaye people.
        /// </summary>
        [DomValIx(1000440)]
        [StringValue("MBAYE")]
        [EnumMember]
        Mbaye,
		
        /// <summary>
        /// The ethnic group of Mbochi people.
        /// </summary>
        [DomValIx(1000441)]
        [StringValue("MBOCHI")]
        [EnumMember]
        Mbochi,
		
        /// <summary>
        /// The ethnic group of Mboum people.
        /// </summary>
        [DomValIx(1000442)]
        [StringValue("MBOUM")]
        [EnumMember]
        Mboum,
		
        /// <summary>
        /// The ethnic group of Melanesian people.
        /// </summary>
        [DomValIx(1000443)]
        [StringValue("MELANE")]
        [EnumMember]
        Melanesian,
		
        /// <summary>
        /// The ethnic group of Meo people.
        /// </summary>
        [DomValIx(1000444)]
        [StringValue("MEO")]
        [EnumMember]
        Meo,
		
        /// <summary>
        /// The ethnic group of Meru people.
        /// </summary>
        [DomValIx(1000445)]
        [StringValue("MERU")]
        [EnumMember]
        Meru,
		
        /// <summary>
        /// The ethnic group of Mestizo (Indian and European) people.
        /// </summary>
        [DomValIx(1000446)]
        [StringValue("MESTZE")]
        [EnumMember]
        MestizoIndianAndEuropean,
		
        /// <summary>
        /// The ethnic group of Mestizo (Indian and Spanish) people.
        /// </summary>
        [DomValIx(1000447)]
        [StringValue("MESTZS")]
        [EnumMember]
        MestizoIndianAndSpanish,
		
        /// <summary>
        /// The ethnic group of Miao people.
        /// </summary>
        [DomValIx(1000448)]
        [StringValue("MIAO")]
        [EnumMember]
        Miao,
		
        /// <summary>
        /// The ethnic group of Micronesian people.
        /// </summary>
        [DomValIx(1000449)]
        [StringValue("MICRON")]
        [EnumMember]
        Micronesian,
		
        /// <summary>
        /// The ethnic group of Mina people.
        /// </summary>
        [DomValIx(1000450)]
        [StringValue("MINA")]
        [EnumMember]
        Mina,
		
        /// <summary>
        /// The ethnic group of Mixed people.
        /// </summary>
        [DomValIx(1000451)]
        [StringValue("MIXED")]
        [EnumMember]
        Mixed,
		
        /// <summary>
        /// The ethnic group of Moldovan people.
        /// </summary>
        [DomValIx(1000452)]
        [StringValue("MOLDOV")]
        [EnumMember]
        Moldovan,
		
        /// <summary>
        /// The ethnic group of Mon people.
        /// </summary>
        [DomValIx(1000453)]
        [StringValue("MON")]
        [EnumMember]
        Mon,
		
        /// <summary>
        /// The ethnic group of Monegasque people.
        /// </summary>
        [DomValIx(1000454)]
        [StringValue("MONEGA")]
        [EnumMember]
        Monegasque,
		
        /// <summary>
        /// The ethnic group of Mongol people.
        /// </summary>
        [DomValIx(1000455)]
        [StringValue("MONGOL")]
        [EnumMember]
        Mongol,
		
        /// <summary>
        /// The ethnic group of Montenegrins people.
        /// </summary>
        [DomValIx(1000456)]
        [StringValue("MONTEN")]
        [EnumMember]
        Montenegrins,
		
        /// <summary>
        /// The ethnic group of Moor people.
        /// </summary>
        [DomValIx(1000457)]
        [StringValue("MOOR")]
        [EnumMember]
        Moor,
		
        /// <summary>
        /// The ethnic group of Moravian people.
        /// </summary>
        [DomValIx(1000458)]
        [StringValue("MORAVI")]
        [EnumMember]
        Moravian,
		
        /// <summary>
        /// The ethnic group of Mossi people.
        /// </summary>
        [DomValIx(1000459)]
        [StringValue("MOSSI")]
        [EnumMember]
        Mossi,
		
        /// <summary>
        /// The ethnic group of Moundang people.
        /// </summary>
        [DomValIx(1000460)]
        [StringValue("MOUND")]
        [EnumMember]
        Moundang,
		
        /// <summary>
        /// The ethnic group of Moussei people.
        /// </summary>
        [DomValIx(1000461)]
        [StringValue("MOUSSE")]
        [EnumMember]
        Moussei,
		
        /// <summary>
        /// The ethnic group of Muhajir people.
        /// </summary>
        [DomValIx(1000462)]
        [StringValue("MUHAJR")]
        [EnumMember]
        Muhajir,
		
        /// <summary>
        /// The ethnic group of Mulatto people.
        /// </summary>
        [DomValIx(1000463)]
        [StringValue("MULATT")]
        [EnumMember]
        Mulatto,
		
        /// <summary>
        /// The ethnic group of Muong people.
        /// </summary>
        [DomValIx(1000464)]
        [StringValue("MUONG")]
        [EnumMember]
        Muong,
		
        /// <summary>
        /// The ethnic group of Muslim people.
        /// </summary>
        [DomValIx(1000465)]
        [StringValue("MUSLIM")]
        [EnumMember]
        Muslim,
		
        /// <summary>
        /// The ethnic group of Muslim (Arab) people.
        /// </summary>
        [DomValIx(1000466)]
        [StringValue("MUSLMA")]
        [EnumMember]
        MuslimArab,
		
        /// <summary>
        /// The ethnic group of Muslim (Baguirmi) people.
        /// </summary>
        [DomValIx(1000467)]
        [StringValue("MUSLMB")]
        [EnumMember]
        MuslimBaguirmi,
		
        /// <summary>
        /// The ethnic group of Muslim (Boulala) people.
        /// </summary>
        [DomValIx(1000468)]
        [StringValue("MUSIMO")]
        [EnumMember]
        MuslimBoulala,
		
        /// <summary>
        /// The ethnic group of Muslim (Fulbe) people.
        /// </summary>
        [DomValIx(1000469)]
        [StringValue("MUSLMF")]
        [EnumMember]
        MuslimFulbe,
		
        /// <summary>
        /// The ethnic group of Muslim (Hadjerai) people.
        /// </summary>
        [DomValIx(1000470)]
        [StringValue("MUSLMH")]
        [EnumMember]
        MuslimHadjerai,
		
        /// <summary>
        /// The ethnic group of Muslim (Kanembou) people.
        /// </summary>
        [DomValIx(1000471)]
        [StringValue("MUSLMK")]
        [EnumMember]
        MuslimKanembou,
		
        /// <summary>
        /// The ethnic group of Muslim (Kotoko) people.
        /// </summary>
        [DomValIx(1000472)]
        [StringValue("MUSLMT")]
        [EnumMember]
        MuslimKotoko,
		
        /// <summary>
        /// The ethnic group of Muslim (Maba) people.
        /// </summary>
        [DomValIx(1000473)]
        [StringValue("MUSLMM")]
        [EnumMember]
        MuslimMaba,
		
        /// <summary>
        /// The ethnic group of Muslim (Malay) people.
        /// </summary>
        [DomValIx(1000474)]
        [StringValue("MUSLMY")]
        [EnumMember]
        MuslimMalay,
		
        /// <summary>
        /// The ethnic group of Muslim (Toubou) people.
        /// </summary>
        [DomValIx(1000475)]
        [StringValue("MUSLMU")]
        [EnumMember]
        MuslimToubou,
		
        /// <summary>
        /// The ethnic group of Muslim (Zaghawa) people.
        /// </summary>
        [DomValIx(1000476)]
        [StringValue("MUSLMZ")]
        [EnumMember]
        MuslimZaghawa,
		
        /// <summary>
        /// The ethnic group of Native African people.
        /// </summary>
        [DomValIx(1000477)]
        [StringValue("NATVEF")]
        [EnumMember]
        NativeAfrican,
		
        /// <summary>
        /// The ethnic group of Native American people.
        /// </summary>
        [DomValIx(1000478)]
        [StringValue("NATVEM")]
        [EnumMember]
        NativeAmerican,
		
        /// <summary>
        /// The ethnic group of Negrito people.
        /// </summary>
        [DomValIx(1000479)]
        [StringValue("NEGRIT")]
        [EnumMember]
        Negrito,
		
        /// <summary>
        /// The ethnic group of New Zealander people.
        /// </summary>
        [DomValIx(1000480)]
        [StringValue("NEWZEA")]
        [EnumMember]
        NewZealander,
		
        /// <summary>
        /// The ethnic group of Newars people.
        /// </summary>
        [DomValIx(1000481)]
        [StringValue("NEWARS")]
        [EnumMember]
        Newars,
		
        /// <summary>
        /// The ethnic group of Ngambye people.
        /// </summary>
        [DomValIx(1000482)]
        [StringValue("NGAMBY")]
        [EnumMember]
        Ngambye,
		
        /// <summary>
        /// The ethnic group of Ngonde people.
        /// </summary>
        [DomValIx(1000483)]
        [StringValue("NGONDE")]
        [EnumMember]
        Ngonde,
		
        /// <summary>
        /// The ethnic group of Ngoni people.
        /// </summary>
        [DomValIx(1000484)]
        [StringValue("NGONI")]
        [EnumMember]
        Ngoni,
		
        /// <summary>
        /// The ethnic group of Nordic people.
        /// </summary>
        [DomValIx(1000485)]
        [StringValue("NORDIC")]
        [EnumMember]
        Nordic,
		
        /// <summary>
        /// The ethnic group of Norman people.
        /// </summary>
        [DomValIx(1000486)]
        [StringValue("NORMAN")]
        [EnumMember]
        Norman,
		
        /// <summary>
        /// The ethnic group of Norman-French people.
        /// </summary>
        [DomValIx(1000487)]
        [StringValue("NORMFR")]
        [EnumMember]
        NormanFrench,
		
        /// <summary>
        /// The ethnic group of North African people.
        /// </summary>
        [DomValIx(1000488)]
        [StringValue("NORTAF")]
        [EnumMember]
        NorthAfrican,
		
        /// <summary>
        /// The ethnic group of Nyanja people.
        /// </summary>
        [DomValIx(1000489)]
        [StringValue("NYANJA")]
        [EnumMember]
        Nyanja,
		
        /// <summary>
        /// The ethnic group of Oimatsaha people.
        /// </summary>
        [DomValIx(1000490)]
        [StringValue("OIMATS")]
        [EnumMember]
        Oimatsaha,
		
        /// <summary>
        /// The ethnic group of Oriental people.
        /// </summary>
        [DomValIx(1000491)]
        [StringValue("ORIENT")]
        [EnumMember]
        Oriental,
		
        /// <summary>
        /// The ethnic group of Oromo people.
        /// </summary>
        [DomValIx(1000492)]
        [StringValue("OROMO")]
        [EnumMember]
        Oromo,
		
        /// <summary>
        /// The ethnic group of Ossetian people.
        /// </summary>
        [DomValIx(1000493)]
        [StringValue("OSSET")]
        [EnumMember]
        Ossetian,
		
        /// <summary>
        /// The ethnic group of Ovimbundu people.
        /// </summary>
        [DomValIx(1000494)]
        [StringValue("OVIMBU")]
        [EnumMember]
        Ovimbundu,
		
        /// <summary>
        /// The ethnic group of Palauans people.
        /// </summary>
        [DomValIx(1000495)]
        [StringValue("PALAUA")]
        [EnumMember]
        Palauans,
		
        /// <summary>
        /// The ethnic group of Pashtun people.
        /// </summary>
        [DomValIx(1000496)]
        [StringValue("PASHTU")]
        [EnumMember]
        Pashtun,
		
        /// <summary>
        /// The ethnic group of Pashtun (Pathan) people.
        /// </summary>
        [DomValIx(1000497)]
        [StringValue("PASHTP")]
        [EnumMember]
        PashtunPathan,
		
        /// <summary>
        /// The ethnic group of Persian people.
        /// </summary>
        [DomValIx(1000498)]
        [StringValue("PERSAN")]
        [EnumMember]
        Persian,
		
        /// <summary>
        /// The ethnic group of Peul people.
        /// </summary>
        [DomValIx(1000499)]
        [StringValue("PEUL")]
        [EnumMember]
        Peul,
		
        /// <summary>
        /// The ethnic group of Phoutheung (Kya) people.
        /// </summary>
        [DomValIx(1000500)]
        [StringValue("PHOUTH")]
        [EnumMember]
        PhoutheungKya,
		
        /// <summary>
        /// The ethnic group of Polynesian people.
        /// </summary>
        [DomValIx(1000501)]
        [StringValue("POLYNE")]
        [EnumMember]
        Polynesian,
		
        /// <summary>
        /// The ethnic group of Polynesian (Samoan) people.
        /// </summary>
        [DomValIx(1000502)]
        [StringValue("POLYNS")]
        [EnumMember]
        PolynesianSamoan,
		
        /// <summary>
        /// The ethnic group of Polynesian (Tongans) people.
        /// </summary>
        [DomValIx(1000503)]
        [StringValue("POLYNT")]
        [EnumMember]
        PolynesianTongans,
		
        /// <summary>
        /// The ethnic group of Quechua people.
        /// </summary>
        [DomValIx(1000504)]
        [StringValue("QUECHU")]
        [EnumMember]
        Quechua,
		
        /// <summary>
        /// The ethnic group of Rais people.
        /// </summary>
        [DomValIx(1000505)]
        [StringValue("RAIS")]
        [EnumMember]
        Rais,
		
        /// <summary>
        /// The ethnic group of Rakhine people.
        /// </summary>
        [DomValIx(1000506)]
        [StringValue("RAKHIN")]
        [EnumMember]
        Rakhine,
		
        /// <summary>
        /// The ethnic group of Rio Muni (Fang) people.
        /// </summary>
        [DomValIx(1000507)]
        [StringValue("RIOMUN")]
        [EnumMember]
        RioMuniFang,
		
        /// <summary>
        /// The ethnic group of Romansch people.
        /// </summary>
        [DomValIx(1000508)]
        [StringValue("ROMANS")]
        [EnumMember]
        Romansch,
		
        /// <summary>
        /// The ethnic group of Ruthenian people.
        /// </summary>
        [DomValIx(1000509)]
        [StringValue("RUTHEN")]
        [EnumMember]
        Ruthenian,
		
        /// <summary>
        /// The ethnic group of Rwandans people.
        /// </summary>
        [DomValIx(1000510)]
        [StringValue("RWANDA")]
        [EnumMember]
        Rwandans,
		
        /// <summary>
        /// The ethnic group of Saho people.
        /// </summary>
        [DomValIx(1000511)]
        [StringValue("SAHO")]
        [EnumMember]
        Saho,
		
        /// <summary>
        /// The ethnic group of Sakalava people.
        /// </summary>
        [DomValIx(1000512)]
        [StringValue("SAKALA")]
        [EnumMember]
        Sakalava,
		
        /// <summary>
        /// The ethnic group of Sammarinese people.
        /// </summary>
        [DomValIx(1000513)]
        [StringValue("SAMMAR")]
        [EnumMember]
        Sammarinese,
		
        /// <summary>
        /// The ethnic group of Samoan (Polynesian) people.
        /// </summary>
        [DomValIx(1000514)]
        [StringValue("SAMOAP")]
        [EnumMember]
        SamoanPolynesian,
		
        /// <summary>
        /// The ethnic group of Sangha people.
        /// </summary>
        [DomValIx(1000515)]
        [StringValue("SANGHA")]
        [EnumMember]
        Sangha,
		
        /// <summary>
        /// The ethnic group of Sara people.
        /// </summary>
        [DomValIx(1000516)]
        [StringValue("SARA")]
        [EnumMember]
        Sara,
		
        /// <summary>
        /// The ethnic group of Scandinavian people.
        /// </summary>
        [DomValIx(1000517)]
        [StringValue("SCANDN")]
        [EnumMember]
        Scandinavian,
		
        /// <summary>
        /// The ethnic group of Sena people.
        /// </summary>
        [DomValIx(1000518)]
        [StringValue("SENA")]
        [EnumMember]
        Sena,
		
        /// <summary>
        /// The ethnic group of Senoufou people.
        /// </summary>
        [DomValIx(1000519)]
        [StringValue("SENOUF")]
        [EnumMember]
        Senoufou,
		
        /// <summary>
        /// The ethnic group of Senufo people.
        /// </summary>
        [DomValIx(1000520)]
        [StringValue("SENUFO")]
        [EnumMember]
        Senufo,
		
        /// <summary>
        /// The ethnic group of Serer people.
        /// </summary>
        [DomValIx(1000521)]
        [StringValue("SERER")]
        [EnumMember]
        Serer,
		
        /// <summary>
        /// The ethnic group of Servicais people.
        /// </summary>
        [DomValIx(1000522)]
        [StringValue("SERVIC")]
        [EnumMember]
        Servicais,
		
        /// <summary>
        /// The ethnic group of Shan people.
        /// </summary>
        [DomValIx(1000523)]
        [StringValue("SHAN")]
        [EnumMember]
        Shan,
		
        /// <summary>
        /// The ethnic group of Sherpas people.
        /// </summary>
        [DomValIx(1000524)]
        [StringValue("SHERPA")]
        [EnumMember]
        Sherpas,
		
        /// <summary>
        /// The ethnic group of Sicilian people.
        /// </summary>
        [DomValIx(1000525)]
        [StringValue("SICLAN")]
        [EnumMember]
        Sicilian,
		
        /// <summary>
        /// The ethnic group of Sidamo people.
        /// </summary>
        [DomValIx(1000526)]
        [StringValue("SIDAMO")]
        [EnumMember]
        Sidamo,
		
        /// <summary>
        /// The ethnic group of Sindhi people.
        /// </summary>
        [DomValIx(1000527)]
        [StringValue("SINDHI")]
        [EnumMember]
        Sindhi,
		
        /// <summary>
        /// The ethnic group of Sino-Mauritian people.
        /// </summary>
        [DomValIx(1000528)]
        [StringValue("SINOMA")]
        [EnumMember]
        SinoMauritian,
		
        /// <summary>
        /// The ethnic group of Solvene people.
        /// </summary>
        [DomValIx(1000529)]
        [StringValue("SOLVEN")]
        [EnumMember]
        Solvene,
		
        /// <summary>
        /// The ethnic group of Songhai people.
        /// </summary>
        [DomValIx(1000530)]
        [StringValue("SONGHA")]
        [EnumMember]
        Songhai,
		
        /// <summary>
        /// The ethnic group of Sotho people.
        /// </summary>
        [DomValIx(1000531)]
        [StringValue("SOTHO")]
        [EnumMember]
        Sotho,
		
        /// <summary>
        /// The ethnic group of Soussou people.
        /// </summary>
        [DomValIx(1000532)]
        [StringValue("SOUSSO")]
        [EnumMember]
        Soussou,
		
        /// <summary>
        /// The ethnic group of South Asian people.
        /// </summary>
        [DomValIx(1000533)]
        [StringValue("SOUTHA")]
        [EnumMember]
        SouthAsian,
		
        /// <summary>
        /// The ethnic group of Sundanese people.
        /// </summary>
        [DomValIx(1000534)]
        [StringValue("SUNDAN")]
        [EnumMember]
        Sundanese,
		
        /// <summary>
        /// The ethnic group of Syrian-Lebanese people.
        /// </summary>
        [DomValIx(1000535)]
        [StringValue("SYRANL")]
        [EnumMember]
        SyrianLebanese,
		
        /// <summary>
        /// The ethnic group of Syro-Lebanese people.
        /// </summary>
        [DomValIx(1000536)]
        [StringValue("SYROLE")]
        [EnumMember]
        SyroLebanese,
		
        /// <summary>
        /// The ethnic group of Tajik people.
        /// </summary>
        [DomValIx(1000537)]
        [StringValue("TAJIK")]
        [EnumMember]
        Tajik,
		
        /// <summary>
        /// The ethnic group of Tamangs people.
        /// </summary>
        [DomValIx(1000538)]
        [StringValue("TAMANG")]
        [EnumMember]
        Tamangs,
		
        /// <summary>
        /// The ethnic group of Tatar people.
        /// </summary>
        [DomValIx(1000539)]
        [StringValue("TATAR")]
        [EnumMember]
        Tatar,
		
        /// <summary>
        /// The ethnic group of Teke people.
        /// </summary>
        [DomValIx(1000540)]
        [StringValue("TEKE")]
        [EnumMember]
        Teke,
		
        /// <summary>
        /// The ethnic group of Teutonic people.
        /// </summary>
        [DomValIx(1000541)]
        [StringValue("TEUTON")]
        [EnumMember]
        Teutonic,
		
        /// <summary>
        /// The ethnic group of Tigrean people.
        /// </summary>
        [DomValIx(1000542)]
        [StringValue("TIGREA")]
        [EnumMember]
        Tigrean,
		
        /// <summary>
        /// The ethnic group of Tongas people.
        /// </summary>
        [DomValIx(1000543)]
        [StringValue("TONGAS")]
        [EnumMember]
        Tongas,
		
        /// <summary>
        /// The ethnic group of Toubou people.
        /// </summary>
        [DomValIx(1000544)]
        [StringValue("TOUBOU")]
        [EnumMember]
        Toubou,
		
        /// <summary>
        /// The ethnic group of Toucouleur people.
        /// </summary>
        [DomValIx(1000545)]
        [StringValue("TOUCOU")]
        [EnumMember]
        Toucouleur,
		
        /// <summary>
        /// The ethnic group of Tsimihety people.
        /// </summary>
        [DomValIx(1000546)]
        [StringValue("TSIMHE")]
        [EnumMember]
        Tsimihety,
		
        /// <summary>
        /// The ethnic group of Tuareg people.
        /// </summary>
        [DomValIx(1000547)]
        [StringValue("TUAREG")]
        [EnumMember]
        Tuareg,
		
        /// <summary>
        /// The ethnic group of Tumbuko people.
        /// </summary>
        [DomValIx(1000548)]
        [StringValue("TUMBUK")]
        [EnumMember]
        Tumbuko,
		
        /// <summary>
        /// The ethnic group of Turkmen people.
        /// </summary>
        [DomValIx(1000549)]
        [StringValue("TURKME")]
        [EnumMember]
        Turkmen,
		
        /// <summary>
        /// The ethnic group of Turkoman people.
        /// </summary>
        [DomValIx(1000550)]
        [StringValue("TURKOM")]
        [EnumMember]
        Turkoman,
		
        /// <summary>
        /// The ethnic group of Tutsi (Hamitic) people.
        /// </summary>
        [DomValIx(1000551)]
        [StringValue("TUTSI")]
        [EnumMember]
        TutsiHamitic,
		
        /// <summary>
        /// The ethnic group of Twa (Pygmy) people.
        /// </summary>
        [DomValIx(1000552)]
        [StringValue("TWA")]
        [EnumMember]
        TwaPygmy,
		
        /// <summary>
        /// The ethnic group of Uygur people.
        /// </summary>
        [DomValIx(1000553)]
        [StringValue("UYGUR")]
        [EnumMember]
        Uygur,
		
        /// <summary>
        /// The ethnic group of Uzbek people.
        /// </summary>
        [DomValIx(1000554)]
        [StringValue("UZBEK")]
        [EnumMember]
        Uzbek,
		
        /// <summary>
        /// The ethnic group of Vedda people.
        /// </summary>
        [DomValIx(1000555)]
        [StringValue("VEDDA")]
        [EnumMember]
        Vedda,
		
        /// <summary>
        /// The ethnic group of Vlachs people.
        /// </summary>
        [DomValIx(1000556)]
        [StringValue("VLACHS")]
        [EnumMember]
        Vlachs,
		
        /// <summary>
        /// The ethnic group of Voltaic people.
        /// </summary>
        [DomValIx(1000557)]
        [StringValue("VOLTAC")]
        [EnumMember]
        Voltaic,
		
        /// <summary>
        /// The ethnic group of Wallisian people.
        /// </summary>
        [DomValIx(1000558)]
        [StringValue("WALLIS")]
        [EnumMember]
        Wallisian,
		
        /// <summary>
        /// The ethnic group of Walloon people.
        /// </summary>
        [DomValIx(1000559)]
        [StringValue("WALLOO")]
        [EnumMember]
        Walloon,
		
        /// <summary>
        /// The ethnic group of White people.
        /// </summary>
        [DomValIx(1000560)]
        [StringValue("WHITE")]
        [EnumMember]
        White,
		
        /// <summary>
        /// The ethnic group of Wolof people.
        /// </summary>
        [DomValIx(1000561)]
        [StringValue("WOLOF")]
        [EnumMember]
        Wolof,
		
        /// <summary>
        /// The ethnic group of Yao people.
        /// </summary>
        [DomValIx(1000562)]
        [StringValue("YAO")]
        [EnumMember]
        Yao,
		
        /// <summary>
        /// The ethnic group of Yi people.
        /// </summary>
        [DomValIx(1000563)]
        [StringValue("YI")]
        [EnumMember]
        Yi,
		
        /// <summary>
        /// The ethnic group of Yoruba people.
        /// </summary>
        [DomValIx(1000564)]
        [StringValue("YORUBA")]
        [EnumMember]
        Yoruba,
		
        /// <summary>
        /// The ethnic group of Yugoslavian people.
        /// </summary>
        [DomValIx(1000565)]
        [StringValue("YUGOSL")]
        [EnumMember]
        Yugoslavian,
		
        /// <summary>
        /// The ethnic group of Zairians people.
        /// </summary>
        [DomValIx(1000566)]
        [StringValue("ZAIRAN")]
        [EnumMember]
        Zairians,
		
        /// <summary>
        /// The ethnic group of Zanzibari people.
        /// </summary>
        [DomValIx(1000567)]
        [StringValue("ZANZIB")]
        [EnumMember]
        Zanzibari,
		
        /// <summary>
        /// The ethnic group of Zhuang people.
        /// </summary>
        [DomValIx(1000568)]
        [StringValue("ZHUANG")]
        [EnumMember]
        Zhuang,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000569)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

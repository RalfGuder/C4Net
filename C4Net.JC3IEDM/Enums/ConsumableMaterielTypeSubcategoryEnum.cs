using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of a specific CONSUMABLE-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000185)]
    [DataContract]
    public enum ConsumableMaterielTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A mixture of liquid hydrocarbons, a commercial product of the distillation of petroleum intended to be used in kerosene based engines.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("KEROS")]
        [EnumMember]
        Kerosene,
		
        /// <summary>
        /// A petroleum fraction intended to be used as fuel in diesel engines.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DIESEL")]
        [EnumMember]
        DieselFuel,
		
        /// <summary>
        /// A refined petroleum product intended to be used as fuel in gasoline engines.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PETROL")]
        [EnumMember]
        Petrol,
		
        /// <summary>
        /// A substance having the following characters (or most of them): viz. those of being liquid at ordinary temperatures, of a viscid consistence and characteristic smooth and sticky (unctuous) feel, lighter than water and insoluble in it, soluble in alcohol and ether, inflammable, chemically neutral.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OIL")]
        [EnumMember]
        Oil,
		
        /// <summary>
        /// A material, usually an oil, used to lubricate machinery.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LUBRIC")]
        [EnumMember]
        Lubricant,
		
        /// <summary>
        /// A distinctive dress of uniform cut, materials, and colour worn by all the members of a particular naval, military, or other force to which it is recognised as properly belonging and peculiar.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("UNIFRM")]
        [EnumMember]
        Uniform,
		
        /// <summary>
        /// The personal equipment and or medical supplies issued to a person for protection against chemical, biological, radiological, or nuclear materiel contamination or exposure.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NBCKIT")]
        [EnumMember]
        NbcKit,
		
        /// <summary>
        /// A pliable metallic strand or rod made in many lengths and diameters.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("WIRE")]
        [EnumMember]
        Wire,
		
        /// <summary>
        /// Steel or other supporting material used in constructing a wall of earth.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("REVET")]
        [EnumMember]
        RevettingMaterial,
		
        /// <summary>
        /// Steel or other material used to construct a supporting surface over ground.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MATING")]
        [EnumMember]
        Matting,
		
        /// <summary>
        /// The red liquid circulating in the arteries and veins of man and the higher animals, by which the tissues are constantly nourished and renewed.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("BLOOD")]
        [EnumMember]
        Blood,
		
        /// <summary>
        /// Any substance or preparation used in the treatment of disease.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MEDICN")]
        [EnumMember]
        Medicine,
		
        /// <summary>
        /// H2O that has been filtered or processed to remove poisons/toxins harmful to humans and that has also been sterilised to enable it to be used for medical purposes.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("WTRMED")]
        [EnumMember]
        WaterFitForMedicalUse,
		
        /// <summary>
        /// H2O that has been filtered and processed to remove poisons/toxins harmful to humans.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("WTRHUM")]
        [EnumMember]
        WaterFitForHumanConsumption,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// H2O that may have a level of poisons/toxins or bacteria that make it unfit for human consumption or medical usage, but that may be used for other purposes.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("WTROTH")]
        [EnumMember]
        WaterNeitherMedicalNorHumanUse,
		
        /// <summary>
        /// Fresh food allotted for persons.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("RATFR")]
        [EnumMember]
        RationsFresh,
		
        /// <summary>
        /// Food preserved in a container allotted for persons.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("RATTI")]
        [EnumMember]
        RationsTin,
		
        /// <summary>
        /// A package of fixed portions of food allotted for persons.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("RATCO")]
        [EnumMember]
        RationsCombat,
		
        /// <summary>
        /// A petroleum fraction used as fuel in aeroplane engines.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("AVNFU")]
        [EnumMember]
        AviationFuel,
		
        /// <summary>
        /// Medical material applied to cover and protect an injury.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("BNDDR")]
        [EnumMember]
        BandagesDressings,
		
        /// <summary>
        /// Articles of dress or attire worn by individuals.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("CLTHNG")]
        [EnumMember]
        Clothing,
		
        /// <summary>
        /// A container used to dispense chemical or biological agents.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("SPRAY")]
        [EnumMember]
        SprayTank,
		
        /// <summary>
        /// An airtight envelope of paper, silk or similar material filled with light gas or air designed to be held by hand.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("BALNHH")]
        [EnumMember]
        BalloonHandHeld,
		
        /// <summary>
        /// A literary composition such as would occupy one or more volumes, without regard to the material form or forms in which it actually exists.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("BOOK")]
        [EnumMember]
        Book,
		
        /// <summary>
        /// A printed notice or advertisement on a single page, intended to be delivered or circulated by hand.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("HANDBL")]
        [EnumMember]
        Handbill,
		
        /// <summary>
        /// A small sized leaf of paper containing printed matter, chiefly for gratuitous distribution.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("LEAFLT")]
        [EnumMember]
        Leaflet,
		
        /// <summary>
        /// A periodical publication containing articles by various writers.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("MAGZNE")]
        [EnumMember]
        Magazine,
		
        /// <summary>
        /// A painting executed on a wall or ceiling as part of a scheme or decoration.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("MURAL")]
        [EnumMember]
        Mural,
		
        /// <summary>
        /// A printed publication containing the news, commonly with the addition of advertisements and other matters of interest.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("NWSPPR")]
        [EnumMember]
        Newspaper,
		
        /// <summary>
        /// A small treatise occupying fewer pages than would make a book, issued as a separate work; always unbound, with or without paper covers.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("PMPHLT")]
        [EnumMember]
        Pamphlet,
		
        /// <summary>
        /// A substance consisting of a solid colouring matter dissolved in a liquid vehicle, as water or oil, used to impart a colour by being spread over a surface.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("PAINT")]
        [EnumMember]
        Paint,
		
        /// <summary>
        /// A device designed to apply paint.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("PNTBRS")]
        [EnumMember]
        PaintBrush,
		
        /// <summary>
        /// A substance composed of fibres interlaced into a compact web.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("PAPER")]
        [EnumMember]
        Paper,
		
        /// <summary>
        /// A placard posted or displayed in a public place as an announcement or advertisement.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("POSTER")]
        [EnumMember]
        Poster,
		
        /// <summary>
        /// Fuel made from carbon, cinder or ember.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("COAL")]
        [EnumMember]
        Coal,
		
        /// <summary>
        /// Liquefied petroleum gas.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("LPG")]
        [EnumMember]
        LiquefiedPetroleumGas,
		
        /// <summary>
        /// A flammable gas, consisting largely of methane and other hydrocarbons, occurring naturally underground and used as fuel.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("NATGAS")]
        [EnumMember]
        NaturalGas,
		
        /// <summary>
        /// Dried bog or swamp matter used for fuel.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("PEAT")]
        [EnumMember]
        Peat,
		
        /// <summary>
        /// A material used for construction or fuel.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("WOOD")]
        [EnumMember]
        Wood,
		
        /// <summary>
        /// An improvised explosive device deliberately sent by postal or other services, as an apparently harmless letter or parcel, to cause casualties to the addressee.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("LTRBMB")]
        [EnumMember]
        LetterBomb,
		
        /// <summary>
        /// An explosive or non-explosive device or other material deliberately placed to cause casualties when an apparently harmless object is disturbed or a normally safe act is performed.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("BBYTRP")]
        [EnumMember]
        BoobyTrap,
		
        /// <summary>
        /// A synthetic drug used esp. as a stimulant.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("AMPHTM")]
        [EnumMember]
        Amphetamine,
		
        /// <summary>
        /// A drug derived from coca or prepared synthetically, used as a local anaesthetic and as a stimulant.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("COCANE")]
        [EnumMember]
        Cocaine,
		
        /// <summary>
        /// A potent hard crystalline form of cocaine broken into small pieces and inhaled or smoked for its stimulating effect.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("CRACK")]
        [EnumMember]
        Crack,
		
        /// <summary>
        /// A synthetic phenethylamine substance marked by visual hallucinations.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("DOB")]
        [EnumMember]
        Dob,
		
        /// <summary>
        /// Methylenedioxyamphetamine, an amphetamine-based drug that causes euphoric and hallucinatory effects, originally produced as an appetite suppressant.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("ECSMDA")]
        [EnumMember]
        EcstasyMda,
		
        /// <summary>
        /// Methylenedioxy-ethylamphetamine, an amphetamine-based drug that causes euphoric and hallucinatory effects, originally produced as an appetite suppressant.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("ECSMDE")]
        [EnumMember]
        EcstasyMdea,
		
        /// <summary>
        /// Methylenedioxymethamphetamine, an amphetamine-based drug that causes euphoric and hallucinatory effects, originally produced as an appetite suppressant.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("ECSMDM")]
        [EnumMember]
        EcstasyMdma,
		
        /// <summary>
        /// Gamma hydroxy butyrate, a designer drug with anaesthetic properties, claimed also to be an aphrodisiac.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("GHB")]
        [EnumMember]
        Ghb,
		
        /// <summary>
        /// A resinous product of the top leaves and tender parts of hemp, smoked or chewed for its narcotic effects.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("HASHSH")]
        [EnumMember]
        Hashish,
		
        /// <summary>
        /// A dark brown to black oily substance possessing a THC content averaging 20 percent.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("HASOIL")]
        [EnumMember]
        HashishOil,
		
        /// <summary>
        /// A highly addictive crystalline analgesic drug derived from morphine, often used as a narcotic.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("HEROIN")]
        [EnumMember]
        Heroin,
		
        /// <summary>
        /// An anaesthetic and pain-killing drug, also used (illicitly) as a hallucinogen.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("KTMINE")]
        [EnumMember]
        Ketamine,
		
        /// <summary>
        /// The leaves of this shrub, chewed or infused as a stimulant.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("KHAT")]
        [EnumMember]
        Khat,
		
        /// <summary>
        /// Lysergic acid diethylamide.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("LSD")]
        [EnumMember]
        Lsd,
		
        /// <summary>
        /// The dried leaves, flowering tops, and stems of the hemp, used as an intoxicating or hallucinogenic drug and usu. smoked in cigarettes; cannabis.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("MARJUN")]
        [EnumMember]
        Marijuana,
		
        /// <summary>
        /// A hallucinogenic alkaloid present in mescal buttons.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("MSCLNE")]
        [EnumMember]
        Mescaline,
		
        /// <summary>
        /// An amphetamine derivative with quicker and longer action, used as a stimulant.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("MTHAMP")]
        [EnumMember]
        Methamphetamine,
		
        /// <summary>
        /// An analgesic and narcotic drug obtained from opium and used medicinally to relieve pain.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("MORFIN")]
        [EnumMember]
        Morphine,
		
        /// <summary>
        /// A reddish-brown heavy-scented addictive drug prepared from the juice of the opium poppy, used in medicine as an analgesic and narcotic.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("OPIUM")]
        [EnumMember]
        Opium,
		
        /// <summary>
        /// A piperidine derivative used as a veterinary anaesthetic and a hallucinogenic drug.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("PCP")]
        [EnumMember]
        Phencyclidine,
		
        /// <summary>
        /// A hallucinogenic alkaloid found in toadstools of the genus Psilocybe.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("PSLCYB")]
        [EnumMember]
        Psilocybin,
		
        /// <summary>
        /// A synthetic hallucinogenic substance marked by visual hallucinations similar to mescaline – a component of the peyote cactus.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("2CB")]
        [EnumMember]
        _2CB,
		
        /// <summary>
        /// A portable container of a wet/dry cell or cells carrying an electric charge, as a source of current.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("BATDWC")]
        [EnumMember]
        BatteryDryWetCell,
		
        /// <summary>
        /// A wide cut gasoline type fuel. Specification MIL-T-5624, interchangeable with AVTAG/FSII, NATO F-40.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("JP4F")]
        [EnumMember]
        Jp4Fuel,
		
        /// <summary>
        /// Aviation kerosene, high flash point type, for ship borne aircraft. Specification MIL-T-5624, interchangeable with AVCAT/FSII, NATO F-44.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("JP5F")]
        [EnumMember]
        Jp5Fuel,
		
        /// <summary>
        /// A kerosene type fuel of low volatility and high thermal stability. Specification MIL-T-38219.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("JP7F")]
        [EnumMember]
        Jp7Fuel,
		
        /// <summary>
        /// Aviation kerosene, Specification MIL-T-83133 (F-34), interchangeable with AVTUR/FSII, NATO F-34.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("JP8F")]
        [EnumMember]
        Jp8Fuel,
		
        /// <summary>
        /// Gasoline, Aviation, Grade 100/130.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("NASF18")]
        [EnumMember]
        NatoStandardFuelCodeF18,
		
        /// <summary>
        /// Turbine Fuel, Aviation, Kerosene Type With S748.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("NASF34")]
        [EnumMember]
        NatoStandardFuelCodeF34,
		
        /// <summary>
        /// Turbine Fuel, Aviation, Kerosene Type.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("NASF35")]
        [EnumMember]
        NatoStandardFuelCodeF35,
		
        /// <summary>
        /// Turbine Fuel, Aviation, Wide Cut Type, With S748.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("NASF40")]
        [EnumMember]
        NatoStandardFuelCodeF40,
		
        /// <summary>
        /// Turbine Fuel, Aviation, High Flash Type With S748.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("NASF44")]
        [EnumMember]
        NatoStandardFuelCodeF44,
		
    }
}

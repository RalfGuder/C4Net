using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of RAILCAR-TYPE.
    /// </summary>
    [DomId(100000347)]
    [DataContract]
    public enum RailcarTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A locomotive that uses diesel engine(s) as its source of tractive power.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LCMDSL")]
        [EnumMember]
        LocomotiveDiesel,
		
        /// <summary>
        /// A locomotive that uses diesel engine(s) to produce electricity for electric engine(s) that provide the engine with its source of tractive power.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LCMDSE")]
        [EnumMember]
        LocomotiveDieselElectric,
		
        /// <summary>
        /// A locomotive that uses electric engine(s) as its source of tractive power, the electricity being supplied from an external source, typically via a pantograph (overhead electrical cable).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LCMELC")]
        [EnumMember]
        LocomotiveElectric,
		
        /// <summary>
        /// A locomotive that uses the principle of heating water above its boiling point to produce steam, the expansion in a sealed vessel the pressure becomes the engine(s) source of tractive power.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LCMSTM")]
        [EnumMember]
        LocomotiveSteam,
		
        /// <summary>
        /// A locomotive tender is used to carry coal and water for a steam locomotive when not integral to the locomotive design.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LCMTND")]
        [EnumMember]
        LocomotiveTender,
		
        /// <summary>
        /// Rolling stock specifically designed to carry an articulated truck by rail (for example EUROSTAR).
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("WGNART")]
        [EnumMember]
        WagonArticulatedVehicleTransporter,
		
        /// <summary>
        /// Rolling stock used to assist with the control of a formed train, that when used are manned and contain auxiliary braking apparatus.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("WGNBRK")]
        [EnumMember]
        WagonBrake,
		
        /// <summary>
        /// Rolling stock used to move bulk fuel by rail. [Also often known as tank wagons.]
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("WGNFUL")]
        [EnumMember]
        WagonBulkFuel,
		
        /// <summary>
        /// Rolling stock specifically designed to carry civilian or military cars by rail (for example EURORAIL).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("WGNCAR")]
        [EnumMember]
        WagonCarTransporter,
		
        /// <summary>
        /// Rolling stock used to move boxed or palletised equipment/stores and closed by means of fixed doors either sliding or hinged.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("WGNCRG")]
        [EnumMember]
        WagonCargoEnclosed,
		
        /// <summary>
        /// Rolling stock used to move boxed or palletised equipment/stores and closed by means of sliding curtained side panels.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("WGNCSS")]
        [EnumMember]
        WagonCargoSlidingSides,
		
        /// <summary>
        /// Rolling stock used to move livestock by rail.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("WGNCTL")]
        [EnumMember]
        WagonCattle,
		
        /// <summary>
        /// Rolling stock used to move either large bulky cargoes, for example B vehicles, or large linear cargoes, for example logs/cut timber, replacement sections of track.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("WGNFLB")]
        [EnumMember]
        WagonFlatbed,
		
        /// <summary>
        /// Rolling stock used to move bulk loose material by rail and unloaded by gravity through bottom doors. [Mineral or foodstuffs e.g. grain are typical cargoes.]
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("WGNHPR")]
        [EnumMember]
        WagonHopper,
		
        /// <summary>
        /// Rolling stock used to move standard ISO containers, either single or multiple containers.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("WGNISO")]
        [EnumMember]
        WagonIsoContainerS,
		
        /// <summary>
        /// Rolling stock used to move bulk liquids by rail.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("WGNLQD")]
        [EnumMember]
        WagonLiquid,
		
        /// <summary>
        /// Rolling stock used to move bulk mineral by rail with unloading facilities from either side.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("WGNMNR")]
        [EnumMember]
        WagonMineral,
		
        /// <summary>
        /// Rolling stock used to move bulk loose items by rail.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("WGNOPC")]
        [EnumMember]
        WagonOpenContainer,
		
        /// <summary>
        /// Rolling stock used for the transportation of passengers.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("WGNPAS")]
        [EnumMember]
        WagonPassenger,
		
        /// <summary>
        /// Rolling stock used to move potable water by rail.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("WGNWAT")]
        [EnumMember]
        WagonPotableWater,
		
        /// <summary>
        /// Rolling stock used to move refrigerated cargoes by rail.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("WGNRFG")]
        [EnumMember]
        WagonRefrigerated,
		
        /// <summary>
        /// Rolling stock used to move specialised or outsized loads by rail, for example MBTs, other outsized loads.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("WGNSPP")]
        [EnumMember]
        WagonSpecialPurpose,
		
        /// <summary>
        /// Rolling stock used to repair (replace track) or maintain the railway track and track bed.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("WGNRPR")]
        [EnumMember]
        WagonTrackRepairAndMaintenance,
		
        /// <summary>
        /// Rolling stock used to move specific military loads, for example AIFVs (UK Warrior).
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("WGNWFL")]
        [EnumMember]
        WagonWarflat,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

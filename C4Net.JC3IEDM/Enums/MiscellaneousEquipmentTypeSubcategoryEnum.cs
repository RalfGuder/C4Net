using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of MISCELLANEOUS-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100004235)]
    [DataContract]
    public enum MiscellaneousEquipmentTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A component of a refuelling system by which a boom device on an aerial refuelling tanker is inserted into a receptacle on a receiver aircraft.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BOOM")]
        [EnumMember]
        Boom,
		
        /// <summary>
        /// Two components of a refuelling system by which a boom and a centreline drogue devices can provide fuel on a receiver aircraft.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BCD")]
        [EnumMember]
        BoomAndCentrelineDrogue,
		
        /// <summary>
        /// Three components of a refuelling system by which a boom, centreline drogue and wingtip drogue devices can provide fuel on a receiver aircraft.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BCDW")]
        [EnumMember]
        BoomAndCentrelineDrogueAndWingtipDrogue,
		
        /// <summary>
        /// Two components of a refuelling system by which a boom and a wingtip drogue devices provide fuel on a receiver aircraft.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BWD")]
        [EnumMember]
        BoomAndWingtipDrogue,
		
        /// <summary>
        /// A component of a refuelling system by which a centreline drogue device can provide fuel on a receiver aircraft.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CD")]
        [EnumMember]
        CentrelineDrogue,
		
        /// <summary>
        /// Two components of a refuelling system by which centreline drogue and wingtip drogue devices can provide fuel on a receiver aircraft.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CDWD")]
        [EnumMember]
        CentrelineDrogueAndWingtipDrogue,
		
        /// <summary>
        /// A component of a refuelling system by which a wingtip drogue device can provide fuel on a receiver aircraft.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("WD")]
        [EnumMember]
        WingtipDrogue,
		
        /// <summary>
        /// Hand tool consisting of a handle with a head of metal or other heavy rigid material, used for striking or pounding.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("HAMMER")]
        [EnumMember]
        Hammer,
		
        /// <summary>
        /// Pincers, usually small, having long jaws mostly with parallel surfaces, sometimes toothed, used for bending wire, manipulating small objects, etc.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("PLIERS")]
        [EnumMember]
        Pliers,
		
        /// <summary>
        /// Hand tool for lifting loose material; consists of a curved container or scoop and a handle.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SHOVEL")]
        [EnumMember]
        Shovel,
		
    }
}

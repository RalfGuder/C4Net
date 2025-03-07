using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the current colour scheme of a specific MATERIEL.
    /// </summary>
    [DomId(100000389)]
    [DataContract]
    public enum MaterielStatusBodyColourEnum
    {
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AUBURN")]
        [EnumMember]
        Auburn,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BEIGE")]
        [EnumMember]
        Beige,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BLACK")]
        [EnumMember]
        Black,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BLUE")]
        [EnumMember]
        Blue,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BLUELG")]
        [EnumMember]
        BlueLight,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("BRONZE")]
        [EnumMember]
        Bronze,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("BROWN")]
        [EnumMember]
        Brown,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CHROME")]
        [EnumMember]
        Chrome,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("COPPER")]
        [EnumMember]
        Copper,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CREAM")]
        [EnumMember]
        Cream,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("GOLD")]
        [EnumMember]
        Gold,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("GREEN")]
        [EnumMember]
        Green,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("GREEND")]
        [EnumMember]
        GreenDark,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("GREENL")]
        [EnumMember]
        GreenLight,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("GREY")]
        [EnumMember]
        Grey,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("LAVNDR")]
        [EnumMember]
        Lavender,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MAROON")]
        [EnumMember]
        Maroon,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MULTI")]
        [EnumMember]
        Multicoloured,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("ORANGE")]
        [EnumMember]
        Orange,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("PURPLE")]
        [EnumMember]
        Purple,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("RUST")]
        [EnumMember]
        Rust,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SILVER")]
        [EnumMember]
        Silver,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("TAN")]
        [EnumMember]
        Tan,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("TURQSE")]
        [EnumMember]
        Turquoise,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("WHITE")]
        [EnumMember]
        White,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("YELLOW")]
        [EnumMember]
        Yellow,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("CAMDSG")]
        [EnumMember]
        CamouflageDesertGrey,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("CAMDSR")]
        [EnumMember]
        CamouflageDesertRed,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("CAMWOD")]
        [EnumMember]
        CamouflageWoodland,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("CAMWNT")]
        [EnumMember]
        CamouflageWinter,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the colour of the markings of a specific MATERIEL.
    /// </summary>
    [DomId(100000391)]
    [DataContract]
    public enum MaterielStatusMarkingColourEnum
    {
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BLACK")]
        [EnumMember]
        Black,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BLUE")]
        [EnumMember]
        Blue,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BROWN")]
        [EnumMember]
        Brown,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("GREEN")]
        [EnumMember]
        Green,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GREY")]
        [EnumMember]
        Grey,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ORANGE")]
        [EnumMember]
        Orange,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PURPLE")]
        [EnumMember]
        Purple,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SILVER")]
        [EnumMember]
        Silver,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("TAN")]
        [EnumMember]
        Tan,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("WHITE")]
        [EnumMember]
        White,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("YELLOW")]
        [EnumMember]
        Yellow,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

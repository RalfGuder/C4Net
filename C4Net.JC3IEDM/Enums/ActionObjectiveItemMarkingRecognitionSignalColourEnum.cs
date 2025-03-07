using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the coloration of the marking signal.
    /// </summary>
    [DomId(100004145)]
    [DataContract]
    public enum ActionObjectiveItemMarkingRecognitionSignalColourEnum
    {
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BLUE")]
        [EnumMember]
        Blue,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GREEN")]
        [EnumMember]
        Green,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ORANGE")]
        [EnumMember]
        Orange,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PURPLE")]
        [EnumMember]
        Purple,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("WHITE")]
        [EnumMember]
        White,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("YELLOW")]
        [EnumMember]
        Yellow,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the colour of the flare released by the exercise mine.
    /// </summary>
    [DomId(100004344)]
    [DataContract]
    public enum AmmunitionTypeExerciseMineFlareColourEnum
    {
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("GREEN")]
        [EnumMember]
        Green,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ORANGE")]
        [EnumMember]
        Orange,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("WHITE")]
        [EnumMember]
        White,
		
        /// <summary>
        /// Self defined.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("YELLOW")]
        [EnumMember]
        Yellow,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether an aircraft can be used for training purposes.
    /// </summary>
    [DomId(100004372)]
    [DataContract]
    public enum AircraftTypeTrainingCategoryEnum
    {
		
        /// <summary>
        /// The AIRCRAFT-TYPE is not designed to be used as a trainer.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The AIRCRAFT-TYPE is designed to be used as a trainer.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

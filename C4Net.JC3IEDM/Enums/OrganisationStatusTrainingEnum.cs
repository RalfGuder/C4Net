using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the assessed training status of a specific ORGANISATION.
    /// </summary>
    [DomId(100004199)]
    [DataContract]
    public enum OrganisationStatusTrainingEnum
    {
		
        /// <summary>
        /// A status indicating that the training level of an ORGANISATION is between 60% and 80%.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AMBER")]
        [EnumMember]
        Amber,
		
        /// <summary>
        /// A status indicating that the training level of an ORGANISATION is greater than 80%.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GREEN")]
        [EnumMember]
        Green,
		
        /// <summary>
        /// A status indicating that the training level of an ORGANISATION is less than 60%.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

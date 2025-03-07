using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of NETWORK.
    /// </summary>
    [DomId(100004122)]
    [DataContract]
    public enum NetworkCategoryEnum
    {
		
        /// <summary>
        /// A broadcast network used to transport voice and/or data.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BRDCST")]
        [EnumMember]
        Broadcast,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A transmission where information is transferred between two nodes.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("PTTOPT")]
        [EnumMember]
        PointToPoint,
		
        /// <summary>
        /// A mode of transmission where information is conveyed from one sender to a determined number of receivers
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MLTCST")]
        [EnumMember]
        Multicast,
		
    }
}

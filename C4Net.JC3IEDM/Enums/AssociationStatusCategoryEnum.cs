using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific status refers to the beginning or termination of the association.
    /// </summary>
    [DomId(100004242)]
    [DataContract]
    public enum AssociationStatusCategoryEnum
    {
		
        /// <summary>
        /// The period of effectiveness of the specific association is beginning.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("START")]
        [EnumMember]
        Start,
		
        /// <summary>
        /// The period of effectiveness of the specific association is terminating.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("END")]
        [EnumMember]
        End,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-OBJECTIVE-TYPE.
    /// </summary>
    [DomId(100004251)]
    [DataContract]
    public enum ActionObjectiveTypeCategoryEnum
    {
		
        /// <summary>
        /// The intended characteristics of a specific ACTION-OBJECTIVE-TYPE-IMAGERY-PRODUCT that is an instance of MATERIEL-TYPE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AOTIMG")]
        [EnumMember]
        ActionObjectiveTypeImageryProduct,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

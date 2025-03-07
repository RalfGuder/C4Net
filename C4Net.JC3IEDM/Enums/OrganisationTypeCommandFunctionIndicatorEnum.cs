using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether an ORGANISATION-TYPE has a command function.
    /// </summary>
    [DomId(100004194)]
    [DataContract]
    public enum OrganisationTypeCommandFunctionIndicatorEnum
    {
		
        /// <summary>
        /// The ORGANISATION-TYPE does not have a command function.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The ORGANISATION-TYPE does have a command function.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}

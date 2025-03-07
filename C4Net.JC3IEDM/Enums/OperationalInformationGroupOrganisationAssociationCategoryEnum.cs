using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between a specific OPERATIONAL-INFORMATION-GROUP and a specific ORGANISATION in a specific OPERATIONAL-INFORMATION-GROUP-ORGANISATION-ASSOCIATION.
    /// </summary>
    [DomId(100004247)]
    [DataContract]
    public enum OperationalInformationGroupOrganisationAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP has the specific ORGANISATION as the operationally responsible party for creating and populating it.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RESP")]
        [EnumMember]
        IsUnderOperationalResponsibilityOf,
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP is currently maintained by the specified ORGANISATION on behalf of the operationally responsible organisation.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PROXY")]
        [EnumMember]
        IsUnderProxyResponsibilityFor,
		
    }
}

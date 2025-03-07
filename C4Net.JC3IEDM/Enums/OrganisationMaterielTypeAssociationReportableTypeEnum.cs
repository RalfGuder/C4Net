using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ORGANISATION-MATERIEL-TYPE-ASSOCIATION.
    /// </summary>
    [DomId(100004239)]
    [DataContract]
    public enum OrganisationMaterielTypeAssociationReportableTypeEnum
    {
		
        /// <summary>
        /// A designation of the additional reference given to a MATERIEL-TYPE that has not been assigned a value from Reportable Item Code list but still needed in Land Forces Reportable Item List.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LFRIL")]
        [EnumMember]
        LandForcesReportableItemList,
		
        /// <summary>
        /// A designation of the additional reference given to a MATERIEL-TYPE as assigned in the official list containing Reportable Item Codes issued by NATO.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RIC")]
        [EnumMember]
        ReportableItemCode,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of OPERATIONAL-INFORMATION-GROUP.
    /// </summary>
    [DomId(100004248)]
    [DataContract]
    public enum OperationalInformationGroupCategoryEnum
    {
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP represents aggregated data about opposing or unknown force elements. Both factual reports and estimates may be included as part of the OPERATIONAL-INFORMATION-GROUP.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CORENU")]
        [EnumMember]
        CorrelatedEnemyAndUnknown,
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP represents essential data about friendly and neutral organisations. The data set includes as a minimum holdings, status, and location.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FRDNEU")]
        [EnumMember]
        FriendlyAndNeutralOrganisational,
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP represents data about objects, such as facilities and control measures, that a given organisation controls or is responsible for directly.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FRNENO")]
        [EnumMember]
        FriendlyAndNeutralNonOrganisational,
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP represents data that cannot be aggregated and does not fall within the scope of other predefined subcategories.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GLBSGN")]
        [EnumMember]
        GloballySignificant,
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP represents factual data about individual detection or report of opposing or unknown force elements without the data being aggregated.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("UNCORR")]
        [EnumMember]
        UncorrelatedEnemyAndUnknown,
		
        /// <summary>
        /// The specific OPERATIONAL-INFORMATION-GROUP represents planning and/or order data that is to be distributed as a package.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PLNORD")]
        [EnumMember]
        PlansOrders,
		
    }
}

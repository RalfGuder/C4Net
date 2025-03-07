using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of ORDER.
    /// </summary>
    [DomId(100004382)]
    [DataContract]
    public enum OrderCategoryEnum
    {
		
        /// <summary>
        /// An order to give the commander’s plan for administrative and service support of operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADLOGO")]
        [EnumMember]
        AdministrativeLogisticsOrder,
		
        /// <summary>
        /// An abbreviated form of an Operations order.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FRAGO")]
        [EnumMember]
        FragmentaryOrderToExistingOperationOrder,
		
        /// <summary>
        /// An order that includes only such detail as is necessary for commanders of subordinate formations/units to issue their own orders and to ensure coordination.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("OPORD")]
        [EnumMember]
        OperationsOrder,
		
        /// <summary>
        /// An order to assist units and their staffs initiate the preparations for and the execution of their new mission by giving them the maximum warning and essential details of impending operations and information of time available.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("WNGO")]
        [EnumMember]
        WarningOrder,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

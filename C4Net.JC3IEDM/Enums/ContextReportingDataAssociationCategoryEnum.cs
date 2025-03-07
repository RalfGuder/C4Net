using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relation of a specific CONTEXT with a specific REPORTING-DATA.
    /// </summary>
    [DomId(100000295)]
    [DataContract]
    public enum ContextReportingDataAssociationCategoryEnum
    {
		
        /// <summary>
        /// A relationship between a REPORTING-DATA and a CONTEXT that is the logical consequence of the CONTEXT.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("IMPL")]
        [EnumMember]
        Implies,
		
        /// <summary>
        /// A relationship between a REPORTING-DATA and a CONTEXT with the purpose of amending the CONTEXT.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CORR")]
        [EnumMember]
        IsACorrectionOf,
		
        /// <summary>
        /// A relationship between a REPORTING-DATA and a CONTEXT in which the data referenced by REPORTING-DATA affirms the data referenced by CONTEXT.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CONF")]
        [EnumMember]
        IsConfirmedBy,
		
        /// <summary>
        /// A relationship between a REPORTING-DATA and a CONTEXT, where the information referred to by the REPORTING-DATA is in any way contradictory to the information referred to by the CONTEXT.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NEGA")]
        [EnumMember]
        IsNegatedBy,
		
        /// <summary>
        /// A relationship between a REPORTING-DATA and a CONTEXT, where the information referred to by the REPORTING-DATA replaces the information referred to by the CONTEXT.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SUPR")]
        [EnumMember]
        IsSupersededBy,
		
        /// <summary>
        /// A relationship between a REPORTING-DATA and a CONTEXT in which a CONTEXT is recorded as a REPORTING-DATA.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISDFT")]
        [EnumMember]
        IsDefinedToBe,
		
    }
}

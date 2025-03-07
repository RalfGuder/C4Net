using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the nature of the ACTION-CONTEXT as it relates to a specific ACTION and a specific CONTEXT.
    /// </summary>
    [DomId(100000179)]
    [DataContract]
    public enum ActionContextCategoryEnum
    {
		
        /// <summary>
        /// An actual specific CONTEXT as it exists at the end of a specific ACTION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FINACT")]
        [EnumMember]
        FinalStateActual,
		
        /// <summary>
        /// A planned specific CONTEXT that may exist at the end of a specific ACTION.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FINPLA")]
        [EnumMember]
        FinalStatePlanning,
		
        /// <summary>
        /// An actual specific CONTEXT as it exists at the start of a specific ACTION.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INIACT")]
        [EnumMember]
        InitialStateActual,
		
        /// <summary>
        /// A planned specific CONTEXT that may exist at the start of a specific ACTION.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("INIPLA")]
        [EnumMember]
        InitialStatePlanning,
		
        /// <summary>
        /// An actual specific CONTEXT as it exists at an intermediate point during the execution of a specific ACTION.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("INTACT")]
        [EnumMember]
        IntermediateStateActual,
		
        /// <summary>
        /// A planned specific CONTEXT that may exist at an intermediate point during the execution of a specific ACTION.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("INTPLA")]
        [EnumMember]
        IntermediateStatePlanning,
		
        /// <summary>
        /// An expected positive consequence of a specific CONTEXT in relation to a specific ACTION.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DES")]
        [EnumMember]
        Desired,
		
        /// <summary>
        /// The maximum value referred to by a specific CONTEXT that is necessary for the evolution of a specific ACTION.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MAX")]
        [EnumMember]
        MaximumRequired,
		
        /// <summary>
        /// The minimum value referred to by a specific CONTEXT that is necessary for the evolution of a specific ACTION.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MIN")]
        [EnumMember]
        MinimumRequired,
		
        /// <summary>
        /// The specific ACTION is encompassed within the information content of a specific CONTEXT.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ISINCL")]
        [EnumMember]
        IsIncludedIn,
		
    }
}

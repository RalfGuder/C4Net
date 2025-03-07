using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CONTEXT.
    /// </summary>
    [DomId(100004244)]
    [DataContract]
    public enum ContextCategoryEnum
    {
		
        /// <summary>
        /// Information encompassed by the CONTEXT is the subject for an assessment.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ASSESS")]
        [EnumMember]
        Assessment,
		
        /// <summary>
        /// Information encompassed by the CONTEXT is the basis for a summary arrived at through a process of correlation.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CORREL")]
        [EnumMember]
        Correlation,
		
        /// <summary>
        /// A CONTEXT that encompasses a set of pre-defined operational information.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("OIG")]
        [EnumMember]
        OperationalInformationGroup,
		
        /// <summary>
        /// Information encompassed by the CONTEXT is the basis for an overlay.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OVERLY")]
        [EnumMember]
        Overlay,
		
        /// <summary>
        /// Information encompassed by the CONTEXT is to be corrected.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CORREC")]
        [EnumMember]
        Correction,
		
        /// <summary>
        /// Information encompassed by the CONTEXT is to be declared untrue.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NEGATE")]
        [EnumMember]
        Negation,
		
        /// <summary>
        /// Information encompassed by the CONTEXT is the basis for a forecast.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PREDCT")]
        [EnumMember]
        Prediction,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

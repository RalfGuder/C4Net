using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the pavement evaluation method classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
    /// </summary>
    [DomId(100004278)]
    [DataContract]
    public enum RunwayPavementEvaluationMethodEnum
    {
		
        /// <summary>
        /// The specific value, which indicates that the pavement evaluation method is determined by experience of aircraft using the pavement.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("U")]
        [EnumMember]
        ByExperience,
		
        /// <summary>
        /// The specific value, which indicates that the pavement evaluation method is based on a technical study.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("T")]
        [EnumMember]
        TechnicalEvaluation,
		
    }
}

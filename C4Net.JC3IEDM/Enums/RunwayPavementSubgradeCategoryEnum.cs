using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the pavement subgrade classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
    /// </summary>
    [DomId(100004276)]
    [DataContract]
    public enum RunwayPavementSubgradeCategoryEnum
    {
		
        /// <summary>
        /// The specific value that indicates that the pavement subgrade is characterised by a (spring constant) K value greater than 400 pci (pavement condition index) for rigid pavements, and by a (California Bearing Ratio) CBR value above 13% for flexible pavements.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("A")]
        [EnumMember]
        High,
		
        /// <summary>
        /// The specific value that indicates that the pavement subgrade is characterised by a (spring constant) K value between 100 and 200 pci (pavement condition index) for rigid pavements, and by (California Bearing Ratio) CBR of 5 to 8% for flexible pavements.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("C")]
        [EnumMember]
        Low,
		
        /// <summary>
        /// The specific value that indicates that the pavement subgrade is characterised by a (spring constant) K value between 201 to 400 pci (pavement condition index) for rigid pavements, and by (California Bearing Ratio) CBR of 9 to 13% for flexible pavements.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("B")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// The specific value that indicates that the pavement subgrade is characterised by a (spring constant) K value less than 100 pci (pavement condition index) for rigid pavements, and by a (California Bearing Ratio) CBR value less than 5% for flexible pavements.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("D")]
        [EnumMember]
        UltraLow,
		
    }
}

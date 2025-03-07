using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MATERIEL.
    /// </summary>
    [DomId(100004316)]
    [DataContract]
    public enum MaterielCategoryEnum
    {
		
        /// <summary>
        /// A MATERIEL that provides aircraft with horizontal and vertical guidance just before landing and during landing, and at certain fixed points, indicates the distance to the reference point of landing.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ILS")]
        [EnumMember]
        InstrumentLandingSystem,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

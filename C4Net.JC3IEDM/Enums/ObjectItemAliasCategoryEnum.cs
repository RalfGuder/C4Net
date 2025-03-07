using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of OBJECT-ITEM-ALIAS.
    /// </summary>
    [DomId(100004237)]
    [DataContract]
    public enum ObjectItemAliasCategoryEnum
    {
		
        /// <summary>
        /// A standard coded representation of a geolocation of a military organisation or a place with military significance.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("GEOLOC")]
        [EnumMember]
        Geolocation,
		
        /// <summary>
        /// A designation of the common additional reference given to an OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ALTNAM")]
        [EnumMember]
        AlternateName,
		
        /// <summary>
        /// An identifier that is used in track reporting.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TRACK")]
        [EnumMember]
        TrackIdentifier,
		
        /// <summary>
        /// A 5-character ELINT notation for non-communications electronics emissions related to such equipments.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ELINT")]
        [EnumMember]
        ElintNotation,
		
        /// <summary>
        /// A 4-character code which facilitates reporting equipment type that has no associated ELINT notation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("EMSSNS")]
        [EnumMember]
        EmissionsSortingCode,
		
        /// <summary>
        /// The designator of the unit that is tasked to perform the mission, for example: "UNIT:ARS BROCKZETEL".
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("UNITDS")]
        [EnumMember]
        UnitDesignator,
		
    }
}

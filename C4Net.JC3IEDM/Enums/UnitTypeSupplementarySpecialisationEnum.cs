using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that supplements the designation of a particular UNIT-TYPE.
    /// </summary>
    [DomId(100004186)]
    [DataContract]
    public enum UnitTypeSupplementarySpecialisationEnum
    {
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, employs helicopter assets as an integral element of its assault operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARASLT")]
        [EnumMember]
        AirAssault,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, is specially trained to carry out operations, either by paradrop or air landing, following an air movement.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRBRN")]
        [EnumMember]
        Airborne,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, is able to conduct an operation launched from the sea by military forces against a hostile or potentially hostile shore.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AMPH")]
        [EnumMember]
        Amphibious,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, is able to perform a mission in arctic environment.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARCTIC")]
        [EnumMember]
        Arctic,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, employs principally armoured assets.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ARMORD")]
        [EnumMember]
        Armoured,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, is equipped with materiel of small weight.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LIGHT")]
        [EnumMember]
        LightUnit,
		
        /// <summary>
        /// A UNIT-TYPE that is capable of performing marine operations in addition to its primary function.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MARINE")]
        [EnumMember]
        Marine,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, employs principally mechanised assets.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MECH")]
        [EnumMember]
        Mechanised,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, employs principally motorised assets.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MTRSD")]
        [EnumMember]
        Motorised,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, is dedicated to conduct military operations in mountainous areas.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MOUNTN")]
        [EnumMember]
        Mountain,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, is dedicated to conduct operations in a maritime environment.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NAVAL")]
        [EnumMember]
        Naval,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, employs principally air assets.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("AIR")]
        [EnumMember]
        Air,
		
        /// <summary>
        /// A UNIT-TYPE that, whatever its primary function is, employs principally ground assets.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("GROUND")]
        [EnumMember]
        Ground,
		
    }
}

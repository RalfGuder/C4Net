using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of UNIT-TYPE.
    /// </summary>
    [DomId(100000333)]
    [DataContract]
    public enum UnitTypeCategoryEnum
    {
		
        /// <summary>
        /// A UNIT-TYPE who closes with and destroys enemy forces or provides firepower and destructive capabilities in the battlespace.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COMBAT")]
        [EnumMember]
        Combat,
		
        /// <summary>
        /// A UNIT-TYPE tasked to provide support to combat forces, primarily in the fields of administration and logistics.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("COMSER")]
        [EnumMember]
        CombatServiceSupport,
		
        /// <summary>
        /// A UNIT-TYPE that provides critical combat functions in conjunction with combat arms units and soldiers.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COMSPT")]
        [EnumMember]
        CombatSupport,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A UNIT-TYPE that provides unique capabilities of special reconnaissance, direct action and military assistance in order to undertake difficult, dangerous and sometimes politically sensitive missions for the theatre commander.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SOF")]
        [EnumMember]
        SpecialOperationsForces,
		
    }
}

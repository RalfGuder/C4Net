using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the NATO supply class of MATERIEL-TYPE.
    /// </summary>
    [DomId(100000398)]
    [DataContract]
    public enum MaterielTypeSupplyClassEnum
    {
		
        /// <summary>
        /// Items that are consumed by personnel and animals at an approximately uniform rate, irrespective of local changes in combat or terrain conditions, e.g. food and forage.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CLS1")]
        [EnumMember]
        ClassI,
		
        /// <summary>
        /// Supplies for which allowances are established by tables of organisation and equipment, e.g. clothing, weapons, tools, spare parts, vehicles.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CLS2")]
        [EnumMember]
        ClassIi,
		
        /// <summary>
        /// Fuel and lubricants for all purposes, except for operating aircraft or for use in weapons such as flame-throwers, e.g. gasoline, fuel oil, greases, coal and coke.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CLS3")]
        [EnumMember]
        ClassIii,
		
        /// <summary>
        /// Aviation fuel and lubricants.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CLS3A")]
        [EnumMember]
        ClassIiia,
		
        /// <summary>
        /// Supplies for which initial use allowances are not prescribed by approved issue tables. Normally includes fortification and construction materials, as well as additional quantities of items identical to those authorised for initial issue (Class II) such as additional vehicles.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CLS4")]
        [EnumMember]
        ClassIv,
		
        /// <summary>
        /// Ammunition, explosives and chemical agents of all types.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CLS5")]
        [EnumMember]
        ClassV,
		
    }
}

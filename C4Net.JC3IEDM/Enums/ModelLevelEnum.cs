using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the data model source of the object.
    /// </summary>
    [DomId(100006013)]
    [DataContract]
    public enum ModelLevelEnum
    {
		
        /// <summary>
        /// Application level, denoting a part of a data model.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("APPL")]
        [EnumMember]
        Application,
		
        /// <summary>
        /// Dictionary level, denoting a part of a data model.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DICT")]
        [EnumMember]
        Dictionary,
		
        /// <summary>
        /// MIP JC3IEDM metamodel management.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("META")]
        [EnumMember]
        Metamodel,
		
    }
}

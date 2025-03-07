using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION.
    /// </summary>
    [DomId(100000110)]
    [DataContract]
    public enum ActionCategoryEnum
    {
		
        /// <summary>
        /// An ACTION that is an incident, phenomenon, or occasion of military significance which has occurred or is occurring but for which planning is not known.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ACTEV")]
        [EnumMember]
        ActionEvent,
		
        /// <summary>
        /// An ACTION that is being or has been planned and for which the planning details are known.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ACTTA")]
        [EnumMember]
        ActionTask,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a restriction or other qualification applicable to a specific ACTION-OBJECTIVE for a specific ACTION.
    /// </summary>
    [DomId(100000116)]
    [DataContract]
    public enum ActionObjectiveQualifierEnum
    {
		
        /// <summary>
        /// The ACTION-OBJECTIVE is authorised without restriction.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AUTH")]
        [EnumMember]
        Authorised,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no exploitation east of it.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NEEL")]
        [EnumMember]
        NoExploitationEastOfLine,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no exploitation north of it.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NENL")]
        [EnumMember]
        NoExploitationNorthOfLine,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no exploitation south of it.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NESL")]
        [EnumMember]
        NoExploitationSouthOfLine,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no exploitation west of it.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NEWL")]
        [EnumMember]
        NoExploitationWestOfLine,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is not authorised.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOTA")]
        [EnumMember]
        NotAuthorised,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no movement below or within it.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("STAYAB")]
        [EnumMember]
        StayAbove,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no movement above or within it.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("STAYBL")]
        [EnumMember]
        StayBelow,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no movement outside it.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("STAYIN")]
        [EnumMember]
        StayInside,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE is authorised with the restriction that there is to be no movement inside it.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("STAYOT")]
        [EnumMember]
        StayOutside,
		
        /// <summary>
        /// The specific ACTION-OBJECTIVE (e.g. hospitals or friendly forces) must not be attacked.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DONTAT")]
        [EnumMember]
        DoNotAttack,
		
    }
}

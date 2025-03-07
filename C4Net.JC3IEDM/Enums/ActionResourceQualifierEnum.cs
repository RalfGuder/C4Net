using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of restriction or other qualification applicable to a specific ACTION-RESOURCE for a specific ACTION.
    /// </summary>
    [DomId(100000119)]
    [DataContract]
    public enum ActionResourceQualifierEnum
    {
		
        /// <summary>
        /// The specified ACTION-RESOURCE is authorised for use without restriction.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AUTH")]
        [EnumMember]
        AuthorisedForUse,
		
        /// <summary>
        /// The specified ACTION-RESOURCE is authorised and its use is to be maximised.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MAXU")]
        [EnumMember]
        MaximiseUseOf,
		
        /// <summary>
        /// The specified ACTION-RESOURCE is authorised, but use of it is to be minimised to only that which is operationally necessary in the opinion of the authorised commander.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MINU")]
        [EnumMember]
        MinimiseUseOf,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no exploitation east of it.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NEEL")]
        [EnumMember]
        NoExploitationEastOfLine,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no exploitation north of it.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NENL")]
        [EnumMember]
        NoExploitationNorthOfLine,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no exploitation south of it.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NESL")]
        [EnumMember]
        NoExploitationSouthOfLine,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no exploitation west of it.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NEWL")]
        [EnumMember]
        NoExploitationWestOfLine,
		
        /// <summary>
        /// The specified ACTION-RESOURCE is not authorised for use.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOTA")]
        [EnumMember]
        NotAuthorised,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no movement below or within it.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("STAYAB")]
        [EnumMember]
        StayAbove,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no movement above or within it.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("STAYBL")]
        [EnumMember]
        StayBelow,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no movement outside it.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("STAYIN")]
        [EnumMember]
        StayInside,
		
        /// <summary>
        /// The specific ACTION-RESOURCE is authorised with the restriction that there is to be no movement within it.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("STAYOT")]
        [EnumMember]
        StayOutside,
		
    }
}

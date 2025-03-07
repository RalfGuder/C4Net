using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type classification of a specific REQUEST.
    /// </summary>
    [DomId(100000217)]
    [DataContract]
    public enum RequestCategoryEnum
    {
		
        /// <summary>
        /// To discover the actions of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACTION")]
        [EnumMember]
        Action,
		
        /// <summary>
        /// To discover the relation between two ACTION-OBJECTIVEs (OBJECT-ITEMs) by any means.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ASSOC")]
        [EnumMember]
        Association,
		
        /// <summary>
        /// To discover the capability of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CAPAB")]
        [EnumMember]
        Capability,
		
        /// <summary>
        /// To discover the holding of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HOLDNG")]
        [EnumMember]
        Holding,
		
        /// <summary>
        /// To recognise the friendly or enemy character of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("HOSTIL")]
        [EnumMember]
        Hostility,
		
        /// <summary>
        /// To discover the location of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LOCATN")]
        [EnumMember]
        Location,
		
        /// <summary>
        /// To discover the manifestation of an ACTION-OBJECTIVE in the area of operational interest specified through another ACTION-OBJECTIVE (OBJECT-ITEM: FACILITY, FEATURE).
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PRESNC")]
        [EnumMember]
        Presence,
		
        /// <summary>
        /// To recognise the status of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("STATUS")]
        [EnumMember]
        Status,
		
        /// <summary>
        /// To recognise the type of an ACTION-OBJECTIVE (OBJECT-ITEM) by any means.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TYPE")]
        [EnumMember]
        Type,
		
    }
}

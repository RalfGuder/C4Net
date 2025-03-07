using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of document used to identify a specific PERSON.
    /// </summary>
    [DomId(100000381)]
    [DataContract]
    public enum PersonIdentificationDocumentEnum
    {
		
        /// <summary>
        /// The PERSON is identified by a passport.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PSSPRT")]
        [EnumMember]
        Passport,
		
        /// <summary>
        /// The PERSON is identified by a civilian identification card.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CIVID")]
        [EnumMember]
        CivilianIdentificationCard,
		
        /// <summary>
        /// The PERSON is identified by a military identification card.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MILID")]
        [EnumMember]
        MilitaryIdentificationCard,
		
        /// <summary>
        /// The PERSON is identified by military orders.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MILORD")]
        [EnumMember]
        MilitaryOrders,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

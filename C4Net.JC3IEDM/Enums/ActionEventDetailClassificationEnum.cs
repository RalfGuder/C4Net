using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the classification of a specific ACTION-EVENT according to a broad subject area.
    /// </summary>
    [DomId(100000399)]
    [DataContract]
    public enum ActionEventDetailClassificationEnum
    {
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within an economic area of activity.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ECONMC")]
        [EnumMember]
        Economic,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within an ethnic area of activity.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ETHNIC")]
        [EnumMember]
        Ethnic,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within an historical area of activity.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HSTRCL")]
        [EnumMember]
        Historical,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within a labour area of activity.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LABOUR")]
        [EnumMember]
        Labour,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within a military area of activity.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MILTRY")]
        [EnumMember]
        Military,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within a political area of activity.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("POLTCL")]
        [EnumMember]
        Political,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within a religious area of activity.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RELIGS")]
        [EnumMember]
        Religious,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as occurring within a social area of activity.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SOCIAL")]
        [EnumMember]
        Social,
		
        /// <summary>
        /// The specific ACTION-EVENT can be characterised as resulting in a great or sudden misfortune.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DISAST")]
        [EnumMember]
        Disastrous,
		
        /// <summary>
        /// The specific ACTION-EVENT that is related to ecological or environmental conditions.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ENVIRN")]
        [EnumMember]
        Environmental,
		
    }
}

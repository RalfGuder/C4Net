using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the maximum resolution used for the expression of a value of an angle.
    /// </summary>
    [DomId(100004218)]
    [DataContract]
    public enum AnglePrecisionEnum
    {
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1/1000 of a minute.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("1000MN")]
        [EnumMember]
        _11000Minute,
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1/100 of a minute (centiminute).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("100MN")]
        [EnumMember]
        _1100Minute,
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1/100 of a second.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("100SEC")]
        [EnumMember]
        _1100Second,
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1/10 of a degree.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("10DEG")]
        [EnumMember]
        _110Degree,
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1/10 of a minute.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("10MN")]
        [EnumMember]
        _110Minute,
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1/10 of a second.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("10SEC")]
        [EnumMember]
        _110Second,
		
        /// <summary>
        /// Angular precision is expressed to the precision of a degree (60 minutes).
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DEGREE")]
        [EnumMember]
        Degree,
		
        /// <summary>
        /// Angular precision is expressed to the precision of 1 mil (1/6400 of a full circle).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MIL")]
        [EnumMember]
        Mil,
		
        /// <summary>
        /// Angular precision is expressed to the precision of a minute (60 seconds).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MINUTE")]
        [EnumMember]
        Minute,
		
        /// <summary>
        /// Angular precision is expressed to the precision of a second.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SECOND")]
        [EnumMember]
        Second,
		
    }
}

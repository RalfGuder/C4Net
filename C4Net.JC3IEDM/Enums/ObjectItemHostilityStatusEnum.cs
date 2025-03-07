using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the perceived hostility status of a specific OBJECT-ITEM.
    /// </summary>
    [DomId(100004376)]
    [DataContract]
    public enum ObjectItemHostilityStatusEnum
    {
		
        /// <summary>
        /// An OBJECT-ITEM that is assumed to be a friend because of its characteristics, behaviour or origin.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFR")]
        [EnumMember]
        AssumedFriend,
		
        /// <summary>
        /// An indication that the OBJECT-ITEM in question is likely to belong to enemy forces.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AHO")]
        [EnumMember]
        AssumedHostile,
		
        /// <summary>
        /// An indication that the OBJECT-ITEM in question is likely to belong to involved forces different from own, allied and enemy forces.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AIV")]
        [EnumMember]
        AssumedInvolved,
		
        /// <summary>
        /// An indication that the OBJECT-ITEM in question is likely to belong to neither own, allied, enemy or otherwise involved forces.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ANT")]
        [EnumMember]
        AssumedNeutral,
		
        /// <summary>
        /// An OBJECT-ITEM that belongs to a declared friendly nation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FR")]
        [EnumMember]
        Friend,
		
        /// <summary>
        /// An OBJECT-ITEM that is positively identified as enemy.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("HO")]
        [EnumMember]
        Hostile,
		
        /// <summary>
        /// An indication that the OBJECT-ITEM in question belongs to involved forces different from own, allied and enemy forces.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("IV")]
        [EnumMember]
        Involved,
		
        /// <summary>
        /// An OBJECT-ITEM whose characteristics, behaviour, origin or nationality indicate that it is neither supporting friendly nor opposing forces.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NEUTRL")]
        [EnumMember]
        Neutral,
		
        /// <summary>
        /// An OBJECT-ITEM that is a friendly aircraft simulating a hostile aircraft in an air defence exercise.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FAKER")]
        [EnumMember]
        Faker,
		
        /// <summary>
        /// An OBJECT-ITEM that is acting as a suspect track for exercise purposes only.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("JOKER")]
        [EnumMember]
        Joker,
		
        /// <summary>
        /// An OBJECT-ITEM for which identification is to be determined.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("PENDNG")]
        [EnumMember]
        Pending,
		
        /// <summary>
        /// An OBJECT-ITEM that is potentially hostile because of its characteristics, behaviour or origin.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SUSPCT")]
        [EnumMember]
        Suspect,
		
        /// <summary>
        /// An OBJECT-ITEM for which its hostility status information is not available.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("UNK")]
        [EnumMember]
        Unknown,
		
    }
}

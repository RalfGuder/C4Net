using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the intended function of the specific MINEFIELD-LAND.
    /// </summary>
    [DomId(100004196)]
    [DataContract]
    public enum MinefieldLandFunctionEnum
    {
		
        /// <summary>
        /// A minefield that is part of a formation obstacle plan and is laid to delay, channel or break up an enemy advance. A heavy minefield is categorised as one with 7 rows per kilometre depth at a standard spacing for the type of mine used.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HTACT")]
        [EnumMember]
        HeavyTactical,
		
        /// <summary>
        /// A minefield that is part of a formation obstacle plan and is laid to delay, channel or break up an enemy advance. A light minefield is categorised as one with 3 rows per kilometre depth at a standard spacing for the type of mine used.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LTACT")]
        [EnumMember]
        LightTactical,
		
        /// <summary>
        /// A minefield that is part of a formation obstacle plan and is laid to delay, channel or break up an enemy advance. A medium minefield is categorised as one with 5 rows per kilometre depth at a standard spacing for the type of mine used.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MTACT")]
        [EnumMember]
        MediumTactical,
		
        /// <summary>
        /// A minefield laid to delay and disorganise the enemy and to hinder his use of an area or route.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NUISNC")]
        [EnumMember]
        Nuisance,
		
        /// <summary>
        /// A minefield that denotes an area free of live mines used to simulate a minefield, or section of a minefield, with the object of deceiving the enemy.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PHONEY")]
        [EnumMember]
        Phoney,
		
        /// <summary>
        /// A minefield employed to protect an ORGANISATION, FACILITY, or FEATURE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PROTCT")]
        [EnumMember]
        Protective,
		
    }
}

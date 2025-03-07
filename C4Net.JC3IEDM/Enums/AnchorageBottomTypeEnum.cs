using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the description of the ground under the water of a lake, river, ocean, or other body of water at a specific ANCHORAGE.
    /// </summary>
    [DomId(100004175)]
    [DataContract]
    public enum AnchorageBottomTypeEnum
    {
		
        /// <summary>
        /// The surface consists of boulders larger than human head size.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BOULDR")]
        [EnumMember]
        Boulder,
		
        /// <summary>
        /// The surface consists of clay.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CLAY")]
        [EnumMember]
        Clay,
		
        /// <summary>
        /// The surface consists of cobbles up to human head size.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COBBLS")]
        [EnumMember]
        Cobbles,
		
        /// <summary>
        /// The surface consists of coral.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CORAL")]
        [EnumMember]
        Coral,
		
        /// <summary>
        /// The surface consists of gravel.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GRAVEL")]
        [EnumMember]
        Gravel,
		
        /// <summary>
        /// The surface consists of limestone.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LMNSTN")]
        [EnumMember]
        Limestone,
		
        /// <summary>
        /// The surface consists of mud.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MUD")]
        [EnumMember]
        Mud,
		
        /// <summary>
        /// The surface consists of mud and smooth sand.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MUDSND")]
        [EnumMember]
        MudSmoothSand,
		
        /// <summary>
        /// The surface consists of pebbles up to clenched fist size.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("PEBBLS")]
        [EnumMember]
        Pebbles,
		
        /// <summary>
        /// The surface is made of rock, not specified.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ROCK")]
        [EnumMember]
        Rock,
		
        /// <summary>
        /// The surface of the bottom is uneven, with holes, bumps and folds up to 30cm and/or a lot of seaweed.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ROUGH")]
        [EnumMember]
        Rough,
		
        /// <summary>
        /// The surface of the bottom is uneven and contains outcrops of rock and or coral.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("RGHCRL")]
        [EnumMember]
        RoughCoralRock,
		
        /// <summary>
        /// The surface consists of fine sand up to pinhead size.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SAND")]
        [EnumMember]
        Sand,
		
        /// <summary>
        /// The surface consists of sand between 0.5 and 2.0 mm in size.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SANDCR")]
        [EnumMember]
        SandCoarse,
		
        /// <summary>
        /// The surface consists of sand between 0.125 and 0.25mm in size.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SANDFN")]
        [EnumMember]
        SandFine,
		
        /// <summary>
        /// The surface consists of sand between 0.25 and 0.5mm in size.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SANDMD")]
        [EnumMember]
        SandMedium,
		
        /// <summary>
        /// The surface consists of sand up to 72mm in size.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SANDVC")]
        [EnumMember]
        SandVeryCoarse,
		
        /// <summary>
        /// The surface consists of sand between 0.063 and 0.125mm in size.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SANDVF")]
        [EnumMember]
        SandVeryFine,
		
        /// <summary>
        /// The surface is stable and smooth and contains ripples of less than 15cm.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SMTHFL")]
        [EnumMember]
        SmoothAndFlat,
		
        /// <summary>
        /// The surface is stable and smooth and contains holes, bumps and folds up to 30cm.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("STBLSM")]
        [EnumMember]
        StableAndSmooth,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

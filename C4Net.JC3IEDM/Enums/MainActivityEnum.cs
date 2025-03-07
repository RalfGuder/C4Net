using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the main activity of an ORGANISATION-TYPE.
    /// </summary>
    [DomId(100004101)]
    [DataContract]
    public enum MainActivityEnum
    {
		
        /// <summary>
        /// The activity that deals with providing agriculture services.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AGRCPR")]
        [EnumMember]
        AgriculturePrograms,
		
        /// <summary>
        /// The activity that deals with providing education services.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EDUCPR")]
        [EnumMember]
        EducationPrograms,
		
        /// <summary>
        /// The activity that deals with distribution of food.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FOODPR")]
        [EnumMember]
        FoodPrograms,
		
        /// <summary>
        /// The activity that deals with providing health care services.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HLTHPR")]
        [EnumMember]
        HealthPrograms,
		
        /// <summary>
        /// The activity that deals with providing infrastructure and construction repair services.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("INFSPR")]
        [EnumMember]
        InfrastructureAndConstructionRepairPrograms,
		
        /// <summary>
        /// The activity that deals with providing social programs.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SOCLPR")]
        [EnumMember]
        SocialPrograms,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CIVILIAN-POST-TYPE.
    /// </summary>
    [DomId(100000369)]
    [DataContract]
    public enum CivilianPostTypeCategoryEnum
    {
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is to manage or direct the affairs of an organisation that provides relief services.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIDADM")]
        [EnumMember]
        AidAdministrator,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job entails the participation in the legislative body of town or city governments.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ALDRMN")]
        [EnumMember]
        Alderman,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job entails the leadership in an executive or administrative function in a private sector business.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COREXC")]
        [EnumMember]
        CorporateExecutive,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job entails the leadership of a separate division or branch of an organisation.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DEPTHD")]
        [EnumMember]
        DepartmentHead,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job entails the lower level executive duties of the government.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GOVMST")]
        [EnumMember]
        GovernmentMinister,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is the executive leadership and administrative control over a group of people.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("GOVRNR")]
        [EnumMember]
        Governor,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is the supreme executive magistracy of a country.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("HEADST")]
        [EnumMember]
        HeadOfState,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is the chief officer of the municipal corporation of a city or borough.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MAYOR")]
        [EnumMember]
        Mayor,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is the chief officer of a civil force to which is entrusted the duty of maintaining public order, enforcing regulations and detecting crime.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("POLCHF")]
        [EnumMember]
        PoliceChief,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is to manage or direct the affairs of a regional organisation.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("REGADM")]
        [EnumMember]
        RegionalAdministrator,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose business is the issuing of books, newspapers, music, engravings, videos or the like, as the agent of the author or owner.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("PUBLSR")]
        [EnumMember]
        Publisher,
		
        /// <summary>
        /// A CIVILIAN-POST-TYPE whose job is to authorize the release of a product or information.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("RELATH")]
        [EnumMember]
        ReleaseAuthority,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a designation for a military or naval grade that establishes the relative position or status of a specific MILITARY-POST-TYPE.
    /// </summary>
    [DomId(100000376)]
    [DataContract]
    public enum MilitaryPostTypeRankEnum
    {
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for an individual in the armed forces without an officer's commission, warrant or other rank conferring leadership over other servicemen.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EPTE")]
        [EnumMember]
        EnlistedPrivate,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Lieutenant/Second Lieutenant/Midshipman/Sub-Lieutenant/Pilot Officer/Flying Officer.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OF1")]
        [EnumMember]
        Of1,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Captain/Lieutenant/Flight Lieutenant.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("OF2")]
        [EnumMember]
        Of2,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Major/Lieutenant-Commander/Squadron Leader.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OF3")]
        [EnumMember]
        Of3,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Lieutenant Colonel/Commander/Wing Commander.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("OF4")]
        [EnumMember]
        Of4,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Colonel/Captain (under 6 years of seniority)/Group Captain.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("OF5")]
        [EnumMember]
        Of5,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Brigadier Captain (over 6 years seniority)/Air Commodore.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("OF6")]
        [EnumMember]
        Of6,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Major General/Rear Admiral/Air Vice Marshal.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("OF7")]
        [EnumMember]
        Of7,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Lieutenant General/Vice Admiral/Air Marshall.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("OF8")]
        [EnumMember]
        Of8,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of General/Admiral/Air Chief Marshal.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("OF9")]
        [EnumMember]
        Of9,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the officer rank of Field Marshal/Fleet Admiral/General of the Air Force.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("OF10")]
        [EnumMember]
        Of10,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for an individual who is invested with authority by means of a commission in the armed forces.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("OFFR")]
        [EnumMember]
        OfficerNotOtherwiseSpecified,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Private (Class 4)/Seaman Recruit/Basic Airman.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("OR1")]
        [EnumMember]
        Or1,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Private (Class 1-3)/Seaman Apprentice/Airman.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("OR2")]
        [EnumMember]
        Or2,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Lance Corporal/Seaman/Airman First Class.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("OR3")]
        [EnumMember]
        Or3,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Corporal/Petty Officer Third Class/Senior Airman/Sergeant.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("OR4")]
        [EnumMember]
        Or4,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Sergeant (Junior)/Petty Officer second Class/Staff Sergeant.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("OR5")]
        [EnumMember]
        Or5,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Sergeant (3 Years Seniority)/Petty Officer First Class/Technical Sergeant.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("OR6")]
        [EnumMember]
        Or6,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Staff Sergeant/Chief Petty Officer First Class/Master Sergeant.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("OR7")]
        [EnumMember]
        Or7,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Warrant Officer Class 2/Senior Chief Petty Officer/Senior Master Sergeant.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("OR8")]
        [EnumMember]
        Or8,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for the rank of Warrant Officer Class 1/Master Chief Petty Officer/Chief Master Sergeant.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("OR9")]
        [EnumMember]
        Or9,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for an enlisted member of the armed forces appointed to a rank conferring leadership over other servicemen.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("NCO")]
        [EnumMember]
        NcoNotOtherwiseSpecified,
		
        /// <summary>
        /// The specification of a MILITARY-POST-TYPE as being appropriate for an individual who does not hold an officer's commission in the armed forces.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("OTHR")]
        [EnumMember]
        OtherRanks,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

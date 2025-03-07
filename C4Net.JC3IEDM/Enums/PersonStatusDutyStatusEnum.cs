using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the availability of a specific PERSON for duty at a military or civilian post of employment.
    /// </summary>
    [DomId(100000102)]
    [DataContract]
    public enum PersonStatusDutyStatusEnum
    {
		
        /// <summary>
        /// Not present at the place of duty for an as yet unspecified reason and has not been posted as either deceased or missing.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABS")]
        [EnumMember]
        Absent,
		
        /// <summary>
        /// Present at the place of duty.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ADU")]
        [EnumMember]
        AtDuty,
		
        /// <summary>
        /// Being held by friendly forces military police or civilian police force on suspicion of having committed an offence against either military or civil law.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ARR")]
        [EnumMember]
        Arrested,
		
        /// <summary>
        /// A status indicating that a PERSON is dead.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DEC")]
        [EnumMember]
        Deceased,
		
        /// <summary>
        /// A status indicating that a PERSON is in a hospital.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("HSP")]
        [EnumMember]
        Hospitalised,
		
        /// <summary>
        /// Has been captured by opposing forces or a terrorist organisation and is being held for the purpose of negotiation.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("HST")]
        [EnumMember]
        Hostage,
		
        /// <summary>
        /// Is missing but has not been posted as absent or deceased.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MIS")]
        [EnumMember]
        Missing,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A status indicating that a PERSON is absent from duty with permission.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("OLV")]
        [EnumMember]
        OnLeave,
		
        /// <summary>
        /// Has been captured by opposing forces and is being held in internment.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("POW")]
        [EnumMember]
        PrisonerOfWar,
		
        /// <summary>
        /// The PERSON has left the place of duty permanently without permission.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("DESRTD")]
        [EnumMember]
        Deserted,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that due to the nature of the destruction of the equipment, the individual is assumed dead.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("AKIA")]
        [EnumMember]
        AssumedKilledInAction,
		
    }
}

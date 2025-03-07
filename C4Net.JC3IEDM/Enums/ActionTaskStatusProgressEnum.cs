using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the perceived appraisal of the progress of a specific ACTION-TASK.
    /// </summary>
    [DomId(100000289)]
    [DataContract]
    public enum ActionTaskStatusProgressEnum
    {
		
        /// <summary>
        /// The specified ACTION-TASK has been abandoned subsequent to its initiation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABO")]
        [EnumMember]
        Aborted,
		
        /// <summary>
        /// The specified ACTION-TASK was cancelled prior to its initiation.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CANCLD")]
        [EnumMember]
        Cancelled,
		
        /// <summary>
        /// The specified ACTION-TASK has been carried out and is complete.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COM")]
        [EnumMember]
        Complete,
		
        /// <summary>
        /// The specified ACTION-TASK is in the process of being carried out at the time of the report.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("IPR")]
        [EnumMember]
        InProgress,
		
        /// <summary>
        /// The specified ACTION-TASK has not yet begun at the time of the report.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NST")]
        [EnumMember]
        NotStarted,
		
        /// <summary>
        /// The specified ACTION-TASK has been temporarily halted for an unspecified period of time.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PAU")]
        [EnumMember]
        Paused,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The specified ACTION-TASK is in the main phase at the time of the report.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("AIRBRN")]
        [EnumMember]
        Airborne,
		
        /// <summary>
        /// The execution of the specified ACTION-TASK has been delayed beyond the planned starting time.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DELAY")]
        [EnumMember]
        Delayed,
		
        /// <summary>
        /// The specified ACTION-TASK is still in the planning phase.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("PLAN")]
        [EnumMember]
        Planning,
		
        /// <summary>
        /// The specified ACTION-TASK has been replaced or modified subsequent to its initiation.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("RETASK")]
        [EnumMember]
        Retasked,
		
        /// <summary>
        /// The order to take-off has been received by the aircraft tasked with the specified ACTION-TASK, but the action area is not yet reached.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SCRMBL")]
        [EnumMember]
        Scrambled,
		
        /// <summary>
        /// The specified ACTION-TASK has been assigned, but the execution has not started.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("TASKED")]
        [EnumMember]
        Tasked,
		
        /// <summary>
        /// Hours that a unit is scheduled off task.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("OFFTSK")]
        [EnumMember]
        OffTask,
		
        /// <summary>
        /// Hours that equipment e.g. helicopters, cannot operate due to weather conditions.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("DWNTMW")]
        [EnumMember]
        DownTimeWeather,
		
        /// <summary>
        /// The method of completing the end of a run on one track and preparing to commence the next run either on the same track or another track.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("TRNMMW")]
        [EnumMember]
        TurningMaritimeMineWarfare,
		
        /// <summary>
        /// The planned task was not carried out during a specified period.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("NOOPER")]
        [EnumMember]
        NoOperation,
		
        /// <summary>
        /// To deploy maritime mine warfare equipment from a vessel.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("DPLMMW")]
        [EnumMember]
        DeployMaritimeMineWarfareEquipment,
		
        /// <summary>
        /// To recover maritime mine warfare equipment to a vessel.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("RECMMW")]
        [EnumMember]
        RecoverMaritimeMineWarfareEquipment,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

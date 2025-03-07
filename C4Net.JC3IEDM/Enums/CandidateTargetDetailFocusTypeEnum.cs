using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes a general class of actions intended by the nominating authority for a specific CANDIDATE-TARGET-DETAIL.
    /// </summary>
    [DomId(100000268)]
    [DataContract]
    public enum CandidateTargetDetailFocusTypeEnum
    {
		
        /// <summary>
        /// To conduct a type of offensive action characterised by coordinated employment of firepower and manoeuvre to close with and destroy or capture the enemy.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ATTACK")]
        [EnumMember]
        Attack,
		
        /// <summary>
        /// To take possession of an object, normally by force; it frequently involves movement as a preliminary phase.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CAPTUR")]
        [EnumMember]
        Capture,
		
        /// <summary>
        /// To diminish the effectiveness of the enemy to the extent that he is unable to participate further in the battle or at least cannot fulfil his intention.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DEFEAT")]
        [EnumMember]
        Defeat,
		
        /// <summary>
        /// To physically render a target combat-ineffective or damage it so that it cannot function as intended nor be restored to a usable condition without being entirely rebuilt.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DESTRY")]
        [EnumMember]
        Destroy,
		
        /// <summary>
        /// Battlespace illumination provided by employing searchlight or pyrotechnic illuminants using diffusion or reflection.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ILLUMN")]
        [EnumMember]
        Illuminate,
		
        /// <summary>
        /// To move a force, broken down as individuals or small groups, over, through or around enemy positions with the aim of avoiding detection.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("INFILT")]
        [EnumMember]
        Infiltrate,
		
        /// <summary>
        /// To conduct Electronic Warfare Support operations with a view to searching, locating, recording and analysing radiated electromagnetic energy for the purposes of supporting an operation.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("INTCEP")]
        [EnumMember]
        Intercept,
		
        /// <summary>
        /// To deliberately radiate, re-radiate or reflect electromagnetic energy with the object of impairing the use of electronic devices, equipment or systems being used by the enemy.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("JAM")]
        [EnumMember]
        Jam,
		
        /// <summary>
        /// To establish the position of an objective.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("LOCATE")]
        [EnumMember]
        Locate,
		
        /// <summary>
        /// To make visible (by the use of light/IR/laser/arty) an objective in order to allow its identification by another object (usually as a precursor to the use of direct fire weapons against the marked objective).
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MARK")]
        [EnumMember]
        Mark,
		
        /// <summary>
        /// To render the enemy’s weapons temporarily ineffective, normally by use of indirect fire (also normally associated with the imposition of 10% casualties in the case of indirect fire).
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NUTRLS")]
        [EnumMember]
        Neutralize,
		
        /// <summary>
        /// To provide continuous view, and the potential for reports on the activity of an objective.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("OBSRV")]
        [EnumMember]
        Observe,
		
        /// <summary>
        /// To move into and properly organise an area to be used as a battle position.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("OCCUPY")]
        [EnumMember]
        Occupy,
		
        /// <summary>
        /// To conduct a mission to obtain by visual operations or other detection methods information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("RECCE")]
        [EnumMember]
        Reconnoitre,
		
        /// <summary>
        /// To provide fire which neutralizes or temporarily degrades the capabilities of enemy forces within a specific area. This makes no assumptions as to enemy casualties; it may be a transitory effect.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SUPPRS")]
        [EnumMember]
        Suppress,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The specific object or type in the CANDIDATE-TARGET-DETAIL must not be attacked.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("DONOTA")]
        [EnumMember]
        DoNotAttack,
		
    }
}

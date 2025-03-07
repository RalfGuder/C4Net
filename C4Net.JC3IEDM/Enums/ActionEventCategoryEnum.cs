using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general class or nature of activity prescribed by an ACTION-EVENT.
    /// </summary>
    [DomId(100000282)]
    [DataContract]
    public enum ActionEventCategoryEnum
    {
		
        /// <summary>
        /// Operating as a force that is tasked with the continuation of the operation during an obstacle crossing.
        /// </summary>
        [DomValIx(1000418)]
        [StringValue("SRVBRK")]
        [EnumMember]
        ServingAsABreakoutForce,
		
        /// <summary>
        /// Operating as a force that seizes or controls ground in order to permit the continuous embarkation, landing or crossing of troops or materiel and to provide manoeuvre space during a water obstacle crossing.
        /// </summary>
        [DomValIx(1000419)]
        [StringValue("SRVBRD")]
        [EnumMember]
        ServingAsABridgeheadForce,
		
        /// <summary>
        /// Operating as a security element whose primary task is to protect the main force by fighting on the designated flank to gain time, whilst also observing and reporting information.
        /// </summary>
        [DomValIx(1000420)]
        [StringValue("SRVFLK")]
        [EnumMember]
        ServingAsAFlankGuard,
		
        /// <summary>
        /// Operating as the main force for a specific operation.
        /// </summary>
        [DomValIx(1000421)]
        [StringValue("SRVMNB")]
        [EnumMember]
        ServingAsAMainBody,
		
        /// <summary>
        /// Operating as a security element whose primary task is to move (or remain) at the rear of the main body and protect the main force by fighting to gain time, whilst also observing and reporting information.
        /// </summary>
        [DomValIx(1000422)]
        [StringValue("SRVRGD")]
        [EnumMember]
        ServingAsARearGuard,
		
        /// <summary>
        /// Operating as a force that may be committed into combat only on the order of the commander of the organisation who so designated the reserve force.
        /// </summary>
        [DomValIx(1000423)]
        [StringValue("SRVRSF")]
        [EnumMember]
        ServingAsAReserve,
		
        /// <summary>
        /// Operating as a security element whose primary task is to move ahead of the main body and protect the main force by fighting to gain time, whilst also observing and reporting information.
        /// </summary>
        [DomValIx(1000424)]
        [StringValue("SRVADV")]
        [EnumMember]
        ServingAsAnAdvanceGuard,
		
        /// <summary>
        /// Operating as a force that provides fire and other support to the bridgehead force during an obstacle crossing.
        /// </summary>
        [DomValIx(1000425)]
        [StringValue("SRVINP")]
        [EnumMember]
        ServingAsAnInPlaceForce,
		
        /// <summary>
        /// Establishing a FACILITY, ORGANISATION or FEATURE.
        /// </summary>
        [DomValIx(1000426)]
        [StringValue("STNGUP")]
        [EnumMember]
        SettingUp,
		
        /// <summary>
        /// Aiding, protecting, complementing or sustaining an object.
        /// </summary>
        [DomValIx(1000427)]
        [StringValue("SUPRTN")]
        [EnumMember]
        Supporting,
		
        /// <summary>
        /// Providing fires that neutralizes or temporarily degrades the capabilities of enemy forces within a specific area. This makes no assumptions as to enemy casualties; it may be a transitory effect.
        /// </summary>
        [DomValIx(1000428)]
        [StringValue("SUPRSN")]
        [EnumMember]
        Suppressing,
		
        /// <summary>
        /// Moving assets to a specified objective by sea, land or air.
        /// </summary>
        [DomValIx(1000429)]
        [StringValue("TRNSPN")]
        [EnumMember]
        Transporting,
		
        /// <summary>
        /// Compelling an enemy force to move from one avenue of approach or movement corridor to another.
        /// </summary>
        [DomValIx(1000430)]
        [StringValue("TURNNG")]
        [EnumMember]
        Turning,
		
        /// <summary>
        /// Disengaging a force in contact from an enemy force.
        /// </summary>
        [DomValIx(1000431)]
        [StringValue("WITDRL")]
        [EnumMember]
        Withdrawal,
		
        /// <summary>
        /// Disengaging from the enemy when the enemy has sufficient contact with friendly forces to interfere with the withdrawal.
        /// </summary>
        [DomValIx(1000432)]
        [StringValue("WDRPRS")]
        [EnumMember]
        WithdrawalUnderPressure,
		
        /// <summary>
        /// Observing an activity that may result in the need to provide evidence.
        /// </summary>
        [DomValIx(1000433)]
        [StringValue("WITNSN")]
        [EnumMember]
        Witnessing,
		
        /// <summary>
        /// A behaviour that results in the disturbance of the normal order of society that generally falls short of riots and/or property destruction in the civil population.
        /// </summary>
        [DomValIx(1000434)]
        [StringValue("CIVUNR")]
        [EnumMember]
        CivilUnrest,
		
        /// <summary>
        /// Violation of the laws so gross in numbers affected that it is considered to affect all humans and not only individuals.
        /// </summary>
        [DomValIx(1000435)]
        [StringValue("CRMHMN")]
        [EnumMember]
        CrimeAgainstHumanity,
		
        /// <summary>
        /// Violation of the laws of a civil society performed by a group of persons established for that reason.
        /// </summary>
        [DomValIx(1000436)]
        [StringValue("ORGCRM")]
        [EnumMember]
        OrganisedCrime,
		
        /// <summary>
        /// Violation of the laws and customs of war, i.e. the principles and norms of international law that enshrine the rights and duties of warring parties and neutral states.
        /// </summary>
        [DomValIx(1000437)]
        [StringValue("WARCRM")]
        [EnumMember]
        WarCrime,
		
        /// <summary>
        /// The detection of a device intended to cause damage to unsuspecting people.
        /// </summary>
        [DomValIx(1000438)]
        [StringValue("BBYTRD")]
        [EnumMember]
        BoobyTrapDiscovery,
		
        /// <summary>
        /// Seizure of a boat or ship in order to go somewhere other than the scheduled destination.
        /// </summary>
        [DomValIx(1000439)]
        [StringValue("HJCKBT")]
        [EnumMember]
        HijackingBoat,
		
        /// <summary>
        /// Seizure of a land vehicle in order to go somewhere other than the scheduled destination.
        /// </summary>
        [DomValIx(1000440)]
        [StringValue("HJCKLV")]
        [EnumMember]
        HijackingLandVehicle,
		
        /// <summary>
        /// Seizure of an aircraft in order to go somewhere other than the scheduled destination.
        /// </summary>
        [DomValIx(1000441)]
        [StringValue("HJCKPL")]
        [EnumMember]
        HijackingPlane,
		
        /// <summary>
        /// An act or acts with intent to injure, interfere with, or obstruct the national defence of a country by wilfully injuring or destroying, or attempting to injure or destroy, any national defence or war material, premises or utilities, to include human and natural resources.
        /// </summary>
        [DomValIx(1000442)]
        [StringValue("SABOTG")]
        [EnumMember]
        Sabotage,
		
        /// <summary>
        /// An accident involving an aircraft during ground operations or maintenance.
        /// </summary>
        [DomValIx(1000443)]
        [StringValue("ACCAIR")]
        [EnumMember]
        AccidentAircraftGround,
		
        /// <summary>
        /// Launching of aircraft by a naval platform.
        /// </summary>
        [DomValIx(1000444)]
        [StringValue("CARLNC")]
        [EnumMember]
        CarrierLaunch,
		
        /// <summary>
        /// Aircraft recovery by a naval platform.
        /// </summary>
        [DomValIx(1000445)]
        [StringValue("CARREC")]
        [EnumMember]
        CarrierRecovery,
		
        /// <summary>
        /// In-flight collision of an aircraft with another aircraft.
        /// </summary>
        [DomValIx(1000446)]
        [StringValue("COLMID")]
        [EnumMember]
        CollisionMidAir,
		
        /// <summary>
        /// In-flight collision of an aircraft with natural or man-made object (fixed or mobile) located on the ground.
        /// </summary>
        [DomValIx(1000447)]
        [StringValue("COLOBS")]
        [EnumMember]
        CollisionObstacle,
		
        /// <summary>
        /// Working or acting together.
        /// </summary>
        [DomValIx(1000448)]
        [StringValue("COOPER")]
        [EnumMember]
        Cooperating,
		
        /// <summary>
        /// Accidental damage by Allied troops to one's own installations, aircraft or personnel.
        /// </summary>
        [DomValIx(1000449)]
        [StringValue("FRNDFR")]
        [EnumMember]
        FriendlyFire,
		
        /// <summary>
        /// Aircraft launch or recovery by a naval platform.
        /// </summary>
        [DomValIx(1000450)]
        [StringValue("NAVPLF")]
        [EnumMember]
        NavalPlatformFlightOperations,
		
        /// <summary>
        /// Attack by enemy aircraft against ground targets using forward firing ordnance (bullets, shells, or rockets).
        /// </summary>
        [DomValIx(1000451)]
        [StringValue("STRFAR")]
        [EnumMember]
        StrafingAerial,
		
        /// <summary>
        /// Testifying to, asserting, affirming or confirming, as true or certain.
        /// </summary>
        [DomValIx(1000452)]
        [StringValue("VERFYN")]
        [EnumMember]
        Verifying,
		
        /// <summary>
        /// A violation of law.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CRIMIN")]
        [EnumMember]
        CriminalIncident,
		
        /// <summary>
        /// Seizure of a vehicle in order to go somewhere other than the scheduled destination.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HIJACK")]
        [EnumMember]
        HijackingNotOtherwiseSpecified,
		
        /// <summary>
        /// The commitment of an act against human rights.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HRVIOL")]
        [EnumMember]
        HumanRightsViolation,
		
        /// <summary>
        /// Seizing and holding a person unlawfully, usually for ransom or political gain.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("KIDNAP")]
        [EnumMember]
        Kidnapping,
		
        /// <summary>
        /// The driving out or removing from a home or place of usual resort or continuance of a large number of people.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DEPORT")]
        [EnumMember]
        MassiveDeportationBanishment,
		
        /// <summary>
        /// The absence of a PERSON from an expected or anticipated location.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MISSIG")]
        [EnumMember]
        MissingIndividual,
		
        /// <summary>
        /// A day designated by a national authority as a day when work is not compulsory.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("HOLIDY")]
        [EnumMember]
        NationalHoliday,
		
        /// <summary>
        /// The overthrow or renunciation of one government or ruler and the substitution of another by the governed.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("REVOLU")]
        [EnumMember]
        Revolution,
		
        /// <summary>
        /// A disturbance of the peace by a crowd; an occurrence of public disorder.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("RIOT")]
        [EnumMember]
        Riot,
		
        /// <summary>
        /// The formal gathering of a group of people in order to carry out an act or series of acts prescribed by ritual protocol or convention.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CEREMN")]
        [EnumMember]
        CeremonyOrParade,
		
        /// <summary>
        /// The deliberated and systematic destruction of a racial, political or cultural group.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("GENOCD")]
        [EnumMember]
        Genocide,
		
        /// <summary>
        /// The use of force or violence by or against racial or tribal groups.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("RACIAL")]
        [EnumMember]
        OutbreakOfRacialTribalEthnicWarfare,
		
        /// <summary>
        /// The enabling of transmission of information.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("COMACT")]
        [EnumMember]
        CommunicationsActivation,
		
        /// <summary>
        /// The disabling of transmission of information.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("COMDEA")]
        [EnumMember]
        CommunicationsDeactivation,
		
        /// <summary>
        /// Interruption of the passage of communications by natural or man-made phenomena.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("COMDIS")]
        [EnumMember]
        CommunicationsDisruption,
		
        /// <summary>
        /// Capturing electromagnetic communications signals.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("COMINT")]
        [EnumMember]
        CommunicationsInterception,
		
        /// <summary>
        /// The failure of communications equipment due to a mechanical malfunction.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("COMOUT")]
        [EnumMember]
        CommunicationsOutage,
		
        /// <summary>
        /// The reestablishment of the ability to communicate.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("COMRES")]
        [EnumMember]
        CommunicationsRestoration,
		
        /// <summary>
        /// The radiation of electromagnetic energy.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("ELCEMS")]
        [EnumMember]
        ElectronicEmission,
		
        /// <summary>
        /// The unforeseen destruction or damage of an aircraft (and personnel).
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("AIRCRS")]
        [EnumMember]
        AircraftCrash,
		
        /// <summary>
        /// The damage caused by force of nature, such as a hurricane, cyclone, tornado or tidal wave.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("NATDIS")]
        [EnumMember]
        NaturalDisaster,
		
        /// <summary>
        /// The unforeseen loss, destruction or damage of a spacecraft.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SPACAC")]
        [EnumMember]
        SpaceAccident,
		
        /// <summary>
        /// The overflowing of a body of water onto dry land.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("FLOOD")]
        [EnumMember]
        Flood,
		
        /// <summary>
        /// A convulsion of the earth's crust due to the release of accumulated stress as a result of faults in strata or volcanic action.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("EARTHQ")]
        [EnumMember]
        Earthquake,
		
        /// <summary>
        /// The release of lava or steam by a volcano.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("VOLCAN")]
        [EnumMember]
        VolcanicEruption,
		
        /// <summary>
        /// A prolonged or chronic shortage of water.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("DROUGH")]
        [EnumMember]
        Drought,
		
        /// <summary>
        /// A widespread occurrence of a disease in a community at a particular time.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("EPEDEM")]
        [EnumMember]
        Epidemic,
		
        /// <summary>
        /// A sudden release of any kind of energy.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("EXPLOS")]
        [EnumMember]
        Explosion,
		
        /// <summary>
        /// An extreme scarcity of food.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("FAMINE")]
        [EnumMember]
        Famine,
		
        /// <summary>
        /// The unforeseen loss, damage or destruction of a vessel by submersion.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("SINKIN")]
        [EnumMember]
        VesselSinking,
		
        /// <summary>
        /// A rapid, persistent chemical reaction that releases heat and light, especially the exothermic combination of a combustible substance with oxygen.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("FIRE")]
        [EnumMember]
        Fire,
		
        /// <summary>
        /// An activity of, relating to or based on the production of arms.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("ARMPRD")]
        [EnumMember]
        ArmsProduction,
		
        /// <summary>
        /// A happening of selling or buying of arms.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("ARMTRD")]
        [EnumMember]
        ArmsTrade,
		
        /// <summary>
        /// The organised refusal by employees to work until some grievance is remedied.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("STRIKE")]
        [EnumMember]
        Strike,
		
        /// <summary>
        /// The practice of spying or the use of spies to obtain information about the plans and activities of competitors.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("INDESP")]
        [EnumMember]
        IndustrialEspionageIncident,
		
        /// <summary>
        /// The accidental or delivered release of any petroleum product into the environment.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("PETSPL")]
        [EnumMember]
        PetroleumProductSpills,
		
        /// <summary>
        /// Contamination of the atmosphere caused by a poison or toxin.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("ATMPOL")]
        [EnumMember]
        AtmosphericPollution,
		
        /// <summary>
        /// Contamination of a body of water caused by a poison or toxin.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("WATPOL")]
        [EnumMember]
        OceansSeasOrWaterPollution,
		
        /// <summary>
        /// The act of assembling and making ready for active military service.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("MILMOB")]
        [EnumMember]
        MilitaryMobilisation,
		
        /// <summary>
        /// The concentration of large quantities of military equipment and personnel.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("MASFOR")]
        [EnumMember]
        MassingOfForces,
		
        /// <summary>
        /// The occurrence of one or more aircraft taking off.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("AIRLAU")]
        [EnumMember]
        AircraftLaunchActivity,
		
        /// <summary>
        /// The occurrence of a hostile encounter between military aircraft.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("AERENG")]
        [EnumMember]
        AerialEngagement,
		
        /// <summary>
        /// The deliberate destruction of an aircraft.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("AERSHO")]
        [EnumMember]
        AerialShootDown,
		
        /// <summary>
        /// Moving a force or a group of people across a national or territorial border.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("BORINC")]
        [EnumMember]
        BorderIncursion,
		
        /// <summary>
        /// A war among fellow-citizens or within the limits of one community.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("CIVWAR")]
        [EnumMember]
        CivilWar,
		
        /// <summary>
        /// A cessation of proper functioning or performance of a piece of equipment.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("EQPFAI")]
        [EnumMember]
        EquipmentFailure,
		
        /// <summary>
        /// Early notification of the launch or approach of weapons or weapons carriers.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("EARWAR")]
        [EnumMember]
        EarlyWarningAlert,
		
        /// <summary>
        /// The act of taking possession of another land.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("INVASI")]
        [EnumMember]
        Invasion,
		
        /// <summary>
        /// Yielding to the control or power of the enemy.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("SURREN")]
        [EnumMember]
        Surrender,
		
        /// <summary>
        /// Conducting an operation by an attack force.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("OFFCOF")]
        [EnumMember]
        OffensiveCounteroffensive,
		
        /// <summary>
        /// A surprise attack by a force or a group of people across a national or territorial border (restricted to 25 km from the border).
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("BORRAI")]
        [EnumMember]
        BorderRaid,
		
        /// <summary>
        /// The invasion of the declared own airspace by an aircraft.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("AIRVIO")]
        [EnumMember]
        AirspaceViolation,
		
        /// <summary>
        /// Taking electronic control of a communications network.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("NETSEI")]
        [EnumMember]
        NetworkSeizure,
		
        /// <summary>
        /// Firing without a specific objective and without making distinction.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("INDSHO")]
        [EnumMember]
        IndiscriminateShooting,
		
        /// <summary>
        /// The renouncement by a person of his official functions.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("ABDICA")]
        [EnumMember]
        Abdication,
		
        /// <summary>
        /// The state of readiness caused by the possibility of a war.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("WARALE")]
        [EnumMember]
        WarCrisisAlert,
		
        /// <summary>
        /// The end of a state of readiness.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("ALRCAN")]
        [EnumMember]
        AlertCancellation,
		
        /// <summary>
        /// A violent or illegal seizure of power.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("COUPDE")]
        [EnumMember]
        CoupDÉtat,
		
        /// <summary>
        /// Self-defined.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("DEACST")]
        [EnumMember]
        DeathOfChiefOfState,
		
        /// <summary>
        /// Self-defined.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("DEASPL")]
        [EnumMember]
        DeathOfSpiritualLeader,
		
        /// <summary>
        /// A public display of group feelings towards a political idea, person or cause.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("POLDEM")]
        [EnumMember]
        PoliticalDemonstration,
		
        /// <summary>
        /// An ACTION-EVENT in which local officials are selected by vote.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("LOCELC")]
        [EnumMember]
        LocalElection,
		
        /// <summary>
        /// An ACTION-EVENT in which national officials are selected by vote.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("NATELC")]
        [EnumMember]
        NationalElection,
		
        /// <summary>
        /// The occurrence of violent acts due to an election process.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("ELCVIO")]
        [EnumMember]
        ElectionAssociatedViolence,
		
        /// <summary>
        /// The sudden loss of force, effectiveness or authority of the governing organisation.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("GOVCOL")]
        [EnumMember]
        GovernmentalCollapse,
		
        /// <summary>
        /// An arrangement or contract between a number of organisations to provide mutual support.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("MUTASS")]
        [EnumMember]
        MutualAssistancePactAgreement,
		
        /// <summary>
        /// Giving practical effect to military law, usually by restricting the rights of citizens for security reasons.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("MARLAW")]
        [EnumMember]
        MartialLawImplementation,
		
        /// <summary>
        /// A meeting of a group of persons to discuss a peace process.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("PEACON")]
        [EnumMember]
        PeaceConference,
		
        /// <summary>
        /// A putting to death of a person or group of persons for political reasons.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("POLEXE")]
        [EnumMember]
        PoliticalExecution,
		
        /// <summary>
        /// The arrival of a POW or a group of POWs to their own forces or country.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("POWRET")]
        [EnumMember]
        PowReturn,
		
        /// <summary>
        /// The act of giving or taking POWs in return for others.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("POWEXC")]
        [EnumMember]
        PrisonerExchange,
		
        /// <summary>
        /// The formal withdrawal of a portion of a country.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("SECCOU")]
        [EnumMember]
        SecessionOfPortionOfCountry,
		
        /// <summary>
        /// A political term, to describe a condition approximating to that of war, wherein the normal constitution is suspended.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("NATEMG")]
        [EnumMember]
        NationalStateOfEmergency,
		
        /// <summary>
        /// The cessation of war activities.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("SUSHOS")]
        [EnumMember]
        SuspensionOfHostilities,
		
        /// <summary>
        /// An arrangement or contract among involved nations or factions to end a conflict.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("PEAAGR")]
        [EnumMember]
        PeaceTreatyAgreement,
		
        /// <summary>
        /// An infringement or breaking of the provisions of a formal agreement.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("TREVIO")]
        [EnumMember]
        TreatyViolation,
		
        /// <summary>
        /// A state characterised by hostile military activity between the parts.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("STAWAR")]
        [EnumMember]
        StateOfWar,
		
        /// <summary>
        /// An act of open armed conflict due to a difference of religious belief between two separate groups.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("RELWAR")]
        [EnumMember]
        ReligiousWarfare,
		
        /// <summary>
        /// A public display of group feelings towards a religious idea, person or cause.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("RELDEM")]
        [EnumMember]
        ReligiousDemonstration,
		
        /// <summary>
        /// Individual or organised act directed against groups or individuals because of their religious beliefs.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("RELVIO")]
        [EnumMember]
        ReligiousViolence,
		
        /// <summary>
        /// The situation when opposing forces are in sight of or in range of direct fire of each other's weapons.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("ENMCON")]
        [EnumMember]
        EnemyContact,
		
        /// <summary>
        /// A meeting of a group of persons to discuss war/military process.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("WARCON")]
        [EnumMember]
        WarMilitaryConference,
		
        /// <summary>
        /// A surprise attack by fire or other destructive means from concealed positions on a moving or temporarily halted force or group of personnel.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("AMBUSH")]
        [EnumMember]
        Ambush,
		
        /// <summary>
        /// Mounting an operation launched from the sea by naval and land forces against a hostile, or potentially hostile shore.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("AMPH")]
        [EnumMember]
        AmphibiousOperation,
		
        /// <summary>
        /// Mounting an assault utilising a mixture of aviation and ground transport, the principal feature of which is the insertion of combat power.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("ARASLT")]
        [EnumMember]
        AirAssault,
		
        /// <summary>
        /// Mounting an airborne operation, a phase beginning with delivery by air of the assault echelon of the force into the objective area and extending through attack of assault objectives and consolidation of the initial airhead.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("ARBNAS")]
        [EnumMember]
        AirborneAssault,
		
        /// <summary>
        /// Conducting an offensive operation characterised by coordinated employment of firepower and manoeuvre to close with and destroy or capture the enemy.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("ATTACK")]
        [EnumMember]
        AttackNotOtherwiseSpecified,
		
        /// <summary>
        /// Attaining prescribed strength of units and prescribed levels of vehicles, equipment, stores and supplies.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("BLDUP")]
        [EnumMember]
        BuildUp,
		
        /// <summary>
        /// Mounting an offensive operation in which an attack by a part or all of a defending force is made against an enemy attacking force, for such specific purposes as regaining ground lost, cutting off or destroying lead enemy units, and with the general objective of regaining the initiative and denying the enemy the attainment of his goal or purpose in attacking.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("CTRATK")]
        [EnumMember]
        CounterAttack,
		
        /// <summary>
        /// Fire delivered for the purpose of destroying or neutralizing indirect fire weapons systems.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("CTRBYF")]
        [EnumMember]
        CounterBatteryFire,
		
        /// <summary>
        /// Diminution of the effectiveness of the enemy to the extent that he is unable to participate further in the battle or at least cannot fulfil his intention.
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("DEFEAT")]
        [EnumMember]
        Defeat,
		
        /// <summary>
        /// Conducting an offensive operation characterised by pre-planned coordinated employment of firepower and manoeuvre to close with and destroy or capture the enemy.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("DLBATK")]
        [EnumMember]
        AttackDeliberate,
		
        /// <summary>
        /// Adopting a defended formation as a temporary defensive measure in areas of low or moderate risk of combat.
        /// </summary>
        [DomValIx(1000153)]
        [StringValue("LEAGR")]
        [EnumMember]
        Leaguer,
		
        /// <summary>
        /// The process of moving any person who is wounded, injured or ill to/between medical treatment FACILITYs.
        /// </summary>
        [DomValIx(1000157)]
        [StringValue("MEDEVC")]
        [EnumMember]
        MedicalEvacuation,
		
        /// <summary>
        /// Changing position.
        /// </summary>
        [DomValIx(1000158)]
        [StringValue("MOVING")]
        [EnumMember]
        Moving,
		
        /// <summary>
        /// Conducting a mission to obtain by visual operations or other detection methods information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000169)]
        [StringValue("RECCE")]
        [EnumMember]
        Reconnaissance,
		
        /// <summary>
        /// Conducting an offensive operation designed to discover and/or test the enemy's strength, or to obtain other information.
        /// </summary>
        [DomValIx(1000170)]
        [StringValue("RECCEF")]
        [EnumMember]
        ReconnaissanceInForce,
		
        /// <summary>
        /// Moving a force out of contact with the enemy with the expectation of no further significant contact.
        /// </summary>
        [DomValIx(1000179)]
        [StringValue("RETIRE")]
        [EnumMember]
        Retire,
		
        /// <summary>
        /// Achieving a pre-arranged meeting at a given time and place.
        /// </summary>
        [DomValIx(1000180)]
        [StringValue("RNDZVS")]
        [EnumMember]
        Rendezvous,
		
        /// <summary>
        /// In land operations, an attack in which preparation time is traded for speed in order to exploit an opportunity.
        /// </summary>
        [DomValIx(1000189)]
        [StringValue("HASTY")]
        [EnumMember]
        AttackHasty,
		
        /// <summary>
        /// Manoeuvring around an obstacle, position, or enemy force to maintain the momentum of advance.
        /// </summary>
        [DomValIx(1000190)]
        [StringValue("BYPASS")]
        [EnumMember]
        Bypass,
		
        /// <summary>
        /// Menacing an armed force by manoeuvre or action.
        /// </summary>
        [DomValIx(1000196)]
        [StringValue("THREAT")]
        [EnumMember]
        Threaten,
		
        /// <summary>
        /// Using or threatening force or violence against individuals or property in an attempt to coerce or intimidate governments or societies to achieve political, religious or ideological objectives.
        /// </summary>
        [DomValIx(1000198)]
        [StringValue("TERR")]
        [EnumMember]
        Terrorism,
		
        /// <summary>
        /// The destruction of structures, facilities, or materiel by use of fire, water, explosives, mechanical, or other means.
        /// </summary>
        [DomValIx(1000199)]
        [StringValue("DEMO")]
        [EnumMember]
        Demolition,
		
        /// <summary>
        /// An attack by one who shoots at others from a concealed place.
        /// </summary>
        [DomValIx(1000200)]
        [StringValue("SNPATK")]
        [EnumMember]
        SniperAttack,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000201)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The crime of maliciously setting fire to the property of another or of burning one's own property for an improper purpose, as to collect insurance.
        /// </summary>
        [DomValIx(1000204)]
        [StringValue("ARSON")]
        [EnumMember]
        Arson,
		
        /// <summary>
        /// The use of artillery fire.
        /// </summary>
        [DomValIx(1000205)]
        [StringValue("ARTFIR")]
        [EnumMember]
        ArtilleryFire,
		
        /// <summary>
        /// Conducting the principal attack or effort into which the commander throws the full weight of the offensive power at his disposal. An attack directed against the chief objective of the campaign or battle.
        /// </summary>
        [DomValIx(1000209)]
        [StringValue("ATTMN")]
        [EnumMember]
        AttackMain,
		
        /// <summary>
        /// Conducting an offensive operation carried out in conjunction with a main attack and designed to achieve one or more of the following: a. deceive the enemy; b. destroy or pin down enemy forces which could interfere with the main attack; c. control ground whose occupation by the enemy will hinder the main attack; or d. force the enemy to commit reserves prematurely or in an indecisive area.
        /// </summary>
        [DomValIx(1000210)]
        [StringValue("ATTSPT")]
        [EnumMember]
        AttackSupporting,
		
        /// <summary>
        /// Attacking, damaging or destroying through the use of bombs.
        /// </summary>
        [DomValIx(1000211)]
        [StringValue("BOMBNG")]
        [EnumMember]
        Bombing,
		
        /// <summary>
        /// Restricting operations to a narrow zone by use of existing or reinforcing obstacles or by fire or bombing.
        /// </summary>
        [DomValIx(1000212)]
        [StringValue("CANLSE")]
        [EnumMember]
        Canalise,
		
        /// <summary>
        /// Taking possession of an object, normally by force; it frequently involves movement as a preliminary phase.
        /// </summary>
        [DomValIx(1000213)]
        [StringValue("CAPTUR")]
        [EnumMember]
        Capture,
		
        /// <summary>
        /// Denying the enemy his goal by using fire against an engagement area to defeat or destroy an enemy force.
        /// </summary>
        [DomValIx(1000215)]
        [StringValue("CTRFIR")]
        [EnumMember]
        CounterAttackByFire,
		
        /// <summary>
        /// Conducting an offensive operation that is either an attack or a show of force on a front where a decision is not sought, made with the aim of deceiving the enemy. It is similar to a feint with the exception that no contact with the enemy is sought. In OOTW, an operation by military forces in sight of an actual or potential enemy to show military capabilities.
        /// </summary>
        [DomValIx(1000218)]
        [StringValue("DMNSTR")]
        [EnumMember]
        Demonstration,
		
        /// <summary>
        /// The act of firing a weapon, usually at a person, from a passing vehicle.
        /// </summary>
        [DomValIx(1000220)]
        [StringValue("DRVSHT")]
        [EnumMember]
        DriveByShooting,
		
        /// <summary>
        /// Illegal trafficking in drugs by a group or an organisation.
        /// </summary>
        [DomValIx(1000221)]
        [StringValue("DRGOPR")]
        [EnumMember]
        DrugOperation,
		
        /// <summary>
        /// Preventing the enemy from moving any part of his force from a specific location for a specific period of time.
        /// </summary>
        [DomValIx(1000222)]
        [StringValue("FIX")]
        [EnumMember]
        Fix,
		
        /// <summary>
        /// Determining a position using electromagnetic data.
        /// </summary>
        [DomValIx(1000223)]
        [StringValue("FIXELM")]
        [EnumMember]
        FixElectromagnetic,
		
        /// <summary>
        /// Determining a position using acoustic data.
        /// </summary>
        [DomValIx(1000224)]
        [StringValue("FIXACO")]
        [EnumMember]
        FixAcoustic,
		
        /// <summary>
        /// Determining a position using electro-optical data.
        /// </summary>
        [DomValIx(1000225)]
        [StringValue("FIXELO")]
        [EnumMember]
        FixElectroOptical,
		
        /// <summary>
        /// Fire delivered on a target that is not itself used as a point of aim for the weapons or the director.
        /// </summary>
        [DomValIx(1000229)]
        [StringValue("INDFIR")]
        [EnumMember]
        IndirectFire,
		
        /// <summary>
        /// Emplacement or deployment of one or more mines.
        /// </summary>
        [DomValIx(1000231)]
        [StringValue("MINLAY")]
        [EnumMember]
        MineLaying,
		
        /// <summary>
        /// The discharge of a projectile from a mortar weapon.
        /// </summary>
        [DomValIx(1000232)]
        [StringValue("MRTFIR")]
        [EnumMember]
        MortarFire,
		
        /// <summary>
        /// Injuring or killing with toxic agents.
        /// </summary>
        [DomValIx(1000234)]
        [StringValue("POISON")]
        [EnumMember]
        Poisoning,
		
        /// <summary>
        /// Planned operations to convey selected information and indicators to foreign audiences to influence their emotions, motives, objective reasoning, and ultimately the behaviour of foreign governments, organisations, groups, and individuals. The purpose of psychological operations is to induce or reinforce foreign attitudes and behaviour favourable to the originator's objectives.
        /// </summary>
        [DomValIx(1000235)]
        [StringValue("PSYOP")]
        [EnumMember]
        PsychologicalOperation,
		
        /// <summary>
        /// An operation in which, by direction of higher authority, all or part of a unit is replaced in an area by the incoming unit. The responsibilities of the replaced elements for the mission and the assigned zone of operations are transferred to the incoming unit. The incoming unit continues the operation as ordered.
        /// </summary>
        [DomValIx(1000236)]
        [StringValue("RLFPLC")]
        [EnumMember]
        ReliefInPlace,
		
        /// <summary>
        /// Occupying and holding a terrain feature to ensure it is free of enemy occupation or use.
        /// </summary>
        [DomValIx(1000237)]
        [StringValue("RETAIN")]
        [EnumMember]
        Retain,
		
        /// <summary>
        /// The employment of a rocket powered weapon.
        /// </summary>
        [DomValIx(1000238)]
        [StringValue("RKTFIR")]
        [EnumMember]
        RocketFire,
		
        /// <summary>
        /// An act of vandalism, raping, looting, ransacking or plundering against an individual or property.
        /// </summary>
        [DomValIx(1000241)]
        [StringValue("VANDAL")]
        [EnumMember]
        VandalismRapeLootRansackPlunderSack,
		
        /// <summary>
        /// A border crossing that is conducted under escort.
        /// </summary>
        [DomValIx(1000244)]
        [StringValue("BCESC")]
        [EnumMember]
        BorderCrossingEscorted,
		
        /// <summary>
        /// A border crossing that is conducted under pressure.
        /// </summary>
        [DomValIx(1000245)]
        [StringValue("BCFRCD")]
        [EnumMember]
        BorderCrossingForced,
		
        /// <summary>
        /// A border crossing that is forbidden by law.
        /// </summary>
        [DomValIx(1000246)]
        [StringValue("BCILGL")]
        [EnumMember]
        BorderCrossingIllegal,
		
        /// <summary>
        /// A border crossing that is unplanned.
        /// </summary>
        [DomValIx(1000247)]
        [StringValue("BCNTPL")]
        [EnumMember]
        BorderCrossingNotPlanned,
		
        /// <summary>
        /// A border crossing that is known to have been planned ahead of time.
        /// </summary>
        [DomValIx(1000248)]
        [StringValue("BCPLND")]
        [EnumMember]
        BorderCrossingPlanned,
		
        /// <summary>
        /// A border crossing that is conducted under surveillance.
        /// </summary>
        [DomValIx(1000249)]
        [StringValue("BCSRVL")]
        [EnumMember]
        BorderCrossingSurveilled,
		
        /// <summary>
        /// The detection of a seemingly harmless letter or parcel.
        /// </summary>
        [DomValIx(1000250)]
        [StringValue("LTRBMI")]
        [EnumMember]
        LetterBombIncident,
		
        /// <summary>
        /// The explosion of a seemingly harmless letter or parcel.
        /// </summary>
        [DomValIx(1000251)]
        [StringValue("LTRBME")]
        [EnumMember]
        LetterBombExplosion,
		
        /// <summary>
        /// An aircraft has landed without using the landing gear.
        /// </summary>
        [DomValIx(1000252)]
        [StringValue("BLYLND")]
        [EnumMember]
        BellyLanding,
		
        /// <summary>
        /// Complete destruction of an object by flames.
        /// </summary>
        [DomValIx(1000253)]
        [StringValue("BRNOBJ")]
        [EnumMember]
        BurnedOutObject,
		
        /// <summary>
        /// An aircraft that by hostile act, or lack of vital resources is compelled to land.
        /// </summary>
        [DomValIx(1000254)]
        [StringValue("FRCLND")]
        [EnumMember]
        ForcedLanding,
		
        /// <summary>
        /// The detection of the presence of unexploded explosive ordnance.
        /// </summary>
        [DomValIx(1000255)]
        [StringValue("UXODSC")]
        [EnumMember]
        UxoDiscovery,
		
        /// <summary>
        /// The seizure of property under public authority.
        /// </summary>
        [DomValIx(1000256)]
        [StringValue("CNFSTN")]
        [EnumMember]
        Confiscation,
		
        /// <summary>
        /// An unfortunate event, esp. one causing physical harm or damage, brought about unintentionally.
        /// </summary>
        [DomValIx(1000257)]
        [StringValue("ACCDNT")]
        [EnumMember]
        Accident,
		
        /// <summary>
        /// An accident involving unexploded ordnance.
        /// </summary>
        [DomValIx(1000258)]
        [StringValue("ACCMNE")]
        [EnumMember]
        AccidentMine,
		
        /// <summary>
        /// An accident involving at least one motor vehicle.
        /// </summary>
        [DomValIx(1000259)]
        [StringValue("ACCTRF")]
        [EnumMember]
        AccidentTraffic,
		
        /// <summary>
        /// An accident involving a weapon.
        /// </summary>
        [DomValIx(1000260)]
        [StringValue("ACCWPN")]
        [EnumMember]
        AccidentWeapon,
		
        /// <summary>
        /// An accident occurring at the workplace.
        /// </summary>
        [DomValIx(1000261)]
        [StringValue("ACCWRK")]
        [EnumMember]
        AccidentWorkplace,
		
        /// <summary>
        /// Murder of a prominent person.
        /// </summary>
        [DomValIx(1000262)]
        [StringValue("ASSNTN")]
        [EnumMember]
        Assassination,
		
        /// <summary>
        /// An unfortunate bombing incident that happens unexpectedly and unintentionally.
        /// </summary>
        [DomValIx(1000263)]
        [StringValue("BMBACC")]
        [EnumMember]
        BombingAccidental,
		
        /// <summary>
        /// A deliberate and intentional bombing incident.
        /// </summary>
        [DomValIx(1000264)]
        [StringValue("BMBDLB")]
        [EnumMember]
        BombingDeliberate,
		
        /// <summary>
        /// A public meeting or march legally expressing protest or other opinion on an issue.
        /// </summary>
        [DomValIx(1000265)]
        [StringValue("CIVDML")]
        [EnumMember]
        CivilDemonstrationLegal,
		
        /// <summary>
        /// A public meeting or march illegally expressing protest or other opinion on an issue.
        /// </summary>
        [DomValIx(1000266)]
        [StringValue("CIVDMI")]
        [EnumMember]
        CivilDemonstrationIllegal,
		
        /// <summary>
        /// The refusal to comply with certain laws or to pay taxes etc. as a peaceful form of political protest.
        /// </summary>
        [DomValIx(1000267)]
        [StringValue("CIVDIS")]
        [EnumMember]
        CivilDisobedience,
		
        /// <summary>
        /// Normal termination of life.
        /// </summary>
        [DomValIx(1000269)]
        [StringValue("DTHNAT")]
        [EnumMember]
        DeathNaturalCauses,
		
        /// <summary>
        /// A disorder of structure or function in a human, animal, or plant, especially one that produces specific symptoms or that affects a specific part.
        /// </summary>
        [DomValIx(1000270)]
        [StringValue("DISEAS")]
        [EnumMember]
        Disease,
		
        /// <summary>
        /// An action of consuming illegal drugs.
        /// </summary>
        [DomValIx(1000271)]
        [StringValue("DRGCNS")]
        [EnumMember]
        DrugConsumptionIllegal,
		
        /// <summary>
        /// An action to distribute illegal drugs or to illegally distribute legal drugs.
        /// </summary>
        [DomValIx(1000272)]
        [StringValue("DRGDST")]
        [EnumMember]
        DrugDistributionIllegal,
		
        /// <summary>
        /// An action to manufacture illegal drugs or to illegally manufacture legal drugs.
        /// </summary>
        [DomValIx(1000273)]
        [StringValue("DRGMNF")]
        [EnumMember]
        DrugManufacturingIllegal,
		
        /// <summary>
        /// An action to store drugs.
        /// </summary>
        [DomValIx(1000274)]
        [StringValue("DRGSTR")]
        [EnumMember]
        DrugStorage,
		
        /// <summary>
        /// An action to transport drugs.
        /// </summary>
        [DomValIx(1000275)]
        [StringValue("DRGTRN")]
        [EnumMember]
        DrugTransportation,
		
        /// <summary>
        /// Putting a person to death, especially as a legal penalty.
        /// </summary>
        [DomValIx(1000276)]
        [StringValue("EXECTN")]
        [EnumMember]
        Execution,
		
        /// <summary>
        /// The activity of extinguishing fires.
        /// </summary>
        [DomValIx(1000277)]
        [StringValue("FRFGTN")]
        [EnumMember]
        Firefighting,
		
        /// <summary>
        /// Action to seize or hold a person as security for the fulfilment of a condition.
        /// </summary>
        [DomValIx(1000279)]
        [StringValue("HSTTKN")]
        [EnumMember]
        HostageTaking,
		
        /// <summary>
        /// The activity of hunting wild animals or game, especially for food or sport.
        /// </summary>
        [DomValIx(1000280)]
        [StringValue("HUNTNG")]
        [EnumMember]
        Hunting,
		
        /// <summary>
        /// Act to frighten or overawe.
        /// </summary>
        [DomValIx(1000281)]
        [StringValue("INTMDN")]
        [EnumMember]
        Intimidation,
		
        /// <summary>
        /// The organised refusal by employees to work until some grievance is remedied.
        /// </summary>
        [DomValIx(1000282)]
        [StringValue("LABSTR")]
        [EnumMember]
        LabourStrike,
		
        /// <summary>
        /// Act to take private property from an enemy in war or stolen by thieves.
        /// </summary>
        [DomValIx(1000283)]
        [StringValue("LOOTNG")]
        [EnumMember]
        Looting,
		
        /// <summary>
        /// The unlawful killing of one human being by another, especially with premeditated malice.
        /// </summary>
        [DomValIx(1000284)]
        [StringValue("MURDER")]
        [EnumMember]
        Murder,
		
        /// <summary>
        /// A fatal epidemic disease, especially bubonic plague.
        /// </summary>
        [DomValIx(1000285)]
        [StringValue("PSTLNC")]
        [EnumMember]
        Pestilence,
		
        /// <summary>
        /// An act by a person or persons outside a place of work, intending to persuade esp. workers not to enter during a strike.
        /// </summary>
        [DomValIx(1000286)]
        [StringValue("PCKTNG")]
        [EnumMember]
        Picketing,
		
        /// <summary>
        /// A deliberate and intentional bombing incident that happens unexpectedly where the perpetrator acts through a representative.
        /// </summary>
        [DomValIx(1000287)]
        [StringValue("PRXBMB")]
        [EnumMember]
        ProxyBombing,
		
        /// <summary>
        /// The act of forcing another person to submit to sexual intercourse.
        /// </summary>
        [DomValIx(1000288)]
        [StringValue("RAPE")]
        [EnumMember]
        Rape,
		
        /// <summary>
        /// The movement of people who has been forced to leave their country in order to escape war, persecution, or natural disaster.
        /// </summary>
        [DomValIx(1000289)]
        [StringValue("REFMVM")]
        [EnumMember]
        RefugeeMovement,
		
        /// <summary>
        /// Unlawfully taking property, valuables or money from a person or place.
        /// </summary>
        [DomValIx(1000290)]
        [StringValue("ROBERY")]
        [EnumMember]
        Robbery,
		
        /// <summary>
        /// The act of firing of a weapon, usually at a person.
        /// </summary>
        [DomValIx(1000291)]
        [StringValue("SHOTNG")]
        [EnumMember]
        Shooting,
		
        /// <summary>
        /// Obtaining intelligence information furtively as an agent of a foreign power or competition.
        /// </summary>
        [DomValIx(1000292)]
        [StringValue("SPYING")]
        [EnumMember]
        Spying,
		
        /// <summary>
        /// The action of killing oneself intentionally.
        /// </summary>
        [DomValIx(1000293)]
        [StringValue("SUICDE")]
        [EnumMember]
        Suicide,
		
        /// <summary>
        /// An action or practice of inflicting severe pain as a punishment or a forcible means of persuasion.
        /// </summary>
        [DomValIx(1000294)]
        [StringValue("TORTUR")]
        [EnumMember]
        Torture,
		
        /// <summary>
        /// The firing of weapons.
        /// </summary>
        [DomValIx(1000295)]
        [StringValue("WPNFIR")]
        [EnumMember]
        WeaponFiring,
		
        /// <summary>
        /// Making safe or non-toxic an object contaminated with a chemical agent.
        /// </summary>
        [DomValIx(1000302)]
        [StringValue("NTRCHM")]
        [EnumMember]
        NeutralizeChemical,
		
        /// <summary>
        /// Rendering ineffective or unusable in military operations.
        /// </summary>
        [DomValIx(1000303)]
        [StringValue("NTRCOM")]
        [EnumMember]
        NeutralizeCombat,
		
        /// <summary>
        /// Rendering bombs, mines, missiles, and booby traps into a safe state.
        /// </summary>
        [DomValIx(1000304)]
        [StringValue("NTREXP")]
        [EnumMember]
        NeutralizeExplosive,
		
        /// <summary>
        /// The attempted act of unlawfully killing of one human being by another, especially with premeditated malice.
        /// </summary>
        [DomValIx(1000306)]
        [StringValue("ATMRDR")]
        [EnumMember]
        AttemptedMurder,
		
        /// <summary>
        /// The attempted act of forcing another person to submit to sexual intercourse.
        /// </summary>
        [DomValIx(1000307)]
        [StringValue("ATRAPE")]
        [EnumMember]
        AttemptedRape,
		
        /// <summary>
        /// The attempted act of robbing a person or place.
        /// </summary>
        [DomValIx(1000308)]
        [StringValue("ATRBRY")]
        [EnumMember]
        AttemptedRobbery,
		
        /// <summary>
        /// The attempted act of killing oneself intentionally.
        /// </summary>
        [DomValIx(1000309)]
        [StringValue("ATSCDE")]
        [EnumMember]
        AttemptedSuicide,
		
        /// <summary>
        /// Conducting a meeting for discussion, esp. a regular one held by an association or organisation.
        /// </summary>
        [DomValIx(1000310)]
        [StringValue("CNDCNF")]
        [EnumMember]
        ConductingConference,
		
        /// <summary>
        /// Conducting a conversation between a reporter etc. and a person of public interest, used as a basis of a broadcast or publication.
        /// </summary>
        [DomValIx(1000311)]
        [StringValue("CNDMED")]
        [EnumMember]
        ConductingMediaInterview,
		
        /// <summary>
        /// Conducting a refreshing or entertaining activity.
        /// </summary>
        [DomValIx(1000312)]
        [StringValue("CNDRCR")]
        [EnumMember]
        ConductingRecreationalActivities,
		
        /// <summary>
        /// Conducting any social gathering, esp. one organised by a club or congregation.
        /// </summary>
        [DomValIx(1000313)]
        [StringValue("CNDSCL")]
        [EnumMember]
        ConductingSocialEvents,
		
        /// <summary>
        /// Conducting any game or competitive activity, especially an outdoor one involving physical exertion, e.g. cricket, football, racing, hunting.
        /// </summary>
        [DomValIx(1000314)]
        [StringValue("CNDSPT")]
        [EnumMember]
        ConductingSportingEvents,
		
        /// <summary>
        /// Dividing or dispensing in portions.
        /// </summary>
        [DomValIx(1000315)]
        [StringValue("DSTRBT")]
        [EnumMember]
        Distributing,
		
        /// <summary>
        /// Breaking free from a restriction or control of a place, person, or organisation.
        /// </summary>
        [DomValIx(1000316)]
        [StringValue("ESCPNG")]
        [EnumMember]
        Escaping,
		
        /// <summary>
        /// Sending forth or putting into circulation a non-fictional essay, especially one included with others in a newspaper, magazine, or journal.
        /// </summary>
        [DomValIx(1000317)]
        [StringValue("ISSMDA")]
        [EnumMember]
        IssuingMediaArticle,
		
        /// <summary>
        /// Sending forth or putting into circulation any document published on a media that provides a factual record or report.
        /// </summary>
        [DomValIx(1000318)]
        [StringValue("ISSMDD")]
        [EnumMember]
        IssuingMediaDocumentary,
		
        /// <summary>
        /// Sending forth or putting into circulation an official statement issued to media for information.
        /// </summary>
        [DomValIx(1000319)]
        [StringValue("ISSPRS")]
        [EnumMember]
        IssuingPressRelease,
		
        /// <summary>
        /// Providing advice or supplies for cultivating the soil and rearing animals.
        /// </summary>
        [DomValIx(1000320)]
        [StringValue("PRVAGR")]
        [EnumMember]
        ProvidingAgriculturalSupport,
		
        /// <summary>
        /// Providing (1) sleeping accommodation or (2) mattress and bedclothes.
        /// </summary>
        [DomValIx(1000321)]
        [StringValue("PRVBDD")]
        [EnumMember]
        ProvidingBedding,
		
        /// <summary>
        /// Providing temporary accommodation of various kinds, usually consisting of huts or tents, for detainees, homeless persons, and other emergency use.
        /// </summary>
        [DomValIx(1000322)]
        [StringValue("PRVCMP")]
        [EnumMember]
        ProvidingCamps,
		
        /// <summary>
        /// Providing labour and materiel for construction of facilities.
        /// </summary>
        [DomValIx(1000323)]
        [StringValue("PRVCNS")]
        [EnumMember]
        ProvidingConstructionServices,
		
        /// <summary>
        /// Providing labour and materiel for the educational process.
        /// </summary>
        [DomValIx(1000324)]
        [StringValue("PRVEDU")]
        [EnumMember]
        ProvidingEducationServices,
		
        /// <summary>
        /// Providing labour and materiel for maintaining the general health and welfare.
        /// </summary>
        [DomValIx(1000325)]
        [StringValue("PRVHLT")]
        [EnumMember]
        ProvidingHealthcareServices,
		
        /// <summary>
        /// Providing basic facilities such as roads, bridges, and sewers.
        /// </summary>
        [DomValIx(1000326)]
        [StringValue("PRVINF")]
        [EnumMember]
        ProvidingInfrastructure,
		
        /// <summary>
        /// Providing labour and materiel for laundering of clothes or linens.
        /// </summary>
        [DomValIx(1000327)]
        [StringValue("PRVLND")]
        [EnumMember]
        ProvidingLaundryServices,
		
        /// <summary>
        /// Providing labour and materiel to restore objects to sound condition.
        /// </summary>
        [DomValIx(1000328)]
        [StringValue("PRVRPR")]
        [EnumMember]
        ProvidingRepairServices,
		
        /// <summary>
        /// Providing labour and materiel to assure safety of personnel and facilities.
        /// </summary>
        [DomValIx(1000329)]
        [StringValue("PRVSCY")]
        [EnumMember]
        ProvidingSecurityServices,
		
        /// <summary>
        /// Providing housing.
        /// </summary>
        [DomValIx(1000330)]
        [StringValue("PRVSHL")]
        [EnumMember]
        ProvidingShelter,
		
        /// <summary>
        /// Making generally known a non-fictional essay, especially one included with others in a newspaper, magazine, journal, etc.
        /// </summary>
        [DomValIx(1000331)]
        [StringValue("PUBMDA")]
        [EnumMember]
        PublishingMediaArticle,
		
        /// <summary>
        /// Making generally known any document published on a media that provides a factual record or report.
        /// </summary>
        [DomValIx(1000332)]
        [StringValue("PUBMDD")]
        [EnumMember]
        PublishingMediaDocumentary,
		
        /// <summary>
        /// Making generally known an official statement issued to media for information.
        /// </summary>
        [DomValIx(1000333)]
        [StringValue("PUBPRS")]
        [EnumMember]
        PublishingPressRelease,
		
        /// <summary>
        /// A release of information to someone unauthorised.
        /// </summary>
        [DomValIx(1000334)]
        [StringValue("SECCMP")]
        [EnumMember]
        SecurityCompromise,
		
        /// <summary>
        /// An infringement of a security protocol.
        /// </summary>
        [DomValIx(1000335)]
        [StringValue("SECVIO")]
        [EnumMember]
        SecurityViolation,
		
        /// <summary>
        /// Stirring up of public interest on a matter of controversy, such as a political or social issue.
        /// </summary>
        [DomValIx(1000336)]
        [StringValue("TRBAGT")]
        [EnumMember]
        TroublemakingAgitating,
		
        /// <summary>
        /// Intimidating by the use of superior size or strength.
        /// </summary>
        [DomValIx(1000337)]
        [StringValue("TRBBLL")]
        [EnumMember]
        TroublemakingBullying,
		
        /// <summary>
        /// Persecuting systematically by besetting with annoyances, threats or demands.
        /// </summary>
        [DomValIx(1000338)]
        [StringValue("TRBHAR")]
        [EnumMember]
        TroublemakingHarassing,
		
        /// <summary>
        /// Causing difficulties by the actions of hoodlums, especially young ruffians.
        /// </summary>
        [DomValIx(1000339)]
        [StringValue("TRBHLG")]
        [EnumMember]
        TroublemakingHooliganism,
		
        /// <summary>
        /// Provoking to action, stirring up or urging on.
        /// </summary>
        [DomValIx(1000340)]
        [StringValue("TRBINC")]
        [EnumMember]
        TroublemakingInciting,
		
        /// <summary>
        /// Discouraging or inhibiting by or as if by threats.
        /// </summary>
        [DomValIx(1000341)]
        [StringValue("TRBINT")]
        [EnumMember]
        TroublemakingIntimidating,
		
        /// <summary>
        /// Producing chemical smoke to act as a form of cover to protect ongoing operations.
        /// </summary>
        [DomValIx(1000342)]
        [StringValue("GENCHS")]
        [EnumMember]
        GeneratingChemicalSmoke,
		
        /// <summary>
        /// Providing services to keep equipment in condition to carry out its function.
        /// </summary>
        [DomValIx(1000343)]
        [StringValue("MAINTN")]
        [EnumMember]
        Maintaining,
		
        /// <summary>
        /// Buying whatever is needed to fulfil a certain action.
        /// </summary>
        [DomValIx(1000344)]
        [StringValue("PROCUR")]
        [EnumMember]
        Procuring,
		
        /// <summary>
        /// Providing room for receiving people, esp. a place to live or lodgings.
        /// </summary>
        [DomValIx(1000345)]
        [StringValue("PRVACC")]
        [EnumMember]
        ProvidingAccommodation,
		
        /// <summary>
        /// Providing purification of different items from contamination.
        /// </summary>
        [DomValIx(1000346)]
        [StringValue("PRVDCN")]
        [EnumMember]
        ProvidingDecontaminationServices,
		
        /// <summary>
        /// Providing civil and/or military assistance rendered by a nation to foreign forces within its territory during peacetime, crises or emergencies, or war based on agreements mutually concluded between nations.
        /// </summary>
        [DomValIx(1000347)]
        [StringValue("PRVHSN")]
        [EnumMember]
        ProvidingHostNationSupport,
		
        /// <summary>
        /// Providing services for storage.
        /// </summary>
        [DomValIx(1000348)]
        [StringValue("PRVSTG")]
        [EnumMember]
        ProvidingStorageServices,
		
        /// <summary>
        /// Providing movement of cargo from one ship or train or container to another for further shipment.
        /// </summary>
        [DomValIx(1000349)]
        [StringValue("PRVTRS")]
        [EnumMember]
        ProvidingTranshipmentServices,
		
        /// <summary>
        /// Moving towards an objective in some form of tactical formation. This is a transitional phase between operations that may or may not result in contact with the enemy.
        /// </summary>
        [DomValIx(1000350)]
        [StringValue("ADVANC")]
        [EnumMember]
        Advancing,
		
        /// <summary>
        /// Seizing and detaining of a person under authority of the law.
        /// </summary>
        [DomValIx(1000351)]
        [StringValue("ARRLGL")]
        [EnumMember]
        ArrestingLegal,
		
        /// <summary>
        /// Stopping or checking of the motion, progress, growth, or spread of something.
        /// </summary>
        [DomValIx(1000352)]
        [StringValue("ARROBS")]
        [EnumMember]
        ArrestingObstructing,
		
        /// <summary>
        /// Joining together of multiple objects in the same area.
        /// </summary>
        [DomValIx(1000353)]
        [StringValue("ASSMBL")]
        [EnumMember]
        Assembling,
		
        /// <summary>
        /// Conducting an attack wherein a force attacks, or threatens to attack, a target other than the main target for the purpose of drawing enemy defences away from the main effort.
        /// </summary>
        [DomValIx(1000354)]
        [StringValue("ATTDVR")]
        [EnumMember]
        AttackDiversion,
		
        /// <summary>
        /// Staying clear of a specified object.
        /// </summary>
        [DomValIx(1000355)]
        [StringValue("AVOIDN")]
        [EnumMember]
        Avoiding,
		
        /// <summary>
        /// Denying of enemy access to an area or preventing his advance in a direction or along an avenue of approach.
        /// </summary>
        [DomValIx(1000356)]
        [StringValue("BLOCKN")]
        [EnumMember]
        Blocking,
		
        /// <summary>
        /// Breaking through or securing a passage through an enemy defence, obstacle, minefield, or fortification.
        /// </summary>
        [DomValIx(1000357)]
        [StringValue("BREACH")]
        [EnumMember]
        Breaching,
		
        /// <summary>
        /// Clearing of the air to gain either temporary or permanent air superiority or control in a given sector.
        /// </summary>
        [DomValIx(1000358)]
        [StringValue("CLRAIR")]
        [EnumMember]
        ClearingAir,
		
        /// <summary>
        /// Removing all enemy forces from a specific location, area, or zone.
        /// </summary>
        [DomValIx(1000359)]
        [StringValue("CLRLND")]
        [EnumMember]
        ClearingLandCombat,
		
        /// <summary>
        /// Eliminating or neutralizing an obstacle.
        /// </summary>
        [DomValIx(1000360)]
        [StringValue("CLROBS")]
        [EnumMember]
        ClearingObstacle,
		
        /// <summary>
        /// Eliminating transmissions on a tactical radio net in order to allow a higher precedence transmission to occur.
        /// </summary>
        [DomValIx(1000361)]
        [StringValue("CLRRAD")]
        [EnumMember]
        ClearingRadioNet,
		
        /// <summary>
        /// Moving an incoming force through another force that is currently in contact with the enemy in order for the incoming force to come into contact with the enemy.
        /// </summary>
        [DomValIx(1000363)]
        [StringValue("CNFWPS")]
        [EnumMember]
        ConductingForwardPassageOfLines,
		
        /// <summary>
        /// Delivering fire on a target preparatory to an assault.
        /// </summary>
        [DomValIx(1000364)]
        [StringValue("CNPRFR")]
        [EnumMember]
        ConductingPreparatoryFire,
		
        /// <summary>
        /// Moving a force through the defensive positions of another force behind it in order to break contact with the enemy.
        /// </summary>
        [DomValIx(1000365)]
        [StringValue("CNRWPS")]
        [EnumMember]
        ConductingRearwardPassageOfLines,
		
        /// <summary>
        /// Enabling the movement of a number of specific units.
        /// </summary>
        [DomValIx(1000366)]
        [StringValue("CNRDSV")]
        [EnumMember]
        ConductingRoadService,
		
        /// <summary>
        /// Re-organising and strengthening of a newly captured position so that it can be used against the enemy.
        /// </summary>
        [DomValIx(1000367)]
        [StringValue("CNSLDT")]
        [EnumMember]
        ConsolidatingOfAPosition,
		
        /// <summary>
        /// Building, digging or creating an object.
        /// </summary>
        [DomValIx(1000368)]
        [StringValue("CONSTN")]
        [EnumMember]
        Constructing,
		
        /// <summary>
        /// Restricting enemy forces by stopping, holding or surrounding them or compelling the enemy forces to centre activity on a given front and to prevent his withdrawing any part of his forces for use elsewhere.
        /// </summary>
        [DomValIx(1000369)]
        [StringValue("CONTAN")]
        [EnumMember]
        Containing,
		
        /// <summary>
        /// Operating as a force apart from the main body to protect the main body by fighting to gain time while also observing and reporting information and preventing enemy ground observation of an direct fire against the main body.
        /// </summary>
        [DomValIx(1000370)]
        [StringValue("COVERN")]
        [EnumMember]
        Covering,
		
        /// <summary>
        /// Traversing a FEATURE or FACILITY.
        /// </summary>
        [DomValIx(1000371)]
        [StringValue("CROSSN")]
        [EnumMember]
        Crossing,
		
        /// <summary>
        /// Employing measures designed to mislead the enemy by manipulation, distortion, or falsification of evidence to induce him to react in a manner prejudicial to his interests.
        /// </summary>
        [DomValIx(1000372)]
        [StringValue("DCPTIN")]
        [EnumMember]
        Deception,
		
        /// <summary>
        /// Protecting a defined object against an enemy attack.
        /// </summary>
        [DomValIx(1000373)]
        [StringValue("DEFEND")]
        [EnumMember]
        Defending,
		
        /// <summary>
        /// Preventing an enemy force from following the intended course.
        /// </summary>
        [DomValIx(1000374)]
        [StringValue("DEFLCT")]
        [EnumMember]
        Deflecting,
		
        /// <summary>
        /// Slowing the momentum of the enemy by conducting an operation in which the force under pressure trades time for space; the aim is to inflict the maximum damage on the enemy without becoming decisively engaged.
        /// </summary>
        [DomValIx(1000375)]
        [StringValue("DELAYN")]
        [EnumMember]
        Delaying,
		
        /// <summary>
        /// Preventing access by blocking, disrupting, dislocating and/or bringing fire to bear.
        /// </summary>
        [DomValIx(1000376)]
        [StringValue("DENYNG")]
        [EnumMember]
        Denying,
		
        /// <summary>
        /// Moving to and adopting a tactical formation or dispersal at a specific location.
        /// </summary>
        [DomValIx(1000377)]
        [StringValue("DEPLOY")]
        [EnumMember]
        Deploying,
		
        /// <summary>
        /// Physically rendering an enemy force combat-ineffective or damaging a target so that it cannot function as intended, nor be restored to a usable condition without being entirely rebuilt.
        /// </summary>
        [DomValIx(1000378)]
        [StringValue("DSTRYN")]
        [EnumMember]
        Destroying,
		
        /// <summary>
        /// Breaking off an action.
        /// </summary>
        [DomValIx(1000379)]
        [StringValue("DISENG")]
        [EnumMember]
        Disengaging,
		
        /// <summary>
        /// Breaking apart an enemy’s formation and tempo, interrupting the enemy’s time table, causing premature commitment of forces, and/or splintering their attack using integrated fire planning and obstacle effect.
        /// </summary>
        [DomValIx(1000380)]
        [StringValue("DSRPTN")]
        [EnumMember]
        Disrupting,
		
        /// <summary>
        /// Drawing the attention and forces of an enemy from the point of the principal operation; an attack, alarm, or feint that diverts attention.
        /// </summary>
        [DomValIx(1000381)]
        [StringValue("DIVRSN")]
        [EnumMember]
        Diversion,
		
        /// <summary>
        /// Manoeuvring by the main attacking force to pass around or over the enemy's principal defensive positions with the aim of securing objectives to the enemy's rear.
        /// </summary>
        [DomValIx(1000382)]
        [StringValue("ENVLPN")]
        [EnumMember]
        Enveloping,
		
        /// <summary>
        /// Accompanying and protecting another force or convoy.
        /// </summary>
        [DomValIx(1000383)]
        [StringValue("ESCRTN")]
        [EnumMember]
        Escorting,
		
        /// <summary>
        /// Clearing or removing materiel and personnel from a given locality.
        /// </summary>
        [DomValIx(1000384)]
        [StringValue("EVACTN")]
        [EnumMember]
        Evacuating,
		
        /// <summary>
        /// Taking advantage of a successful attack by mounting an offensive operation to follow-up and harass a dislocated enemy with the aim of further disorganising him in depth. This may provide the opportunity to capture ground that was not part of the objective of the original attack.
        /// </summary>
        [DomValIx(1000385)]
        [StringValue("EXPLTN")]
        [EnumMember]
        Exploitation,
		
        /// <summary>
        /// Operating as a committed force that is following a force conducting an offensive operation and is prepared to continue the mission of the force it is following when that force is fixed, attrited, or otherwise unable to continue.
        /// </summary>
        [DomValIx(1000386)]
        [StringValue("FOLASS")]
        [EnumMember]
        FollowingAndAssuming,
		
        /// <summary>
        /// Operating as a committed force that follows and supports the mission accomplishment of a force conducting an offensive operation.
        /// </summary>
        [DomValIx(1000387)]
        [StringValue("FOLSPT")]
        [EnumMember]
        FollowingAndSupporting,
		
        /// <summary>
        /// Operating as a security element to protect the main body by fighting to gain time while also observing and reporting information.
        /// </summary>
        [DomValIx(1000388)]
        [StringValue("GUARDN")]
        [EnumMember]
        Guarding,
		
        /// <summary>
        /// Conducting an operation or executing a fire plan designed to curtail movement and, by threat of losses, to lower the morale of enemy troops.
        /// </summary>
        [DomValIx(1000389)]
        [StringValue("HARASS")]
        [EnumMember]
        Harassing,
		
        /// <summary>
        /// Maintaining or retaining possession by force a position or area in defensive operations.
        /// </summary>
        [DomValIx(1000390)]
        [StringValue("HLDDEF")]
        [EnumMember]
        HoldDefensive,
		
        /// <summary>
        /// Exerting sufficient pressure by means of combat power in an attack to prevent the movement or redeployment of enemy forces.
        /// </summary>
        [DomValIx(1000391)]
        [StringValue("HLDOFF")]
        [EnumMember]
        HoldOffensive,
		
        /// <summary>
        /// Determining the identification of a particular class of object, recognising the friendly or enemy character of an object, or detecting the presence of an object.
        /// </summary>
        [DomValIx(1000392)]
        [StringValue("IDENT")]
        [EnumMember]
        Identifying,
		
        /// <summary>
        /// Providing battlespace lighting by employing searchlight or pyrotechnic illuminants using diffusion or reflection.
        /// </summary>
        [DomValIx(1000393)]
        [StringValue("ILLUMN")]
        [EnumMember]
        Illumination,
		
        /// <summary>
        /// Moving a force, broken down as individuals or small groups, over, through or around enemy positions with the aim of avoiding detection.
        /// </summary>
        [DomValIx(1000394)]
        [StringValue("INFLTN")]
        [EnumMember]
        Infiltration,
		
        /// <summary>
        /// Conducting electronic warfare support operations with a view to searching, locating and recording radiated electromagnetic energy.
        /// </summary>
        [DomValIx(1000395)]
        [StringValue("INTCPN")]
        [EnumMember]
        Interception,
		
        /// <summary>
        /// Diverting, disrupting, delaying, or destroying the enemy's surface military potential before it can be used effectively against friendly forces.
        /// </summary>
        [DomValIx(1000396)]
        [StringValue("INTDCT")]
        [EnumMember]
        Interdiction,
		
        /// <summary>
        /// Sealing off (both physically and psychologically) an enemy from its sources of support, denying an enemy freedom of movement, and preventing an enemy unit from having contact with other enemy forces.
        /// </summary>
        [DomValIx(1000397)]
        [StringValue("ISOLTN")]
        [EnumMember]
        Isolation,
		
        /// <summary>
        /// Deliberately radiating, re-radiating or reflecting electromagnetic energy with the object of impairing the use of electronic devices, equipment or systems being used by the enemy.
        /// </summary>
        [DomValIx(1000398)]
        [StringValue("JAMMNG")]
        [EnumMember]
        Jamming,
		
        /// <summary>
        /// Establishing the position of an object.
        /// </summary>
        [DomValIx(1000399)]
        [StringValue("LOCTNG")]
        [EnumMember]
        Locating,
		
        /// <summary>
        /// Making visible (by the use of light/IR/laser/arty) an object in order to allow its identification by another object (usually as a precursor to the use of direct fire weapons).
        /// </summary>
        [DomValIx(1000400)]
        [StringValue("MARKNG")]
        [EnumMember]
        Marking,
		
        /// <summary>
        /// Providing continuous view and the potential for reports on the activity of an object.
        /// </summary>
        [DomValIx(1000401)]
        [StringValue("OBSRNG")]
        [EnumMember]
        Observing,
		
        /// <summary>
        /// Moving onto an objective, key terrain, or other manmade or natural terrain area without opposition and controlling that entire area.
        /// </summary>
        [DomValIx(1000402)]
        [StringValue("OCCPNG")]
        [EnumMember]
        Occupying,
		
        /// <summary>
        /// Gathering information or carrying out a destructive, harassing, mopping-up, or security mission.
        /// </summary>
        [DomValIx(1000403)]
        [StringValue("PTRLNG")]
        [EnumMember]
        Patrolling,
		
        /// <summary>
        /// Breaking through the enemy's defence or disrupting the enemy's defensive systems.
        /// </summary>
        [DomValIx(1000404)]
        [StringValue("PENTRT")]
        [EnumMember]
        Penetrating,
		
        /// <summary>
        /// Continuing an offensive operation in order to catch or cut off a hostile force attempting to escape, with the aim of destroying it. Typically, contact is maintained and risk taken to harass relentlessly, thereby turning the pursuit into a rout.
        /// </summary>
        [DomValIx(1000405)]
        [StringValue("PURSNG")]
        [EnumMember]
        Pursuing,
		
        /// <summary>
        /// Attaining prescribed strength of units and prescribed levels of vehicles, equipment, stores and supplies. The process will only take place after a unit/formation combat effectiveness has been reduced.
        /// </summary>
        [DomValIx(1000406)]
        [StringValue("RECNSN")]
        [EnumMember]
        Reconstituting,
		
        /// <summary>
        /// Retrieving any lost, incapacitated or captured object.
        /// </summary>
        [DomValIx(1000407)]
        [StringValue("RECVRN")]
        [EnumMember]
        Recovering,
		
        /// <summary>
        /// Resting a unit after it has been in action. Some reconstitution may take place as well.
        /// </summary>
        [DomValIx(1000408)]
        [StringValue("RECPRN")]
        [EnumMember]
        Recuperating,
		
        /// <summary>
        /// Transferring a unit, an individual, or supplies deployed in one area to another area, or to another location within the area, for the purpose of further employment.
        /// </summary>
        [DomValIx(1000409)]
        [StringValue("REDPLN")]
        [EnumMember]
        Redeployment,
		
        /// <summary>
        /// Making a force available for the purpose of supplementing an in-place force.
        /// </summary>
        [DomValIx(1000410)]
        [StringValue("REINFN")]
        [EnumMember]
        Reinforcing,
		
        /// <summary>
        /// Changing a task organisation for a particular operation. (Normally takes place before an operation). This includes the transfer of authority.
        /// </summary>
        [DomValIx(1000411)]
        [StringValue("REORGN")]
        [EnumMember]
        Reorganising,
		
        /// <summary>
        /// Restoring an item to serviceable condition through correction of a specific failure or unserviceable condition.
        /// </summary>
        [DomValIx(1000412)]
        [StringValue("REPAIR")]
        [EnumMember]
        Repairing,
		
        /// <summary>
        /// Observing a specified period of inactivity by an organisation that is out of contact with the enemy.
        /// </summary>
        [DomValIx(1000413)]
        [StringValue("RESTNG")]
        [EnumMember]
        Resting,
		
        /// <summary>
        /// Replenishing stocks in order to maintain the required levels of supply.
        /// </summary>
        [DomValIx(1000414)]
        [StringValue("RESPLN")]
        [EnumMember]
        Resupplying,
		
        /// <summary>
        /// Operating as a security element whose primary task is to observe, identify and report information, and which only fights in self-protection.
        /// </summary>
        [DomValIx(1000415)]
        [StringValue("SCRNNG")]
        [EnumMember]
        Screening,
		
        /// <summary>
        /// Gaining possession of a position or terrain feature, with or without force, and making such disposition to prevent, as far as possible, its destruction or loss by enemy action.
        /// </summary>
        [DomValIx(1000416)]
        [StringValue("SECRNG")]
        [EnumMember]
        Securing,
		
        /// <summary>
        /// Clearing a designated area and obtaining control of it.
        /// </summary>
        [DomValIx(1000417)]
        [StringValue("SEIZNG")]
        [EnumMember]
        Seizing,
		
        /// <summary>
        /// Assisting or abetting a known criminal or terrorist.
        /// </summary>
        [DomValIx(1000453)]
        [StringValue("ASTCRM")]
        [EnumMember]
        AssistingACriminal,
		
        /// <summary>
        /// Concealing an object.
        /// </summary>
        [DomValIx(1000454)]
        [StringValue("HIDING")]
        [EnumMember]
        Hiding,
		
        /// <summary>
        /// Travelling over a designated route.
        /// </summary>
        [DomValIx(1000455)]
        [StringValue("TRVRSN")]
        [EnumMember]
        Traversing,
		
        /// <summary>
        /// Initiating the codeword activity.
        /// </summary>
        [DomValIx(1000456)]
        [StringValue("CDWDEX")]
        [EnumMember]
        CodewordExecution,
		
        /// <summary>
        /// The unforeseen loss of an aircraft (and personnel), other than crash.
        /// </summary>
        [DomValIx(1000457)]
        [StringValue("ACRLOS")]
        [EnumMember]
        AircraftLoss,
		
        /// <summary>
        /// Conducting electronic warfare involving the use of electromagnetic energy, directed energy or anti-radiation weapons to attack personnel, facilities, or equipment with the intent of degrading, neutralizing, or destroying enemy combat capability and is considered a form of fires.
        /// </summary>
        [DomValIx(1000458)]
        [StringValue("ATTEL")]
        [EnumMember]
        AttackElectronic,
		
        /// <summary>
        /// In electronic countermeasures, the deliberate radiation, re-radiation, alteration, absorption or reflection of electromagnetic energy in a manner intended to confuse, distract or seduce an enemy or his electronic systems.
        /// </summary>
        [DomValIx(1000459)]
        [StringValue("DCPTEL")]
        [EnumMember]
        DeceptionElectronic,
		
        /// <summary>
        /// That division of electronic warfare involving actions taken to ensure effective friendly use of the electromagnetic spectrum despite the enemy's use of electromagnetic energy.
        /// </summary>
        [DomValIx(1000460)]
        [StringValue("PROTEL")]
        [EnumMember]
        ProtectionElectronic,
		
        /// <summary>
        /// The systematic observation of aerospace, surface or subsurface areas, places, persons, or things, by electronic means.
        /// </summary>
        [DomValIx(1000461)]
        [StringValue("SURVEL")]
        [EnumMember]
        SurveillanceElectronic,
		
        /// <summary>
        /// The act of firing a naval surface-to-surface weapon.
        /// </summary>
        [DomValIx(1000462)]
        [StringValue("NAVGUN")]
        [EnumMember]
        NavalGunFire,
		
        /// <summary>
        /// The act of firing an air-to-air weapon, usually at an aircraft.
        /// </summary>
        [DomValIx(1000463)]
        [StringValue("GUNATA")]
        [EnumMember]
        GunneryAirToAir,
		
        /// <summary>
        /// An ACTION-EVENT that involves chemical, biological, radiological, or nuclear materiel individually or in combination.
        /// </summary>
        [DomValIx(1000464)]
        [StringValue("CBRN")]
        [EnumMember]
        CbrnEvent,
		
        /// <summary>
        /// Military action to exploit the electro-magnetic spectrum encompassing the search for, interception and identification of electro-magnetic emissions, the employment of electro-magnetic energy, including directed energy, to reduce or prevent hostile use of the electro-magnetic spectrum, and actions to ensure its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000465)]
        [StringValue("ELCWAR")]
        [EnumMember]
        ElectronicWarfare,
		
        /// <summary>
        /// The assembly of aircraft for the completion of a mission or other activity.
        /// </summary>
        [DomValIx(1000466)]
        [StringValue("MISSTG")]
        [EnumMember]
        MissionStaging,
		
        /// <summary>
        /// The action of approaching and alighting on the ground or some other surface after a flight.
        /// </summary>
        [DomValIx(1000467)]
        [StringValue("AIRLND")]
        [EnumMember]
        AircraftLanding,
		
        /// <summary>
        /// Causing a temporary loss of vision or a temporary reduction in visual acuity; may also be applied to effects on optics.
        /// </summary>
        [DomValIx(1000468)]
        [StringValue("DAZZLE")]
        [EnumMember]
        Dazzle,
		
        /// <summary>
        /// Bringing the enemy under fire.
        /// </summary>
        [DomValIx(1000469)]
        [StringValue("ENGAGE")]
        [EnumMember]
        Engaging,
		
        /// <summary>
        /// Covering something by a smoke screen.
        /// </summary>
        [DomValIx(1000470)]
        [StringValue("OBSCUR")]
        [EnumMember]
        Obscure,
		
        /// <summary>
        /// Obtaining by coercive means, as by threats or intimidation.
        /// </summary>
        [DomValIx(1000481)]
        [StringValue("EXTORT")]
        [EnumMember]
        Extortion,
		
        /// <summary>
        /// Initial observing or finding of an IED.
        /// </summary>
        [DomValIx(1000482)]
        [StringValue("IEDDSC")]
        [EnumMember]
        IedDiscovery,
		
        /// <summary>
        /// A violent and destructive shattering or blowing apart of an IED.
        /// </summary>
        [DomValIx(1000483)]
        [StringValue("IEDEXP")]
        [EnumMember]
        IedExplosion,
		
        /// <summary>
        /// An IED incident that involves the discovery and/or recovery of a cache of unarmed devices, IED components and IED paraphernalia.
        /// </summary>
        [DomValIx(1000484)]
        [StringValue("IEDCCH")]
        [EnumMember]
        IedCacheDiscovery,
		
        /// <summary>
        /// An IED incident that involves a device fabricated to look like an IED and is intended to purposely simulate one in order to elicit a response.
        /// </summary>
        [DomValIx(1000485)]
        [StringValue("IEDHX")]
        [EnumMember]
        IedHoax,
		
        /// <summary>
        /// The practice of persuading someone to do something by using force or threats.
        /// </summary>
        [DomValIx(1000486)]
        [StringValue("COERC")]
        [EnumMember]
        Coercion,
		
        /// <summary>
        /// The action of consulting or taking counsel together; deliberation, conference, e.g. Shura.
        /// </summary>
        [DomValIx(1000487)]
        [StringValue("CONSLT")]
        [EnumMember]
        Consultation,
		
        /// <summary>
        /// The act of forsaking; abandonment of a service, a cause, or any post of duty; the quitting of one's duties wilfully and without right.
        /// </summary>
        [DomValIx(1000488)]
        [StringValue("DESRTN")]
        [EnumMember]
        Desertion,
		
        /// <summary>
        /// The moving of something from its place or position.
        /// </summary>
        [DomValIx(1000489)]
        [StringValue("DISPLC")]
        [EnumMember]
        Displacement,
		
        /// <summary>
        /// An assembly or meeting, especially a social or festive one or one held for a specific purpose.
        /// </summary>
        [DomValIx(1000490)]
        [StringValue("GTHRNG")]
        [EnumMember]
        Gathering,
		
        /// <summary>
        /// The act of controlling movement with the intent of conducting illegal activities.
        /// </summary>
        [DomValIx(1000491)]
        [StringValue("ILCKPT")]
        [EnumMember]
        IllegalCheckPointActivity,
		
        /// <summary>
        /// Affecting the condition of, to have an affect on.
        /// </summary>
        [DomValIx(1000492)]
        [StringValue("INFLUC")]
        [EnumMember]
        Influence,
		
        /// <summary>
        /// The action of coming together into one place or into the presence of each other.
        /// </summary>
        [DomValIx(1000493)]
        [StringValue("MEETNG")]
        [EnumMember]
        Meeting,
		
        /// <summary>
        /// The action of producing or manufacturing narcotics.
        /// </summary>
        [DomValIx(1000494)]
        [StringValue("NARCTC")]
        [EnumMember]
        NarcoticsProduction,
		
        /// <summary>
        /// The expressing of dissent from, or rejection of the prevailing social, political or cultural mores.
        /// </summary>
        [DomValIx(1000495)]
        [StringValue("PROTST")]
        [EnumMember]
        Protest,
		
        /// <summary>
        /// The action of gathering information.
        /// </summary>
        [DomValIx(1000496)]
        [StringValue("SCOTNG")]
        [EnumMember]
        Scouting,
		
        /// <summary>
        /// The act of looking for something or someone.
        /// </summary>
        [DomValIx(1000497)]
        [StringValue("SRCHNG")]
        [EnumMember]
        Searching,
		
        /// <summary>
        /// The action of looking, catching sight of.
        /// </summary>
        [DomValIx(1000498)]
        [StringValue("SIGTNG")]
        [EnumMember]
        Sighting,
		
        /// <summary>
        /// To convey (goods) clandestinely, in order to avoid payment of legal duties or to convey illegal goods.
        /// </summary>
        [DomValIx(1000499)]
        [StringValue("SMGLNG")]
        [EnumMember]
        Smuggling,
		
        /// <summary>
        /// An address or discourse of more or less formal character delivered to an audience or assembly; an oration.
        /// </summary>
        [DomValIx(1000500)]
        [StringValue("SPEECH")]
        [EnumMember]
        Speech,
		
        /// <summary>
        /// Action designed to weaken the military, economic or political strength of a nation by undermining the morale, loyalty or reliability of its citizens.
        /// </summary>
        [DomValIx(1000501)]
        [StringValue("SBVRSN")]
        [EnumMember]
        Subversion,
		
        /// <summary>
        /// The systematic observation of aerospace, surface or subsurface areas, places, person or things by visual, aural, electronic, photographic or other means.
        /// </summary>
        [DomValIx(1000502)]
        [StringValue("SRVLNC")]
        [EnumMember]
        Surveillance,
		
        /// <summary>
        /// The transfer of information from one point to one or more other points by means of signals.
        /// </summary>
        [DomValIx(1000503)]
        [StringValue("TRNSMS")]
        [EnumMember]
        Transmission,
		
    }
}

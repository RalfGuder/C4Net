using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ROUTE-TYPE.
    /// </summary>
    [DomId(100004222)]
    [DataContract]
    public enum RouteTypeCategoryEnum
    {
		
        /// <summary>
        /// A designated route along which air traffic advisory service is available.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADVRTE")]
        [EnumMember]
        AdvisoryRoute,
		
        /// <summary>
        /// The navigable airspace between two points identified to the extent necessary for the application of flight.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRRTE")]
        [EnumMember]
        AirRoute,
		
        /// <summary>
        /// A specified route designed for channelling the flow of traffic as necessary for the provision of air traffic services (ATS).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ATS")]
        [EnumMember]
        AirTrafficServicesRoute,
		
        /// <summary>
        /// A route or routes designated within an area of operations to provide for the movement of traffic when main supply routes become disabled or congested.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ALTSPL")]
        [EnumMember]
        AlternateSupplyRoute,
		
        /// <summary>
        /// An air traffic services route established for the use of aircraft capable of employing area navigation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NAVRTE")]
        [EnumMember]
        AreaNavigationRoute,
		
        /// <summary>
        /// A non-permanent air traffic service route or portion thereof which can be planned and used only under certain conditions.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CONDRT")]
        [EnumMember]
        ConditionalRoute,
		
        /// <summary>
        /// Conventional route.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CONVRT")]
        [EnumMember]
        ConventionalRoute,
		
        /// <summary>
        /// Direct routing.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("DCT")]
        [EnumMember]
        Dct,
		
        /// <summary>
        /// A route generally parallel to the forward edge of the battle area, which crosses, or feeds into, axial routes.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("LATR")]
        [EnumMember]
        LateralRoute,
		
        /// <summary>
        /// A temporary corridor of defined dimensions established in the forward area to minimise the risk to friendly aircraft from friendly air defences or surface forces.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("LLTR")]
        [EnumMember]
        LowLevelTransitRoute,
		
        /// <summary>
        /// The route or routes designated with an area of operations on which the bulk of traffic flows in support of military operations.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MSR")]
        [EnumMember]
        MainSupplyRoute,
		
        /// <summary>
        /// A temporary corridor of defined dimensions recommended for use by high-speed, fixed-wing aircraft that presents the minimum known hazards to low-flying aircraft transiting the combat zone. Army--An MRR is a temporary flight route recommended for USAF use. It presents the minimum known hazards to low-flying aircraft in the control zone (CZ). The MRR must be approved by the airspace control authority and avoids fire support targets such as air defence weapons, landing zones, pick-up zones, FARPs, and Army airfields.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MRR")]
        [EnumMember]
        MinimumRiskRoute,
		
        /// <summary>
        /// Polar route.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("POLRRT")]
        [EnumMember]
        PolarRoute,
		
        /// <summary>
        /// Planned route profiles for use by friendly aircraft returning to an aircraft-capable ship.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("RETFRT")]
        [EnumMember]
        ReturnToForceRoute,
		
        /// <summary>
        /// Route established below the coordination altitude to facilitate movement of army aviation assets in the forward area in direct support of ground operations.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("STDART")]
        [EnumMember]
        StandardUseArmyAircraftFlightRoute,
		
        /// <summary>
        /// Supersonic route.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SUPRRT")]
        [EnumMember]
        SupersonicRoute,
		
        /// <summary>
        /// Tactical air navigation route.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("TACAN")]
        [EnumMember]
        TacanRoute,
		
        /// <summary>
        /// A temporary route of defined dimension recommended for use by high speed fixed-wing aircraft to route them between TRs and the rear of the forward area and their operations areas.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("TMMRRT")]
        [EnumMember]
        TemporaryMinimumRiskRoute,
		
        /// <summary>
        /// A temporary corridor of defined dimensions established in the forward area to minimise the risk to friendly aircraft from friendly air defences or surface forces.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("TRSTRT")]
        [EnumMember]
        TransitRoute,
		
        /// <summary>
        /// Trunk route.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("TRNKRT")]
        [EnumMember]
        TrunkRoute,
		
        /// <summary>
        /// The CONTROL-FEATURE-TYPE that specifies a route along which an unmanned aerial vehicle travels.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("UNMVRT")]
        [EnumMember]
        UnmannedAerialVehicleRoute,
		
        /// <summary>
        /// An outbound route from a specific area or target.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("EGRRTU")]
        [EnumMember]
        EgressRoute,
		
        /// <summary>
        /// The route that follows the shortest arc between two points on the earth's surface.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("GRCLRT")]
        [EnumMember]
        GreatCircleRoute,
		
        /// <summary>
        /// An inbound route to a specific area or target.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("INGRTE")]
        [EnumMember]
        IngressRoute,
		
        /// <summary>
        /// The route that maintains a constant direction, shown on a map as a line crossing all meridians at the same angle.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("RHLNRT")]
        [EnumMember]
        RhumbLineRoute,
		
        /// <summary>
        /// In naval cooperation and guidance for shipping, a preplanned single track connecting positions within the main shipping route.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("STRDRT")]
        [EnumMember]
        StandardRoute,
		
        /// <summary>
        /// The route that follows the shape or boundary of a coast.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("USCTRT")]
        [EnumMember]
        UsualCoastalRoute,
		
        /// <summary>
        /// Any combination of other than standard routes.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("VARTRA")]
        [EnumMember]
        VariableTrackRoute,
		
        /// <summary>
        /// A system of preplanned shipping lanes in mined or potentially mined waters used to minimize the area the mine countermeasures commander has to keep clear of mines in order to provide safe passage for friendly shipping.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("QROUTE")]
        [EnumMember]
        QRoute,
		
        /// <summary>
        /// A part of a system of preplanned shipping lanes in mined or potentially mined waters used to minimize the area the mine countermeasures commander has to keep clear of mines in order to provide safe passage for friendly shipping.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("QRTESG")]
        [EnumMember]
        QRouteSegment,
		
        /// <summary>
        /// A restricted air route of travel specified for use by friendly aircraft and established for the purpose of preventing friendly aircraft from being fired on by friendly forces.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("AIRCOR")]
        [EnumMember]
        AirCorridor,
		
        /// <summary>
        /// A control area or portion thereof established in the form of a corridor equipped with radio navigational aids.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("AIRWAY")]
        [EnumMember]
        Airway,
		
        /// <summary>
        /// Airspace established for the safe passage of land based aircraft joining or departing a maritime force.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("APRCOR")]
        [EnumMember]
        ApproachCorridor,
		
        /// <summary>
        /// The line connecting the successive positions occupied, or to be occupied, by an aircraft, missile or space vehicle as it moves through air or space.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("FLTPTH")]
        [EnumMember]
        FlightPath,
		
        /// <summary>
        /// An area established to accommodate the special routing requirements of specific missions.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("SPCCDR")]
        [EnumMember]
        SpecialCorridor,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The prescribed reference line over the ground along which the centre of the mine counter measures gear must travel.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("REFTRK")]
        [EnumMember]
        ReferenceTrack,
		
        /// <summary>
        /// The prescribed line over the ground along which the centre of the minelaying gear must travel.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("MAMNTR")]
        [EnumMember]
        MaritimeMinelayingTrack,
		
        /// <summary>
        /// The prescribed line over the ground along which the centre of the mine counter measures gear must travel in order that the lane swept can be defined by the width and the depth swept.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("MAMNST")]
        [EnumMember]
        MaritimeMinefieldSweepTrack,
		
    }
}

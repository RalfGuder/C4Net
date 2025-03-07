using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of VEHICLE-TYPE.
    /// </summary>
    [DomId(100000348)]
    [DataContract]
    public enum VehicleTypeCategoryEnum
    {
		
        /// <summary>
        /// A lightly armoured, highly mobile vehicle, amphibious and air-droppable, used primarily for transporting personnel and their individual equipment during tactical operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("APC")]
        [EnumMember]
        ArmouredPersonnelCarrier,
		
        /// <summary>
        /// An armoured vehicle used to carry persons for reconnaissance activities.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ARMRCC")]
        [EnumMember]
        ArmouredReconnaissanceCarrier,
		
        /// <summary>
        /// An armoured vehicle mainly used for maintenance, recovery, ambulance functions or resupply.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ASSV")]
        [EnumMember]
        ArmouredServiceSupport,
		
        /// <summary>
        /// An armoured vehicle with less armour that uses its increased mobility and possibly more lethal armaments for survivability.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARVELT")]
        [EnumMember]
        ArmouredVehicleLight,
		
        /// <summary>
        /// A self-propelled passenger vehicle.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AUTOMO")]
        [EnumMember]
        Automobile,
		
        /// <summary>
        /// A vehicle designed to recover heavy weight battle tanks.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("BTHVRE")]
        [EnumMember]
        BattleTankHeavyRecovery,
		
        /// <summary>
        /// A vehicle designed to recover medium weight battle tanks.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("BTMDRE")]
        [EnumMember]
        BattleTankMediumRecovery,
		
        /// <summary>
        /// A vehicle of two wheels held in a frame one behind the other, propelled by pedals and steered with handlebars attached to the front wheel.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("BICYCL")]
        [EnumMember]
        Bicycle,
		
        /// <summary>
        /// A large passenger road vehicle.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BUS")]
        [EnumMember]
        Bus,
		
        /// <summary>
        /// An automotive vehicle designed to be used off road for transporting loads.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CCTRCK")]
        [EnumMember]
        CrossCountryTruck,
		
        /// <summary>
        /// A large motor vehicle designed to carry fire-fighters and equipment to a fire and supports extinguishing operations.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("FRFGTN")]
        [EnumMember]
        Firefighting,
		
        /// <summary>
        /// A vehicle designed to carry cumbersome or heavy items.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("HETVEH")]
        [EnumMember]
        HeavyEquipmentTransport,
		
        /// <summary>
        /// A vehicle which, as its primary function, is designed to provide equipment support facilities in or out of the battlespace.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MAINT")]
        [EnumMember]
        Maintenance,
		
        /// <summary>
        /// A vehicle which, as its primary, is designed to provide materiel handling facilities in or out of the battlespace.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MHVEH")]
        [EnumMember]
        MaterielHandling,
		
        /// <summary>
        /// A small, sturdy, four-wheel-drive army vehicle, used chiefly for reconnaissance; a similar vehicle in non-military use.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MILUV")]
        [EnumMember]
        MilitaryUtility,
		
        /// <summary>
        /// A vehicle with two wheels in tandem, self-propelled and sometimes having a sidecar with a third wheel.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MOTCYC")]
        [EnumMember]
        Motorcycle,
		
        /// <summary>
        /// A road trailer that has a wheel system at the rear only and is coupled to a suitable tractor to form an articulated lorry.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SEMI")]
        [EnumMember]
        Semi,
		
        /// <summary>
        /// A powered vehicle that pulls or draws machinery.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("TRACTR")]
        [EnumMember]
        Tractor,
		
        /// <summary>
        /// A vehicle designed to be towed by another.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("TRAILR")]
        [EnumMember]
        Trailer,
		
        /// <summary>
        /// A bus powered by electricity obtained from an overhead cable by means of a trolley-wheel.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("TRLBUS")]
        [EnumMember]
        TrolleyBus,
		
        /// <summary>
        /// An automotive vehicle used for transporting loads.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("TRUCK")]
        [EnumMember]
        Truck,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A vehicle for conveying sick, wounded, incapacitated, or injured persons.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("AMBUL")]
        [EnumMember]
        Ambulance,
		
        /// <summary>
        /// A vehicle designed to recover armoured personnel carriers.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("APCREC")]
        [EnumMember]
        ArmouredPersonnelCarrierRecovery,
		
        /// <summary>
        /// A vehicle designed to travel over land and on water.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("AMPH")]
        [EnumMember]
        Amphibian,
		
        /// <summary>
        /// A vehicle that has some form of ballistic protection (excluding tanks).
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("ARMORD")]
        [EnumMember]
        Armoured,
		
        /// <summary>
        /// A vehicle designed to recover light weight battle tanks.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("BTLTRE")]
        [EnumMember]
        BattleTankLightRecovery,
		
        /// <summary>
        /// A vehicle designed to be used as a command post or as part of a command post.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("CMDPST")]
        [EnumMember]
        CommandPost,
		
        /// <summary>
        /// An armoured vehicle designed to be used as a command post or as part of a command post.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("CMDPTA")]
        [EnumMember]
        CommandPostArmoured,
		
        /// <summary>
        /// A wheeled, non-armoured vehicle, designed to be used as a command post or as part of a command post.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("CMDPTW")]
        [EnumMember]
        CommandPostWheeled,
		
        /// <summary>
        /// A vehicle used by engineers, without any other precision.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ENGNOS")]
        [EnumMember]
        EngineeringNotOtherwiseSpecified,
		
        /// <summary>
        /// A vehicle designed for multiple uses.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("GNLPRP")]
        [EnumMember]
        GeneralPurpose,
		
        /// <summary>
        /// A vehicle specifically designed for special use.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("SPCPRP")]
        [EnumMember]
        SpecialPurpose,
		
        /// <summary>
        /// A vehicle designed to carry assault troops.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("ASSVEH")]
        [EnumMember]
        AssaultVehicle,
		
        /// <summary>
        /// A non self-propelled vehicle with two or four wheels for carrying loads.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("CART")]
        [EnumMember]
        Cart,
		
        /// <summary>
        /// A vehicle with a horizontal fork in front for lifting and carrying loads.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("FORKLF")]
        [EnumMember]
        Forklift,
		
        /// <summary>
        /// A vehicle, usually military, with wheels in front and tracks in the rear.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("HALFTR")]
        [EnumMember]
        HalfTrack,
		
        /// <summary>
        /// A vehicle designed to push snow aside.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("SNOWPL")]
        [EnumMember]
        Snowplough,
		
        /// <summary>
        /// A vehicle whose primary role is the transportation of heavy equipment.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("TRANSG")]
        [EnumMember]
        TransporterGeneral,
		
        /// <summary>
        /// A vehicle whose primary role is the transportation of main battle tanks.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("TRANST")]
        [EnumMember]
        TransporterTank,
		
        /// <summary>
        /// A truck having a body that tilts and opens for unloading materials
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("TRUCKD")]
        [EnumMember]
        TruckDump,
		
        /// <summary>
        /// A small, sturdy, four-wheel-drive vehicle, used chiefly for reconnaissance; a similar vehicle in non-military use.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("UTILTY")]
        [EnumMember]
        Utility,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1650/6.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("CEVEH")]
        [EnumMember]
        CombatEngineerVehicle,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1650/6.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("CSVEH")]
        [EnumMember]
        CombatSupportVehicle,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1650/6.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("LNDVEH")]
        [EnumMember]
        LandingVehicle,
		
        /// <summary>
        /// A vehicle used in recovering a damaged one.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("WRCKR")]
        [EnumMember]
        Wrecker,
		
        /// <summary>
        /// An Armoured Command and Control Vehicle (C2V) or an Armoured Combat Vehicle (ACV).
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("ACVACV")]
        [EnumMember]
        ArmouredC2VAcv,
		
        /// <summary>
        /// A motorized pedal cycle.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("MOPED")]
        [EnumMember]
        Moped,
		
        /// <summary>
        /// An animal (such as a mule, donkey, camel or horse) with the role of transport used to carry loads.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("PACKAN")]
        [EnumMember]
        PackAnimal,
		
        /// <summary>
        /// A covered motor vehicle, typically without side windows, used for transporting goods or people.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("VAN")]
        [EnumMember]
        Van,
		
    }
}

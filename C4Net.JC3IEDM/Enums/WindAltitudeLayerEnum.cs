using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value used to indicate the class of the altitude for a specific set of reported wind data.
    /// </summary>
    [DomId(100004310)]
    [DataContract]
    public enum WindAltitudeLayerEnum
    {
		
        /// <summary>
        /// Reported wind data are valid for altitudes less than 2000 metres above ground.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("2")]
        [EnumMember]
        _2000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 2000 and less than 4000 metres above ground.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("4")]
        [EnumMember]
        _4000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 4000 and less than 6000 metres above ground.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("6")]
        [EnumMember]
        _6000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 6000 and less than 8000 metres above ground.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("8")]
        [EnumMember]
        _8000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 8000 and less than 10000 metres above ground.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("10")]
        [EnumMember]
        _10000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 10000 and less than 12000 metres above ground.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("12")]
        [EnumMember]
        _12000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes between 12000 and less than 14000 metres above ground.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("14")]
        [EnumMember]
        _14000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 14000 and less than 16000 metres above ground.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("16")]
        [EnumMember]
        _16000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 16000 and less than 18000 metres above ground.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("18")]
        [EnumMember]
        _18000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 18000 and less than 20000 metres above ground.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("20")]
        [EnumMember]
        _20000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 20000 and less than 22000 metres above ground.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("22")]
        [EnumMember]
        _22000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 22000 and less than 24000 metres above ground.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("24")]
        [EnumMember]
        _24000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 24000 and less than 26000 metres above ground.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("26")]
        [EnumMember]
        _26000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 26000 and less than 28000 metres above ground.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("28")]
        [EnumMember]
        _28000Metres,
		
        /// <summary>
        /// Reported wind data are valid for altitudes greater than or equal to 28000 and less than 30000 metres above ground.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("30")]
        [EnumMember]
        _30000Metres,
		
    }
}

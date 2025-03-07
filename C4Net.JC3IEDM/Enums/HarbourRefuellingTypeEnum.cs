using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the refuelling means available at the specific HARBOUR.
    /// </summary>
    [DomId(100004172)]
    [DataContract]
    public enum HarbourRefuellingTypeEnum
    {
		
        /// <summary>
        /// A mobile facility that is a barge whose sole purpose is the refuelling of vessels.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BKRBRG")]
        [EnumMember]
        BunkeringBarge,
		
        /// <summary>
        /// A static facility from which vessels can refuel.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FXDINS")]
        [EnumMember]
        FixedInstallation,
		
        /// <summary>
        /// A mobile facility that is a road fuel tanker used for refuelling vessels whilst moored alongside a jetty, basin, quay or berth.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TNKRRD")]
        [EnumMember]
        TankerRoad,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

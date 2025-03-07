using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of signal system used for the RAILWAY.
    /// </summary>
    [DomId(100004262)]
    [DataContract]
    public enum RailwaySignalSystemEnum
    {
		
        /// <summary>
        /// The specific value that represents a signal, which gives indication by the colour of the light only.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CL")]
        [EnumMember]
        ColourLight,
		
        /// <summary>
        /// The specific value that represents a signal giving indications by the colour and position of two or more lights.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CP")]
        [EnumMember]
        ColourPosition,
		
        /// <summary>
        /// The specific value that represents an electric light system.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("EL")]
        [EnumMember]
        ElectricLight,
		
        /// <summary>
        /// The specific value that indicates that the analysis of the system is inconclusive.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("Z")]
        [EnumMember]
        InconclusiveAnalysis,
		
        /// <summary>
        /// The specific value that represents a signal to which indications are given by the position of two or more lights.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PL")]
        [EnumMember]
        PositionLight,
		
        /// <summary>
        /// The specific value that represents a signal in which the day indicators are given by changing positions of a semaphore arm and the night indications are given by coloured lights.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SF")]
        [EnumMember]
        Semaphore,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

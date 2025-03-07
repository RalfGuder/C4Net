using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the OBJECT-ITEM usage of an ELECTRONIC-ADDRESS in terms of transmission and reception.
    /// </summary>
    [DomId(100004254)]
    [DataContract]
    public enum ObjectItemAddressTransmitReceiveEnum
    {
		
        /// <summary>
        /// The specific ELECTRONIC-ADDRESS is used only for reception purposes with respect to the specific OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RECEIV")]
        [EnumMember]
        Receive,
		
        /// <summary>
        /// The specific ELECTRONIC-ADDRESS is used only for transmission purposes with respect to the specific OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TRNSMT")]
        [EnumMember]
        Transmit,
		
        /// <summary>
        /// The specific ELECTRONIC-ADDRESS is used both for transmission and reception purposes with respect to the specific OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TRNREC")]
        [EnumMember]
        TransmitAndReceive,
		
    }
}

using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether an IED was initiated by an operator at a time of his/her choosing in which the operator intentionally kills himself/herself as part of the attack.
    /// </summary>
    [DomId(100004424)]
    [DataContract]
    public enum IedTacticalCharacterizationSuicideEnum
    {
		
        /// <summary>
        /// The specific value that indicates the operator does not intentionally kill himself/herself as part of the attack.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// An IED initiated by an insurgent/terrorist at a time of his/her choosing in which the operator intentionally kills himself/herself as part of the attack or to deny his/her capture.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}

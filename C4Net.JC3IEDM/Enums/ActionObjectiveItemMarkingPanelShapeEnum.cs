using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the shape of the marking panel.
    /// </summary>
    [DomId(100004146)]
    [DataContract]
    public enum ActionObjectiveItemMarkingPanelShapeEnum
    {
		
        /// <summary>
        /// The panel is in the shape of the letter H.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HSHAPE")]
        [EnumMember]
        HShape,
		
        /// <summary>
        /// The panel is in the shape of the letter I.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISHAPE")]
        [EnumMember]
        IShape,
		
        /// <summary>
        /// The panel is in the shape of the letter T.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TSHAPE")]
        [EnumMember]
        TShape,
		
        /// <summary>
        /// The panel is in the shape of the letter X.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("XSHAPE")]
        [EnumMember]
        XShape,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}

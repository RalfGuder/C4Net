using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of relationship of subject ACTION to object ACTION.
    /// </summary>
    [DomId(100000114)]
    [DataContract]
    public enum ActionFunctionalAssociationCategoryEnum
    {
		
        /// <summary>
        /// The value that links two activities such that the subject ACTION has as a sub-ACTION the object ACTION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HSA")]
        [EnumMember]
        HasAsASubAction,
		
        /// <summary>
        /// The subject ACTION is to be carried out so that the conditions are established for the completion of the object ACTION (e.g., carrying out ACTION A so that ACTION B can then be carried out). (Note: This has no bearing on the temporal relationships between ACTIONs).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("IOT")]
        [EnumMember]
        InOrderThat,
		
        /// <summary>
        /// The value denoting that the subject ACTION amends (or suggests an amendment to) an existing object ACTION (be it a plan, order, or request).
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("IMO")]
        [EnumMember]
        IsAModificationOf,
		
        /// <summary>
        /// The value that establishes a link between existing ACTIONs and new ACTIONs, be they requests, plans, or orders. (Note: The subject ACTION uses the specified object ACTION as a reference).
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("UAR")]
        [EnumMember]
        UsesAsAReference,
		
        /// <summary>
        /// The subject ACTION may replace the object ACTION.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ALT")]
        [EnumMember]
        IsAnAlternativeTo,
		
        /// <summary>
        /// The subject ACTION constitutes an example that the object ACTION should conform to.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("TPL")]
        [EnumMember]
        IsATemplateFor,
		
        /// <summary>
        /// The subject ACTION may be re-directed to an alternative object ACTION. Note: The need for object ACTION is foreseen in planning, but its execution depends on external circumstances.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("HASPRV")]
        [EnumMember]
        HasAsAProvisionalSubAction,
		
        /// <summary>
        /// The value that links two ACTIONs such that the subject ACTION is planned to be or may be expected to be carried out in reaction to the object ACTION.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("INRSTO")]
        [EnumMember]
        InResponseTo,
		
        /// <summary>
        /// The subject ACTION must be completed as planned before the object ACTION may commence.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ISAPRQ")]
        [EnumMember]
        IsAPrerequisiteFor,
		
        /// <summary>
        /// The value denoting that the subject ACTION is the cause for the object ACTION. (Note: This is intended to be used only when the ACTION is an ACTION-EVENT).
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ISCAUS")]
        [EnumMember]
        IsTheCauseOf,
		
        /// <summary>
        /// The subject ACTION is designated as the primary activity and has the object ACTION as a secondary activity.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("HASSEC")]
        [EnumMember]
        HasAsSecondary,
		
    }
}

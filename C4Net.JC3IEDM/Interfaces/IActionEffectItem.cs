using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ActionEffectItem that represents the table ACT_EFFECT_ITEM
	/// 
	/// An ACTION-EFFECT of a specific ACTION in accomplishing its aim in relation to a specific OBJECT-ITEM.
    /// </summary>
	[EntId(10000237)]
    [EntName("ACTION-EFFECT-ITEM")]
    [EntTableName("ACT_EFFECT_ITEM")]
    [EntDepth(4)]
    public interface IActionEffectItem
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_effect_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EFFECT for a specific ACTION and to distinguish it from all other ACTION-EFFECTs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_effect_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-effect-index")]
		[AttrColumnName("act_effect_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionEffectIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rat
		///
		/// The numeric quotient value that represents the portion of a whole OBJECT-ITEM that is estimated in a specific ACTION-EFFECT-ITEM to have the result specified in ACTION-EFFECT. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column rat
        /// </value>
        [AttrIx(100003)]
		[AttrName("action-effect-item-ratio")]
		[AttrColumnName("rat")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double Ratio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-item-id")]
		[AttrColumnName("obj_item_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-EFFECT that represents the table ACT_EFFECT.
	///
	/// A perceived effectiveness of a specific ACTION against a specific battlespace object or its class.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionEffect", "C4Net.JC3IEDM.Definitions.ActionEffect.definition.xml")]
    public class ActionEffect : IEntity, IActionEffect
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionEffectExpression _ = new ActionEffectExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_effect_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-EFFECT for a specific ACTION and to distinguish it from all other ACTION-EFFECTs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_effect_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-EFFECT with respect to item or type. It serves as a discriminator that partitions ACTION-EFFECT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionEffectCategoryEnum ActionEffectCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_code
		///
		/// The specific value that represents the type of outcome of a specific ACTION that is being estimated or recorded.
        /// </summary>
        /// <value>
        /// Value of the column descr_code
        /// </value>
		public ActionEffectDescriptionEnum Description { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sev_code
		///
		/// The specific value that represents the degree of seriousness of a specific ACTION-EFFECT.
        /// </summary>
        /// <value>
        /// Value of the column sev_code
        /// </value>
		public ActionEffectSeverityEnum? Severity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}

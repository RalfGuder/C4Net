using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table SUBT_REL.
    /// </summary>
    [Serializable]
    [DefinitionName("SubtRel", "C4Net.Metamodel.Definitions.SubtRel.definition.xml")]
    public partial class SubtRel : ISubtRel
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly SubtRelExpression _ = new SubtRelExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column sup_ent_id
        /// </summary>
        /// <value>
        /// Value of the column sup_ent_id
        /// </value>
        public double SupEntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sub_ent_id
        /// </summary>
        /// <value>
        /// Value of the column sub_ent_id
        /// </value>
        public double SubEntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_ix
        /// </summary>
        /// <value>
        /// Value of the column rel_ix
        /// </value>
        public double RelIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_ix
        /// </summary>
        /// <value>
        /// Value of the column cat_ix
        /// </value>
        public double CatIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dom_id
        /// </summary>
        /// <value>
        /// Value of the column dom_id
        /// </value>
        public double DomId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dom_val_ix
        /// </summary>
        /// <value>
        /// Value of the column dom_val_ix
        /// </value>
        public double DomValIx { get; set; }
		
        #endregion
    }
}

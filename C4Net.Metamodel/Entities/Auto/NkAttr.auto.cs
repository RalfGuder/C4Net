using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table NK_ATTR.
    /// </summary>
    [Serializable]
    [DefinitionName("NkAttr", "C4Net.Metamodel.Definitions.NkAttr.definition.xml")]
    public partial class NkAttr : INkAttr
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly NkAttrExpression _ = new NkAttrExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ent_id
        /// </summary>
        /// <value>
        /// Value of the column ent_id
        /// </value>
        public double EntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column attr_ix
        /// </summary>
        /// <value>
        /// Value of the column attr_ix
        /// </value>
        public double AttrIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column opt_ind_code
        /// </summary>
        /// <value>
        /// Value of the column opt_ind_code
        /// </value>
        public string OptIndCode { get; set; }
		
        #endregion
    }
}

using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table BR_ENT_ATTR_COMP.
    /// </summary>
    [Serializable]
    [DefinitionName("BrEntAttrComp", "C4Net.Metamodel.Definitions.BrEntAttrComp.definition.xml")]
    public partial class BrEntAttrComp : IBrEntAttrComp
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly BrEntAttrCompExpression _ = new BrEntAttrCompExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column br_id
        /// </summary>
        /// <value>
        /// Value of the column br_id
        /// </value>
        public double BrId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column br_ent_ix
        /// </summary>
        /// <value>
        /// Value of the column br_ent_ix
        /// </value>
        public double BrEntIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column br_ent_attr_comp_ix
        /// </summary>
        /// <value>
        /// Value of the column br_ent_attr_comp_ix
        /// </value>
        public double BrEntAttrCompIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column null_ind_code
        /// </summary>
        /// <value>
        /// Value of the column null_ind_code
        /// </value>
        public string NullIndCode { get; set; }
		
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
		
        #endregion
    }
}

using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table CAT.
    /// </summary>
    [Serializable]
    [DefinitionName("Cat", "C4Net.Metamodel.Definitions.Cat.definition.xml")]
    public partial class Cat : ICat
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CatExpression _ = new CatExpression();

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
        /// Gets or sets the value of the column cat_ix
        /// </summary>
        /// <value>
        /// Value of the column cat_ix
        /// </value>
        public double CatIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column def_txt
        /// </summary>
        /// <value>
        /// Value of the column def_txt
        /// </value>
        public string DefTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column discr_ix
        /// </summary>
        /// <value>
        /// Value of the column discr_ix
        /// </value>
        public double DiscrIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column compl_ind_code
        /// </summary>
        /// <value>
        /// Value of the column compl_ind_code
        /// </value>
        public string ComplIndCode { get; set; }
		
        #endregion
    }
}

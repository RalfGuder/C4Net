using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table DOM_VAL.
    /// </summary>
    [Serializable]
    [DefinitionName("DomVal", "C4Net.Metamodel.Definitions.DomVal.definition.xml")]
    public partial class DomVal : IDomVal
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly DomValExpression _ = new DomValExpression();

        #endregion

        #region - Properties -
		
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
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
        public string DescrTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        public string NameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column def_txt
        /// </summary>
        /// <value>
        /// Value of the column def_txt
        /// </value>
        public string DefTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column type_code
        /// </summary>
        /// <value>
        /// Value of the column type_code
        /// </value>
        public string TypeCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stdn_lvl_code
        /// </summary>
        /// <value>
        /// Value of the column stdn_lvl_code
        /// </value>
        public string StdnLvlCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column src_txt
        /// </summary>
        /// <value>
        /// Value of the column src_txt
        /// </value>
        public string SrcTxt { get; set; }
		
        #endregion
    }
}

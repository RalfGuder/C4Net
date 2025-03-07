using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table BASE_ATTR.
    /// </summary>
    [Serializable]
    [DefinitionName("BaseAttr", "C4Net.Metamodel.Definitions.BaseAttr.definition.xml")]
    public partial class BaseAttr : IBaseAttr
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly BaseAttrExpression _ = new BaseAttrExpression();

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
        /// Gets or sets the value of the column def_txt
        /// </summary>
        /// <value>
        /// Value of the column def_txt
        /// </value>
        public string DefTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column data_type_code
        /// </summary>
        /// <value>
        /// Value of the column data_type_code
        /// </value>
        public string DataTypeCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column data_len_cnt
        /// </summary>
        /// <value>
        /// Value of the column data_len_cnt
        /// </value>
        public double DataLenCnt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column data_dec_cnt
        /// </summary>
        /// <value>
        /// Value of the column data_dec_cnt
        /// </value>
        public double DataDecCnt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dom_id
        /// </summary>
        /// <value>
        /// Value of the column dom_id
        /// </value>
        public double DomId { get; set; }
		
        #endregion
    }
}

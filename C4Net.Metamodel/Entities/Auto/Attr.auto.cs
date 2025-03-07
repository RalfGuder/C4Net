using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table ATTR.
    /// </summary>
    [Serializable]
    [DefinitionName("Attr", "C4Net.Metamodel.Definitions.Attr.definition.xml")]
    public partial class Attr : IAttr
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly AttrExpression _ = new AttrExpression();

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
        /// Gets or sets the value of the column name_txt
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        public string NameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column col_name_txt
        /// </summary>
        /// <value>
        /// Value of the column col_name_txt
        /// </value>
        public string ColNameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column attr_seqnr_ord
        /// </summary>
        /// <value>
        /// Value of the column attr_seqnr_ord
        /// </value>
        public double AttrSeqnrOrd { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pk_ind_code
        /// </summary>
        /// <value>
        /// Value of the column pk_ind_code
        /// </value>
        public string PkIndCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fk_ind_code
        /// </summary>
        /// <value>
        /// Value of the column fk_ind_code
        /// </value>
        public string FkIndCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stdn_lvl_code
        /// </summary>
        /// <value>
        /// Value of the column stdn_lvl_code
        /// </value>
        public string StdnLvlCode { get; set; }
		
        #endregion
    }
}

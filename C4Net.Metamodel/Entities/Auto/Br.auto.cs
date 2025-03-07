using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table BR.
    /// </summary>
    [Serializable]
    [DefinitionName("Br", "C4Net.Metamodel.Definitions.Br.definition.xml")]
    public partial class Br : IBr
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly BrExpression _ = new BrExpression();

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
        /// Gets or sets the value of the column cat_code
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        public string CatCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column section_xref_txt
        /// </summary>
        /// <value>
        /// Value of the column section_xref_txt
        /// </value>
        public string SectionXrefTxt { get; set; }
		
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
        /// Gets or sets the value of the column tab_xref_txt
        /// </summary>
        /// <value>
        /// Value of the column tab_xref_txt
        /// </value>
        public string TabXrefTxt { get; set; }
		
        #endregion
    }
}

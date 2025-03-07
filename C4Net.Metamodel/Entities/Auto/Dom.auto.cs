using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table DOM.
    /// </summary>
    [Serializable]
    [DefinitionName("Dom", "C4Net.Metamodel.Definitions.Dom.definition.xml")]
    public partial class Dom : IDom
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly DomExpression _ = new DomExpression();

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
        /// Gets or sets the value of the column class_name_txt
        /// </summary>
        /// <value>
        /// Value of the column class_name_txt
        /// </value>
        public string ClassNameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column restr_type_code
        /// </summary>
        /// <value>
        /// Value of the column restr_type_code
        /// </value>
        public string RestrTypeCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column meas_unit_descr_txt
        /// </summary>
        /// <value>
        /// Value of the column meas_unit_descr_txt
        /// </value>
        public string MeasUnitDescrTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pa_dom_id
        /// </summary>
        /// <value>
        /// Value of the column pa_dom_id
        /// </value>
        public double PaDomId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stdn_lvl_code
        /// </summary>
        /// <value>
        /// Value of the column stdn_lvl_code
        /// </value>
        public string StdnLvlCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mod_lvl_code
        /// </summary>
        /// <value>
        /// Value of the column mod_lvl_code
        /// </value>
        public string ModLvlCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column def_src_txt
        /// </summary>
        /// <value>
        /// Value of the column def_src_txt
        /// </value>
        public string DefSrcTxt { get; set; }
		
        #endregion
    }
}

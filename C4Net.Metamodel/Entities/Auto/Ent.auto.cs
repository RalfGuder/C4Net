using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table ENT.
    /// </summary>
    [Serializable]
    [DefinitionName("Ent", "C4Net.Metamodel.Definitions.Ent.definition.xml")]
    public partial class Ent : IEnt
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly EntExpression _ = new EntExpression();

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
        /// Gets or sets the value of the column name_txt
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        public string NameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column tab_name_txt
        /// </summary>
        /// <value>
        /// Value of the column tab_name_txt
        /// </value>
        public string TabNameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column def_txt
        /// </summary>
        /// <value>
        /// Value of the column def_txt
        /// </value>
        public string DefTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depen_code
        /// </summary>
        /// <value>
        /// Value of the column depen_code
        /// </value>
        public string DepenCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_cnt
        /// </summary>
        /// <value>
        /// Value of the column depth_cnt
        /// </value>
        public double DepthCnt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stg_type_code
        /// </summary>
        /// <value>
        /// Value of the column stg_type_code
        /// </value>
        public string StgTypeCode { get; set; }
		
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
		
        #endregion
    }
}

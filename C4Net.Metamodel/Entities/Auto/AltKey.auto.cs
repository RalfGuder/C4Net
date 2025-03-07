using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table ALT_KEY.
    /// </summary>
    [Serializable]
    [DefinitionName("AltKey", "C4Net.Metamodel.Definitions.AltKey.definition.xml")]
    public partial class AltKey : IAltKey
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly AltKeyExpression _ = new AltKeyExpression();

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
        /// Gets or sets the value of the column ak_ix
        /// </summary>
        /// <value>
        /// Value of the column ak_ix
        /// </value>
        public double AkIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ak_no_qty
        /// </summary>
        /// <value>
        /// Value of the column ak_no_qty
        /// </value>
        public double AkNoQty { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column uniq_ind_code
        /// </summary>
        /// <value>
        /// Value of the column uniq_ind_code
        /// </value>
        public string UniqIndCode { get; set; }
		
        #endregion
    }
}

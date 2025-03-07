using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table REL.
    /// </summary>
    [Serializable]
    [DefinitionName("Rel", "C4Net.Metamodel.Definitions.Rel.definition.xml")]
    public partial class Rel : IRel
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly RelExpression _ = new RelExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pa_ent_id
        /// </summary>
        /// <value>
        /// Value of the column pa_ent_id
        /// </value>
        public double PaEntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ch_ent_id
        /// </summary>
        /// <value>
        /// Value of the column ch_ent_id
        /// </value>
        public double ChEntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_ix
        /// </summary>
        /// <value>
        /// Value of the column rel_ix
        /// </value>
        public double RelIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column type_code
        /// </summary>
        /// <value>
        /// Value of the column type_code
        /// </value>
        public string TypeCode { get; set; }
		
        #endregion
    }
}

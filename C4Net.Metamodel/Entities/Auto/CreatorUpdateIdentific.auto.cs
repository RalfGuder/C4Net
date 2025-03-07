using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table CREATOR_UPDATE_IDENTIFIC.
    /// </summary>
    [Serializable]
    [DefinitionName("CreatorUpdateIdentific", "C4Net.Metamodel.Definitions.CreatorUpdateIdentific.definition.xml")]
    public partial class CreatorUpdateIdentific : ICreatorUpdateIdentific
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CreatorUpdateIdentificExpression _ = new CreatorUpdateIdentificExpression();

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
        /// Gets or sets the value of the column creator_attr_ix
        /// </summary>
        /// <value>
        /// Value of the column creator_attr_ix
        /// </value>
        public double CreatorAttrIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_attr_ix
        /// </summary>
        /// <value>
        /// Value of the column update_attr_ix
        /// </value>
        public double UpdateAttrIx { get; set; }
		
        #endregion
    }
}

namespace C4Net.Metamodel.Interfaces
{
    /// <summary>
    /// Interface for the model class for the table PK_ATTR
    /// </summary>
    public interface IPkAttr
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ent_id
        /// </summary>
        /// <value>
        /// Value of the column ent_id
        /// </value>
        double EntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column attr_ix
        /// </summary>
        /// <value>
        /// Value of the column attr_ix
        /// </value>
        double AttrIx { get; set; }
		
        #endregion
    }
}

namespace C4Net.Metamodel.Interfaces
{
    /// <summary>
    /// Interface for the model class for the table CREATOR_UPDATE_IDENTIFIC
    /// </summary>
    public interface ICreatorUpdateIdentific
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
        /// Gets or sets the value of the column creator_attr_ix
        /// </summary>
        /// <value>
        /// Value of the column creator_attr_ix
        /// </value>
        double CreatorAttrIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_attr_ix
        /// </summary>
        /// <value>
        /// Value of the column update_attr_ix
        /// </value>
        double UpdateAttrIx { get; set; }
		
        #endregion
    }
}

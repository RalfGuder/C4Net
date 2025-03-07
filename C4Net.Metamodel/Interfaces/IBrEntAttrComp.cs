namespace C4Net.Metamodel.Interfaces
{
    /// <summary>
    /// Interface for the model class for the table BR_ENT_ATTR_COMP
    /// </summary>
    public interface IBrEntAttrComp
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column br_id
        /// </summary>
        /// <value>
        /// Value of the column br_id
        /// </value>
        double BrId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column br_ent_ix
        /// </summary>
        /// <value>
        /// Value of the column br_ent_ix
        /// </value>
        double BrEntIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column br_ent_attr_comp_ix
        /// </summary>
        /// <value>
        /// Value of the column br_ent_attr_comp_ix
        /// </value>
        double BrEntAttrCompIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column null_ind_code
        /// </summary>
        /// <value>
        /// Value of the column null_ind_code
        /// </value>
        string NullIndCode { get; set; }
		
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

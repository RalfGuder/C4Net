namespace C4Net.Metamodel.Interfaces
{
    /// <summary>
    /// Interface for the model class for the table BR_ENT
    /// </summary>
    public interface IBrEnt
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
        /// Gets or sets the value of the column ent_of_interest_id
        /// </summary>
        /// <value>
        /// Value of the column ent_of_interest_id
        /// </value>
        double EntOfInterestId { get; set; }
		
        #endregion
    }
}

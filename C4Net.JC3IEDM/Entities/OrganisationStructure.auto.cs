using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-STRUCTURE that represents the table ORG_STRUCT.
	///
	/// The hierarchical configuration of a specific root ORGANISATION where the configuration is specified by reference to a set of associations between instances of OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationStructure", "C4Net.JC3IEDM.Definitions.OrganisationStructure.definition.xml")]
    public class OrganisationStructure : IEntity, IOrganisationStructure
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationStructureExpression _ = new OrganisationStructureExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_root_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_root_org_id
        /// </value>
		public decimal RootOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column org_struct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ORGANISATION-STRUCTURE for a specific ORGANISATION and to distinguish it from all other ORGANISATION-STRUCTUREs for that ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column org_struct_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific ORGANISATION-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of the ORGANISATION-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public OrganisationStructureCategoryEnum OrganisationStructureCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}

using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ORGANISATION-MATERIEL-TYPE-ASSOCIATION that represents the table ORG_MAT_TYPE_ASSOC.
	///
	/// A relationship of an ORGANISATION as a subject with a MATERIEL-TYPE as an object.
    /// </summary>
    [Serializable]
    [DefinitionName("OrganisationMaterielTypeAssociation", "C4Net.JC3IEDM.Definitions.OrganisationMaterielTypeAssociation.definition.xml")]
    public class OrganisationMaterielTypeAssociation : IEntity, IOrganisationMaterielTypeAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly OrganisationMaterielTypeAssociationExpression _ = new OrganisationMaterielTypeAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column org_id
        /// </value>
		public decimal OrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column mat_type_id
        /// </value>
		public decimal MaterielTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_type_code
		///
		/// The specific value that represents the class of ORGANISATION-MATERIEL-TYPE-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_type_code
        /// </value>
		public OrganisationMaterielTypeAssociationReportableTypeEnum ReportableType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_type_txt
		///
		/// The character string assigned to represent the Reportable type code for a specific MATERIEL-TYPE, as assigned by a specific ORGANISATION.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_type_txt
        /// </value>
		public string ReportableTypeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_type_dttm
		///
		/// The character string representing a point in time that designates when the Reportable type code referenced by the ORGANISATION-MATERIEL-TYPE-ASSOCIATION is assigned.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_type_dttm
        /// </value>
		public string ReportableTypeDatetime { get; set; }
		
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

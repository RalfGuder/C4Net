using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity UNIT-TYPE that represents the table UNIT_TYPE.
	///
	/// A MILITARY-ORGANISATION-TYPE whose structure is prescribed by competent authority.
    /// </summary>
    [Serializable]
    [DefinitionName("UnitType", "C4Net.JC3IEDM.Definitions.UnitType.definition.xml")]
    public class UnitType : MilitaryOrganisationType, IUnitType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly UnitTypeExpression _ = new UnitTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public UnitTypeCategoryEnum UnitTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arm_cat_code
		///
		/// The specific value that represents the designation of a military branch for a particular UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column arm_cat_code
        /// </value>
		public UnitTypeArmCategoryEnum ArmCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arm_spclsn_code
		///
		/// The specific value that qualifies the functional specialisation of a particular UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column arm_spclsn_code
        /// </value>
		public UnitTypeArmSpecialisationEnum? ArmSpecialisation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column suppl_spclsn_code
		///
		/// The specific value that supplements the designation of a particular UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column suppl_spclsn_code
        /// </value>
		public UnitTypeSupplementarySpecialisationEnum? SupplementarySpecialisation { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gen_mob_code
		///
		/// The specific value that represents the general mobility of a unit, seen as a whole.
        /// </summary>
        /// <value>
        /// Value of the column gen_mob_code
        /// </value>
		public UnitTypeGeneralMobilityEnum? GeneralMobility { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qual_code
		///
		/// The specific value that conveys additional information on the specified UNIT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column qual_code
        /// </value>
		public UnitTypeQualifierEnum? Qualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column size_code
		///
		/// The specific value that represents the relative size of the commonly accepted configuration of military formations.
        /// </summary>
        /// <value>
        /// Value of the column size_code
        /// </value>
		public EchelonSizeEnum Size { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column principal_eqpt_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column principal_eqpt_type_id
        /// </value>
		public decimal? PrincipalEquipmentTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column supported_mil_org_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column supported_mil_org_type_id
        /// </value>
		public decimal? SupportedMilitaryOrganisationTypeId { get; set; }
		
        #endregion
    }
}

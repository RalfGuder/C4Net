using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-TYPE-ESTABLISHMENT that represents the table OBJ_TYPE_ESTAB.
	///
	/// The authorisation or other form of specification that associates with the established OBJECT-TYPE numbers of specific OBJECT-TYPEs under specified conditions.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectTypeEstablishment", "C4Net.JC3IEDM.Definitions.ObjectTypeEstablishment.definition.xml")]
    public class ObjectTypeEstablishment : IEntity, IObjectTypeEstablishment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectTypeEstablishmentExpression _ = new ObjectTypeEstablishmentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column estabd_obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column estabd_obj_type_id
        /// </value>
		public decimal EstablishedObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_estab_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column effctv_dttm
		///
		/// The character string representing a point in time that designates the beginning date of the period of effectiveness of a specific OBJECT-TYPE-ESTABLISHMENT.
        /// </summary>
        /// <value>
        /// Value of the column effctv_dttm
        /// </value>
		public string EffectiveDatetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-TYPE-ESTABLISHMENT when the established and detail OBJECT-TYPEs are instances of MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ObjectTypeEstablishmentCategoryEnum? ObjectTypeEstablishmentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column environ_cond_code
		///
		/// The specific value that represents the environmental conditions for which a specific OBJECT-TYPE-ESTABLISHMENT is authorised.
        /// </summary>
        /// <value>
        /// Value of the column environ_cond_code
        /// </value>
		public ObjectTypeEstablishmentEnvironmentConditionEnum? EnvironmentCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_mode_code
		///
		/// The specific value that represents the operational mode for which a specific OBJECT-TYPE-ESTABLISHMENT is authorised.
        /// </summary>
        /// <value>
        /// Value of the column operat_mode_code
        /// </value>
		public ObjectTypeEstablishmentOperationalModeEnum? OperationalMode { get; set; }
		
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

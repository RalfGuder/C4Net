using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAIL that represents the table OBJ_TYPE_ESTAB_OBJT_DET.
	///
	/// The number of a specific OBJECT-TYPE that is authorised by a specific OBJECT-TYPE-ESTABLISHMENT.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectTypeEstablishmentObjectTypeDetail", "C4Net.JC3IEDM.Definitions.ObjectTypeEstablishmentObjectTypeDetail.definition.xml")]
    public class ObjectTypeEstablishmentObjectTypeDetail : IEntity, IObjectTypeEstablishmentObjectTypeDetail
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectTypeEstablishmentObjectTypeDetailExpression _ = new ObjectTypeEstablishmentObjectTypeDetailExpression();

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
		public decimal ObjectTypeEstablishmentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_estab_objt_det_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAIL for a specific "established" OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAILs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_estab_objt_det_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column major_part_ind_code
		///
		/// The specific value that denotes whether a detail is a ‘major part’ when the established and detail OBJECT-TYPEs are instances of MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column major_part_ind_code
        /// </value>
		public ObjectTypeEstablishmentObjectTypeDetailMajorPartIndicatorEnum? MajorPartIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cnt
		///
		/// The integer value representing the count of the numbers of a specific OBJECT-TYPE authorised to be part of a specific OBJECT-TYPE-ESTABLISHMENT-OBJECT-TYPE-DETAIL.
        /// </summary>
        /// <value>
        /// Value of the column cnt
        /// </value>
		public int Count { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column det_obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column det_obj_type_id
        /// </value>
		public decimal ObjectTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column det_obj_type_estab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE-ESTABLISHMENT for a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPE-ESTABLISHMENTs for that OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column det_obj_type_estab_ix
        /// </value>
		public decimal? ObjectTypeEstablishmentDetailObjectTypeEstablishmentIndex { get; set; }
		
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

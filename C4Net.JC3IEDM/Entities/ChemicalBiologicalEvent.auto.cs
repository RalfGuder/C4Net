using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CHEMICAL-BIOLOGICAL-EVENT that represents the table CHM_BIO_EVENT.
	///
	/// A CBRN-EVENT involving chemical and/or biological materiel.
    /// </summary>
    [Serializable]
    [DefinitionName("ChemicalBiologicalEvent", "C4Net.JC3IEDM.Definitions.ChemicalBiologicalEvent.definition.xml")]
    public class ChemicalBiologicalEvent : CbrnEvent, IChemicalBiologicalEvent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ChemicalBiologicalEventExpression _ = new ChemicalBiologicalEventExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CHEMICAL-BIOLOGICAL-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ChemicalBiologicalEventCategoryEnum ChemicalBiologicalEventCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_cat_code
		///
		/// The specific value that represents the class of release in a CHEMICAL-BIOLOGICAL-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column release_cat_code
        /// </value>
		public ReleaseCategoryEnum? ReleaseCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column spill_size_code
		///
		/// The specific value that represents the mass or the volume of a materiel spilled in a CHEMICAL-BIOLOGICAL-EVENT that is a release other than attack (ROTA).
        /// </summary>
        /// <value>
        /// Value of the column spill_size_code
        /// </value>
		public ChemicalBiologicalEventSpillSizeEnum? SpillSize { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_height_dim
		///
		/// The one-dimensional linear distance representing the height above ground level at which the chemical or biological agent is released. Release height is frequently referred to as burst height.
        /// </summary>
        /// <value>
        /// Value of the column release_height_dim
        /// </value>
		public double? ReleaseHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vol_cncntr_qty
		///
		/// The numeric value that represents the level of chemical or biological contamination per unit volume in air or water. The unit of measure is milligrams per cubic metre (MGM3).
        /// </summary>
        /// <value>
        /// Value of the column vol_cncntr_qty
        /// </value>
		public double? VolumeConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_dep_qty
		///
		/// The numeric value that represents the level of chemical or biological contamination per unit area on a surface. The unit of measure is milligrams per square metre (MGM2).
        /// </summary>
        /// <value>
        /// Value of the column surf_dep_qty
        /// </value>
		public double? SurfaceDepositionQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column atmspc_prtcl_cncntr_qty
		///
		/// The numeric value that represents the level of chemical or biological atmospheric contamination The unit of measure is Agent Containing Particles Per Litre (ACPL).
        /// </summary>
        /// <value>
        /// Value of the column atmspc_prtcl_cncntr_qty
        /// </value>
		public double? AtmosphericParticleConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mass_frac_cncntr_qty
		///
		/// The numeric value that represents the number of 'parts' by weight of a biological or chemical substance per million parts of water. The unit of measure is in Parts per Million (PPM).
        /// </summary>
        /// <value>
        /// Value of the column mass_frac_cncntr_qty
        /// </value>
		public double? MassFractionConcentrationQuantity { get; set; }
		
        #endregion
    }
}

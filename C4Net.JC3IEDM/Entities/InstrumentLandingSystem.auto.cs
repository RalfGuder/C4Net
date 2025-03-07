using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity INSTRUMENT-LANDING-SYSTEM that represents the table INST_LNDG_SYS.
	///
	/// A MATERIEL that provides aircraft with horizontal and vertical guidance just before landing and during landing, and at certain fixed points, indicates the distance to the reference point of landing.
    /// </summary>
    [Serializable]
    [DefinitionName("InstrumentLandingSystem", "C4Net.JC3IEDM.Definitions.InstrumentLandingSystem.definition.xml")]
    public class InstrumentLandingSystem : Materiel, IInstrumentLandingSystem
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly InstrumentLandingSystemExpression _ = new InstrumentLandingSystemExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column beam_width_dim
		///
		/// The one-dimensional linear distance representing the extreme horizontal distance measured from side to side and perpendicular to the central axis of the main beam coil of a specific localiser.
        /// </summary>
        /// <value>
        /// Value of the column beam_width_dim
        /// </value>
		public double? BeamWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column glide_path_angle
		///
		/// The rotational measurement from the horizontal plane to the glide path, where the positive angle is vertically upward.
        /// </summary>
        /// <value>
        /// Value of the column glide_path_angle
        /// </value>
		public double? GlidePathAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column magn_varn_angle
		///
		/// The rotational measurement of the angular difference between true north and magnetic north.
        /// </summary>
        /// <value>
        /// Value of the column magn_varn_angle
        /// </value>
		public double? MagneticVariationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column slaved_varn_angle
		///
		/// The rotational measurement of the fixed value of magnetic variation applied to true direction to obtain the magnetic values for radials, courses and headings.
        /// </summary>
        /// <value>
        /// Value of the column slaved_varn_angle
        /// </value>
		public double? SlavedVariationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_angle
		///
		/// The rotational measurement clockwise from true North to the localiser used for final approach guidance.
        /// </summary>
        /// <value>
        /// Value of the column brng_angle
        /// </value>
		public double? BearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column thrsh_crsn_height_dim
		///
		/// The one-dimensional linear distance representing the height above the landing threshold on a normal glide path.
        /// </summary>
        /// <value>
        /// Value of the column thrsh_crsn_height_dim
        /// </value>
		public double? ThresholdCrossingHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column localizer_dist_dim
		///
		/// The one-dimensional linear distance representing the extreme horizontal distance measured perpendicular from the end of the runway to the localiser antenna position.
        /// </summary>
        /// <value>
        /// Value of the column localizer_dist_dim
        /// </value>
		public double? LocaliserDistanceDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dist_mesn_eqpt_dist_dim
		///
		/// The one-dimensional linear distance representing the distance between the distance measuring equipment and the associated landing threshold.
        /// </summary>
        /// <value>
        /// Value of the column dist_mesn_eqpt_dist_dim
        /// </value>
		public double? DistanceMeasuringEquipmentDistanceDimension { get; set; }
		
        #endregion
    }
}

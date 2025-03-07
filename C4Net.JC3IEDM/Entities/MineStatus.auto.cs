using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINE-STATUS that represents the table MINE_STAT.
	///
	/// A MATERIEL-STATUS that is a record of condition of a specific mine.
    /// </summary>
    [Serializable]
    [DefinitionName("MineStatus", "C4Net.JC3IEDM.Definitions.MineStatus.definition.xml")]
    public class MineStatus : MaterielStatus, IMineStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MineStatusExpression _ = new MineStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mine_buried_rat
		///
		/// The numeric quotient value that represents the percentage of the maritime mine that is buried. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column mine_buried_rat
        /// </value>
		public double? MineBuriedRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the status of a mine.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public MineStatusEnum? MineStatusCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column air_drop_effect_code
		///
		/// The specific value that represent the behaviour of air-delivered mine after weapon release.
        /// </summary>
        /// <value>
        /// Value of the column air_drop_effect_code
        /// </value>
		public MineStatusAirDropEffectEnum? AirDropEffect { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mrt_mine_qual_code
		///
		/// The specific value that represents the qualification status of a specific maritime mine.
        /// </summary>
        /// <value>
        /// Value of the column mrt_mine_qual_code
        /// </value>
		public MineStatusMaritimeMineQualifierEnum? MaritimeMineQualifier { get; set; }
		
        #endregion
    }
}

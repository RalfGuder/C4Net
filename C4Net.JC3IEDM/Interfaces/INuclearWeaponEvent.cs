using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity NuclearWeaponEvent that represents the table NUC_WEAPON_EVENT
	/// 
	/// A NUCLEAR-EVENT that involves the detonation of a nuclear device.
    /// </summary>
	[EntId(10000315)]
    [EntName("NUCLEAR-WEAPON-EVENT")]
    [EntTableName("NUC_WEAPON_EVENT")]
    [EntDepth(5)]
    public interface INuclearWeaponEvent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column nuc_weapon_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column nuc_weapon_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("nuclear-weapon-event-id")]
		[AttrColumnName("nuc_weapon_event_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column flash_to_bang_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds from light being first observed until the sound of the nuclear detonation is heard in a specific NUCLEAR-WEAPON-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column flash_to_bang_dur
        /// </value>
        [AttrIx(100002)]
		[AttrName("nuclear-weapon-event-flash-to-bang-duration")]
		[AttrColumnName("flash_to_bang_dur")]
        [AttrSeqnr(2)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? FlashToBangDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crater_prsnc_code
		///
		/// The specific value that represents the presence of a crater.
        /// </summary>
        /// <value>
        /// Value of the column crater_prsnc_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("nuclear-weapon-event-crater-presence-code")]
		[AttrColumnName("crater_prsnc_code")]
        [AttrSeqnr(3)]
        [DomId(100004273)]
        [DataLength(6)]
        [DataDecimals(0)]
        NuclearWeaponEventCraterPresenceEnum? CraterPresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column crater_width_dim
		///
		/// The one-dimensional linear distance representing the width of a crater caused by the detonation of a nuclear device.
        /// </summary>
        /// <value>
        /// Value of the column crater_width_dim
        /// </value>
        [AttrIx(100004)]
		[AttrName("nuclear-weapon-event-crater-width-dimension")]
		[AttrColumnName("crater_width_dim")]
        [AttrSeqnr(4)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? CraterWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column yield_group_code
		///
		/// The specific value that represents the energy released in the detonation of a nuclear weapon, measured in terms of the kilotons or megatons of trinitrotoluene required to produce the same energy release.
        /// </summary>
        /// <value>
        /// Value of the column yield_group_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("nuclear-weapon-event-yield-group-code")]
		[AttrColumnName("yield_group_code")]
        [AttrSeqnr(5)]
        [DomId(100004375)]
        [DataLength(6)]
        [DataDecimals(0)]
        NuclearYieldGroupEnum? YieldGroup { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column yield_qty
		///
		/// The numeric value that represents the energy release or predicted to be released by the detonation of a nuclear weapon. The unit of measure is kiloton.
        /// </summary>
        /// <value>
        /// Value of the column yield_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("nuclear-weapon-event-yield-quantity")]
		[AttrColumnName("yield_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? YieldQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}

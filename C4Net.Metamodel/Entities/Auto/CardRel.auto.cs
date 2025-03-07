using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table CARD_REL.
    /// </summary>
    [Serializable]
    [DefinitionName("CardRel", "C4Net.Metamodel.Definitions.CardRel.definition.xml")]
    public partial class CardRel : ICardRel
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly CardRelExpression _ = new CardRelExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pa_ent_id
        /// </summary>
        /// <value>
        /// Value of the column pa_ent_id
        /// </value>
        public double PaEntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ch_ent_id
        /// </summary>
        /// <value>
        /// Value of the column ch_ent_id
        /// </value>
        public double ChEntId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_ix
        /// </summary>
        /// <value>
        /// Value of the column rel_ix
        /// </value>
        public double RelIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column verb_name_txt
        /// </summary>
        /// <value>
        /// Value of the column verb_name_txt
        /// </value>
        public string VerbNameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column inv_verb_name_txt
        /// </summary>
        /// <value>
        /// Value of the column inv_verb_name_txt
        /// </value>
        public string InvVerbNameTxt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ident_ind_code
        /// </summary>
        /// <value>
        /// Value of the column ident_ind_code
        /// </value>
        public string IdentIndCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pa_card_code
        /// </summary>
        /// <value>
        /// Value of the column pa_card_code
        /// </value>
        public string PaCardCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ch_card_code
        /// </summary>
        /// <value>
        /// Value of the column ch_card_code
        /// </value>
        public string ChCardCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ch_mnm_card_cnt
        /// </summary>
        /// <value>
        /// Value of the column ch_mnm_card_cnt
        /// </value>
        public double ChMnmCardCnt { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ch_max_card_cnt
        /// </summary>
        /// <value>
        /// Value of the column ch_max_card_cnt
        /// </value>
        public double ChMaxCardCnt { get; set; }
		
        #endregion
    }
}

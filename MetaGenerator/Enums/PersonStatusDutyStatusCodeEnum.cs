using C4Net.Core.Attributes;
using C4Net.Data.Attributes;

namespace MetaGenerator.Enums
{
    /// <summary>
    /// The specific value that represents the availability of a specific PERSON for duty at 
    /// a military or civilian post of employment.
    /// </summary>
    [DomId(100000102)]
    public enum PersonStatusDutyStatusCodeEnum
    {

        /// <summary>
        /// Not present at the place of duty for an as yet unspecified reason and has not been posted as either deceased or missing.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABS")]
        Absent,
        AtDuty,
        Arrested,
        Deceased,
        Hospitalised,
        Hostage,
        Missing,
        NotKnown,
        OnLeave,
        Prisoner,
        Deserted,
        AssumedKilledInAction
    }
}

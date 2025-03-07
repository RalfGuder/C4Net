using System;
using System.Runtime.Serialization;

namespace C4Net.Service.Base
{
    [DataContract(Name="DtoItem", Namespace="")]
    public class DtoItem<T> where T : class
    {
        #region - Properties -

        [DataMember]
        public Uri ItemLink { get; set; }

        [DataMember]
        public T Item { get; set; }

        #endregion
    }

}

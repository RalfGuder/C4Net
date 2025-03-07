using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace C4Net.Service.Base
{
    [DataContract(Name = "DtoItemList", Namespace = "")]
    public class DtoItemList<T> where T : class
    {
        #region - Properties -

        [DataMember]
        public List<DtoItem<T>> Items { get; private set; }

        [DataMember]
        public Uri NextPage { get; private set; }

        [DataMember]
        public Uri PreviousPage { get; private set; }

        #endregion

        #region - Constructors -

        public DtoItemList(List<DtoItem<T>> items, Uri nextPage, Uri previousPage)
        {
            this.Items = items;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
        }

        #endregion
    }
}

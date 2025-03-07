
using System.Collections.Generic;
namespace C4Net.Metamodel.Entities
{
    public partial class Dom
    {
        private List<DomVal> domVals = new List<DomVal>();

        public List<DomVal> DomVals
        {
            get { return this.domVals; }
        }
    }
}

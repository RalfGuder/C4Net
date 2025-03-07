using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4Net.Metamodel.Entities
{
    public partial class Ent
    {
        private List<Attr> attributes = new List<Attr>();

        public List<Attr> Attributes
        {
            get { return this.attributes; }
        }
        //private List<DomVal> domVals = new List<DomVal>();

        //public List<DomVal> DomVals
        //{
        //    get { return this.domVals; }
        //}

    }
}

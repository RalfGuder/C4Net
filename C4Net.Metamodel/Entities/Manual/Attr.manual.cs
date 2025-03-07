using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4Net.Metamodel.Entities
{
    public partial class Attr
    {
        private BaseAttr baseAttr = null;

        private FkAttr fkAttr = null;

        private NkAttr nkAttr = null;

        public BaseAttr BaseAttr
        {
            get { return this.baseAttr; }
            set { this.baseAttr = value; }
        }

        public FkAttr FkAttr
        {
            get { return this.fkAttr; }
            set { this.fkAttr = value; }
        }

        public NkAttr NkAttr
        {
            get { return this.nkAttr; }
            set { this.nkAttr = value; }
        }

    }
}

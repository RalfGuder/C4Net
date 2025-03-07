using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C4Net.Core.Attributes;

namespace CoreBed.Attributes
{
    public class TestAttribute
    {
        [StringValue("It's a name")]
        public string Name { get; set; }

        [StringValue("A")]
        public int Age { get; set; }
    }
}

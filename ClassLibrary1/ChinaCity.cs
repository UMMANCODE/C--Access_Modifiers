using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class ChinaCity : City {
        public override int Population {
            set {
                if (value >= 100000) _population = value;
            }
        }
    }
}

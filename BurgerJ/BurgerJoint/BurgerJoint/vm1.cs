using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint
{
     public class vm1
    {
        public string ItemName { get; set; }
        public string Category { get; set; }
        public byte[] ItemPhoto { get; set; }
        public int Quantity { get; set; }

        public DateTime orderDate { get; set; }
        public int UnitPrice { get; set; }
        public int SubTotal { get; set; }
    }
}

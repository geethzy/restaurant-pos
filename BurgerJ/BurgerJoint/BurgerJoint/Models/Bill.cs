using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime PayDate { get; set; }
        public DateTime PayTime { get; set; }
    }
}

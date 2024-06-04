using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string AdminPwd { get; set; }
        public Item Item { get; set; }
    }
}

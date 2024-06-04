using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        [Required]
        public string Category { get; set; }
        [MinLength(5)]
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public string Imagepath { get; set; }
        public byte[] ItemPhoto { get; set; }
    }
}

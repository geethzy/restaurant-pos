using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint
{
    public static class Global
    {
        public static List<int> sub = new List<int>();
        public static int total;
        public static int Quantity;
        public static string itemName;
        public static int itemprice;
        public static List<string> ListQuantity = new List<string>();
        public static List<string> ListItem = new List<string>();
        public static List<string> Listprice = new List<string>();
        public static List<string> ListSub = new List<string>();
        public static string date;

        public static int Itemprice { get; internal set; }
    }
}


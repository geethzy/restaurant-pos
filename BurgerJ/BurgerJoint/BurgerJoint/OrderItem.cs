using BurgerJoint.Database;
using BurgerJoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerJoint
{
    public class OrderItem
    {
        DatabaseRepository db = new DatabaseRepository();
        public OrderItem()
        {
            db = new DatabaseRepository();
        }
        public List<vm1> getOrderItemdetails()
        {
            try
            {
                var newTable = (from a in db.Orders
                                join b in db.Items on a.ItemName equals b.ItemName
                                select new vm1
                                {
                                    ItemName = a.ItemName,
                                    Quantity = a.Quantity,
                                    Category = b.Category,
                                    ItemPhoto = b.ItemPhoto,
                                    UnitPrice = a.UnitPrice,
                                    orderDate = a.orderDate,
                                    SubTotal = a.UnitPrice*a.Quantity
    }).ToList();
                return newTable;
            }
            catch (Exception)
            {
                return new List<vm1>();
            }
        }
        public List<Item> getAllItem()
        {
            return db.Items.ToList();
        }
        public List<Order> getAllOrder()
        {
            return db.Orders.ToList();
        }
    }
}

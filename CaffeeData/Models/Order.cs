using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int BillNumber { get; set; }
        public Order(int billNumber)
        {
            BillNumber = billNumber;

            List<OrderItem> orderItems = new List<OrderItem>();
        }
        public Order()
        {

        }

    }
}

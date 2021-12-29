using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;

namespace CaffeBusiness
{
    public class OrderBsiness
    {
        //instance of OrderRepository that allows us to access methods of data layer
        OrderRepository orderRepository = new OrderRepository();    

        //method that calls GetAllOrder from OrderRepository class and returns list of all orders
        List<Order> getAllOrders()
        {
            List<Order> orders = orderRepository.GetAllOrders();
            return orders;
        }
        //method that pases order object to InsertObject method on dataLayer
        bool insertOrder(Order o)
        {
            return orderRepository.InsertOrder(o)!=0;
        }
    }
}

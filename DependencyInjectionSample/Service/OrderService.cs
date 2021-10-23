using DependencyInjectionSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Service
{
    public class OrderService:IOrderService
    {
        List<Order> orders = new List<Order>
        {
            new Order{ Id=1, Name="order1", Price=12.5},
            new Order{ Id=2, Name="order2", Price=54},
            new Order{ Id=3, Name="order3", Price=449.9},
            new Order{ Id=4, Name="order4", Price=265.5},
            new Order{ Id=5, Name="order5", Price=119.9}

        };

        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}

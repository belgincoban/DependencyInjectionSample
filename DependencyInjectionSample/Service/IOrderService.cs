using DependencyInjectionSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Service
{
    public interface IOrderService
    {
        public List<Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}

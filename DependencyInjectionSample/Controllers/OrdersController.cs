using DependencyInjectionSample.Model;
using DependencyInjectionSample.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService orderService;
        private IMessageService messageService;
        private ICreditCardService creditCardService;
        private IDbService dbService;

        public OrdersController(IOrderService orderService, IMessageService messageService, ICreditCardService creditCardService, IDbService dbService)
        {
            this.orderService = orderService;
            this.messageService = messageService;
            this.creditCardService = creditCardService;
            this.dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var order = orderService.GetOrders();
            return Ok(order);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = orderService.GetOrders().FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                if (ModelState.IsValid)
                {
                    return Ok(order);
                }
                return BadRequest(ModelState);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] Order order)
        {
            if (ModelState.IsValid)
            {
                var orders = orderService.GetOrders();
                orders.Add(order);
                return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, null);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("send/")]
        public IActionResult SendOrder()
        {
            //SmsSenderService.SendMessage();
            dbService.GetData();
            //CreditCardService.CreditCardinfo();
            return Ok();
        }
    }
}

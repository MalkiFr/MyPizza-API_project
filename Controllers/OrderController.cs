using Microsoft.AspNetCore.Mvc;
using My_pizza.Models;
using My_pizza.Interface;

namespace My_pizza.controllers;

    [ApiController]
    [Route("[controller]/[action]")]

    public class OrderController: ControllerBase
    {
        private readonly Iorder _OrderService;
        public OrderController(Iorder OrderService)
        {
            _OrderService = OrderService;
            Console.WriteLine(_OrderService.CreateDate);
        }


        [HttpPost("CustomerId/{CustomerId}/TotalAmount/{TotalAmount}/Items/{Items}")]

        public List<Order> Post(string customerId,decimal totalAmount,List<Pizza> items)
        {
            Order o=new Order() { CustomerId= customerId, TotalAmount= totalAmount, Items= items } ;
            return _OrderService.Add(o);
        }



//(:סתם כי רציתי לבדוק איך זה עובד.
        [HttpGet]
        [Route("mmm")]
        public String Getstring()
          {
             return "hi,good night";
          }


    }


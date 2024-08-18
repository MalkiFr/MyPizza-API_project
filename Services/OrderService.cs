using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Interface;
using My_pizza.Models;

namespace My_pizza.Services;

  public class OrderService :Iorder{
    
     public DateTime CreateDate {get; set;}
     private List<Order> orders {get; set;}

//empty constructor
     public OrderService()
      {
        orders=new List<Order>();
        CreateDate=DateTime.Now;
      }
     
     public List<Order> Add(Order o)
      {
         orders.Add(o);
         return orders;
      }

  }


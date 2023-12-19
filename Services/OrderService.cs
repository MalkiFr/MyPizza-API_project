using My_pizza.Interface;
using My_pizza.models;

namespace My_pizza.Services{

  public class OrderService: Iorder{
    
     public DateTime CreateDate {get; set;}
     private List<Order> orders=new List<Order>();
     
     public list<Order> add(Order o)
      {
         DateTime date=new DateTime();
         date=DateTime.now;
         o.Date=date;
         orders.Add(o);
         return orders;
      }

  }
}

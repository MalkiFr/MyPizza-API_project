using My_pizza.models;

namespace My_pizza.interface{

 public interface Iorder{
     public DateTime CreateDate {get; set;}
     public List<Order> add(Order o);
 }


}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace My_pizza.Interface
 public interface Ipizza{
    public DateTime CreateDate{ get; set;}

    List<Pizza> GetAll();
    Pizza? GetId(int id);
    void Add(Pizza pizza);
    void Delete(int id);
    void Update(Pizza pizza);

 }
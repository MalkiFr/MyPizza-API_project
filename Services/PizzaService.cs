using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Interface;
using My_pizza.Models;

namespace My_pizza.Services;

public class PizzaService :Ipizza{
    
    public DateTime CreateDate {get; set;}
    List<Pizza> Pizzot { get; set;}
    static int nextId = 3;


    public PizzaService()
    {
        Pizzot = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic", IsGluten = true, Price=45 },
            new Pizza { Id = 2, Name = "Italiano", IsGluten = true, Price=70 },
            new Pizza { Id = 3, Name = "pizza free", IsGluten = false, Price=55 }
        };
        CreateDate=DateTime.Now;
        
        
    }

//מחזירה את מערך הפיצות 
    public List<Pizza> GetAll(){
          return Pizzot;
    }

//(id)מחזירה פיצה מתוך המערך לפי ערך מזהה
    public Pizza? GetId(int id){
         foreach(var p in Pizzot){
            if(p.Id==id)
                return p;
         }
        return null; 
    }

//הוספת פיצה למערך
    public void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzot.Add(pizza);
    }

//מחיקת פיצה מהמערך
    public void Delete(int id)
    {
        var pizza = GetId(id);
        if(pizza is null)
            return;

        Pizzot.Remove(pizza);
    }

//עדכון
    public ActionResult<Pizza> Update(Pizza pizza)
    {
        var index = Pizzot.FindIndex(p => p.Id == pizza.Id);
        // if(index == -1)
        //     return null;

        Pizzot[index] = pizza;
        return pizza;
    }
    ActionResult<Pizza?> Ipizza.Update(Pizza pizza){
            throw new NotImplementedException();
        }
}

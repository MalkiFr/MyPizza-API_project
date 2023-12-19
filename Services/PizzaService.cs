using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_pizza.Interface;

namespace My_pizza.Services;

public static class PizzaService :Ipizza{

    static List<Pizza> Pizzot { get; }
    static int nextId = 3;

    static PizzaService()
    {
        Pizzot = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Italiano", Gluten = true },
            new Pizza { Id = 2, Name = "pizza free", Gluten = false }
        };
    }

//מחזירה את מערך הפיצות 
    public static List<Pizza> GetAll(){
          return Pizzot;
    }

//(id)מחזירה פיצה מתוך המערך לפי ערך מזהה
    public static Pizza? GetId(int id){
         foreach(var p in Pizzot){
            if(p.Id=id)
                return p;
         }
        return null; 
    }

//הוספת פיצה למערך
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzot.Add(pizza);
    }

//מחיקת פיצה מהמערך
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Pizzot.Remove(pizza);
    }


    public static void Update(Pizza pizza)
    {
        var index = Pizzot.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
            return;

        Pizzaot[index] = pizza;
    }
}

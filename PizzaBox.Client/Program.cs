using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client {
  class Program {
    static void Main(string[] args) {
      ConcretePizza testPizza = new ConcretePizza();
      Console.WriteLine($"You ordered a {testPizza.Size.Name} {testPizza.Crust.Name} Style Pizza with {testPizza.Topping.Name}. Your total cost is: ${testPizza.Price}.");
    }
  }
}


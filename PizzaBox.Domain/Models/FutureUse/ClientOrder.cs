using System.Collections.Generic;

namespace PizzaBox.Domain.Models.FutureUse {
  public class ClientOrder {
    public List<ConcretePizza> Pizzas { get; set; }
    public decimal totalPrice;
    public ClientOrder() {
      Pizzas = new List<ConcretePizza>();
    }

    public void CompleteOrder() {
      //will add current Pizza to the Order as well ask the user if they want to add additional Pizzas to the order.
      ConcretePizza pizza = new ConcretePizza();
    }

    public decimal CalculateOrder() {
      int priceCounter = 0;
      foreach(ConcretePizza p in Pizzas) {
        totalPrice += p.Price;
        priceCounter++;
      }

      return totalPrice;
    }
  }    
}
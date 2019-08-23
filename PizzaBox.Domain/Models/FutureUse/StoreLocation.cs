using System.Collections.Generic;
using PizzaBox.Data.Entities;

namespace PizzaBox.Domain.Models.FutureUse {
  public class StoreLocation {
    private readonly PizzaBoxDBContext _db = new PizzaBoxDBContext();
    public List<ClientOrder> Orders { get; set; }
    public StoreLocation() {
      Orders = new List<ClientOrder>(); 
    }

    public ClientOrder PrepareOrder() {
      return new ClientOrder { Pizzas = new List<ConcretePizza>() };
    }

    public void SubmitOrder(ClientOrder order, ConcretePizza pizza) {
      _db.Pizza.Add(new Data.Entities.Pizza {
        Crust = new Crust { Name = pizza.Crust.Name, Price = pizza.Crust.Price },
        Size = new Size { Name = pizza.Size.Name, Price = pizza.Size.Price },
        Price = pizza.Price
      });

      _db.SaveChanges();

      order.Pizzas.Add(pizza);
      Orders.Add(order);
    }
  }    
}
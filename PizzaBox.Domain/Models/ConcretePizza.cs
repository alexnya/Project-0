using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models {
  public class ConcretePizza {
    public ConcreteCrust Crust { get; set; }
    public ConcreteSize Size { get; set; }
    public ConcreteTopping Topping { get; set; }
    public decimal Price { get; set; }

    public ConcretePizza() {
      this.Crust = SelectCrust();
      this.Size = SelectSize();
      this.Topping = SelectTopping();
      this.Price = this.Crust.Price + this.Size.Price + this.Topping.Price;
    }

    public ConcreteCrust SelectCrust() {
      //Lines 11-24 handle the initialization & printing of the crust options for user to select.
      List<ConcreteCrust> CrustOptions = new List<ConcreteCrust>();
      Console.Write("Please choose a crust for your Pizza. These are our options: ");

      CrustOptions.Add(new ConcreteCrust {Name = "New York", Price = 1.00M});
      CrustOptions.Add(new ConcreteCrust {Name = "Chicago", Price = 1.50M});
      CrustOptions.Add(new ConcreteCrust {Name = "California", Price = 2.00M});

      int crustCounter = 1;
      foreach (ConcreteCrust Crust in CrustOptions) {
        Console.Write(" {0}. {1} ", crustCounter, Crust.Name);
        crustCounter++;
      }

      Console.WriteLine();

      //Lines 29-48 handle the actual selection of the crust from the user.
      Console.Write("Enter the selected number here: ");

      string crustSelector = Console.ReadLine();

      ConcreteCrust pizzaCrust = new ConcreteCrust();
      Console.WriteLine();

      switch (crustSelector) {
        case "1":
          pizzaCrust = CrustOptions.Find(s => s.Name.Contains("New York"));
          break;
        case "2":
          pizzaCrust = CrustOptions.Find(s => s.Name.Contains("Chicago"));
          break;
        case "3":
          pizzaCrust = CrustOptions.Find(s => s.Name.Contains("California"));
          break;
        default:
          Console.WriteLine("Your response could not be interpreted. Please try again.\n");
          break;
      }
 
      return pizzaCrust;
    }

    public ConcreteSize SelectSize() {
      //Lines 11-24 handle the initialization & printing of the size options for the user to select.
      List<ConcreteSize> SizeOptions = new List<ConcreteSize>();
      Console.Write("Please choose a size for your Pizza. These are our options: ");

      SizeOptions.Add(new ConcreteSize {Name = "Small", Price = 3.50M});
      SizeOptions.Add(new ConcreteSize {Name = "Medium", Price = 5.50M});
      SizeOptions.Add(new ConcreteSize {Name = "Large", Price = 7.50M});

      int sizeCounter = 1;
      foreach (ConcreteSize Size in SizeOptions) {
        Console.Write(" {0}. {1} ", sizeCounter, Size.Name);
        sizeCounter++;
      }

      Console.WriteLine();

      //Lines 29-48 handle the actual selection of size from the user.
      Console.Write("Enter the selected number here: ");

      string sizeSelector = Console.ReadLine();

      ConcreteSize pizzaSize = new ConcreteSize();
      
      Console.WriteLine();

      switch (sizeSelector) {
        case "1":
          pizzaSize = SizeOptions.Find(s => s.Name.Contains("Small"));
          break;
        case "2":
          pizzaSize = SizeOptions.Find(s => s.Name.Contains("Medium"));
          break;
        case "3":
          pizzaSize = SizeOptions.Find(s => s.Name.Contains("Large"));
          break;
        default:
          Console.WriteLine("Your response could not be interpreted. Please try again.\n");
          break;
      }

      return pizzaSize;
    }

    public ConcreteTopping SelectTopping() {
      //Lines 11-24 handle the initialization & printing of the topping options for the user to select.
      List<ConcreteTopping> ToppingOptions = new List<ConcreteTopping>();
      Console.Write("Please choose a topping for your Pizza. These are our options: ");

      ToppingOptions.Add(new ConcreteTopping {Name = "Pepperoni", Price = 0.25M});
      ToppingOptions.Add(new ConcreteTopping {Name = "Green Peppers", Price = 0.10M});
      ToppingOptions.Add(new ConcreteTopping {Name = "Sausage", Price = 0.50M});
      ToppingOptions.Add(new ConcreteTopping {Name = "Pineapple", Price = 1.00M});
      ToppingOptions.Add(new ConcreteTopping {Name = "Onions", Price = 0.75M});

      int toppingCounter = 1;
      foreach (ConcreteTopping Topping in ToppingOptions) {
        Console.Write(" {0}. {1} ", toppingCounter, Topping.Name);
        toppingCounter++;
      }

      Console.WriteLine();

      //Lines 29-48 handle the actual selection of a topping from the user.
      Console.Write("Enter the selected number here: ");

      string toppingSelector = Console.ReadLine();

      ConcreteTopping pizzaTopping = new ConcreteTopping();
      
      Console.WriteLine();

      switch (toppingSelector) {
        case "1":
          pizzaTopping = ToppingOptions.Find(s => s.Name.Contains("Pepperoni"));
          break;
        case "2":
          pizzaTopping = ToppingOptions.Find(s => s.Name.Contains("Green Peppers"));
          break;
        case "3":
          pizzaTopping = ToppingOptions.Find(s => s.Name.Contains("Sausage"));
          break;
        case "4":
          pizzaTopping = ToppingOptions.Find(s => s.Name.Contains("Pineapple"));
          break;
        case "5":
          pizzaTopping = ToppingOptions.Find(s => s.Name.Contains("Onions"));
          break;
        default:
          Console.WriteLine("Your response could not be interpreted. Please try again.\n");
          break;
      }

      return pizzaTopping;
    }
  }
}
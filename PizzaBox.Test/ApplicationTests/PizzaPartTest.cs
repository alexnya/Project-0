using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Test.ApplicationTests {
  public class PizzaPartTest {
    [Fact]
    public void Pizza_Part_Is_Set() {
      // Arrange
      string expectedName = "NYStyle";
      decimal expectedPrice = 4.00M;

      // Act
      ConcreteCrust actualCrust = new ConcreteCrust { Name = "NYStyle", Price = 4.00M };

      // Assert
      Assert.Equal(expectedName, actualCrust.Name);
      Assert.Equal(expectedPrice, actualCrust.Price);

    }

    [Fact]
    public void Pizza_Part_Option_Count_Is_Correct() {
      // Arrange
      int expectedCount = 4;

      // Act
      List<ConcreteCrust> CrustOptions = new List<ConcreteCrust>();
      CrustOptions.Add(new ConcreteCrust {Name = "New York", Price = 1.00M});
      CrustOptions.Add(new ConcreteCrust {Name = "Chicago", Price = 1.50M});
      CrustOptions.Add(new ConcreteCrust {Name = "California", Price = 2.00M});

      int crustCounter = 1;
      foreach (ConcreteCrust Crust in CrustOptions) {
        Console.Write(" {0}. {1} ", crustCounter, Crust.Name);
        crustCounter++;
      }

      int actualCount = crustCounter;

      // Assert
      Assert.Equal(expectedCount, actualCount);
    }

    [Fact]
    public void Pizza_Part_Selected_Is_Correct() {
      // Arrange
      string expectedName = null;
      
      // Act
      string actualName = new ConcretePizza().SelectTopping().Name;

      // Assert
      Assert.Equal(expectedName, actualName);
    }

    //[Fact]
    //public void Topping_Is_Added_To_List() {
      
    //}
  }
}
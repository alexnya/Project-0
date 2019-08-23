using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Test.ApplicationTests {
  public class PizzaTest {
    [Fact]
    public void Pizza_Is_Set() {
      // Arrange
        string expectedCrustName = "California";
        string expectedSizeName = "Small";
        string expectedToppingName = "Onions";
        decimal expectedTotalPrice = 6.25M;

      // Act
        ConcretePizza actualPizza = new ConcretePizza();
        string actualCrustName = actualPizza.SelectCrust().Name;
        string actualSizeName = actualPizza.SelectSize().Name;
        string actualToppingName = actualPizza.SelectTopping().Name;
        decimal actualTotalPrice = actualPizza.SelectCrust().Price + actualPizza.SelectSize().Price + actualPizza.SelectTopping().Price;

      // Assert
        Assert.Equal(expectedCrustName, actualCrustName);
        Assert.Equal(expectedSizeName, actualSizeName);
        Assert.Equal(expectedToppingName, actualToppingName);
        Assert.Equal(expectedTotalPrice, actualTotalPrice);
    }
  }
}
using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
namespace  Coins
{
  public class CoinTest
  {
    [Fact]
    public void TestCoinsGetQuartersYea()
    {
      Coin newCoins = new Coin(0.23);
      Assert.Equal(0, newCoins.GetQuarters());
    }
    [Fact]
    public void TestCoinsGetDimesYea()
    {
      Coin newCoins = new Coin(1.80);
      Assert.Equal(18, newCoins.GetDimes());
    }
    [Fact]
    public void TestCoinsGetNickelsYea()
    {
      Coin newCoins = new Coin(1.80);
      Assert.Equal(36, newCoins.GetNickels());
    }
    [Fact]
    public void TestCoinsGetPenniesYea()
    {
      Coin newCoins = new Coin(1.80);
      Assert.Equal(180, newCoins.GetPennies());
    }


    [Fact]
    public void TestGetChange()
    {
      Coin newCoins = new Coin(1.80);
      Dictionary<string,int> testResults = new Dictionary<string,int>();
      testResults.Add("Quarters", 7);
      testResults.Add("Dimes", 0);
      testResults.Add("Nickels", 1);
      testResults.Add("Pennies", 0);
      Assert.Equal(testResults, newCoins.GetChange());
    }

  }
}

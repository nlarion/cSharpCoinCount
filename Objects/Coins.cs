using System;
using System.Linq;
using System.Collections.Generic;

namespace Coins

{

//   //variables//
//
  public class Coin
  {
    private double _change;
    public static Dictionary<string,double> _myAmounts = new Dictionary<string,double>
    {
      {"Quarters",.25},
      {"Dimes",.10},
      {"Nickels",.05},
      {"Pennies",.01}
    };

//construtor//
    public Coin (double change)
    {
      _change = change;
    }

    public Dictionary<string,int> GetChange()
    {
     Dictionary<string,int> _changeResults = new Dictionary<string,int> ();
      foreach(KeyValuePair<string, double> entry in _myAmounts)
      {
          double amountTotal = GetChangeCount(entry.Value) * entry.Value;
          _changeResults.Add(entry.Key, GetChangeCount(entry.Value));
          _change = _change - amountTotal;
      }
      return _changeResults;
    }

    public int GetChangeCount(double amount)
    {
      return (int)Math.Floor(_change/amount);
    }
  }
}

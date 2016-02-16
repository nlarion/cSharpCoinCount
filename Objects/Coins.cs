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
    public static Dictionary<string,int> _changeResults = new Dictionary<string,int> ();


//construtor//

    public Coin (double change)
    {
      _change = change;
    }

    public Dictionary<string,int> GetChange()
    {
      double quarterTotal = GetQuarters() * .25;
      _changeResults.Add("Quarters", GetQuarters());
      _change = _change - quarterTotal;


      double dimeTotal = GetDimes() * .10;
      _changeResults.Add("Dimes", GetDimes());
      _change = _change - dimeTotal;

      double nickelTotal = GetNickels() * .05;
      _changeResults.Add("Nickels", GetNickels());
      _change = _change - nickelTotal;

      double pennyTotal = GetPennies() * .01;
      _changeResults.Add("Pennies", GetPennies());
      _change = _change - pennyTotal;


      return _changeResults;
    }

    public int GetQuarters()
    {
      return (int)Math.Floor(_change/.25);
    }
    public int GetDimes()
    {
      return (int)Math.Floor(_change/.10);
    }
    public int GetNickels()
    {
      return (int)Math.Floor(_change/.05);
    }
    public int GetPennies()
    {
      return (int)Math.Floor(_change/.01);
    }

  }
}

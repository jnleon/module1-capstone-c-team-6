using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
   public abstract class FoodProperties
    {
       
            public string YummyName { get; set; }

            public decimal MoneyMoneyPrice { get; set; }


            public int HowManyItemsRemaining { get; set; }


            public FoodProperties()
            {

            }

            public FoodProperties(string yummyName, decimal moneyMoneyPrice, int howManyItemsRemaining)
            {
            YummyName = yummyName;
            MoneyMoneyPrice = moneyMoneyPrice;
            HowManyItemsRemaining = howManyItemsRemaining;

        }
    }
}
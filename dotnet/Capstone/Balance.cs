using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Balance
    {

        public class VendingMachine
        {

            public decimal Balance { get; private set; } = 0;


            public VendingMachine()
            {
            }
            public VendingMachine(decimal balance)
            {
               Balance = balance;
            }

            public virtual decimal Deposit(decimal amountToDeposit)
            {
                Balance += amountToDeposit;
                return Balance;
            }
            }
            }
            }


//public abstract class FoodProperties
//     {

//         public string YummyName { get; set; }

//         public decimal MoneyMoneyPrice { get; set; }

//         public int HowManyItemsRemaining { get; set; }


//         public FoodProperties()
//         {

//         }

//         public FoodProperties(string yummyName, decimal moneyMoneyPrice, int howManyItemsRemaining)
//         {
//             YummyName = yummyName;
//             MoneyMoneyPrice = moneyMoneyPrice;
//             HowManyItemsRemaining = howManyItemsRemaining;







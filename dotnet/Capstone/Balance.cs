using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Balance
    {
       
            public decimal Money { get; set; } = 0;
            
            public bool CheckIftheresMoney(decimal balance)
            {
                if(balance == 0)
                {
                    return true;
                }
                return false ;
            }

            public Balance()
            {
            }
            public Balance(decimal money)
            {
               Money = money;
            }

            public virtual decimal Deposit(decimal amountToDeposit)
            {
            Money += amountToDeposit;
                return Money;
            }
            }
            }
//public abstract class FoodProperties
//{

//    public string YummyName { get; set; }

//    public decimal MoneyMoneyPrice { get; set; }

//    public int HowManyItemsRemaining { get; set; }


//    public FoodProperties()
//    {

//    }

//    public FoodProperties(string yummyName, decimal moneyMoneyPrice, int howManyItemsRemaining)
//    {
//        YummyName = yummyName;
//        MoneyMoneyPrice = moneyMoneyPrice;
//        HowManyItemsRemaining = howManyItemsRemaining;

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







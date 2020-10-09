using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenu : Balance
    {
      
       


        public static void PurchaseMenuStuff()
        {

            Balance.Equals.CheckIftheresMoney
          
            
            
            
            
            
            Items.DisplayItems();
            Console.WriteLine("What Object do you want to purchase?");
            string objectPurchase = Console.ReadLine();
            foreach (KeyValuePair<string, FoodProperties> kvp in //hum)
            {

                if (vm.Money == 0) 
                {

                }

                if (kvp.Value.HowManyItemsRemaining > 0)
                {


                }








            }


        }
    } }

        //public class VendingMachine
        //{

        //    public decimal MoneyInMachine { get; private set; } = 0;


        //}



using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class Menu :PurchaseMenu
    {


        public static void BalanceStuff()
        {
            // Console.WriteLine("\nCURRENT BALANCE : ${0}", "Balance\n");
            Console.WriteLine("\n1) PURCHASE");
            Console.WriteLine("\n2) DEPOSIT");



            int inputForMenu = int.Parse(Console.ReadLine());
            if (inputForMenu == 1)
            {
                //METHOD FOR PURCHASE
            }
            inputForMenu = int.Parse(Console.ReadLine());
            if(inputForMenu == 2)
            {
                //METHOD FOR DEPOSIT


            }
        }
    }
}

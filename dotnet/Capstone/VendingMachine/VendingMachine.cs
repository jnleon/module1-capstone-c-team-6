using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachine
    {
        public decimal Balance { get; set; } = 0.00M;

        Dictionary<string, ItemProperties> ItemsDicKeyValue = new Dictionary<string, ItemProperties>();


        public void StartVendingMachine()
        {
            Console.Clear();
            Console.Write("\n");

            //ask user for path
            string directoryZach = @"C:\Users\Zachary\Workspace\module1-capstone-c-team-6\Example Files\Inventory.txt";
            string directoryJuan = @"C:\Users\Student\Workspace\module1-capstone-c-team-6\Example Files\Inventory.txt";

            using (StreamReader sr = new StreamReader(directoryZach))
            {
                while (!sr.EndOfStream)
                {
                    string lineContents = sr.ReadLine();

                    string[] items = lineContents.Split("|");

                    string itemNumber = items[0];
                    string itemName = items[1];

                    int itemsLeftInStock = 5;

                    decimal itemPrice = decimal.Parse(items[2]);
                    ItemProperties valueItem;

                    switch (items[3])
                    {
                        case "Chip":
                            valueItem = new ItemType.Chip(itemName, itemPrice, itemsLeftInStock);
                            break;

                        case "Candy":
                            valueItem = new ItemType.Candy(itemName, itemPrice, itemsLeftInStock);
                            break;

                        case "Drink":
                            valueItem = new ItemType.Drink(itemName, itemPrice, itemsLeftInStock);
                            break;

                        default:
                            valueItem = new ItemType.Gum(itemName, itemPrice, itemsLeftInStock);
                            break;
                    }
                    ItemsDicKeyValue.Add(items[0], valueItem);
                }

            } 
        }
            public void DisplayVendingMachine()
            {
                Console.WriteLine(String.Format("\n{0, 0} |  {1,-21} | {2,-5} |  {3,0}", " ITEM KEY", "PRODUCT NAME", "STOCK", "PRICE"));
                Console.Write("---------------------------------------------------------\n");

            foreach (KeyValuePair<string, ItemProperties> kvp in ItemsDicKeyValue)
                {
                    if (kvp.Value.ItemsLeftInStock >= 0)
                    {
                        string itemNumber = kvp.Key;
                        int itemsRemaining = kvp.Value.ItemsLeftInStock;
                        string productName = kvp.Value.ItemName;
                        string price = kvp.Value.ItemPrice.ToString();

                        if (itemsRemaining == 0)
                        {
                            Console.WriteLine(String.Format("{0,6}\t  |  {1,-18}    |{2,15}", itemNumber, productName, " **SOLD OUT**"));
                        }
                        else
                            Console.WriteLine(String.Format("{0,6}\t  |  {1,-18}    |{2,4}   |  ${3,0}", itemNumber, productName, itemsRemaining, price));
                    }
                }
            }

        public void SubPurchaseMenuStart()
        {
            if (Balance == 0)
            {
                Console.WriteLine("\n**ADD MONEY FIRST**");
            }
            Console.WriteLine("Current Balace: " + Balance);
            Console.WriteLine("1. Purchase");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Finish Transaction");
            Console.Write("Please choose an option >>> ");
            int inputForMenu = int.Parse(Console.ReadLine());

            if (inputForMenu == 1)
            {
                PurchaseMenuStart();
            }
            if (inputForMenu == 2)
            {
                Console.WriteLine("\nCurrent Balace: " + Balance);
                Console.Write("How much in whole dollar amounts do you want to add to your account >>> ");
                decimal amountToDeposit = decimal.Parse(Console.ReadLine());
                Deposit(amountToDeposit);
                Console.Write("\n");
                SubPurchaseMenuStart();
            }
            if (inputForMenu == 3)
            {
                giveChange();
            }
        }

        public void PurchaseMenuStart()
        {
            DisplayVendingMachine();
            Console.WriteLine("\nCurrent Balace: " + Balance);
            Console.Write("What item do you want to purchase >>> ");
            string keyInput = Console.ReadLine();

            if (Balance != 0)
            {
                foreach (KeyValuePair<string, ItemProperties> kvp in ItemsDicKeyValue)
                {
                    if (kvp.Key == keyInput)
                    {
                        if (kvp.Value.ItemPrice < Balance)
                        {
                            if (kvp.Value.ItemsLeftInStock > 0)
                            {
                                //Not working
                                kvp.Value.ItemsLeftInStock--;
                                Balance -= kvp.Value.ItemPrice;
                                if (keyInput.Contains("A"))
                                {
                                    Audit();
                                    Console.Write("Crunch Crunch, Yum!\n\n");
                                }
                                if (keyInput.Contains("B"))
                                {
                                    Audit();
                                    Console.Write("Munch Munch, Yum!\n\n");
                                }
                                else if (keyInput.Contains("C"))
                                {
                                    Audit();
                                    Console.Write("Glug Glug, Yum!\n\n");
                                }
                                else if (keyInput.Contains("D"))
                                {
                                    Audit();
                                    Console.Write("Chew Chew, Yum!\n\n");
                                }
                            }
                            else 
                            { 
                                Console.WriteLine("\n**Sorry {0} is sold out** \n", kvp.Value.ItemName);
                                SubPurchaseMenuStart();
                            }
                        }
                        else 
                        {
                            Console.WriteLine("\n**Add more money to buy {0}** \n", kvp.Value.ItemName);
                            SubPurchaseMenuStart();
                        }
                    }
                }
                SubPurchaseMenuStart();
            }
            else
            {
                SubPurchaseMenuStart();
            }
        }

        public void Buy(decimal currentMoney)
        {
            Balance -= currentMoney;
        }

        public decimal Deposit(decimal amountToDeposit)
        {
            Audit();
            return Balance += amountToDeposit;
        }

        public decimal giveChange()
        {
            decimal quarters = 0.25M;
            decimal dimes = 0.10M;
            decimal nickels = 0.05M;
            decimal totalQuarters = 0;
            decimal totalDimes = 0;
            decimal totalNickels = 0;

            if (Balance > 0.24M)
            {
                totalQuarters = Math.Floor(Balance / quarters);
                Balance -= totalQuarters * quarters;
            }
            if (Balance >= 0.10M)
            {
                totalDimes = Math.Floor(Balance / dimes);
                Balance -= totalDimes * dimes;
            }
            if (Balance >= 0.05M)
            {
                totalNickels = Math.Floor(Balance / nickels);
                Balance -= totalNickels * nickels;
            }
            Console.Write("\nChange back: Quarters {0} , Dimes {1}, Nickels {2}\n", totalQuarters, totalDimes, totalNickels);
            Balance = 0;
            Audit();
            return Balance;
        }

        public void Audit()
        {
            return;
        }
    }
}
using System;
using System.Runtime.ConstrainedExecution;
namespace Capstone
{
    class Program
    {
        private const string MAIN_MENU_OPTION_DISPLAY_ITEMS = "Display Vending Machine Items";
        private const string MAIN_MENU_OPTION_PURCHASE = "Purchase";
        private const string MAIN_MENU_OPTION_FINISHED = "Finished";
        private readonly string[] MAIN_MENU_OPTIONS = { MAIN_MENU_OPTION_DISPLAY_ITEMS, MAIN_MENU_OPTION_PURCHASE, MAIN_MENU_OPTION_FINISHED }; //const has to be known at compile time, the array initializer is not const in C#
        private readonly IBasicUserInterface ui = new MenuDrivenCLI();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        public void Run()
        {
            while (true)
            {
                String selection = (string)ui.PromptForSelection(MAIN_MENU_OPTIONS);
                if (selection == MAIN_MENU_OPTION_DISPLAY_ITEMS)
                {
                    Items.DisplayItems();
                }
                else if (selection == MAIN_MENU_OPTION_PURCHASE)
                {
                    Menu.BalanceStuff();
                    //do the purchase (probably should call a method to do this too)
                    //if (balance == 0)
                    //{
                    //}
                    //else { }
                }
                else if (selection == MAIN_MENU_OPTION_FINISHED)
                {
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp4 {
    class TestMenu1 : IMenu {
        public string Title => "Main menu";

        public void ConfigureMenuItems(IMenuNavigator navigator, IDictionary<MenuItem, Action> menuItems) {
            menuItems.Add(new MenuItem(1, "Enter TestMenu2"), () => navigator.GoTo(new TestMenu2()));
            menuItems.Add(new MenuItem(2, "Enter TestMenu3"), () => navigator.GoTo(new TestMenu3()));
            menuItems.Add(new MenuItem(3, "Add two numbers"), () => AddNumbers(navigator));
            menuItems.Add(new MenuItem(4, "Exit"), () => Environment.Exit(0));
        }

        private void AddNumbers(IMenuNavigator navigator) {
            Console.Clear();

            int a = Prompt("Enter a number: ");
            int b = Prompt("Enter another number: ");
            Console.WriteLine($"The sum is {a + b}.\nPress Enter to continue...");

            Console.ReadLine();

            navigator.StayInCurrentMenu();
        }

        private int Prompt(string text) {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

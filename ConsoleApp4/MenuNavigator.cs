using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4 {
    class MenuNavigator : IMenuNavigator {
        private readonly Stack<IMenu> navigationPath = new Stack<IMenu>();
        private IMenu topLevelMenu;

        public void GoBack() {
            if (navigationPath.Count == 0)
                return;

            topLevelMenu = navigationPath.Pop();
            ShowMenu(topLevelMenu);
        }

        public void GoTo(IMenu subMenu) {
            navigationPath.Push(topLevelMenu);
            topLevelMenu = subMenu;
            ShowMenu(topLevelMenu);
        }

        public void ShowMenu(IMenu currentMenu) {
            topLevelMenu = currentMenu;

            Dictionary<MenuItem, Action> items = new Dictionary<MenuItem, Action>();
            currentMenu.ConfigureMenuItems(this, items);

            Console.Clear();
            Console.WriteLine(currentMenu.Title);

            foreach (var item in items) {
                Console.WriteLine($"[{item.Key.Key}]: {item.Key.Text}");
            }

            Console.Write("Selected option: ");
            int key = Convert.ToInt32(Console.ReadLine());

            MenuItem selectedItem = items.Keys.Where(x => x.Key == key).Single();
            Action action = items[selectedItem];

            action();
        }

        public void StayInCurrentMenu() {
            ShowMenu(topLevelMenu);
        }
    }
}

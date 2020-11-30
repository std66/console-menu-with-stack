using System;
using System.Collections.Generic;

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

            List<MenuItem> items = new List<MenuItem>();
            currentMenu.ConfigureMenuItems(this, items);

            Console.Clear();
            Console.WriteLine(currentMenu.Title);

            for (int i = 0; i < items.Count; i++) {
                Console.WriteLine($"[{i + 1}]: {items[i].Text}");
            }

            Console.Write("Selected option: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Action action = items[key - 1].Action;
            action();
        }

        public void StayInCurrentMenu() {
            ShowMenu(topLevelMenu);
        }
    }
}

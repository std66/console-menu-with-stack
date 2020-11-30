using System;
using System.Collections.Generic;

namespace ConsoleApp4 {
    class TestMenu2 : IMenu {
        public string Title => "TestMenu2";

        public void ConfigureMenuItems(IMenuNavigator navigator, IDictionary<MenuItem, Action> menuItems) {
            menuItems.Add(new MenuItem(1, "Enter TestMenu3"), () => navigator.GoTo(new TestMenu3()));
            menuItems.Add(new MenuItem(2, "Go back"), () => navigator.GoBack());
        }
    }
}

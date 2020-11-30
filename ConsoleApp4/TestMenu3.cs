using System;
using System.Collections.Generic;

namespace ConsoleApp4 {
    class TestMenu3 : IMenu {
        public string Title => "TestMenu3";

        public void ConfigureMenuItems(IMenuNavigator navigator, IDictionary<MenuItem, Action> menuItems) {
            menuItems.Add(new MenuItem(1, "Go back"), () => navigator.GoBack());
        }
    }
}

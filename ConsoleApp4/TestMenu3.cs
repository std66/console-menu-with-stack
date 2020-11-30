using System.Collections.Generic;

namespace ConsoleApp4 {
    class TestMenu3 : IMenu {
        public string Title => "TestMenu3";

        public void ConfigureMenuItems(IMenuNavigator navigator, IList<MenuItem> menuItems) {
            menuItems.Add(new MenuItem("Go back", () => navigator.GoBack()));
        }
    }
}

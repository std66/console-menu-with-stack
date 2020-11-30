using System.Collections.Generic;

namespace ConsoleApp4 {
    class TestMenu2 : IMenu {
        public string Title => "TestMenu2";

        public void ConfigureMenuItems(IMenuNavigator navigator, IList<MenuItem> menuItems) {
            menuItems.Add(new MenuItem("Enter TestMenu3", () => navigator.GoTo(new TestMenu3())));
            menuItems.Add(new MenuItem("Go back", () => navigator.GoBack()));
        }
    }
}

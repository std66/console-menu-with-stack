using System.Collections.Generic;

namespace ConsoleApp4 {
    interface IMenu {
        void ConfigureMenuItems(IMenuNavigator navigator, IList<MenuItem> menuItems);
        string Title { get; }
    }
}

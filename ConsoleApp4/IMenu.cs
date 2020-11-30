using System;
using System.Collections.Generic;

namespace ConsoleApp4 {
    interface IMenu {
        void ConfigureMenuItems(IMenuNavigator navigator, IDictionary<MenuItem, Action> menuItems);
        string Title { get; }
    }
}

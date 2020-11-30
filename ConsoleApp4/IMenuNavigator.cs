namespace ConsoleApp4 {
    interface IMenuNavigator {
        void GoBack();
        void StayInCurrentMenu();
        void GoTo(IMenu subMenu);
    }
}

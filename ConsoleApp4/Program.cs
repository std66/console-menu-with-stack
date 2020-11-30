namespace ConsoleApp4 {
    class Program {
        static void Main(string[] args) {
            MenuNavigator navigator = new MenuNavigator();
            navigator.ShowMenu(new TestMenu1());
        }
    }
}

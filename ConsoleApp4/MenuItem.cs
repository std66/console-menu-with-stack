using System;

namespace ConsoleApp4 {
    class MenuItem {
        public MenuItem(string text, Action action) {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Action = action ?? throw new ArgumentNullException(nameof(action));
        }

        public string Text { get; }
        public Action Action { get; }
    }
}

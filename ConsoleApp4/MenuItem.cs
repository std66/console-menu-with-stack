using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp4 {
    class MenuItem : IEquatable<MenuItem> {
        public MenuItem(int key, string text) {
            Key = key;
            Text = text;
        }

        public int Key { get; }
        public string Text { get; }

        public override bool Equals(object obj) {
            return Equals(obj as MenuItem);
        }

        public bool Equals([AllowNull] MenuItem other) {
            return other != null &&
                   Key == other.Key &&
                   Text == other.Text;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Key, Text);
        }
    }
}

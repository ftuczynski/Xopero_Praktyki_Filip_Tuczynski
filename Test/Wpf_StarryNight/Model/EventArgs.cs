using System;

namespace Wpf_StarryNight.Model {
    class BeeMovedEventArgs : EventArgs {
        public Bee BeeThatMoved { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public BeeMovedEventArgs(Bee beeThatMoved, double x, double y) {
            BeeThatMoved = beeThatMoved;
            X = x;
            Y = y;
        }
    }

    class StarChangedEventArgs : EventArgs {
        public Star StarThatChanged { get; private set; }
        public bool Removed { get; private set; }

        public StarChangedEventArgs(Star starThatChanged, bool removed) {
            StarThatChanged = starThatChanged;
            Removed = removed;
        }
    }
}

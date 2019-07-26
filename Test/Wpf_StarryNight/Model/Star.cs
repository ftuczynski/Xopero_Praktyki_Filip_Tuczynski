using System.Windows;

namespace Wpf_StarryNight.Model {
    class Star {
        public Point Location { get; set; }
        public Star(Point location) {
            Location = location;
        }
    }
}

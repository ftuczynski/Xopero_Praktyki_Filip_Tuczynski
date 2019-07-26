using System.Windows;

namespace Wpf_StarryNight.Model {
    class Bee {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Rect Position { get { return new Rect(Location, Size); } }
        public double Width { get { return Position.Width; } }
        public double Height { get { return Position.Height; } }

        public Bee(Point location, Size size) {
            Location = location;
            Size = size;
        }
    }
}

namespace Wpf_SloppyJoes {
    class MenuItem {
        public string Meat { get; set; }
        public string Condiment { get; set; }
        public string Bread { get; set; }
        public MenuItem(string meat, string condiment, string bread) {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }
        public override string ToString() {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}

using System;
using System.Drawing;

namespace TheQuest {
    interface IPotion {
        bool Used { get; }
    }

    abstract class Weapon : Mover {
        public bool PickedUp { get; private set; }
        public Weapon(Game game, Point location)
            : base(game, location) {
            PickedUp = false;
        }
        public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random) {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++) {
                foreach (Enemy enemy in game.Enemies) {
                    if (Nearby(enemy.Location, target, distance)) {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }

    class Sword : Weapon {
        public Sword(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random) {
            if (DamageEnemy(direction, 10, 3, random)) { }
            else if (DamageEnemy(((int)direction - 1 < 0 ? direction + 3 : direction - 1), 10, 3, random)) { }
            else if (DamageEnemy(((int)direction + 1 > 3 ? direction - 3 : direction + 1), 10, 3, random)) { }
        }
    }

    class Bow : Weapon {
        public Bow(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Bow"; } }
        public override void Attack(Direction direction, Random random) {
            if (DamageEnemy(direction, 30, 1, random)) { }
        }
    }

    class Mace : Weapon {
        public Mace(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction direction, Random random) {
            if (DamageEnemy(direction, 20, 6, random)) { }
            else if (DamageEnemy(((int)direction - 1 < 0 ? direction + 3 : direction - 1), 20, 6, random)) { }
            else if (DamageEnemy(((int)direction - 2 < 0 ? direction + 2 : direction - 2), 20, 6, random)) { }
            else if (DamageEnemy(((int)direction - 3 < 0 ? direction + 1 : direction - 3), 20, 6, random)) { }
        }
    }

    class BluePotion : Weapon, IPotion {
        public BluePotion(Game game, Point location)
            : base(game, location) {
            Used = false;
        }
        public bool Used { get; private set; }
        public override string Name { get { return "Blue Potion"; } }
        public override void Attack(Direction direction, Random random) {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }

    class RedPotion : Weapon, IPotion {
        public RedPotion(Game game, Point location)
            : base(game, location) {
            Used = false;
        }
        public bool Used { get; private set; }
        public override string Name { get { return "Red Potion"; } }
        public override void Attack(Direction direction, Random random) {
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }
    }
}

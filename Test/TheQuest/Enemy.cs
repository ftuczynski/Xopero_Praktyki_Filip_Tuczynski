using System;
using System.Drawing;

namespace TheQuest {
    abstract class Enemy : Mover {
        private const int NearPlayerDistance = 25;
        public int HitPoints { get; private set; }
        public bool Dead {
            get {
                if (HitPoints <= 0) return true;
                else return false;
            }
        }
        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location) { HitPoints = hitPoints; }
        public abstract void Move(Random random);
        public void Hit(int maxDamage, Random random) {
            HitPoints -= random.Next(1, maxDamage);
        }
        protected bool NearPlayer() {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }
        protected Direction FindPlayerDirection(Point playerLocation) {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }

    class Bat : Enemy {
        public Bat(Game game, Point location)
            : base(game, location, 6) { }
        public override void Move(Random random) {
            if (HitPoints >= 1) {
                if (random.Next(2) == 1) {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else {
                    base.location = Move((Direction)random.Next(4), game.Boundaries);
                }
                if (NearPlayer()) {
                    game.HitPlayer(2, random);
                }
            }
        }
    }

    class Ghost : Enemy {
        public Ghost(Game game, Point location)
            : base(game, location, 8) { }
        public override void Move(Random random) {
            if (HitPoints >= 1) {
                if (random.Next(3) == 2) {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                if (NearPlayer()) {
                    game.HitPlayer(3, random);
                }
            }
        }
    }
    
    class Ghoul : Enemy {
        public Ghoul(Game game, Point location)
            : base(game, location, 10) { }
        public override void Move(Random random) {
            if (HitPoints > 0) {
                if (random.Next(3) != 2) {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                if(NearPlayer()) {
                    game.HitPlayer(4, random);
                }
            }
        }
    }
}

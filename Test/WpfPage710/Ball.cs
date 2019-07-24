using System;

namespace WpfPage710 {
    class BallEventArgs : EventArgs {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }

        public BallEventArgs(int trajectory, int distance) {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }

    class Ball {
        public event EventHandler<BallEventArgs> BallInPlay;
        protected void OnBallInPlay(BallEventArgs e) {
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            if (ballInPlay != null)
                ballInPlay(this, e);
        }
        public Bat GetNewBat() {
            return new Bat(new BatCallback(OnBallInPlay));
        }
    }
}

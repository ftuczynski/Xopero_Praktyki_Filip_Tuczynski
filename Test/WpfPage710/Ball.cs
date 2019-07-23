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
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e) {
            EventHandler ballInPlay = BallInPlay;
            if (ballInPlay != null)
                ballInPlay(this, e);
        }
    }
}

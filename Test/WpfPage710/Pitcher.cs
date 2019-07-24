using System;
using System.Collections.ObjectModel;

namespace WpfPage710 {
    class Pitcher {
        public ObservableCollection<string> PitcherSays = new ObservableCollection<string>();
        private int pitchNumber = 0;

        public  Pitcher(Ball ball) {
            ball.BallInPlay += ball_BallInPlay;
        }

        private void ball_BallInPlay(object sender, EventArgs e) {
            pitchNumber++;
            if(e is BallEventArgs) {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        public void CatchBall() {
            PitcherSays.Add("Pitch #" + pitchNumber + ": I caught the ball");
        }

        public void CoverFirstBase() {
            PitcherSays.Add("Pitch #" + pitchNumber + ": I covered first base");
        }
    }
}

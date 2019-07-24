using System;
using System.Collections.ObjectModel;

namespace WpfPage710 {
    class Fan {
        Random random = new Random();
        public ObservableCollection<string> FanSays = new ObservableCollection<string>();
        private int pitchNumber = 0;

        public Fan(Ball ball) {
            ball.BallInPlay += new EventHandler<BallEventArgs>(ball_BallInPlay);
        }

        private void ball_BallInPlay(object sender, EventArgs e) {
            pitchNumber++;
            if(e is BallEventArgs) {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance > 400) && (ballEventArgs.Trajectory > 30))
                    TryToCatch();
                else
                    ScreamAndYell();
            }
        }

        public void TryToCatch() {
            FanSays.Add("Pitch #" + pitchNumber + ": Home run! I'm going for the ball!");
        }

        public void ScreamAndYell() {
            FanSays.Add("Pitch #" + pitchNumber + ": Woo-hoo! Yeah!");
        }
    }
}

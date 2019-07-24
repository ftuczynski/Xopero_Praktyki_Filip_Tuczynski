namespace WpfPage710 {
    delegate void BatCallback(BallEventArgs e);
    class Bat {
        private BatCallback hitBallCallback;
        public Bat(BatCallback callbackDelegate) {
            this.hitBallCallback = new BatCallback(callbackDelegate);
        }
        public void HitTheBall(BallEventArgs e) {
            if (hitBallCallback != null)
                hitBallCallback(e);
        }
    }
}

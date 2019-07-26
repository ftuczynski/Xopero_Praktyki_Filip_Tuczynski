using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;

namespace Wpf_StarryNight.View {
    /// <summary>
    /// Interaction logic for AnimatedImage.xaml
    /// </summary>
    public partial class AnimatedImage : UserControl {
        public AnimatedImage() {
            InitializeComponent();
        }

        public AnimatedImage(IEnumerable<string> imageNames, TimeSpan interval)
            : this() {
            StartAnimation(imageNames, interval);
        }
        public void StartAnimation(IEnumerable<string> imageNames, TimeSpan interval) {
            Storyboard storyboard = new Storyboard();
            ObjectAnimationUsingKeyFrames animation = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Image.SourceProperty));
            TimeSpan currentInterval = TimeSpan.FromMilliseconds(0);
            foreach (string imageName in imageNames) {
                ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();
                keyFrame.Value = CreateImageFromAssets(imageName);
                keyFrame.KeyTime = currentInterval;
                animation.KeyFrames.Add(keyFrame);
                currentInterval = currentInterval.Add(interval);
            }

            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
        private static BitmapImage CreateImageFromAssets(string imageFilename) {
            try {
                Uri uri = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (System.IO.IOException) {
                return new BitmapImage();
            }
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static Creatures_Creatures_Creatures_.Utility;

namespace Creatures_Creatures_Creatures_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// CREDITS
    ///     Created By: Grace Siegwald
    ///     Code assistance from Claude
    ///     All transcripts of Claude conversations can be found at File Path: 
    ///         Creatures Creatures Creatures!\Creatures Creatures Creatures!\Claude_Transcripts
    
    public partial class MainWindow : Window
    {
        private List<Blob> blobs = new List<Blob>();
        private int currentRound = 1;
        private int lives = 3;
        private double centerX;
        private double centerY;
        private Ellipse damsel; // the thing in the middle that blobs are targeting

        /// The Game Timer needs to:
        ///     Move every blob on the canvas towards the Damsel
        ///     Check if any blobs have reached the center, and if so, remove a health
        ///     Increment to next round if all blobs are gone
        private DispatcherTimer gameTimer;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            // does this need any initialization stuff? idk !?
        }



        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            /// Clicking the Start Button needs to:
            ///     Spawn Damsel instance in middle of canvas
            ///     Start the first round of blobs
            ///     Hide itself
        }
        private void GameCanvas_Click(object sender, MouseButtonEventArgs e)
        {
            /// Clicking in the Canvas needs to:
            ///     Figure out where the click was (x and y coordinates?)
            ///     Check if the click was on a Blob. If so, pop it!
        }

 
        private void SpawnBlob()
        {
            double canvasWidth = GameCanvas.ActualWidth;
            double canvasHeight = GameCanvas.ActualHeight;

            int randomEdge = GetRandomNumber(4); // picks a random number 0-3 
            double x = 0;
            double y = 0;

            switch (randomEdge) // These are the actual locations on the canvas... (0=top, 1=right, 2=bottom, 3=left)
            {
                case 0:
                    x = GetRandomNumber((int)canvasWidth); // casting the canvasWidth to an int, it's the type that GetRandomNumber accepts
                    y = 0;
                    break;
                case 1:
                    x = canvasWidth;
                    y = GetRandomNumber((int)canvasHeight);
                    break;
                case 2:
                    x = GetRandomNumber((int)canvasWidth);
                    y = canvasHeight;
                    break;
                case 3:
                    x = 0;
                    y = GetRandomNumber((int)canvasHeight);
                    break;
            }

            // Set the speed of the blob, increases each round...
            double speed = 1.0 + (currentRound * 0.2);

            // Pick a random color for the blob!
            Color[] colors = { Colors.Red, Colors.Blue, Colors.Yellow, Colors.Green};
            Color c = colors[GetRandomNumber(colors.Length)];

            // Actually creating the new instance of a Blob, with all the attributes we just decided!
            Blob blob = new Blob(x, y, speed, c);
            blobs.Add(blob); // Adds the blob to the list of all blobs on screen

            GameCanvas.Children.Add(blob.Body); // puts physical blob body on canvas
            Canvas.SetLeft(blob.Body, x); // uhhhh I think these are setting the actual spawn position maybe?
            Canvas.SetTop(blob.Body, y);
        }
    }
}
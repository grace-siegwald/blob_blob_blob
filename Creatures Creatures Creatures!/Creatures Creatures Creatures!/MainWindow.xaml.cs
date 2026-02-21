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

namespace Creatures_Creatures_Creatures_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        World GameWorld = new World();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CreatureInfo.Text = GameWorld.GetWorldCreatureInformation();
            
        }

        private void AbilitiesButton_Click(object sender, RoutedEventArgs e)
        {
            CreatureAbilities.Text = GameWorld.ShowAbilities();
        }
    }
}
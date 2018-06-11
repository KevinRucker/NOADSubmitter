using System.Reflection;
using System.Windows;

namespace NOADSubmitter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "NOAD Submitter, Version: " + Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}

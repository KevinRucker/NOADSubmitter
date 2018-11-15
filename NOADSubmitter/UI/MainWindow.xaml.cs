using System.Reflection;
using System.Windows;
using System.Xml.Linq;
using NOADSubmitter.Data.Domain;

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
            var notice = new Notice();
            notice.NoticeDetails.NoticeId = System.Guid.NewGuid();
            notice.Source.OrganizationName = "Test Organization";
            notice.Source.SoftwareApplicationName = "NOAD Submitter";
            notice.Source.Contact = "kevin.d.rucker@uscg.mil";

            var xml = (XDocument)notice;
        }
    }
}

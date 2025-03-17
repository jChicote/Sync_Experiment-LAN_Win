using SyncNotesAppTest_Windows.Application.Data;
using SyncNotesAppTest_Windows.ViewModels;
using System.Windows;

namespace SyncNotesAppTest_Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();
            _ = new ApplicationDbContext(); // This is for dbContext testing
        }
    }
}
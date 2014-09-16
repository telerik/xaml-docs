using System.Collections.ObjectModel;
using System.Windows;

namespace RadOutlookBarDataBinding
{
    public partial class MainWindow : Window
    {
        #region radoutlookbar-databinding-0
        public MainWindow()
        {
            InitializeComponent();
            this.radOutlookBar.DataContext = new MailMenuViewModel();
        }
        #endregion
    }

    #region radoutlookbar-databinding-1
    public class MailMenuViewModel : ViewModelBase
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        private MenuItem selectedItem;
        public MenuItem SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                if (this.selectedItem != value)
                {
                    this.selectedItem = value;
                    this.OnPropertyChanged("SelectedItem");
                }
            }
        }

        public MailMenuViewModel()
        {
            this.MenuItems = new ObservableCollection<MenuItem>();
            this.MenuItems.Add(new MenuItem() { Content = "Mails content", Header = "Mail", ImageSourcePath = "/images/mailBig.png" });
            this.MenuItems.Add(new MenuItem() { Content = "Contacts content", Header = "Contacts", ImageSourcePath = "/images/contactsBig.png" });
            this.MenuItems.Add(new MenuItem() { Content = "Calendar content", Header = "Calendar", ImageSourcePath = "/images/calendarBig.png" });

            this.selectedItem = this.MenuItems[0];
        }
    }   
    #endregion

    #region radoutlookbar-databinding-2
    public class MenuItem
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageSourcePath { get; set; }
    }
    #endregion
}

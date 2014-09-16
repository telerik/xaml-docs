using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region saving-some-lines-of-code_1
public partial class Navigation : UserControl  
    {  
        public Navigation()  
        {  
            InitializeComponent();  
        }  
        private string url;  
        private void OnNavButtonClicked(object sender, RoutedEventArgs e)  
        {  
            this.url = (sender as Button).Content.ToString();  
            RadWindow.Confirm(String.Format("Do you want to open {0}", this.url), OnRadConfirmClosed);  
        }  
        private void OnRadConfirmClosed(object sender, WindowClosedEventArgs e)  
        {  
            if (e.DialogResult == true)  
            {  
                this.GoTo(url);  
            }  
        }  
        private void GoTo(string url)  
        {  
            RadWindow.Alert(String.Format("{0} is opened", url));  
        }  
    }
#endregion

#region saving-some-lines-of-code_2
private void OnNavButtonClicked(object sender, RoutedEventArgs e)  
        {  
            string url = (sender as Button).Content.ToString();  
            RadWindow.Confirm(String.Format("Do you want to open {0}", url),  
                (sender1, args) =>  
                {  
                    if (b.DialogResult == true) 
                    {  
                        this.GoTo(url);  
                    }  
                });  
        }
#endregion
}

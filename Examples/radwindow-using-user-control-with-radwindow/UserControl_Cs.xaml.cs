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

#region radwindow-using-user-control-with-radwindow_1
using System;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
namespace RadWindowTest
{
    public partial class DatePickerUserControl : UserControl
    {
        public DatePickerUserControl()
        {
            InitializeComponent();
        }
        private void OnBtnOkClicked(object sender, RoutedEventArgs e)
        {
            RadWindow parent = RadWindow.GetParentRadWindow(this);
            parent.PromptResult = datePicker.SelectedDate.ToString();
            parent.DialogResult = true;
            parent.Close();
        }
        private void OnBtnCancelClicked(object sender, RoutedEventArgs e)
        {
            RadWindow parent = RadWindow.GetParentRadWindow(this);
            parent.DialogResult = false;
            parent.Close();
        }
    }
}
#endregion

#region radwindow-using-user-control-with-radwindow_4
private void ShowWindow()
        {
            window.Closed += new EventHandler<WindowClosedEventArgs>(OnWindowClosed);
            window.Show();   
        }
        void OnWindowClosed(object sender, WindowClosedEventArgs e)
        {
            RadWindow.Alert(e.PromptResult);        }
#endregion
}

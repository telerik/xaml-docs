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

 
<!-- #region gridview-columns-howto-selectionchanged-comboboxcolumn_1 -->
	public MainWindow()
        {
            InitializeComponent();
            this.AddHandler(RadComboBox.SelectionChangedEvent, new System.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                //your code here
            }
        }
#endregion


<!-- #region gridview-columns-howto-selectionchanged-comboboxcolumn_2 -->
        public MainPage()
        {
            InitializeComponent();
            this.AddHandler(RadComboBox.SelectionChangedEvent, new Telerik.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
        }

        private void OnSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                //your code here
            }
        }
#endregion

}

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
	
	 #region radtimebar-events_0
	      public MainPage()
        {
            InitializeComponent();
            radTimeBar1.ItemIntervalChanged += new EventHandler<DrillEventArgs>(radTimeBar1_ItemIntervalChanged);
        }

        void radTimeBar1_ItemIntervalChanged(object sender, DrillEventArgs e)
        {
            if (radTimeBar1.CurrentItemInterval is MonthInterval)
            {
                radTimeBar1.SelectionStart = new DateTime(2012, 05, 1);
                radTimeBar1.SelectionEnd = new DateTime(2012, 07, 1);
            }
        }
	 #endregion
	}
}
